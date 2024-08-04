Imports System.Data.SQLite
Imports System.Security.Cryptography.X509Certificates

Public Class AccountFrm

    Dim store As New Store
    Dim DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
    Dim DataBaseConnection As New SQLiteConnection(DataBase_Path)

    Private Sub AccountFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayRefresh()
        AdminEditBool = True
        userEditBool = True
        AdminCredEditBtn.PerformClick()
        UserCredEditBtn.PerformClick()
    End Sub

    Public Sub displayRefresh()
        store.ReloadAccountDetails()
        AdminUserNameTxtBox.Text = Store.adminAccount.username
        UserUserNameTxtBox.Text = Store.userAccount.username
        AdminPasswordTxtBox.UseSystemPasswordChar = True
        AdminPasswordTxtBox.Text = Store.adminAccount.password
        UserPasswordTxtBox.Text = Store.userAccount.password
        UserPasswordTxtBox.UseSystemPasswordChar = True
        AdminNameTxtBox.Text = Store.adminAccount.name
        UserNameTxtBox.Text = Store.userAccount.name
    End Sub

    'ADMIN //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Dim AdminEditBool As Boolean

    Private Sub SeeAdminPassBtn_Click(sender As Object, e As EventArgs) Handles SeeAdminPassBtn.Click
        If AdminPasswordTxtBox.UseSystemPasswordChar = True Then
            AdminPasswordTxtBox.UseSystemPasswordChar = False
        Else
            AdminPasswordTxtBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub AdminCredEditBtn_Click(sender As Object, e As EventArgs) Handles AdminCredEditBtn.Click
        If AdminEditBool = False Then
            AdminEditBool = True
        Else
            AdminEditBool = False
        End If

        If AdminEditBool = True Then
            AdminUserNameTxtBox.Enabled = True
            AdminPasswordTxtBox.Enabled = True
            AdminCredSaveBtn.Enabled = True
            AdminCredEditBtn.Text = "Cancel"
            AdminNameTxtBox.ReadOnly = False
            Line1Lbl.Visible = True

        Else
            AdminUserNameTxtBox.Enabled = False
            AdminPasswordTxtBox.Enabled = False
            AdminCredSaveBtn.Enabled = False
            AdminCredEditBtn.Text = "Edit"
            AdminNameTxtBox.ReadOnly = True
            Line1Lbl.Visible = False
            displayRefresh()
        End If
    End Sub

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// ADMIN

    'USER ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    Dim userEditBool As Boolean

    Private Sub UserCredEditBtn_Click(sender As Object, e As EventArgs) Handles UserCredEditBtn.Click
        If userEditBool = False Then
            userEditBool = True
        Else
            userEditBool = False
        End If

        If userEditBool = True Then
            UserUserNameTxtBox.Enabled = True
            UserPasswordTxtBox.Enabled = True
            UserCredSaveBtn.Enabled = True
            UserCredEditBtn.Text = "Cancel"
            UserNameTxtBox.ReadOnly = False
            Line2Lbl.Visible = True
        Else
            UserUserNameTxtBox.Enabled = False
            UserPasswordTxtBox.Enabled = False
            UserCredSaveBtn.Enabled = False
            UserCredEditBtn.Text = "Edit"
            UserNameTxtBox.ReadOnly = True
            Line2Lbl.Visible = False
            displayRefresh()
        End If
    End Sub
    Private Sub SeeUserPassBtn_Click(sender As Object, e As EventArgs) Handles SeeUserPassBtn.Click
        If UserPasswordTxtBox.UseSystemPasswordChar = True Then
            UserPasswordTxtBox.UseSystemPasswordChar = False
        Else
            UserPasswordTxtBox.UseSystemPasswordChar = True
        End If
    End Sub

    '/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////// USER

    Private Sub RecoveryBtnClick(sender As Object, e As EventArgs) Handles AdminRecoveryBtn.Click, UserRecoveryBtn.Click

        If sender Is AdminRecoveryBtn Then
            RecoverySetupDialogue.SelectedRecoveryAcc = 0
        Else
            RecoverySetupDialogue.SelectedRecoveryAcc = 1
        End If

        RecoverySetupDialogue.ShowDialog()
    End Sub

    Private Sub AdminCredSaveBtn_Click(sender As Object, e As EventArgs) Handles AdminCredSaveBtn.Click
        Try
            DataBaseConnection.Open()
            store.ExecuteNonQuery("UPDATE AccountData SET Username = '" & AdminUserNameTxtBox.Text & "' WHERE Num = 1;", DataBaseConnection)
            store.ExecuteNonQuery("UPDATE AccountData SET Password = '" & AdminPasswordTxtBox.Text & "' WHERE Num = 1;", DataBaseConnection)
            store.ExecuteNonQuery("UPDATE AccountData SET Name = '" & AdminNameTxtBox.Text & "' WHERE Num = 1;", DataBaseConnection)
            MsgBox("Admin Account credentials updated successfully.", vbInformation, "Notice")
            store.WriteToLog(Store.loggedInAccount & " : Updates the login credential for admin account")
        Catch ex As Exception
            MsgBox(ex.Message)
            DataBaseConnection.Close()
        End Try
        AdminCredEditBtn.PerformClick()
        DataBaseConnection.Close()
        displayRefresh()

    End Sub

    Private Sub UserCredSaveBtn_Click(sender As Object, e As EventArgs) Handles UserCredSaveBtn.Click
        Try
            DataBaseConnection.Open()

            store.ExecuteNonQuery("UPDATE AccountData SET Username = '" & UserUserNameTxtBox.Text & "' WHERE Num = 2;", DataBaseConnection)
            store.ExecuteNonQuery("UPDATE AccountData SET Password = '" & UserPasswordTxtBox.Text & "' WHERE Num = 2;", DataBaseConnection)
            store.ExecuteNonQuery("UPDATE AccountData SET Name = '" & UserNameTxtBox.Text & "' WHERE Num = 2;", DataBaseConnection)
            MsgBox("User Account credentials updated successfully.", vbInformation, "Notice")
            store.WriteToLog(Store.loggedInAccount & " : Updates the login credential for user account")
        Catch ex As Exception
            MsgBox(ex.Message)
            DataBaseConnection.Close()
        End Try
        UserCredEditBtn.PerformClick()
        DataBaseConnection.Close()
        displayRefresh()
    End Sub
End Class