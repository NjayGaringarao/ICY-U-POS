<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrm))
        MenuPnl = New Panel()
        Panel2 = New Panel()
        Label3 = New Label()
        DocumentationLnkTxt = New LinkLabel()
        AboutUsLnkTxt = New LinkLabel()
        Label5 = New Label()
        Label4 = New Label()
        ActivityBtn = New Button()
        BackupBtn = New Button()
        AccountBtn = New Button()
        ManageBtn = New Button()
        DashboardBtn = New Button()
        Panel1 = New Panel()
        LogoutBtn = New Button()
        Button1 = New Button()
        ShowPnl = New Panel()
        MenuPnl.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuPnl
        ' 
        MenuPnl.BackColor = Color.FromArgb(CByte(169), CByte(178), CByte(136))
        MenuPnl.Controls.Add(Panel2)
        MenuPnl.Controls.Add(ActivityBtn)
        MenuPnl.Controls.Add(BackupBtn)
        MenuPnl.Controls.Add(AccountBtn)
        MenuPnl.Controls.Add(ManageBtn)
        MenuPnl.Controls.Add(DashboardBtn)
        MenuPnl.Controls.Add(Panel1)
        MenuPnl.Dock = DockStyle.Left
        MenuPnl.Location = New Point(0, 0)
        MenuPnl.Name = "MenuPnl"
        MenuPnl.Size = New Size(235, 681)
        MenuPnl.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
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
        Label5.Location = New Point(47, 55)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 13)
        Label5.TabIndex = 9
        Label5.Text = "Point of Sale App 1.0v"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(6, 28)
        Label4.Name = "Label4"
        Label4.Size = New Size(223, 27)
        Label4.TabIndex = 10
        Label4.Text = "ICY-U CORPORATION"
        ' 
        ' ActivityBtn
        ' 
        ActivityBtn.BackColor = Color.FromArgb(CByte(169), CByte(178), CByte(136))
        ActivityBtn.BackgroundImageLayout = ImageLayout.Center
        ActivityBtn.Dock = DockStyle.Top
        ActivityBtn.FlatAppearance.BorderSize = 0
        ActivityBtn.FlatStyle = FlatStyle.Flat
        ActivityBtn.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        ActivityBtn.Image = CType(resources.GetObject("ActivityBtn.Image"), Image)
        ActivityBtn.ImageAlign = ContentAlignment.MiddleLeft
        ActivityBtn.Location = New Point(0, 491)
        ActivityBtn.Name = "ActivityBtn"
        ActivityBtn.Size = New Size(235, 73)
        ActivityBtn.TabIndex = 9
        ActivityBtn.Text = "             ACTIVITY"
        ActivityBtn.TextAlign = ContentAlignment.MiddleLeft
        ActivityBtn.UseVisualStyleBackColor = False
        ' 
        ' BackupBtn
        ' 
        BackupBtn.BackColor = Color.FromArgb(CByte(169), CByte(178), CByte(136))
        BackupBtn.BackgroundImageLayout = ImageLayout.Center
        BackupBtn.Dock = DockStyle.Top
        BackupBtn.FlatAppearance.BorderSize = 0
        BackupBtn.FlatStyle = FlatStyle.Flat
        BackupBtn.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        BackupBtn.Image = CType(resources.GetObject("BackupBtn.Image"), Image)
        BackupBtn.ImageAlign = ContentAlignment.MiddleLeft
        BackupBtn.Location = New Point(0, 418)
        BackupBtn.Name = "BackupBtn"
        BackupBtn.Size = New Size(235, 73)
        BackupBtn.TabIndex = 8
        BackupBtn.Text = "             BACKUP"
        BackupBtn.TextAlign = ContentAlignment.MiddleLeft
        BackupBtn.UseVisualStyleBackColor = False
        ' 
        ' AccountBtn
        ' 
        AccountBtn.BackColor = Color.FromArgb(CByte(169), CByte(178), CByte(136))
        AccountBtn.BackgroundImageLayout = ImageLayout.Center
        AccountBtn.Dock = DockStyle.Top
        AccountBtn.FlatAppearance.BorderSize = 0
        AccountBtn.FlatStyle = FlatStyle.Flat
        AccountBtn.Font = New Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        AccountBtn.Image = CType(resources.GetObject("AccountBtn.Image"), Image)
        AccountBtn.ImageAlign = ContentAlignment.MiddleLeft
        AccountBtn.Location = New Point(0, 345)
        AccountBtn.Name = "AccountBtn"
        AccountBtn.Size = New Size(235, 73)
        AccountBtn.TabIndex = 7
        AccountBtn.Text = "             ACCOUNT"
        AccountBtn.TextAlign = ContentAlignment.MiddleLeft
        AccountBtn.UseVisualStyleBackColor = False
        ' 
        ' ManageBtn
        ' 
        ManageBtn.BackColor = Color.FromArgb(CByte(169), CByte(178), CByte(136))
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
        ManageBtn.Text = "             HISTORY"
        ManageBtn.TextAlign = ContentAlignment.MiddleLeft
        ManageBtn.UseVisualStyleBackColor = False
        ' 
        ' DashboardBtn
        ' 
        DashboardBtn.BackColor = Color.FromArgb(CByte(169), CByte(178), CByte(136))
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
        DashboardBtn.Text = "             TRANSACT"
        DashboardBtn.TextAlign = ContentAlignment.MiddleLeft
        DashboardBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(LogoutBtn)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(235, 199)
        Panel1.TabIndex = 0
        ' 
        ' LogoutBtn
        ' 
        LogoutBtn.BackColor = Color.FromArgb(CByte(169), CByte(178), CByte(136))
        LogoutBtn.FlatStyle = FlatStyle.Flat
        LogoutBtn.Image = CType(resources.GetObject("LogoutBtn.Image"), Image)
        LogoutBtn.Location = New Point(189, 154)
        LogoutBtn.Name = "LogoutBtn"
        LogoutBtn.Size = New Size(43, 39)
        LogoutBtn.TabIndex = 4
        LogoutBtn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(95), CByte(111), CByte(82))
        Button1.Dock = DockStyle.Fill
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(235, 199)
        Button1.TabIndex = 5
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ShowPnl
        ' 
        ShowPnl.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        ShowPnl.Dock = DockStyle.Fill
        ShowPnl.Location = New Point(235, 0)
        ShowPnl.Name = "ShowPnl"
        ShowPnl.Size = New Size(949, 681)
        ShowPnl.TabIndex = 1
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        ClientSize = New Size(1184, 681)
        Controls.Add(ShowPnl)
        Controls.Add(MenuPnl)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MinimumSize = New Size(960, 720)
        Name = "MainFrm"
        MenuPnl.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents MenuPnl As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DashboardBtn As Button
    Friend WithEvents ActivityBtn As Button
    Friend WithEvents BackupBtn As Button
    Friend WithEvents AccountBtn As Button
    Friend WithEvents ManageBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DocumentationLnkTxt As LinkLabel
    Friend WithEvents AboutUsLnkTxt As LinkLabel
    Friend WithEvents ShowPnl As Panel
    Friend WithEvents LogoutBtn As Button
    Friend WithEvents Button1 As Button
End Class
