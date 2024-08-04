Imports System.Data.SQLite
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.ApplicationServices
'Imports QuestPDF.Infrastructure

Public Structure AccountDetails
    Dim index As Integer
    Dim username As String
    Dim password As String
    Dim recoveryQuest As String
    Dim recoveryAns As String
    Dim recoveryClue As String
    Dim name As String
End Structure

Public Class LoginFrm
    Dim store As New Store


    Sub OpenMainForm(ByVal flag As Integer)
        If flag = 1 Then
            MainFrm.AccountBtn.Enabled = True
            MainFrm.BackupBtn.Enabled = True
            MainFrm.ActivityBtn.Enabled = True
            MainFrm.Text = "ICY-U Corporation | Admin Access Point of Sale"
            UserTxtBox.Clear()
            PasswordTxtBox.Clear()
            MainFrm.Show()
            Me.Hide()
            MainFrm.DashboardBtn.PerformClick()
        ElseIf flag = 2 Then
            MainFrm.AccountBtn.Enabled = False
            MainFrm.BackupBtn.Enabled = False
            MainFrm.ActivityBtn.Enabled = False
            MainFrm.Text = "ICY-U Corporation | User Access Point of Sale"
            UserTxtBox.Clear()
            PasswordTxtBox.Clear()
            MainFrm.Show()
            Me.Hide()
            MainFrm.DashboardBtn.PerformClick()
        Else
            Exit Sub
        End If
    End Sub

    Private DataBase_Path As String = "Data Source=" & Application.StartupPath & "\IntegratedDataBase.db;"
    Private TableName As String = "AccountData"

    Dim accountFlag As Integer
    Private Sub UserTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles UserTxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            PasswordTxtBox.Focus()
        End If
    End Sub

    Private Sub PasswordTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PasswordTxtBox.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            LoginBtn.PerformClick()
        End If
    End Sub

    Private Sub PasswordResetLnkTxt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PasswordResetLnkTxt.LinkClicked
        PasswordResetFrm.ShowDialog()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Dim accountFlag As Integer

        If UserTxtBox.Text = Store.userAccount.username Then
            If PasswordTxtBox.Text = Store.userAccount.password Then
                accountFlag = 2
                Store.loggedInAccount = Store.userAccount.username
                Store.loggedInName = Store.userAccount.name
                store.WriteToLog(Store.userAccount.username & " : Logged in")

            Else
                accountFlag = 0
                MsgBox("Wrong Password!", vbCritical, "Input Error")
            End If
        ElseIf UserTxtBox.Text = Store.adminAccount.username Then
            If PasswordTxtBox.Text = Store.adminAccount.password Then
                accountFlag = 1
                Store.loggedInAccount = Store.adminAccount.username
                Store.loggedInName = Store.adminAccount.name
                store.WriteToLog(Store.adminAccount.username & " : Logged in")

            Else
                accountFlag = 0
                MsgBox("Wrong Password!", vbCritical, "Input Error")
            End If
        Else
            MsgBox("Username does not exist!", vbCritical, "Input Error")
            UserTxtBox.Focus()
        End If

        OpenMainForm(accountFlag)
    End Sub

    Private Sub LoginFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        store.ReloadAccountDetails()
        'QuestPDF.Settings.License = LicenseType.Community
    End Sub

    Private Sub AboutUsLnkTxt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AboutUsLnkTxt.LinkClicked
        Process.Start("cmd", $"/c start https://www.facebook.com/profile.php?id=61552580964133")
    End Sub

    Private Sub DocumentationLnkTxt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles DocumentationLnkTxt.LinkClicked
        MsgBox("No Documentations yet", vbInformation, "Apologies")
    End Sub
End Class
