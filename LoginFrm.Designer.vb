<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginFrm))
        LoginGrpBox = New GroupBox()
        PasswordResetLnkTxt = New LinkLabel()
        LoginBtn = New Button()
        PasswordTxtBox = New TextBox()
        UserTxtBox = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        LogoPicBox = New PictureBox()
        AboutUsLnkTxt = New LinkLabel()
        DocumentationLnkTxt = New LinkLabel()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        LoginGrpBox.SuspendLayout()
        CType(LogoPicBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LoginGrpBox
        ' 
        LoginGrpBox.Controls.Add(PasswordResetLnkTxt)
        LoginGrpBox.Controls.Add(LoginBtn)
        LoginGrpBox.Controls.Add(PasswordTxtBox)
        LoginGrpBox.Controls.Add(UserTxtBox)
        LoginGrpBox.Controls.Add(Label1)
        LoginGrpBox.Controls.Add(Label2)
        LoginGrpBox.Location = New Point(73, 414)
        LoginGrpBox.Name = "LoginGrpBox"
        LoginGrpBox.Size = New Size(438, 286)
        LoginGrpBox.TabIndex = 0
        LoginGrpBox.TabStop = False
        LoginGrpBox.Text = "LOGIN TO CONTINUE"
        ' 
        ' PasswordResetLnkTxt
        ' 
        PasswordResetLnkTxt.AutoSize = True
        PasswordResetLnkTxt.LinkColor = Color.Black
        PasswordResetLnkTxt.Location = New Point(161, 249)
        PasswordResetLnkTxt.Name = "PasswordResetLnkTxt"
        PasswordResetLnkTxt.Size = New Size(116, 18)
        PasswordResetLnkTxt.TabIndex = 5
        PasswordResetLnkTxt.TabStop = True
        PasswordResetLnkTxt.Text = "Forgot Password?"
        PasswordResetLnkTxt.VisitedLinkColor = Color.Black
        ' 
        ' LoginBtn
        ' 
        LoginBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        LoginBtn.BackgroundImageLayout = ImageLayout.Center
        LoginBtn.FlatStyle = FlatStyle.Flat
        LoginBtn.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        LoginBtn.Location = New Point(155, 194)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(133, 39)
        LoginBtn.TabIndex = 4
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = False
        ' 
        ' PasswordTxtBox
        ' 
        PasswordTxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        PasswordTxtBox.BorderStyle = BorderStyle.None
        PasswordTxtBox.Font = New Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordTxtBox.Location = New Point(61, 121)
        PasswordTxtBox.Name = "PasswordTxtBox"
        PasswordTxtBox.Size = New Size(329, 22)
        PasswordTxtBox.TabIndex = 2
        PasswordTxtBox.TextAlign = HorizontalAlignment.Center
        PasswordTxtBox.UseSystemPasswordChar = True
        ' 
        ' UserTxtBox
        ' 
        UserTxtBox.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        UserTxtBox.BorderStyle = BorderStyle.None
        UserTxtBox.Font = New Font("Consolas", 14F, FontStyle.Regular, GraphicsUnit.Point)
        UserTxtBox.Location = New Point(61, 53)
        UserTxtBox.Name = "UserTxtBox"
        UserTxtBox.Size = New Size(329, 22)
        UserTxtBox.TabIndex = 0
        UserTxtBox.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(54, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(344, 36)
        Label1.TabIndex = 1
        Label1.Text = "__________________________________________" & vbCrLf & "USERNAME"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(53, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(344, 36)
        Label2.TabIndex = 6
        Label2.Text = "__________________________________________" & vbCrLf & "PASSWORD" & vbCrLf
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LogoPicBox
        ' 
        LogoPicBox.BackColor = Color.Transparent
        LogoPicBox.Image = CType(resources.GetObject("LogoPicBox.Image"), Image)
        LogoPicBox.Location = New Point(134, 39)
        LogoPicBox.Name = "LogoPicBox"
        LogoPicBox.Size = New Size(332, 308)
        LogoPicBox.SizeMode = PictureBoxSizeMode.Zoom
        LogoPicBox.TabIndex = 1
        LogoPicBox.TabStop = False
        ' 
        ' AboutUsLnkTxt
        ' 
        AboutUsLnkTxt.AutoSize = True
        AboutUsLnkTxt.LinkColor = Color.Black
        AboutUsLnkTxt.Location = New Point(201, 715)
        AboutUsLnkTxt.Name = "AboutUsLnkTxt"
        AboutUsLnkTxt.Size = New Size(64, 18)
        AboutUsLnkTxt.TabIndex = 6
        AboutUsLnkTxt.TabStop = True
        AboutUsLnkTxt.Text = "About Us"
        AboutUsLnkTxt.VisitedLinkColor = Color.Black
        ' 
        ' DocumentationLnkTxt
        ' 
        DocumentationLnkTxt.AutoSize = True
        DocumentationLnkTxt.LinkColor = Color.Black
        DocumentationLnkTxt.Location = New Point(294, 715)
        DocumentationLnkTxt.Name = "DocumentationLnkTxt"
        DocumentationLnkTxt.Size = New Size(131, 18)
        DocumentationLnkTxt.TabIndex = 7
        DocumentationLnkTxt.TabStop = True
        DocumentationLnkTxt.Text = "Open Documentation"
        DocumentationLnkTxt.VisitedLinkColor = Color.Black
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(275, 715)
        Label3.Name = "Label3"
        Label3.Size = New Size(13, 18)
        Label3.TabIndex = 6
        Label3.Text = "|"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Comic Sans MS", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(112, 322)
        Label4.Name = "Label4"
        Label4.Size = New Size(378, 45)
        Label4.TabIndex = 8
        Label4.Text = "ICY-U CORPORATION"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(201, 367)
        Label5.Name = "Label5"
        Label5.Size = New Size(180, 22)
        Label5.TabIndex = 6
        Label5.Text = "Point of Sale App"
        ' 
        ' LoginFrm
        ' 
        AutoScaleDimensions = New SizeF(8F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        ClientSize = New Size(584, 761)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DocumentationLnkTxt)
        Controls.Add(AboutUsLnkTxt)
        Controls.Add(LogoPicBox)
        Controls.Add(LoginGrpBox)
        Font = New Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "LoginFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ICY-U Corporation"
        LoginGrpBox.ResumeLayout(False)
        LoginGrpBox.PerformLayout()
        CType(LogoPicBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LoginGrpBox As GroupBox
    Friend WithEvents UserTxtBox As TextBox
    Friend WithEvents PasswordTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents PasswordResetLnkTxt As LinkLabel
    Friend WithEvents LogoPicBox As PictureBox
    Friend WithEvents AboutUsLnkTxt As LinkLabel
    Friend WithEvents DocumentationLnkTxt As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
End Class
