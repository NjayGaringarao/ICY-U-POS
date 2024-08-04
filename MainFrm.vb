Imports System.Security.Cryptography.X509Certificates

Public Class MainFrm

    Dim customUtil As New CustomUtil()
    Dim store As New Store
    Private Sub ManageBtn_Click(sender As Object, e As EventArgs) Handles ManageBtn.Click

        customUtil.OpenChildForm(New HistoryFrm(), ShowPnl) 'for user form, use: CustomUtil.OpenChildForm(New ManageFrm(), UserShowPnl)
        customUtil.ColorChange(2.0)
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        LoginFrm.Show()
        LoginFrm.UserTxtBox.Focus()
        store.ReloadAccountDetails()
        store.WriteToLog(Store.loggedInAccount & " Logged out.")
    End Sub

    Private Sub AccountBtn_Click(sender As Object, e As EventArgs) Handles AccountBtn.Click

        customUtil.OpenChildForm(New AccountFrm(), ShowPnl)
        customUtil.ColorChange(3.0)

    End Sub

    Private Sub AdminFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackupBtn_Click(sender As Object, e As EventArgs) Handles BackupBtn.Click
        customUtil.OpenChildForm(New BackupFrm(), ShowPnl)
        customUtil.ColorChange(4.0)
    End Sub

    Private Sub ActivityBtn_Click(sender As Object, e As EventArgs) Handles ActivityBtn.Click
        customUtil.OpenChildForm(New ActivityLogFrm(), ShowPnl)
        customUtil.ColorChange(5.0)
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        customUtil.OpenChildForm(New TransactFrm(), ShowPnl)
        customUtil.ColorChange(1.0)
    End Sub

    Private Sub AboutUsLnkTxt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles AboutUsLnkTxt.LinkClicked
        Process.Start("cmd", $"/c start https://www.facebook.com/profile.php?id=61552580964133")
    End Sub
End Class