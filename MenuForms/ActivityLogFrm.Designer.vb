<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityLogFrm
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel7 = New Panel()
        DataGridViewTable = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Panel6 = New Panel()
        ClearBtn = New Button()
        ExportBtn = New Button()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        CType(DataGridViewTable, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(999, 21)
        Panel1.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 21)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(19, 621)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(976, 21)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(23, 621)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(Panel6)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(19, 21)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(957, 621)
        Panel5.TabIndex = 4
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(DataGridViewTable)
        Panel7.Dock = DockStyle.Fill
        Panel7.Location = New Point(0, 0)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(957, 558)
        Panel7.TabIndex = 0
        ' 
        ' DataGridViewTable
        ' 
        DataGridViewTable.AllowUserToAddRows = False
        DataGridViewTable.AllowUserToDeleteRows = False
        DataGridViewTable.AllowUserToOrderColumns = True
        DataGridViewTable.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        DataGridViewCellStyle5.Font = New Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        DataGridViewCellStyle5.SelectionForeColor = Color.Black
        DataGridViewTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewTable.BackgroundColor = Color.FromArgb(CByte(169), CByte(179), CByte(136))
        DataGridViewTable.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = SystemColors.Control
        DataGridViewCellStyle6.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DataGridViewTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        DataGridViewTable.ColumnHeadersHeight = 25
        DataGridViewTable.Columns.AddRange(New DataGridViewColumn() {Column1, Column4})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        DataGridViewCellStyle7.Font = New Font("Consolas", 11F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        DataGridViewCellStyle7.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        DataGridViewTable.DefaultCellStyle = DataGridViewCellStyle7
        DataGridViewTable.Dock = DockStyle.Fill
        DataGridViewTable.EnableHeadersVisualStyles = False
        DataGridViewTable.Location = New Point(0, 0)
        DataGridViewTable.Name = "DataGridViewTable"
        DataGridViewTable.RightToLeft = RightToLeft.No
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(214), CByte(199), CByte(174))
        DataGridViewCellStyle8.Font = New Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        DataGridViewCellStyle8.SelectionForeColor = SystemColors.WindowText
        DataGridViewTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewTable.RowHeadersVisible = False
        DataGridViewTable.RowHeadersWidth = 20
        DataGridViewTable.RowTemplate.Height = 25
        DataGridViewTable.Size = New Size(957, 558)
        DataGridViewTable.TabIndex = 1
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column1.FillWeight = 99.61929F
        Column1.HeaderText = "Date and Time"
        Column1.MinimumWidth = 200
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 200
        ' 
        ' Column4
        ' 
        Column4.FillWeight = 99.61929F
        Column4.HeaderText = "Details"
        Column4.MinimumWidth = 60
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(254), CByte(250), CByte(224))
        Panel6.Controls.Add(ClearBtn)
        Panel6.Controls.Add(ExportBtn)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(0, 558)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(957, 63)
        Panel6.TabIndex = 0
        ' 
        ' ClearBtn
        ' 
        ClearBtn.Anchor = AnchorStyles.Left
        ClearBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        ClearBtn.FlatStyle = FlatStyle.Flat
        ClearBtn.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ClearBtn.Location = New Point(0, 9)
        ClearBtn.Name = "ClearBtn"
        ClearBtn.Size = New Size(111, 38)
        ClearBtn.TabIndex = 2
        ClearBtn.Text = "Clear Logs"
        ClearBtn.UseVisualStyleBackColor = False
        ' 
        ' ExportBtn
        ' 
        ExportBtn.Anchor = AnchorStyles.Right
        ExportBtn.BackColor = Color.FromArgb(CByte(185), CByte(148), CByte(112))
        ExportBtn.FlatStyle = FlatStyle.Flat
        ExportBtn.Font = New Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        ExportBtn.Location = New Point(839, 9)
        ExportBtn.Name = "ExportBtn"
        ExportBtn.Size = New Size(118, 38)
        ExportBtn.TabIndex = 3
        ExportBtn.Text = "Export Logs"
        ExportBtn.UseVisualStyleBackColor = False
        ' 
        ' ActivityLogFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(218), CByte(221), CByte(177))
        ClientSize = New Size(999, 642)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Name = "ActivityLogFrm"
        Text = "ActivityLog"
        Panel5.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        CType(DataGridViewTable, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ClearBtn As Button
    Friend WithEvents ExportBtn As Button
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
