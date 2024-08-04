Imports System.Data.SQLite
Imports System.Security.Cryptography.X509Certificates

Public Class RecoverySetupDialogue
    Dim store As New Store
    Public SelectedRecoveryAcc As Integer
    Dim DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
    Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

    Private Sub RecoverySetupDialogue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If SelectedRecoveryAcc = 0 Then
            AccountComboBox.SelectedIndex = 0
            RecQuestTxtBox.Text = Store.adminAccount.recoveryQuest
            RecClueTxtBox.Text = Store.adminAccount.recoveryClue
            RecAnswerTxtBox.Text = Store.adminAccount.recoveryAns

        Else
            AccountComboBox.SelectedIndex = 1
            RecQuestTxtBox.Text = Store.userAccount.recoveryClue
            RecClueTxtBox.Text = Store.userAccount.recoveryClue
            RecAnswerTxtBox.Text = Store.userAccount.recoveryAns
        End If

        Step2Pnl.Hide()
        Step3Pnl.Hide()
    End Sub

    Private Sub NextBtn_Click(sender As Object, e As EventArgs) Handles NextBtn.Click
        Step2Pnl.Show()
        RecQuestTxtBox.Show()
        RecQuestTxtBox.Focus()
    End Sub

    Private Sub Next2Btn_Click(sender As Object, e As EventArgs) Handles Next2Btn.Click
        Step3Pnl.Show()
        PasswordTxtBox.Focus()
    End Sub

    Private Sub RecQuestTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RecQuestTxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            RecClueTxtBox.Focus()
        End If
    End Sub

    Private Sub RecClueTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RecClueTxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            RecAnswerTxtBox.Focus()
        End If
    End Sub

    Private Sub RecAnswerTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RecAnswerTxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Next2Btn.PerformClick()
        End If
    End Sub

    Private Sub PasswordTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SaveBtn.PerformClick()
        End If
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click

        Try
            DataBaseConnection.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            DataBaseConnection.Close()
        End Try

        If AccountComboBox.SelectedIndex = 0 Then
            If Not (PasswordTxtBox.Text = Store.adminAccount.password) Then
                MsgBox("Password is Incorrect!", vbCritical, "Error")
                PasswordTxtBox.Focus()
                Exit Sub
            End If
        Else
            If Not (PasswordTxtBox.Text = Store.userAccount.password) Then
                MsgBox("Password is Incorrect!", vbCritical, "Error")
                PasswordTxtBox.Focus()
                Exit Sub
            End If

        End If

        If MsgBox("Do you really want to save the changes?", MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.No Then
            Exit Sub
        End If

        If AccountComboBox.SelectedIndex = 0 Then
            store.ExecuteNonQuery("UPDATE AccountData SET RecoveryQuest = '" & RecQuestTxtBox.Text & "' WHERE Num = 1;", DataBaseConnection)
            store.ExecuteNonQuery("UPDATE AccountData SET RecoveryClue = '" & RecClueTxtBox.Text & "' WHERE Num = 1;", DataBaseConnection)
            store.ExecuteNonQuery("UPDATE AccountData SET RecoveryAns = '" & RecAnswerTxtBox.Text & "' WHERE Num = 1;", DataBaseConnection)
            store.WriteToLog(Store.loggedInAccount & " updated the account recovery setup for Admin Account.")
        Else
            store.ExecuteNonQuery("UPDATE AccountData SET RecoveryQuest = '" & RecQuestTxtBox.Text & "' WHERE Num = 2;", DataBaseConnection)
            store.ExecuteNonQuery("UPDATE AccountData SET RecoveryClue = '" & RecClueTxtBox.Text & "' WHERE Num = 2;", DataBaseConnection)
            store.ExecuteNonQuery("UPDATE AccountData SET RecoveryAns = '" & RecAnswerTxtBox.Text & "' WHERE Num = 2;", DataBaseConnection)
            store.WriteToLog(Store.loggedInAccount & " updated the account recovery setup for User Account.")
        End If
        DataBaseConnection.Close()

        store.ReloadAccountDetails()
        AccountFrm.displayRefresh()
        MsgBox("The changes is saved.", vbInformation)
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