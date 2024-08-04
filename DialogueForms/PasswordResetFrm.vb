Imports System.Data.SQLite

Public Class PasswordResetFrm


    Dim store As New Store
    Dim userFlag As Boolean
    Private DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
    Dim tableName As String = "AccountData"
    Private DataBaseConnection As New SQLiteConnection(DataBase_Path)

    Private Sub PasswordResetFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Step2Pnl.Hide()
        Step3Pnl.Hide()
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        If UsernameTxtBox.Text = Store.userAccount.username Or UsernameTxtBox.Text = Store.adminAccount.username Then
            Step2Pnl.Show()
            RecoveryAnsTxtBox.Focus()
        Else
            MsgBox("There is no account with '" & UsernameTxtBox.Text & "' username. Please Try again", vbCritical, "Username Unverified")
            Exit Sub
        End If

        If Store.adminAccount.username = UsernameTxtBox.Text Then
            RecoveryQuestLbl.Text = Store.adminAccount.recoveryQuest
            ClueLbl.Text = Store.adminAccount.recoveryClue
            userFlag = False
        Else
            userFlag = True
            RecoveryQuestLbl.Text = Store.userAccount.recoveryQuest
            ClueLbl.Text = Store.userAccount.recoveryClue
        End If
    End Sub

    Private Sub VerifyBtn_Click(sender As Object, e As EventArgs) Handles VerifyBtn.Click
        If userFlag = True Then
            If RecoveryAnsTxtBox.Text = Store.adminAccount.recoveryAns Then
                Step3Pnl.Show()
                NewPass1TxtBox.Focus()
            Else
                MsgBox("Wrong recovery answer. Please try again.", vbCritical, "Error")
                Exit Sub
            End If
        Else
            If RecoveryAnsTxtBox.Text = Store.adminAccount.recoveryAns Then
                Step3Pnl.Show()
                NewPass1TxtBox.Focus()
            Else
                MsgBox("Wrong recovery answer. Please try again.", vbCritical, "Error")
                Exit Sub
            End If

        End If

    End Sub

    Private Sub UsernameTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UsernameTxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            NextBtn.PerformClick()

        End If
    End Sub

    Private Sub RecoveryAnsTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RecoveryAnsTxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            VerifyBtn.PerformClick()
        End If
    End Sub

    Private Sub NewPass1TxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewPass1TxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            NewPass2TxtBox.Focus()
        End If
    End Sub

    Private Sub NewPass2TxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NewPass2TxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SaveBtn.PerformClick()
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If NewPass1TxtBox.Text = NewPass2TxtBox.Text Then
            If MsgBox("Do your really want to save changes?", MsgBoxStyle.YesNo, "Save New Password") Then
                SavePasswordChanges()
            Else
                MsgBox("Retyped password does not match, Please try again", vbCritical, "Error")
                Exit Sub
            End If

            Exit Sub
        End If
    End Sub

    Sub SavePasswordChanges()
        Try
            DataBaseConnection.Open()

            Dim updateStr As String = ""
            Dim updateCMD As New SQLiteCommand()
            Dim account As String

            If UsernameTxtBox.Text = Store.adminAccount.username Then
                ' Admin account
                Store.adminAccount.password = NewPass2TxtBox.Text
                updateStr = "UPDATE " & tableName & " SET Password = @newPassword WHERE Username = @username"
                updateCMD = New SQLiteCommand(updateStr, DataBaseConnection)
                updateCMD.Parameters.AddWithValue("@newPassword", Store.adminAccount.password)
                updateCMD.Parameters.AddWithValue("@username", Store.adminAccount.username)
                account = Store.adminAccount.username
            Else
                ' User account
                Store.userAccount.password = NewPass2TxtBox.Text
                updateStr = "UPDATE " & tableName & " SET Password = @newPassword WHERE Username = @username"
                updateCMD = New SQLiteCommand(updateStr, DataBaseConnection)
                updateCMD.Parameters.AddWithValue("@newPassword", Store.userAccount.password)
                updateCMD.Parameters.AddWithValue("@username", Store.userAccount.username)
                account = Store.userAccount.username
            End If

            ' Execute the query
            updateCMD.ExecuteNonQuery()
            store.WriteToLog("Password reset is used for " & account & " account")
            MsgBox("Password updated successfully!", MsgBoxStyle.Information, "Success")

        Catch ex As Exception
            MsgBox("An error occurred while saving changes: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            DataBaseConnection.Close()
        End Try

        store.ReloadAccountDetails()
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        If MsgBox("Changes will not be saved.", MsgBoxStyle.OkCancel, "Confirmation") Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class