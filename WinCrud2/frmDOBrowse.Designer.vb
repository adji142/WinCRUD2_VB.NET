<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDOBrowse
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.ViewH = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.RowID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoSO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TglSO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaCust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlamatKirim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeSales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaSales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nPrint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewD = New Enerzie.EPSGridControls.EPSDataGridView()
        Me.RowIDD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HrgSatuan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KodeBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmdAdd = New System.Windows.Forms.Button()
        Me.CmdEdit = New System.Windows.Forms.Button()
        Me.CmdDel = New System.Windows.Forms.Button()
        Me.CmdPrint = New System.Windows.Forms.Button()
        Me.CmdSearch = New System.Windows.Forms.Button()
        CType(Me.ViewH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Range Tanggal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(99, 9)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(305, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "s/d"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(334, 9)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 3
        '
        'ViewH
        '
        Me.ViewH.AllowUserToAddRows = False
        Me.ViewH.AllowUserToDeleteRows = False
        Me.ViewH.AllowUserToOrderColumns = True
        Me.ViewH.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.ViewH.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewH.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewH.BackgroundColor = System.Drawing.Color.White
        Me.ViewH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewH.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ViewH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewH.ColumnHeadersHeight = 35
        Me.ViewH.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RowID, Me.NoSO, Me.TglSO, Me.NamaCust, Me.AlamatKirim, Me.KodeSales, Me.NamaSales, Me.nPrint})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewH.DefaultCellStyle = DataGridViewCellStyle2
        Me.ViewH.Location = New System.Drawing.Point(12, 35)
        Me.ViewH.MultiSelect = False
        Me.ViewH.Name = "ViewH"
        Me.ViewH.ReadOnly = True
        Me.ViewH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewH.RowHeadersVisible = False
        Me.ViewH.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ViewH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewH.ShowEditingIcon = False
        Me.ViewH.Size = New System.Drawing.Size(651, 124)
        Me.ViewH.StandardTab = True
        Me.ViewH.TabIndex = 4
        '
        'RowID
        '
        Me.RowID.DataPropertyName = "RowIDH"
        Me.RowID.HeaderText = "RowID"
        Me.RowID.Name = "RowID"
        Me.RowID.ReadOnly = True
        Me.RowID.Visible = False
        '
        'NoSO
        '
        Me.NoSO.DataPropertyName = "NoSO"
        Me.NoSO.HeaderText = "No SO"
        Me.NoSO.Name = "NoSO"
        Me.NoSO.ReadOnly = True
        '
        'TglSO
        '
        Me.TglSO.DataPropertyName = "TglSO"
        Me.TglSO.HeaderText = "Tgl SO"
        Me.TglSO.Name = "TglSO"
        Me.TglSO.ReadOnly = True
        '
        'NamaCust
        '
        Me.NamaCust.DataPropertyName = "NamaCustomer"
        Me.NamaCust.HeaderText = "Nama Cust"
        Me.NamaCust.Name = "NamaCust"
        Me.NamaCust.ReadOnly = True
        '
        'AlamatKirim
        '
        Me.AlamatKirim.DataPropertyName = "Alamat01"
        Me.AlamatKirim.HeaderText = "Alamat Kirim"
        Me.AlamatKirim.Name = "AlamatKirim"
        Me.AlamatKirim.ReadOnly = True
        '
        'KodeSales
        '
        Me.KodeSales.DataPropertyName = "KodeSales"
        Me.KodeSales.HeaderText = "Kode Sales"
        Me.KodeSales.Name = "KodeSales"
        Me.KodeSales.ReadOnly = True
        '
        'NamaSales
        '
        Me.NamaSales.DataPropertyName = "NamaSales"
        Me.NamaSales.HeaderText = "Nama Sales"
        Me.NamaSales.Name = "NamaSales"
        Me.NamaSales.ReadOnly = True
        '
        'nPrint
        '
        Me.nPrint.DataPropertyName = "nPrint"
        Me.nPrint.HeaderText = "nPrint"
        Me.nPrint.Name = "nPrint"
        Me.nPrint.ReadOnly = True
        '
        'ViewD
        '
        Me.ViewD.AllowUserToAddRows = False
        Me.ViewD.AllowUserToDeleteRows = False
        Me.ViewD.AllowUserToOrderColumns = True
        Me.ViewD.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.ViewD.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.ViewD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewD.BackgroundColor = System.Drawing.Color.White
        Me.ViewD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ViewD.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.ViewD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewD.ColumnHeadersHeight = 35
        Me.ViewD.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RowIDD, Me.NamaItem, Me.QtyOrder, Me.QtyDO, Me.HrgSatuan, Me.KodeBarang})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewD.DefaultCellStyle = DataGridViewCellStyle4
        Me.ViewD.Location = New System.Drawing.Point(12, 165)
        Me.ViewD.MultiSelect = False
        Me.ViewD.Name = "ViewD"
        Me.ViewD.ReadOnly = True
        Me.ViewD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ViewD.RowHeadersVisible = False
        Me.ViewD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ViewD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewD.ShowEditingIcon = False
        Me.ViewD.Size = New System.Drawing.Size(651, 124)
        Me.ViewD.StandardTab = True
        Me.ViewD.TabIndex = 5
        '
        'RowIDD
        '
        Me.RowIDD.DataPropertyName = "RowIDD"
        Me.RowIDD.HeaderText = "RowID"
        Me.RowIDD.Name = "RowIDD"
        Me.RowIDD.ReadOnly = True
        Me.RowIDD.Visible = False
        '
        'NamaItem
        '
        Me.NamaItem.DataPropertyName = "NamaItem"
        Me.NamaItem.HeaderText = "Nama Item"
        Me.NamaItem.Name = "NamaItem"
        Me.NamaItem.ReadOnly = True
        '
        'QtyOrder
        '
        Me.QtyOrder.DataPropertyName = "QtyOrder"
        Me.QtyOrder.HeaderText = "Qty Order"
        Me.QtyOrder.Name = "QtyOrder"
        Me.QtyOrder.ReadOnly = True
        '
        'QtyDO
        '
        Me.QtyDO.DataPropertyName = "QtyDO"
        Me.QtyDO.HeaderText = "Qty DO"
        Me.QtyDO.Name = "QtyDO"
        Me.QtyDO.ReadOnly = True
        Me.QtyDO.Visible = False
        '
        'HrgSatuan
        '
        Me.HrgSatuan.DataPropertyName = "HrgSatuan"
        Me.HrgSatuan.HeaderText = "Hrg Satuan"
        Me.HrgSatuan.Name = "HrgSatuan"
        Me.HrgSatuan.ReadOnly = True
        '
        'KodeBarang
        '
        Me.KodeBarang.DataPropertyName = "KodeBarang"
        Me.KodeBarang.HeaderText = "Kode Barang"
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.ReadOnly = True
        Me.KodeBarang.Visible = False
        '
        'CmdAdd
        '
        Me.CmdAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdAdd.Location = New System.Drawing.Point(15, 295)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(75, 23)
        Me.CmdAdd.TabIndex = 6
        Me.CmdAdd.Text = "ADD"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'CmdEdit
        '
        Me.CmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdEdit.Location = New System.Drawing.Point(96, 295)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.Size = New System.Drawing.Size(75, 23)
        Me.CmdEdit.TabIndex = 7
        Me.CmdEdit.Text = "EDIT"
        Me.CmdEdit.UseVisualStyleBackColor = True
        '
        'CmdDel
        '
        Me.CmdDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdDel.Location = New System.Drawing.Point(177, 295)
        Me.CmdDel.Name = "CmdDel"
        Me.CmdDel.Size = New System.Drawing.Size(75, 23)
        Me.CmdDel.TabIndex = 8
        Me.CmdDel.Text = "DELETE"
        Me.CmdDel.UseVisualStyleBackColor = True
        '
        'CmdPrint
        '
        Me.CmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdPrint.Location = New System.Drawing.Point(258, 295)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(75, 23)
        Me.CmdPrint.TabIndex = 9
        Me.CmdPrint.Text = "PRINT"
        Me.CmdPrint.UseVisualStyleBackColor = True
        '
        'CmdSearch
        '
        Me.CmdSearch.Location = New System.Drawing.Point(540, 7)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.CmdSearch.TabIndex = 10
        Me.CmdSearch.Text = "Search"
        Me.CmdSearch.UseVisualStyleBackColor = True
        '
        'frmDOBrowse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 329)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.CmdDel)
        Me.Controls.Add(Me.CmdEdit)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.ViewD)
        Me.Controls.Add(Me.ViewH)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDOBrowse"
        Me.Text = "frmDOBrowse"
        CType(Me.ViewH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private WithEvents ViewH As Enerzie.EPSGridControls.EPSDataGridView
    Private WithEvents ViewD As Enerzie.EPSGridControls.EPSDataGridView
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdDel As System.Windows.Forms.Button
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents RowID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TglSO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaCust As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlamatKirim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeSales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaSales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nPrint As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RowIDD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaItem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyOrder As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QtyDO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HrgSatuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodeBarang As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
