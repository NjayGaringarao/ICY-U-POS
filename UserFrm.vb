Public Class UserFrm

    Private customUtil As New CustomUtil()
    Private Sub UserFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DashboardBtn.PerformClick()
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        customUtil.ColorChange(1.1)
        customUtil.OpenChildForm(New TransactFrm(), ShowPane)
    End Sub

    Private Sub ManageBtn_Click(sender As Object, e As EventArgs) Handles ManageBtn.Click
        customUtil.ColorChange(2.1)

        customUtil.OpenChildForm(New HistoryFrm(), ShowPane)
    End Sub

    Private Sub LogoutBtn_Click(sender As Object, e As EventArgs) Handles LogoutBtn.Click
        Me.Hide()
        LoginFrm.Show()
    End Sub
End Class