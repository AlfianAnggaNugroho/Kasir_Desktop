<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.AlfianbarangBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet1 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet1()
        Me.AlfianbarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet()
        Me.Alfian_barangTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSetTableAdapters.alfian_barangTableAdapter()
        Me.Alfian_barangTableAdapter1 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet1TableAdapters.alfian_barangTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ALFIAN_BTNADD = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNEDIT = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNEXIT = New System.Windows.Forms.Button()
        Me.ALFIAN_TBLBRG = New System.Windows.Forms.DataGridView()
        Me.AlfiansisaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianrusakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianjumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianhrgjualDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alfian_diskon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianmmbrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiankdbrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTNAMA = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTDISKON = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTBARANG = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTHARGA = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTRUSAK = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTSISA = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTJUM = New System.Windows.Forms.TextBox()
        Me.ALFIAN_BTNHAPUS = New System.Windows.Forms.Button()
        Me.ALFIAN_CMBCARI = New System.Windows.Forms.ComboBox()
        Me.ALFIAN_TXTCARI = New System.Windows.Forms.TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.AlfianbarangBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlfianbarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALFIAN_TBLBRG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AlfianbarangBindingSource1
        '
        Me.AlfianbarangBindingSource1.DataMember = "alfian_barang"
        Me.AlfianbarangBindingSource1.DataSource = Me.Db_toko_pbd_if21dxDataSet1
        '
        'Db_toko_pbd_if21dxDataSet1
        '
        Me.Db_toko_pbd_if21dxDataSet1.DataSetName = "db_toko_pbd_if21dxDataSet1"
        Me.Db_toko_pbd_if21dxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlfianbarangBindingSource
        '
        Me.AlfianbarangBindingSource.DataMember = "alfian_barang"
        Me.AlfianbarangBindingSource.DataSource = Me.Db_toko_pbd_if21dxDataSet
        '
        'Db_toko_pbd_if21dxDataSet
        '
        Me.Db_toko_pbd_if21dxDataSet.DataSetName = "db_toko_pbd_if21dxDataSet"
        Me.Db_toko_pbd_if21dxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Alfian_barangTableAdapter
        '
        Me.Alfian_barangTableAdapter.ClearBeforeFill = True
        '
        'Alfian_barangTableAdapter1
        '
        Me.Alfian_barangTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(823, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1, 523)
        Me.Label2.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 522)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(823, 1)
        Me.Label1.TabIndex = 81
        '
        'ALFIAN_BTNADD
        '
        Me.ALFIAN_BTNADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNADD.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ALFIAN_BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNADD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNADD.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNADD.Location = New System.Drawing.Point(260, 204)
        Me.ALFIAN_BTNADD.Name = "ALFIAN_BTNADD"
        Me.ALFIAN_BTNADD.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNADD.TabIndex = 35
        Me.ALFIAN_BTNADD.Text = "Add Data"
        Me.ALFIAN_BTNADD.UseVisualStyleBackColor = False
        '
        'ALFIAN_BTNEDIT
        '
        Me.ALFIAN_BTNEDIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEDIT.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNEDIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ALFIAN_BTNEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNEDIT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNEDIT.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNEDIT.Location = New System.Drawing.Point(179, 204)
        Me.ALFIAN_BTNEDIT.Name = "ALFIAN_BTNEDIT"
        Me.ALFIAN_BTNEDIT.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNEDIT.TabIndex = 37
        Me.ALFIAN_BTNEDIT.Text = "Edit"
        Me.ALFIAN_BTNEDIT.UseVisualStyleBackColor = False
        '
        'ALFIAN_BTNEXIT
        '
        Me.ALFIAN_BTNEXIT.BackColor = System.Drawing.Color.White
        Me.ALFIAN_BTNEXIT.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNEXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNEXIT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNEXIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEXIT.Location = New System.Drawing.Point(17, 204)
        Me.ALFIAN_BTNEXIT.Name = "ALFIAN_BTNEXIT"
        Me.ALFIAN_BTNEXIT.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNEXIT.TabIndex = 36
        Me.ALFIAN_BTNEXIT.Text = "Back"
        Me.ALFIAN_BTNEXIT.UseVisualStyleBackColor = False
        '
        'ALFIAN_TBLBRG
        '
        Me.ALFIAN_TBLBRG.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.ALFIAN_TBLBRG.AllowUserToResizeColumns = False
        Me.ALFIAN_TBLBRG.AllowUserToResizeRows = False
        Me.ALFIAN_TBLBRG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALFIAN_TBLBRG.AutoGenerateColumns = False
        Me.ALFIAN_TBLBRG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ALFIAN_TBLBRG.BackgroundColor = System.Drawing.Color.White
        Me.ALFIAN_TBLBRG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.ALFIAN_TBLBRG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ALFIAN_TBLBRG.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ALFIAN_TBLBRG.ColumnHeadersHeight = 25
        Me.ALFIAN_TBLBRG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ALFIAN_TBLBRG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlfiankdbrgDataGridViewTextBoxColumn, Me.AlfianmmbrgDataGridViewTextBoxColumn, Me.alfian_diskon, Me.AlfianhrgjualDataGridViewTextBoxColumn, Me.AlfianjumlahDataGridViewTextBoxColumn, Me.AlfianrusakDataGridViewTextBoxColumn, Me.AlfiansisaDataGridViewTextBoxColumn})
        Me.ALFIAN_TBLBRG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_TBLBRG.DataSource = Me.AlfianbarangBindingSource1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ALFIAN_TBLBRG.DefaultCellStyle = DataGridViewCellStyle2
        Me.ALFIAN_TBLBRG.Location = New System.Drawing.Point(15, 12)
        Me.ALFIAN_TBLBRG.Name = "ALFIAN_TBLBRG"
        Me.ALFIAN_TBLBRG.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ALFIAN_TBLBRG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ALFIAN_TBLBRG.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ALFIAN_TBLBRG.RowHeadersVisible = False
        Me.ALFIAN_TBLBRG.RowHeadersWidth = 30
        Me.ALFIAN_TBLBRG.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ALFIAN_TBLBRG.Size = New System.Drawing.Size(798, 176)
        Me.ALFIAN_TBLBRG.TabIndex = 34
        '
        'AlfiansisaDataGridViewTextBoxColumn
        '
        Me.AlfiansisaDataGridViewTextBoxColumn.DataPropertyName = "alfian_sisa"
        Me.AlfiansisaDataGridViewTextBoxColumn.HeaderText = "Sisa Barang"
        Me.AlfiansisaDataGridViewTextBoxColumn.Name = "AlfiansisaDataGridViewTextBoxColumn"
        '
        'AlfianrusakDataGridViewTextBoxColumn
        '
        Me.AlfianrusakDataGridViewTextBoxColumn.DataPropertyName = "alfian_rusak"
        Me.AlfianrusakDataGridViewTextBoxColumn.HeaderText = "Rusak"
        Me.AlfianrusakDataGridViewTextBoxColumn.Name = "AlfianrusakDataGridViewTextBoxColumn"
        '
        'AlfianjumlahDataGridViewTextBoxColumn
        '
        Me.AlfianjumlahDataGridViewTextBoxColumn.DataPropertyName = "alfian_jumlah"
        Me.AlfianjumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah"
        Me.AlfianjumlahDataGridViewTextBoxColumn.Name = "AlfianjumlahDataGridViewTextBoxColumn"
        '
        'AlfianhrgjualDataGridViewTextBoxColumn
        '
        Me.AlfianhrgjualDataGridViewTextBoxColumn.DataPropertyName = "alfian_hrg_jual"
        Me.AlfianhrgjualDataGridViewTextBoxColumn.HeaderText = "Harga"
        Me.AlfianhrgjualDataGridViewTextBoxColumn.Name = "AlfianhrgjualDataGridViewTextBoxColumn"
        '
        'alfian_diskon
        '
        Me.alfian_diskon.DataPropertyName = "alfian_diskon"
        Me.alfian_diskon.HeaderText = "Diskon"
        Me.alfian_diskon.Name = "alfian_diskon"
        '
        'AlfianmmbrgDataGridViewTextBoxColumn
        '
        Me.AlfianmmbrgDataGridViewTextBoxColumn.DataPropertyName = "alfian_mm_brg"
        Me.AlfianmmbrgDataGridViewTextBoxColumn.HeaderText = "Nama Barang"
        Me.AlfianmmbrgDataGridViewTextBoxColumn.Name = "AlfianmmbrgDataGridViewTextBoxColumn"
        '
        'AlfiankdbrgDataGridViewTextBoxColumn
        '
        Me.AlfiankdbrgDataGridViewTextBoxColumn.DataPropertyName = "alfian_kd_brg"
        Me.AlfiankdbrgDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.AlfiankdbrgDataGridViewTextBoxColumn.Name = "AlfiankdbrgDataGridViewTextBoxColumn"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTHARGA)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTBARANG)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTDISKON)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTNAMA)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(15, 274)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(399, 218)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATA BARANG"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kode Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Diskon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Harga Jual"
        '
        'ALFIAN_TXTNAMA
        '
        Me.ALFIAN_TXTNAMA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTNAMA.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTNAMA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTNAMA.Location = New System.Drawing.Point(140, 75)
        Me.ALFIAN_TXTNAMA.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTNAMA.Name = "ALFIAN_TXTNAMA"
        Me.ALFIAN_TXTNAMA.Size = New System.Drawing.Size(231, 30)
        Me.ALFIAN_TXTNAMA.TabIndex = 10
        '
        'ALFIAN_TXTDISKON
        '
        Me.ALFIAN_TXTDISKON.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTDISKON.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTDISKON.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTDISKON.Location = New System.Drawing.Point(140, 122)
        Me.ALFIAN_TXTDISKON.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTDISKON.Name = "ALFIAN_TXTDISKON"
        Me.ALFIAN_TXTDISKON.Size = New System.Drawing.Size(114, 30)
        Me.ALFIAN_TXTDISKON.TabIndex = 11
        Me.ALFIAN_TXTDISKON.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ALFIAN_TXTBARANG
        '
        Me.ALFIAN_TXTBARANG.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTBARANG.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTBARANG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ALFIAN_TXTBARANG.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTBARANG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_TXTBARANG.Location = New System.Drawing.Point(140, 31)
        Me.ALFIAN_TXTBARANG.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTBARANG.Name = "ALFIAN_TXTBARANG"
        Me.ALFIAN_TXTBARANG.Size = New System.Drawing.Size(231, 30)
        Me.ALFIAN_TXTBARANG.TabIndex = 12
        '
        'ALFIAN_TXTHARGA
        '
        Me.ALFIAN_TXTHARGA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTHARGA.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTHARGA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTHARGA.Location = New System.Drawing.Point(140, 167)
        Me.ALFIAN_TXTHARGA.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTHARGA.Name = "ALFIAN_TXTHARGA"
        Me.ALFIAN_TXTHARGA.Size = New System.Drawing.Size(231, 30)
        Me.ALFIAN_TXTHARGA.TabIndex = 13
        Me.ALFIAN_TXTHARGA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(114, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Rp"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(117, 133)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(19, 17)
        Me.Label19.TabIndex = 16
        Me.Label19.Text = "%"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.ALFIAN_TXTJUM)
        Me.GroupBox2.Controls.Add(Me.ALFIAN_TXTSISA)
        Me.GroupBox2.Controls.Add(Me.ALFIAN_TXTRUSAK)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(468, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(331, 217)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "STOCK BARANG"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(20, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Jumlah Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Rusak"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(20, 179)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Sisa Barang"
        '
        'ALFIAN_TXTRUSAK
        '
        Me.ALFIAN_TXTRUSAK.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTRUSAK.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTRUSAK.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTRUSAK.Location = New System.Drawing.Point(130, 100)
        Me.ALFIAN_TXTRUSAK.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTRUSAK.Name = "ALFIAN_TXTRUSAK"
        Me.ALFIAN_TXTRUSAK.Size = New System.Drawing.Size(179, 30)
        Me.ALFIAN_TXTRUSAK.TabIndex = 19
        '
        'ALFIAN_TXTSISA
        '
        Me.ALFIAN_TXTSISA.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTSISA.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTSISA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTSISA.Location = New System.Drawing.Point(130, 167)
        Me.ALFIAN_TXTSISA.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTSISA.Name = "ALFIAN_TXTSISA"
        Me.ALFIAN_TXTSISA.Size = New System.Drawing.Size(179, 30)
        Me.ALFIAN_TXTSISA.TabIndex = 20
        '
        'ALFIAN_TXTJUM
        '
        Me.ALFIAN_TXTJUM.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTJUM.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTJUM.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTJUM.Location = New System.Drawing.Point(130, 31)
        Me.ALFIAN_TXTJUM.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTJUM.Name = "ALFIAN_TXTJUM"
        Me.ALFIAN_TXTJUM.Size = New System.Drawing.Size(179, 30)
        Me.ALFIAN_TXTJUM.TabIndex = 21
        '
        'ALFIAN_BTNHAPUS
        '
        Me.ALFIAN_BTNHAPUS.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNHAPUS.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNHAPUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ALFIAN_BTNHAPUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNHAPUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNHAPUS.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNHAPUS.Location = New System.Drawing.Point(98, 204)
        Me.ALFIAN_BTNHAPUS.Name = "ALFIAN_BTNHAPUS"
        Me.ALFIAN_BTNHAPUS.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNHAPUS.TabIndex = 38
        Me.ALFIAN_BTNHAPUS.Text = "Delete"
        Me.ALFIAN_BTNHAPUS.UseVisualStyleBackColor = False
        '
        'ALFIAN_CMBCARI
        '
        Me.ALFIAN_CMBCARI.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBCARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_CMBCARI.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBCARI.FormattingEnabled = True
        Me.ALFIAN_CMBCARI.Items.AddRange(New Object() {"Kode Barang", "Nama Barang"})
        Me.ALFIAN_CMBCARI.Location = New System.Drawing.Point(698, 204)
        Me.ALFIAN_CMBCARI.Name = "ALFIAN_CMBCARI"
        Me.ALFIAN_CMBCARI.Size = New System.Drawing.Size(101, 21)
        Me.ALFIAN_CMBCARI.TabIndex = 43
        '
        'ALFIAN_TXTCARI
        '
        Me.ALFIAN_TXTCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ALFIAN_TXTCARI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ALFIAN_TXTCARI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTCARI.Location = New System.Drawing.Point(515, 204)
        Me.ALFIAN_TXTCARI.Name = "ALFIAN_TXTCARI"
        Me.ALFIAN_TXTCARI.Size = New System.Drawing.Size(177, 26)
        Me.ALFIAN_TXTCARI.TabIndex = 42
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 25
        Me.IconPictureBox1.Location = New System.Drawing.Point(485, 204)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.IconPictureBox1.TabIndex = 44
        Me.IconPictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.IconPictureBox1)
        Me.Panel1.Controls.Add(Me.ALFIAN_TXTCARI)
        Me.Panel1.Controls.Add(Me.ALFIAN_CMBCARI)
        Me.Panel1.Controls.Add(Me.ALFIAN_BTNHAPUS)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.ALFIAN_TBLBRG)
        Me.Panel1.Controls.Add(Me.ALFIAN_BTNEXIT)
        Me.Panel1.Controls.Add(Me.ALFIAN_BTNEDIT)
        Me.Panel1.Controls.Add(Me.ALFIAN_BTNADD)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 523)
        Me.Panel1.TabIndex = 82
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormBarang"
        CType(Me.AlfianbarangBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlfianbarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALFIAN_TBLBRG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Db_toko_pbd_if21dxDataSet As db_toko_pbd_if21dxDataSet
    Friend WithEvents AlfianbarangBindingSource As BindingSource
    Friend WithEvents Alfian_barangTableAdapter As db_toko_pbd_if21dxDataSetTableAdapters.alfian_barangTableAdapter
    Friend WithEvents Db_toko_pbd_if21dxDataSet1 As db_toko_pbd_if21dxDataSet1
    Friend WithEvents AlfianbarangBindingSource1 As BindingSource
    Friend WithEvents Alfian_barangTableAdapter1 As db_toko_pbd_if21dxDataSet1TableAdapters.alfian_barangTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ALFIAN_BTNADD As Button
    Friend WithEvents ALFIAN_BTNEDIT As Button
    Friend WithEvents ALFIAN_BTNEXIT As Button
    Friend WithEvents ALFIAN_TBLBRG As DataGridView
    Friend WithEvents AlfiankdbrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianmmbrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents alfian_diskon As DataGridViewTextBoxColumn
    Friend WithEvents AlfianhrgjualDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianjumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianrusakDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiansisaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ALFIAN_TXTHARGA As TextBox
    Friend WithEvents ALFIAN_TXTBARANG As TextBox
    Friend WithEvents ALFIAN_TXTDISKON As TextBox
    Friend WithEvents ALFIAN_TXTNAMA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ALFIAN_TXTJUM As TextBox
    Friend WithEvents ALFIAN_TXTSISA As TextBox
    Friend WithEvents ALFIAN_TXTRUSAK As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents ALFIAN_BTNHAPUS As Button
    Friend WithEvents ALFIAN_CMBCARI As ComboBox
    Friend WithEvents ALFIAN_TXTCARI As TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
End Class
