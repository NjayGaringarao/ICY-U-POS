<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditDialogueFrm
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(AddEditDialogueFrm))
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label10 = New Label()
        Label9 = New Label()
        Label3 = New Label()
        Label1 = New Label()
        DecrementBtn = New Button()
        IncrementBtn = New Button()
        GenerateBtn = New Button()
        CategoryComboBox = New ComboBox()
        DirectionLbl = New Label()
        AmountTxtBox = New TextBox()
        InventoryIDTxtBox = New TextBox()
        ProductNameTxtBox = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        DescriptionTxtBox = New TextBox()
        TitlePnl = New Panel()
        TitleLbl = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        ClearResetBtn = New Button()
        AddSaveBtn = New Button()
        CloseBtn = New Button()
        Panel5 = New Panel()
        Panel2.SuspendLayout()
        TitlePnl.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(684, 15)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(191), CByte(168), CByte(146))
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(DecrementBtn)
        Panel2.Controls.Add(IncrementBtn)
        Panel2.Controls.Add(GenerateBtn)
        Panel2.Controls.Add(CategoryComboBox)
        Panel2.Controls.Add(DirectionLbl)
        Panel2.Controls.Add(AmountTxtBox)
        Panel2.Controls.Add(InventoryIDTxtBox)
        Panel2.Controls.Add(ProductNameTxtBox)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(DescriptionTxtBox)
        Panel2.Controls.Add(TitlePnl)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(15, 15)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(654, 374)
        Panel2.TabIndex = 1
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(494, 297)
        Label10.Name = "Label10"
        Label10.Size = New Size(16, 18)
        Label10.TabIndex = 14
        Label10.Text = "*"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.ForeColor = Color.Red
        Label9.Location = New Point(194, 298)
        Label9.Name = "Label9"
        Label9.Size = New Size(16, 18)
        Label9.TabIndex = 12
        Label9.Text = "*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(194, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(16, 18)
        Label3.TabIndex = 12
        Label3.Text = "*"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(194, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(16, 18)
        Label1.TabIndex = 11
        Label1.Text = "*"
        ' 
        ' DecrementBtn
        ' 
        DecrementBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        DecrementBtn.FlatStyle = FlatStyle.Flat
        DecrementBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        DecrementBtn.Image = CType(resources.GetObject("DecrementBtn.Image"), Image)
        DecrementBtn.Location = New Point(590, 312)
        DecrementBtn.Name = "DecrementBtn"
        DecrementBtn.Size = New Size(19, 15)
        DecrementBtn.TabIndex = 5
        DecrementBtn.UseVisualStyleBackColor = False
        ' 
        ' IncrementBtn
        ' 
        IncrementBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        IncrementBtn.FlatStyle = FlatStyle.Flat
        IncrementBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        IncrementBtn.Image = CType(resources.GetObject("IncrementBtn.Image"), Image)
        IncrementBtn.Location = New Point(590, 297)
        IncrementBtn.Name = "IncrementBtn"
        IncrementBtn.Size = New Size(19, 15)
        IncrementBtn.TabIndex = 4
        IncrementBtn.UseVisualStyleBackColor = False
        ' 
        ' GenerateBtn
        ' 
        GenerateBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        GenerateBtn.FlatStyle = FlatStyle.Flat
        GenerateBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        GenerateBtn.Location = New Point(518, 78)
        GenerateBtn.Name = "GenerateBtn"
        GenerateBtn.Size = New Size(91, 44)
        GenerateBtn.TabIndex = 0
        GenerateBtn.Text = "Generate"
        GenerateBtn.UseVisualStyleBackColor = False
        ' 
        ' CategoryComboBox
        ' 
        CategoryComboBox.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        CategoryComboBox.Font = New Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point)
        CategoryComboBox.FormattingEnabled = True
        CategoryComboBox.Items.AddRange(New Object() {"-- Select --", "Paper/Medium", "Printed Materials", "Essential Office Supply", "Inks and Cartridges", "Printer Maintenance"})
        CategoryComboBox.Location = New Point(211, 297)
        CategoryComboBox.Name = "CategoryComboBox"
        CategoryComboBox.Size = New Size(178, 31)
        CategoryComboBox.TabIndex = 3
        ' 
        ' DirectionLbl
        ' 
        DirectionLbl.AutoSize = True
        DirectionLbl.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        DirectionLbl.ForeColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        DirectionLbl.Location = New Point(6, 339)
        DirectionLbl.Name = "DirectionLbl"
        DirectionLbl.Size = New Size(12, 20)
        DirectionLbl.TabIndex = 3
        DirectionLbl.Text = "."
        ' 
        ' AmountTxtBox
        ' 
        AmountTxtBox.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        AmountTxtBox.BorderStyle = BorderStyle.FixedSingle
        AmountTxtBox.Font = New Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        AmountTxtBox.Location = New Point(510, 297)
        AmountTxtBox.Name = "AmountTxtBox"
        AmountTxtBox.ReadOnly = True
        AmountTxtBox.Size = New Size(82, 30)
        AmountTxtBox.TabIndex = 10
        AmountTxtBox.TabStop = False
        ' 
        ' InventoryIDTxtBox
        ' 
        InventoryIDTxtBox.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        InventoryIDTxtBox.BorderStyle = BorderStyle.FixedSingle
        InventoryIDTxtBox.Enabled = False
        InventoryIDTxtBox.Font = New Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        InventoryIDTxtBox.Location = New Point(212, 82)
        InventoryIDTxtBox.Name = "InventoryIDTxtBox"
        InventoryIDTxtBox.ReadOnly = True
        InventoryIDTxtBox.Size = New Size(300, 30)
        InventoryIDTxtBox.TabIndex = 9
        InventoryIDTxtBox.TabStop = False
        ' 
        ' ProductNameTxtBox
        ' 
        ProductNameTxtBox.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        ProductNameTxtBox.BorderStyle = BorderStyle.FixedSingle
        ProductNameTxtBox.Font = New Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ProductNameTxtBox.Location = New Point(212, 136)
        ProductNameTxtBox.Name = "ProductNameTxtBox"
        ProductNameTxtBox.Size = New Size(397, 30)
        ProductNameTxtBox.TabIndex = 1
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(395, 298)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 26)
        Label7.TabIndex = 7
        Label7.Text = "Amount   :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(50, 302)
        Label6.Name = "Label6"
        Label6.Size = New Size(150, 26)
        Label6.TabIndex = 6
        Label6.Text = "Category         :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(50, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(152, 26)
        Label5.TabIndex = 5
        Label5.Text = "Description      :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(52, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 26)
        Label4.TabIndex = 4
        Label4.Text = "Product Name : "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(52, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 26)
        Label2.TabIndex = 2
        Label2.Text = "Inventory ID  :"
        ' 
        ' DescriptionTxtBox
        ' 
        DescriptionTxtBox.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        DescriptionTxtBox.BorderStyle = BorderStyle.FixedSingle
        DescriptionTxtBox.Font = New Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        DescriptionTxtBox.Location = New Point(212, 193)
        DescriptionTxtBox.Multiline = True
        DescriptionTxtBox.Name = "DescriptionTxtBox"
        DescriptionTxtBox.ScrollBars = ScrollBars.Vertical
        DescriptionTxtBox.Size = New Size(397, 89)
        DescriptionTxtBox.TabIndex = 2
        ' 
        ' TitlePnl
        ' 
        TitlePnl.BackColor = Color.FromArgb(CByte(191), CByte(168), CByte(158))
        TitlePnl.BorderStyle = BorderStyle.FixedSingle
        TitlePnl.Controls.Add(TitleLbl)
        TitlePnl.Dock = DockStyle.Top
        TitlePnl.Location = New Point(0, 0)
        TitlePnl.Name = "TitlePnl"
        TitlePnl.Size = New Size(654, 70)
        TitlePnl.TabIndex = 0
        ' 
        ' TitleLbl
        ' 
        TitleLbl.Anchor = AnchorStyles.Top
        TitleLbl.AutoSize = True
        TitleLbl.Font = New Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point)
        TitleLbl.Location = New Point(325, 16)
        TitleLbl.Name = "TitleLbl"
        TitleLbl.Size = New Size(21, 33)
        TitleLbl.TabIndex = 1
        TitleLbl.Text = "."
        TitleLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 15)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(15, 374)
        Panel3.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(ClearResetBtn)
        Panel4.Controls.Add(AddSaveBtn)
        Panel4.Controls.Add(CloseBtn)
        Panel4.Dock = DockStyle.Bottom
        Panel4.Location = New Point(0, 389)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(684, 72)
        Panel4.TabIndex = 1
        ' 
        ' ClearResetBtn
        ' 
        ClearResetBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        ClearResetBtn.FlatStyle = FlatStyle.Flat
        ClearResetBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        ClearResetBtn.Location = New Point(383, 15)
        ClearResetBtn.Name = "ClearResetBtn"
        ClearResetBtn.Size = New Size(91, 44)
        ClearResetBtn.TabIndex = 6
        ClearResetBtn.UseVisualStyleBackColor = False
        ' 
        ' AddSaveBtn
        ' 
        AddSaveBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        AddSaveBtn.FlatStyle = FlatStyle.Flat
        AddSaveBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        AddSaveBtn.Location = New Point(480, 15)
        AddSaveBtn.Name = "AddSaveBtn"
        AddSaveBtn.Size = New Size(91, 44)
        AddSaveBtn.TabIndex = 7
        AddSaveBtn.UseVisualStyleBackColor = False
        ' 
        ' CloseBtn
        ' 
        CloseBtn.BackColor = Color.FromArgb(CByte(191), CByte(178), CByte(158))
        CloseBtn.FlatStyle = FlatStyle.Flat
        CloseBtn.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        CloseBtn.Location = New Point(577, 15)
        CloseBtn.Name = "CloseBtn"
        CloseBtn.Size = New Size(91, 44)
        CloseBtn.TabIndex = 8
        CloseBtn.Text = "Close"
        CloseBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Right
        Panel5.Location = New Point(669, 15)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(15, 374)
        Panel5.TabIndex = 1
        ' 
        ' AddEditDialogueFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        ClientSize = New Size(684, 461)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "AddEditDialogueFrm"
        StartPosition = FormStartPosition.CenterParent
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        TitlePnl.ResumeLayout(False)
        TitlePnl.PerformLayout()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TitlePnl As Panel
    Friend WithEvents DescriptionTxtBox As TextBox
    Friend WithEvents TitleLbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DirectionLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GenerateBtn As Button
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents AmountTxtBox As TextBox
    Friend WithEvents InventoryIDTxtBox As TextBox
    Friend WithEvents ProductNameTxtBox As TextBox
    Friend WithEvents AddSaveBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents ClearResetBtn As Button
    Friend WithEvents DecrementBtn As Button
    Friend WithEvents IncrementBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
