<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecoverySetupDialogue
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(RecoverySetupDialogue))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Step3Pnl = New Panel()
        Panel10 = New Panel()
        Label9 = New Label()
        CancelBtn = New Button()
        SaveBtn = New Button()
        Label10 = New Label()
        PasswordTxtBox = New TextBox()
        Panel7 = New Panel()
        Label4 = New Label()
        Step2Pnl = New Panel()
        Label12 = New Label()
        RecAnswerTxtBox = New TextBox()
        Label6 = New Label()
        Panel9 = New Panel()
        Label8 = New Label()
        Next2Btn = New Button()
        Panel6 = New Panel()
        Label3 = New Label()
        Label11 = New Label()
        RecQuestTxtBox = New TextBox()
        RecClueTxtBox = New TextBox()
        Label7 = New Label()
        Step1Pnl = New Panel()
        AccountComboBox = New ComboBox()
        Panel11 = New Panel()
        Label5 = New Label()
        NextBtn = New Button()
        Panel8 = New Panel()
        Label2 = New Label()
        Panel12 = New Panel()
        Label1 = New Label()
        Panel5.SuspendLayout()
        Step3Pnl.SuspendLayout()
        Panel10.SuspendLayout()
        Panel7.SuspendLayout()
        Step2Pnl.SuspendLayout()
        Panel9.SuspendLayout()
        Panel6.SuspendLayout()
        Step1Pnl.SuspendLayout()
        Panel11.SuspendLayout()
        Panel8.SuspendLayout()
        Panel12.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(20, 648)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        Panel2.Dock = DockStyle.Right
        Panel2.Location = New Point(762, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(22, 648)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(20, 618)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(742, 30)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(20, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(742, 25)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(146))
        Panel5.Controls.Add(Step3Pnl)
        Panel5.Controls.Add(Step2Pnl)
        Panel5.Controls.Add(Step1Pnl)
        Panel5.Controls.Add(Panel12)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(20, 25)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(742, 593)
        Panel5.TabIndex = 4
        ' 
        ' Step3Pnl
        ' 
        Step3Pnl.BackColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        Step3Pnl.BorderStyle = BorderStyle.FixedSingle
        Step3Pnl.Controls.Add(Panel10)
        Step3Pnl.Controls.Add(CancelBtn)
        Step3Pnl.Controls.Add(SaveBtn)
        Step3Pnl.Controls.Add(Label10)
        Step3Pnl.Controls.Add(PasswordTxtBox)
        Step3Pnl.Controls.Add(Panel7)
        Step3Pnl.Dock = DockStyle.Top
        Step3Pnl.Location = New Point(0, 434)
        Step3Pnl.Name = "Step3Pnl"
        Step3Pnl.Size = New Size(742, 159)
        Step3Pnl.TabIndex = 7
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel10.Controls.Add(Label9)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(154, 0)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(586, 47)
        Panel10.TabIndex = 6
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = SystemColors.ControlLight
        Label9.Location = New Point(24, 10)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 29)
        Label9.TabIndex = 9
        Label9.Text = "Verify:"
        ' 
        ' CancelBtn
        ' 
        CancelBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        CancelBtn.FlatStyle = FlatStyle.Flat
        CancelBtn.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CancelBtn.Location = New Point(603, 52)
        CancelBtn.Name = "CancelBtn"
        CancelBtn.Size = New Size(107, 43)
        CancelBtn.TabIndex = 9
        CancelBtn.Text = "Cancel"
        CancelBtn.UseVisualStyleBackColor = False
        ' 
        ' SaveBtn
        ' 
        SaveBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        SaveBtn.FlatStyle = FlatStyle.Flat
        SaveBtn.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        SaveBtn.Location = New Point(603, 101)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(107, 43)
        SaveBtn.TabIndex = 8
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(213, 60)
        Label10.Name = "Label10"
        Label10.Size = New Size(188, 26)
        Label10.TabIndex = 5
        Label10.Text = "Type your password"
        ' 
        ' PasswordTxtBox
        ' 
        PasswordTxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        PasswordTxtBox.BorderStyle = BorderStyle.None
        PasswordTxtBox.Font = New Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordTxtBox.Location = New Point(197, 101)
        PasswordTxtBox.Name = "PasswordTxtBox"
        PasswordTxtBox.Size = New Size(379, 29)
        PasswordTxtBox.TabIndex = 7
        PasswordTxtBox.TextAlign = HorizontalAlignment.Center
        PasswordTxtBox.UseSystemPasswordChar = True
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel7.Controls.Add(Label4)
        Panel7.Dock = DockStyle.Left
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(154, 157)
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
        ' Step2Pnl
        ' 
        Step2Pnl.BackColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        Step2Pnl.BorderStyle = BorderStyle.FixedSingle
        Step2Pnl.Controls.Add(Label12)
        Step2Pnl.Controls.Add(RecAnswerTxtBox)
        Step2Pnl.Controls.Add(Label6)
        Step2Pnl.Controls.Add(Panel9)
        Step2Pnl.Controls.Add(Next2Btn)
        Step2Pnl.Controls.Add(Panel6)
        Step2Pnl.Controls.Add(Label11)
        Step2Pnl.Controls.Add(RecQuestTxtBox)
        Step2Pnl.Controls.Add(RecClueTxtBox)
        Step2Pnl.Controls.Add(Label7)
        Step2Pnl.Dock = DockStyle.Top
        Step2Pnl.Location = New Point(0, 179)
        Step2Pnl.Name = "Step2Pnl"
        Step2Pnl.Size = New Size(742, 255)
        Step2Pnl.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(196, 178)
        Label12.Name = "Label12"
        Label12.Size = New Size(83, 26)
        Label12.TabIndex = 14
        Label12.Text = "Answer:"
        ' 
        ' RecAnswerTxtBox
        ' 
        RecAnswerTxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        RecAnswerTxtBox.BorderStyle = BorderStyle.None
        RecAnswerTxtBox.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RecAnswerTxtBox.Location = New Point(196, 208)
        RecAnswerTxtBox.Name = "RecAnswerTxtBox"
        RecAnswerTxtBox.Size = New Size(379, 19)
        RecAnswerTxtBox.TabIndex = 5
        RecAnswerTxtBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(197, 109)
        Label6.Name = "Label6"
        Label6.Size = New Size(54, 26)
        Label6.TabIndex = 12
        Label6.Text = "Clue:"
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel9.Controls.Add(Label8)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(154, 0)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(586, 47)
        Panel9.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = SystemColors.ControlLight
        Label8.Location = New Point(23, 8)
        Label8.Name = "Label8"
        Label8.Size = New Size(290, 29)
        Label8.TabIndex = 5
        Label8.Text = "Create a Recovery Question:"
        ' 
        ' Next2Btn
        ' 
        Next2Btn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        Next2Btn.FlatStyle = FlatStyle.Flat
        Next2Btn.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Next2Btn.Location = New Point(603, 202)
        Next2Btn.Name = "Next2Btn"
        Next2Btn.Size = New Size(107, 43)
        Next2Btn.TabIndex = 6
        Next2Btn.Text = "Next"
        Next2Btn.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel6.Controls.Add(Label3)
        Panel6.Dock = DockStyle.Left
        Panel6.Location = New Point(0, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(154, 253)
        Panel6.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ControlLightLight
        Label3.Location = New Point(31, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 33)
        Label3.TabIndex = 1
        Label3.Text = "Step 2"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label11.Location = New Point(197, 50)
        Label11.Name = "Label11"
        Label11.Size = New Size(96, 26)
        Label11.TabIndex = 10
        Label11.Text = "Question:"
        ' 
        ' RecQuestTxtBox
        ' 
        RecQuestTxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        RecQuestTxtBox.BorderStyle = BorderStyle.None
        RecQuestTxtBox.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RecQuestTxtBox.Location = New Point(197, 77)
        RecQuestTxtBox.Name = "RecQuestTxtBox"
        RecQuestTxtBox.Size = New Size(379, 19)
        RecQuestTxtBox.TabIndex = 3
        ' 
        ' RecClueTxtBox
        ' 
        RecClueTxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        RecClueTxtBox.BorderStyle = BorderStyle.None
        RecClueTxtBox.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        RecClueTxtBox.Location = New Point(197, 139)
        RecClueTxtBox.Name = "RecClueTxtBox"
        RecClueTxtBox.Size = New Size(379, 19)
        RecClueTxtBox.TabIndex = 4
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(213, 54)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 26)
        Label7.TabIndex = 6
        ' 
        ' Step1Pnl
        ' 
        Step1Pnl.BackColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        Step1Pnl.BorderStyle = BorderStyle.FixedSingle
        Step1Pnl.Controls.Add(AccountComboBox)
        Step1Pnl.Controls.Add(Panel11)
        Step1Pnl.Controls.Add(NextBtn)
        Step1Pnl.Controls.Add(Panel8)
        Step1Pnl.Dock = DockStyle.Top
        Step1Pnl.Location = New Point(0, 70)
        Step1Pnl.Name = "Step1Pnl"
        Step1Pnl.Size = New Size(742, 109)
        Step1Pnl.TabIndex = 5
        ' 
        ' AccountComboBox
        ' 
        AccountComboBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        AccountComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        AccountComboBox.FlatStyle = FlatStyle.Popup
        AccountComboBox.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        AccountComboBox.FormattingEnabled = True
        AccountComboBox.Items.AddRange(New Object() {"Admin", "User"})
        AccountComboBox.Location = New Point(197, 62)
        AccountComboBox.Name = "AccountComboBox"
        AccountComboBox.Size = New Size(380, 34)
        AccountComboBox.TabIndex = 1
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel11.Controls.Add(Label5)
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(154, 0)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(586, 51)
        Panel11.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ControlLight
        Label5.Location = New Point(23, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(190, 29)
        Label5.TabIndex = 1
        Label5.Text = "Choose an account"
        ' 
        ' NextBtn
        ' 
        NextBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        NextBtn.FlatStyle = FlatStyle.Flat
        NextBtn.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        NextBtn.Location = New Point(603, 57)
        NextBtn.Name = "NextBtn"
        NextBtn.Size = New Size(107, 43)
        NextBtn.TabIndex = 2
        NextBtn.Tag = ""
        NextBtn.Text = "Next"
        NextBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Panel8.Controls.Add(Label2)
        Panel8.Dock = DockStyle.Left
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(154, 107)
        Panel8.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(31, 35)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 33)
        Label2.TabIndex = 1
        Label2.Text = "Step 1"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        Panel12.BorderStyle = BorderStyle.FixedSingle
        Panel12.Controls.Add(Label1)
        Panel12.Dock = DockStyle.Top
        Panel12.Location = New Point(0, 0)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(742, 70)
        Panel12.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(177, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(452, 33)
        Label1.TabIndex = 0
        Label1.Text = "Create a recovery setup as easy as 123!"
        ' 
        ' RecoverySetupDialogue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        ClientSize = New Size(784, 648)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "RecoverySetupDialogue"
        Text = "Recovery Setup"
        Panel5.ResumeLayout(False)
        Step3Pnl.ResumeLayout(False)
        Step3Pnl.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Step2Pnl.ResumeLayout(False)
        Step2Pnl.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Step1Pnl.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel12.ResumeLayout(False)
        Panel12.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Step3Pnl As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents CancelBtn As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents RecClueTxtBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PasswordTxtBox As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Step2Pnl As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Next2Btn As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents RecQuestTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Step1Pnl As Panel
    Friend WithEvents AccountComboBox As ComboBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents NextBtn As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RecAnswerTxtBox As TextBox
    Friend WithEvents Label6 As Label
End Class
