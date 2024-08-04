<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordResetFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(PasswordResetFrm))
        Panel1 = New Panel()
        Label1 = New Label()
        Step1Pnl = New Panel()
        Panel8 = New Panel()
        Label5 = New Label()
        NextBtn = New Button()
        UsernameTxtBox = New TextBox()
        Label6 = New Label()
        Panel3 = New Panel()
        Label2 = New Label()
        Step2Pnl = New Panel()
        ClueLbl = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Panel9 = New Panel()
        Label8 = New Label()
        VerifyBtn = New Button()
        Panel5 = New Panel()
        Label3 = New Label()
        RecoveryAnsTxtBox = New TextBox()
        RecoveryQuestLbl = New Label()
        Step3Pnl = New Panel()
        Panel10 = New Panel()
        Label9 = New Label()
        CancelBtn = New Button()
        SaveBtn = New Button()
        Label11 = New Label()
        NewPass2TxtBox = New TextBox()
        Label10 = New Label()
        NewPass1TxtBox = New TextBox()
        Panel7 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Step1Pnl.SuspendLayout()
        Panel8.SuspendLayout()
        Panel3.SuspendLayout()
        Step2Pnl.SuspendLayout()
        Panel9.SuspendLayout()
        Panel5.SuspendLayout()
        Step3Pnl.SuspendLayout()
        Panel10.SuspendLayout()
        Panel7.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(784, 70)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(177, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 33)
        Label1.TabIndex = 0
        Label1.Text = "Reset your password as easy as 123!"
        ' 
        ' Step1Pnl
        ' 
        Step1Pnl.BackColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        Step1Pnl.BorderStyle = BorderStyle.FixedSingle
        Step1Pnl.Controls.Add(Panel8)
        Step1Pnl.Controls.Add(NextBtn)
        Step1Pnl.Controls.Add(UsernameTxtBox)
        Step1Pnl.Controls.Add(Label6)
        Step1Pnl.Controls.Add(Panel3)
        Step1Pnl.Dock = DockStyle.Top
        Step1Pnl.Location = New Point(0, 70)
        Step1Pnl.Name = "Step1Pnl"
        Step1Pnl.Size = New Size(784, 141)
        Step1Pnl.TabIndex = 1
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel8.Controls.Add(Label5)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(154, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(628, 51)
        Panel8.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLight
        Label5.Location = New Point(23, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(492, 29)
        Label5.TabIndex = 1
        Label5.Text = "Direction: Please provide the information needed."
        ' 
        ' NextBtn
        ' 
        NextBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        NextBtn.FlatStyle = FlatStyle.Flat
        NextBtn.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NextBtn.Location = New Point(635, 77)
        NextBtn.Name = "NextBtn"
        NextBtn.Size = New Size(127, 43)
        NextBtn.TabIndex = 4
        NextBtn.Text = "Next"
        NextBtn.UseVisualStyleBackColor = False
        ' 
        ' UsernameTxtBox
        ' 
        UsernameTxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        UsernameTxtBox.BorderStyle = BorderStyle.None
        UsernameTxtBox.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameTxtBox.Location = New Point(224, 91)
        UsernameTxtBox.Name = "UsernameTxtBox"
        UsernameTxtBox.Size = New Size(394, 29)
        UsernameTxtBox.TabIndex = 3
        UsernameTxtBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(213, 54)
        Label6.Name = "Label6"
        Label6.Size = New Size(222, 26)
        Label6.TabIndex = 2
        Label6.Text = "What is your username?"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(154, 139)
        Panel3.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(35, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 33)
        Label2.TabIndex = 1
        Label2.Text = "Step 1"
        ' 
        ' Step2Pnl
        ' 
        Step2Pnl.BackColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        Step2Pnl.BorderStyle = BorderStyle.FixedSingle
        Step2Pnl.Controls.Add(ClueLbl)
        Step2Pnl.Controls.Add(Label13)
        Step2Pnl.Controls.Add(Label12)
        Step2Pnl.Controls.Add(Panel9)
        Step2Pnl.Controls.Add(VerifyBtn)
        Step2Pnl.Controls.Add(Panel5)
        Step2Pnl.Controls.Add(RecoveryAnsTxtBox)
        Step2Pnl.Controls.Add(RecoveryQuestLbl)
        Step2Pnl.Dock = DockStyle.Top
        Step2Pnl.Location = New Point(0, 211)
        Step2Pnl.Name = "Step2Pnl"
        Step2Pnl.Size = New Size(784, 181)
        Step2Pnl.TabIndex = 2
        ' 
        ' ClueLbl
        ' 
        ClueLbl.AutoSize = True
        ClueLbl.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ClueLbl.Location = New Point(260, 145)
        ClueLbl.Name = "ClueLbl"
        ClueLbl.Size = New Size(14, 15)
        ClueLbl.TabIndex = 11
        ClueLbl.Text = "."
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(213, 139)
        Label13.Name = "Label13"
        Label13.Size = New Size(60, 26)
        Label13.TabIndex = 10
        Label13.Text = "Clue: "
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(189, 134)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 15)
        Label12.TabIndex = 9
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel9.Controls.Add(Label8)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(154, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(628, 47)
        Panel9.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLight
        Label8.Location = New Point(23, 8)
        Label8.Name = "Label8"
        Label8.Size = New Size(408, 29)
        Label8.TabIndex = 5
        Label8.Text = "Direction: Answer the recovery question."
        ' 
        ' VerifyBtn
        ' 
        VerifyBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        VerifyBtn.FlatStyle = FlatStyle.Flat
        VerifyBtn.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        VerifyBtn.Location = New Point(635, 131)
        VerifyBtn.Name = "VerifyBtn"
        VerifyBtn.Size = New Size(127, 43)
        VerifyBtn.TabIndex = 8
        VerifyBtn.Text = "Verify"
        VerifyBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel5.Controls.Add(Label3)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(154, 179)
        Panel5.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(35, 54)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 33)
        Label3.TabIndex = 1
        Label3.Text = "Step 2"
        ' 
        ' RecoveryAnsTxtBox
        ' 
        RecoveryAnsTxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        RecoveryAnsTxtBox.BorderStyle = BorderStyle.None
        RecoveryAnsTxtBox.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point)
        RecoveryAnsTxtBox.Location = New Point(224, 91)
        RecoveryAnsTxtBox.Name = "RecoveryAnsTxtBox"
        RecoveryAnsTxtBox.Size = New Size(394, 29)
        RecoveryAnsTxtBox.TabIndex = 7
        RecoveryAnsTxtBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' RecoveryQuestLbl
        ' 
        RecoveryQuestLbl.AutoSize = True
        RecoveryQuestLbl.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        RecoveryQuestLbl.Location = New Point(213, 54)
        RecoveryQuestLbl.Name = "RecoveryQuestLbl"
        RecoveryQuestLbl.Size = New Size(16, 26)
        RecoveryQuestLbl.TabIndex = 6
        RecoveryQuestLbl.Text = "."
        ' 
        ' Step3Pnl
        ' 
        Step3Pnl.BackColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        Step3Pnl.BorderStyle = BorderStyle.FixedSingle
        Step3Pnl.Controls.Add(Panel10)
        Step3Pnl.Controls.Add(CancelBtn)
        Step3Pnl.Controls.Add(SaveBtn)
        Step3Pnl.Controls.Add(Label11)
        Step3Pnl.Controls.Add(NewPass2TxtBox)
        Step3Pnl.Controls.Add(Label10)
        Step3Pnl.Controls.Add(NewPass1TxtBox)
        Step3Pnl.Controls.Add(Panel7)
        Step3Pnl.Dock = DockStyle.Top
        Step3Pnl.Location = New Point(0, 392)
        Step3Pnl.Name = "Step3Pnl"
        Step3Pnl.Size = New Size(784, 212)
        Step3Pnl.TabIndex = 3
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel10.Controls.Add(Label9)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(154, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(628, 47)
        Panel10.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ControlLight
        Label9.Location = New Point(24, 10)
        Label9.Name = "Label9"
        Label9.Size = New Size(324, 29)
        Label9.TabIndex = 9
        Label9.Text = "Direction: Create new password."
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        CancelBtn.FlatStyle = FlatStyle.Flat
        CancelBtn.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CancelBtn.Location = New Point(635, 84)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(127, 43)
        CancelBtn.TabIndex = 12
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SaveBtn.Location = New Point(635, 142)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(127, 43)
        SaveBtn.TabIndex = 9
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(213, 127)
        Label11.Name = "Label11"
        Label11.Size = New Size(278, 26)
        Label11.TabIndex = 10
        Label11.Text = "Type your new password again"
        ' 
        ' NewPass2TxtBox
        ' 
        NewPass2TxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        NewPass2TxtBox.BorderStyle = BorderStyle.None
        NewPass2TxtBox.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point)
        NewPass2TxtBox.Location = New Point(224, 156)
        NewPass2TxtBox.Name = "NewPass2TxtBox"
        NewPass2TxtBox.Size = New Size(394, 29)
        NewPass2TxtBox.TabIndex = 11
        NewPass2TxtBox.TextAlign = HorizontalAlignment.Center
        NewPass2TxtBox.UseSystemPasswordChar = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(213, 54)
        Label10.Name = "Label10"
        Label10.Size = New Size(228, 26)
        Label10.TabIndex = 5
        Label10.Text = "Type your new password"
        ' 
        ' NewPass1TxtBox
        ' 
        NewPass1TxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        NewPass1TxtBox.BorderStyle = BorderStyle.None
        NewPass1TxtBox.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point)
        NewPass1TxtBox.Location = New Point(224, 83)
        NewPass1TxtBox.Name = "NewPass1TxtBox"
        NewPass1TxtBox.Size = New Size(394, 29)
        NewPass1TxtBox.TabIndex = 9
        NewPass1TxtBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel7.Controls.Add(Label4)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(154, 210)
        Panel7.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(35, 54)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 33)
        Label4.TabIndex = 1
        Label4.Text = "Step 3"
        ' 
        ' PasswordResetFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        ClientSize = New Size(784, 596)
        Controls.Add(Step3Pnl)
        Controls.Add(Step2Pnl)
        Controls.Add(Step1Pnl)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "PasswordResetFrm"
        Text = "PasswordResetFrm"
        TopMost = True
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Step1Pnl.ResumeLayout(False)
        Step1Pnl.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Step2Pnl.ResumeLayout(False)
        Step2Pnl.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Step3Pnl.ResumeLayout(False)
        Step3Pnl.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Step1Pnl As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Step2Pnl As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Step3Pnl As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NextBtn As Button
    Friend WithEvents UsernameTxtBox As TextBox
    Friend WithEvents VerifyBtn As Button
    Friend WithEvents RecoveryAnsTxtBox As TextBox
    Friend WithEvents RecoveryQuestLbl As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents NewPass1TxtBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CancelBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents NewPass2TxtBox As TextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ClueLbl As Label
End Class
