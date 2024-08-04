Imports System.ComponentModel
Imports JRPS_IMS.Store

Public Class CustomUtil

    Public currentChildForm As Form

    Public Sub OpenChildForm(childForm As Form, panel As Panel)
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panel.Controls.Add(childForm)
        panel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Public Sub ColorChange(ByVal btn As Double)

        Select Case btn
            Case 1.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(254, 250, 224)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(169, 178, 136)


            Case 2.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(254, 250, 224)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(169, 178, 136)

            Case 3.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(254, 250, 224)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(169, 178, 136)
            Case 4.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(254, 250, 224)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(169, 178, 136)
            Case 5.0
                MainFrm.ManageBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.DashboardBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.AccountBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.BackupBtn.BackColor = Color.FromArgb(169, 178, 136)
                MainFrm.ActivityBtn.BackColor = Color.FromArgb(254, 250, 224)
        End Select

    End Sub



End Class
