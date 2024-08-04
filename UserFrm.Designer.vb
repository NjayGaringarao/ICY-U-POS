<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserFrm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(UserFrm))
        ShowPane = New Panel()
        MenuPnl = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        DocumentationLnkTxt = New LinkLabel()
        AboutUsLnkTxt = New LinkLabel()
        Label5 = New Label()
        Label4 = New Label()
        ManageBtn = New Button()
        DashboardBtn = New Button()
        Panel1 = New Panel()
        LogoutBtn = New Button()
        LogoPicBox = New PictureBox()
        MenuPnl.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(LogoPicBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ShowPane
        ' 
        ShowPane.Dock = DockStyle.Fill
        ShowPane.Location = New Point(235, 0)
        ShowPane.Name = "ShowPane"
        ShowPane.Size = New Size(949, 681)
        ShowPane.TabIndex = 3
        ' 
        ' MenuPnl
        ' 
        MenuPnl.BackColor = Color.FromArgb(CByte(179), CByte(168), CByte(146))
        MenuPnl.Controls.Add(Panel2)
        MenuPnl.Controls.Add(ManageBtn)
        MenuPnl.Controls.Add(DashboardBtn)
        MenuPnl.Controls.Add(Panel1)
        MenuPnl.Dock = DockStyle.Left
        MenuPnl.Location = New Point(0, 0)
        MenuPnl.Name = "MenuPnl"
        MenuPnl.Size = New Size(235, 681)
        MenuPnl.TabIndex = 2
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(DocumentationLnkTxt)
        Panel2.Controls.Add(AboutUsLnkTxt)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 568)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(235, 113)
        Panel2.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(85, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(10, 15)
        Label3.TabIndex = 11
        Label3.Text = "|"
        ' 
        ' DocumentationLnkTxt
        ' 
        DocumentationLnkTxt.AutoSize = True
        DocumentationLnkTxt.LinkColor = Color.Black
        DocumentationLnkTxt.Location = New Point(101, 80)
        DocumentationLnkTxt.Name = "DocumentationLnkTxt"
        DocumentationLnkTxt.Size = New Size(122, 15)
        DocumentationLnkTxt.TabIndex = 13
        DocumentationLnkTxt.TabStop = True
        DocumentationLnkTxt.Text = "Open Documentation"
        DocumentationLnkTxt.VisitedLinkColor = Color.Black
        ' 
        ' AboutUsLnkTxt
        ' 
        AboutUsLnkTxt.AutoSize = True
        AboutUsLnkTxt.LinkColor = Color.Black
        AboutUsLnkTxt.Location = New Point(23, 80)
        AboutUsLnkTxt.Name = "AboutUsLnkTxt"
        AboutUsLnkTxt.Size = New Size(56, 15)
        AboutUsLnkTxt.TabIndex = 12
        AboutUsLnkTxt.TabStop = True
        AboutUsLnkTxt.Text = "About Us"
        AboutUsLnkTxt.VisitedLinkColor = Color.Black
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(28, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(181, 13)
        Label5.TabIndex = 9
        Label5.Text = "Inventory Management App 1.0v"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(19, 25)
        Label4.Name = "Label4"
        Label4.Size = New Size(204, 27)
        Label4.TabIndex = 10
        Label4.Text = "JR PRINTING SHOP"
        ' 
        ' ManageBtn
        ' 
        ManageBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        ManageBtn.BackgroundImageLayout = ImageLayout.Center
        ManageBtn.Dock = DockStyle.Top
        ManageBtn.FlatAppearance.BorderSize = 0
        ManageBtn.FlatStyle = FlatStyle.Flat
        ManageBtn.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        ManageBtn.Image = CType(resources.GetObject("ManageBtn.Image"), Image)
        ManageBtn.ImageAlign = ContentAlignment.MiddleLeft
        ManageBtn.Location = New Point(0, 272)
        ManageBtn.Name = "ManageBtn"
        ManageBtn.Size = New Size(235, 73)
        ManageBtn.TabIndex = 6
        ManageBtn.Text = "             MANAGE"
        ManageBtn.TextAlign = ContentAlignment.MiddleLeft
        ManageBtn.UseVisualStyleBackColor = False
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        DashboardBtn.BackgroundImageLayout = ImageLayout.Center
        DashboardBtn.Dock = DockStyle.Top
        DashboardBtn.FlatAppearance.BorderSize = 0
        DashboardBtn.FlatStyle = FlatStyle.Flat
        DashboardBtn.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        DashboardBtn.Image = CType(resources.GetObject("DashboardBtn.Image"), Image)
        DashboardBtn.ImageAlign = ContentAlignment.TopLeft
        DashboardBtn.Location = New Point(0, 199)
        DashboardBtn.Name = "DashboardBtn"
        DashboardBtn.Size = New Size(235, 73)
        DashboardBtn.TabIndex = 5
        DashboardBtn.Text = "             DASHBOARD"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        DashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LogoutBtn)
        Panel1.Controls.Add(LogoPicBox)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(235, 199)
        Panel1.TabIndex = 0
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.FlatStyle = FlatStyle.Flat
        LogoutBtn.Image = CType(resources.GetObject("LogoutBtn.Image"), Image)
        LogoutBtn.Location = New Point(165, 146)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(58, 47)
        LogoutBtn.TabIndex = 3
        LogoutBtn.UseVisualStyleBackColor = True
        ' 
        ' LogoPicBox
        ' 
        LogoPicBox.BackColor = Color.Transparent
        LogoPicBox.Image = My.Resources.Resources.printer_Green_
        LogoPicBox.Location = New Point(41, 12)
        LogoPicBox.Name = "LogoPicBox"
        LogoPicBox.Size = New Size(155, 168)
        LogoPicBox.SizeMode = PictureBoxSizeMode.Zoom
        LogoPicBox.TabIndex = 2
        LogoPicBox.TabStop = False
        ' 
        ' UserFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        ClientSize = New Size(1184, 681)
        Controls.Add(ShowPane)
        Controls.Add(MenuPnl)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(960, 720)
        Name = "UserFrm"
        Text = "JR Printing Shop | User Inventory"
        MenuPnl.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(LogoPicBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ShowPane As Panel
    Friend WithEvents MenuPnl As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DocumentationLnkTxt As LinkLabel
    Friend WithEvents AboutUsLnkTxt As LinkLabel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ManageBtn As Button
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoPicBox As PictureBox
    Friend WithEvents LogoutBtn As Button
End Class
