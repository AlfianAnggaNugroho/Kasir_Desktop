<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Me.ALFIAN_BTNEDIT = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNHAPUS = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNEXIT = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNADD = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ALFIAN_CMBKODEBRG = New System.Windows.Forms.ComboBox()
        Me.AlfianbarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet1 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet1()
        Me.ALFIAN_CMBKODESUP = New System.Windows.Forms.ComboBox()
        Me.AlfiansupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet3 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet3()
        Me.ALFIAN_DTTGL = New System.Windows.Forms.DateTimePicker()
        Me.ALFIAN_TXTHARGABELI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTJUMBELI = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTKODETRAN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ALFIAN_CMBCARI = New System.Windows.Forms.ComboBox()
        Me.ALFIAN_TXTCARI = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TBLTRANSAKSI = New System.Windows.Forms.DataGridView()
        Me.AlfiankdbeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiantglbeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiankdsupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiankdbrgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianjumbeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianhrgbeliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiantransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet5 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet5()
        Me.Alfian_transaksiTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet5TableAdapters.alfian_transaksiTableAdapter()
        Me.Alfian_supplierTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet3TableAdapters.alfian_supplierTableAdapter()
        Me.Alfian_barangTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet1TableAdapters.alfian_barangTableAdapter()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AlfianbarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlfiansupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALFIAN_TBLTRANSAKSI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlfiantransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ALFIAN_BTNEDIT
        '
        Me.ALFIAN_BTNEDIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEDIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ALFIAN_BTNEDIT.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNEDIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ALFIAN_BTNEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNEDIT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNEDIT.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNEDIT.Location = New System.Drawing.Point(182, 212)
        Me.ALFIAN_BTNEDIT.Name = "ALFIAN_BTNEDIT"
        Me.ALFIAN_BTNEDIT.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNEDIT.TabIndex = 53
        Me.ALFIAN_BTNEDIT.Text = "Edit"
        Me.ALFIAN_BTNEDIT.UseVisualStyleBackColor = False
        '
        'ALFIAN_BTNHAPUS
        '
        Me.ALFIAN_BTNHAPUS.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNHAPUS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ALFIAN_BTNHAPUS.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNHAPUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ALFIAN_BTNHAPUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNHAPUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNHAPUS.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNHAPUS.Location = New System.Drawing.Point(101, 212)
        Me.ALFIAN_BTNHAPUS.Name = "ALFIAN_BTNHAPUS"
        Me.ALFIAN_BTNHAPUS.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNHAPUS.TabIndex = 54
        Me.ALFIAN_BTNHAPUS.Text = "Delete"
        Me.ALFIAN_BTNHAPUS.UseVisualStyleBackColor = False
        '
        'ALFIAN_BTNEXIT
        '
        Me.ALFIAN_BTNEXIT.BackColor = System.Drawing.Color.White
        Me.ALFIAN_BTNEXIT.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNEXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNEXIT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNEXIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEXIT.Location = New System.Drawing.Point(20, 212)
        Me.ALFIAN_BTNEXIT.Name = "ALFIAN_BTNEXIT"
        Me.ALFIAN_BTNEXIT.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNEXIT.TabIndex = 52
        Me.ALFIAN_BTNEXIT.Text = "Logout"
        Me.ALFIAN_BTNEXIT.UseVisualStyleBackColor = False
        '
        'ALFIAN_BTNADD
        '
        Me.ALFIAN_BTNADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNADD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ALFIAN_BTNADD.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ALFIAN_BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNADD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNADD.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNADD.Location = New System.Drawing.Point(263, 212)
        Me.ALFIAN_BTNADD.Name = "ALFIAN_BTNADD"
        Me.ALFIAN_BTNADD.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNADD.TabIndex = 51
        Me.ALFIAN_BTNADD.Text = "Add Data"
        Me.ALFIAN_BTNADD.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_CMBKODEBRG)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_CMBKODESUP)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_DTTGL)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTHARGABELI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTJUMBELI)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTKODETRAN)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(20, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 214)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA TRANSAKSI"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(562, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 17)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Rp"
        '
        'ALFIAN_CMBKODEBRG
        '
        Me.ALFIAN_CMBKODEBRG.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBKODEBRG.DataSource = Me.AlfianbarangBindingSource
        Me.ALFIAN_CMBKODEBRG.DisplayMember = "alfian_kd_brg"
        Me.ALFIAN_CMBKODEBRG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ALFIAN_CMBKODEBRG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ALFIAN_CMBKODEBRG.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBKODEBRG.FormattingEnabled = True
        Me.ALFIAN_CMBKODEBRG.Location = New System.Drawing.Point(590, 38)
        Me.ALFIAN_CMBKODEBRG.Name = "ALFIAN_CMBKODEBRG"
        Me.ALFIAN_CMBKODEBRG.Size = New System.Drawing.Size(173, 23)
        Me.ALFIAN_CMBKODEBRG.TabIndex = 48
        Me.ALFIAN_CMBKODEBRG.ValueMember = "alfian_kd_brg"
        '
        'AlfianbarangBindingSource
        '
        Me.AlfianbarangBindingSource.DataMember = "alfian_barang"
        Me.AlfianbarangBindingSource.DataSource = Me.Db_toko_pbd_if21dxDataSet1
        '
        'Db_toko_pbd_if21dxDataSet1
        '
        Me.Db_toko_pbd_if21dxDataSet1.DataSetName = "db_toko_pbd_if21dxDataSet1"
        Me.Db_toko_pbd_if21dxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALFIAN_CMBKODESUP
        '
        Me.ALFIAN_CMBKODESUP.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBKODESUP.DataSource = Me.AlfiansupplierBindingSource
        Me.ALFIAN_CMBKODESUP.DisplayMember = "alfian_kd_sup"
        Me.ALFIAN_CMBKODESUP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ALFIAN_CMBKODESUP.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ALFIAN_CMBKODESUP.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBKODESUP.FormattingEnabled = True
        Me.ALFIAN_CMBKODESUP.Location = New System.Drawing.Point(150, 172)
        Me.ALFIAN_CMBKODESUP.Name = "ALFIAN_CMBKODESUP"
        Me.ALFIAN_CMBKODESUP.Size = New System.Drawing.Size(173, 23)
        Me.ALFIAN_CMBKODESUP.TabIndex = 47
        Me.ALFIAN_CMBKODESUP.ValueMember = "alfian_kd_sup"
        '
        'AlfiansupplierBindingSource
        '
        Me.AlfiansupplierBindingSource.DataMember = "alfian_supplier"
        Me.AlfiansupplierBindingSource.DataSource = Me.Db_toko_pbd_if21dxDataSet3
        '
        'Db_toko_pbd_if21dxDataSet3
        '
        Me.Db_toko_pbd_if21dxDataSet3.DataSetName = "db_toko_pbd_if21dxDataSet3"
        Me.Db_toko_pbd_if21dxDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALFIAN_DTTGL
        '
        Me.ALFIAN_DTTGL.CalendarMonthBackground = System.Drawing.Color.AliceBlue
        Me.ALFIAN_DTTGL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_DTTGL.CustomFormat = "yyyy/MM/dd"
        Me.ALFIAN_DTTGL.Location = New System.Drawing.Point(150, 103)
        Me.ALFIAN_DTTGL.Name = "ALFIAN_DTTGL"
        Me.ALFIAN_DTTGL.Size = New System.Drawing.Size(211, 24)
        Me.ALFIAN_DTTGL.TabIndex = 24
        Me.ALFIAN_DTTGL.Value = New Date(2022, 11, 18, 0, 0, 0, 0)
        '
        'ALFIAN_TXTHARGABELI
        '
        Me.ALFIAN_TXTHARGABELI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTHARGABELI.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTHARGABELI.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTHARGABELI.Location = New System.Drawing.Point(590, 165)
        Me.ALFIAN_TXTHARGABELI.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTHARGABELI.Multiline = True
        Me.ALFIAN_TXTHARGABELI.Name = "ALFIAN_TXTHARGABELI"
        Me.ALFIAN_TXTHARGABELI.Size = New System.Drawing.Size(173, 30)
        Me.ALFIAN_TXTHARGABELI.TabIndex = 17
        Me.ALFIAN_TXTHARGABELI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(484, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Harga Beli"
        '
        'ALFIAN_TXTJUMBELI
        '
        Me.ALFIAN_TXTJUMBELI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTJUMBELI.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTJUMBELI.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTJUMBELI.Location = New System.Drawing.Point(590, 97)
        Me.ALFIAN_TXTJUMBELI.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTJUMBELI.Multiline = True
        Me.ALFIAN_TXTJUMBELI.Name = "ALFIAN_TXTJUMBELI"
        Me.ALFIAN_TXTJUMBELI.Size = New System.Drawing.Size(173, 30)
        Me.ALFIAN_TXTJUMBELI.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(484, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Jumlah Beli"
        '
        'ALFIAN_TXTKODETRAN
        '
        Me.ALFIAN_TXTKODETRAN.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTKODETRAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ALFIAN_TXTKODETRAN.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTKODETRAN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_TXTKODETRAN.Location = New System.Drawing.Point(150, 31)
        Me.ALFIAN_TXTKODETRAN.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTKODETRAN.Name = "ALFIAN_TXTKODETRAN"
        Me.ALFIAN_TXTKODETRAN.Size = New System.Drawing.Size(211, 26)
        Me.ALFIAN_TXTKODETRAN.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(484, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Kode Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Kode Supplier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tanggal Pembelian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kode Pembelian"
        '
        'ALFIAN_CMBCARI
        '
        Me.ALFIAN_CMBCARI.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBCARI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ALFIAN_CMBCARI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ALFIAN_CMBCARI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_CMBCARI.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBCARI.FormattingEnabled = True
        Me.ALFIAN_CMBCARI.Items.AddRange(New Object() {"Kode Transaksi", "Tanggal Beli"})
        Me.ALFIAN_CMBCARI.Location = New System.Drawing.Point(703, 212)
        Me.ALFIAN_CMBCARI.Name = "ALFIAN_CMBCARI"
        Me.ALFIAN_CMBCARI.Size = New System.Drawing.Size(101, 21)
        Me.ALFIAN_CMBCARI.TabIndex = 49
        '
        'ALFIAN_TXTCARI
        '
        Me.ALFIAN_TXTCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ALFIAN_TXTCARI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTCARI.Location = New System.Drawing.Point(503, 212)
        Me.ALFIAN_TXTCARI.Name = "ALFIAN_TXTCARI"
        Me.ALFIAN_TXTCARI.Size = New System.Drawing.Size(194, 26)
        Me.ALFIAN_TXTCARI.TabIndex = 48
        '
        'ALFIAN_TBLTRANSAKSI
        '
        Me.ALFIAN_TBLTRANSAKSI.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.ALFIAN_TBLTRANSAKSI.AllowUserToResizeColumns = False
        Me.ALFIAN_TBLTRANSAKSI.AllowUserToResizeRows = False
        Me.ALFIAN_TBLTRANSAKSI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALFIAN_TBLTRANSAKSI.AutoGenerateColumns = False
        Me.ALFIAN_TBLTRANSAKSI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ALFIAN_TBLTRANSAKSI.BackgroundColor = System.Drawing.Color.White
        Me.ALFIAN_TBLTRANSAKSI.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ALFIAN_TBLTRANSAKSI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ALFIAN_TBLTRANSAKSI.ColumnHeadersHeight = 26
        Me.ALFIAN_TBLTRANSAKSI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ALFIAN_TBLTRANSAKSI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlfiankdbeliDataGridViewTextBoxColumn, Me.AlfiantglbeliDataGridViewTextBoxColumn, Me.AlfiankdsupDataGridViewTextBoxColumn, Me.AlfiankdbrgDataGridViewTextBoxColumn, Me.AlfianjumbeliDataGridViewTextBoxColumn, Me.AlfianhrgbeliDataGridViewTextBoxColumn})
        Me.ALFIAN_TBLTRANSAKSI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_TBLTRANSAKSI.DataSource = Me.AlfiantransaksiBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ALFIAN_TBLTRANSAKSI.DefaultCellStyle = DataGridViewCellStyle2
        Me.ALFIAN_TBLTRANSAKSI.Location = New System.Drawing.Point(20, 20)
        Me.ALFIAN_TBLTRANSAKSI.Name = "ALFIAN_TBLTRANSAKSI"
        Me.ALFIAN_TBLTRANSAKSI.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ALFIAN_TBLTRANSAKSI.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ALFIAN_TBLTRANSAKSI.RowHeadersVisible = False
        Me.ALFIAN_TBLTRANSAKSI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ALFIAN_TBLTRANSAKSI.Size = New System.Drawing.Size(784, 176)
        Me.ALFIAN_TBLTRANSAKSI.TabIndex = 47
        '
        'AlfiankdbeliDataGridViewTextBoxColumn
        '
        Me.AlfiankdbeliDataGridViewTextBoxColumn.DataPropertyName = "alfian_kd_beli"
        Me.AlfiankdbeliDataGridViewTextBoxColumn.HeaderText = "Kode Beli"
        Me.AlfiankdbeliDataGridViewTextBoxColumn.Name = "AlfiankdbeliDataGridViewTextBoxColumn"
        '
        'AlfiantglbeliDataGridViewTextBoxColumn
        '
        Me.AlfiantglbeliDataGridViewTextBoxColumn.DataPropertyName = "alfian_tgl_beli"
        Me.AlfiantglbeliDataGridViewTextBoxColumn.HeaderText = "Tanggal Beli"
        Me.AlfiantglbeliDataGridViewTextBoxColumn.Name = "AlfiantglbeliDataGridViewTextBoxColumn"
        '
        'AlfiankdsupDataGridViewTextBoxColumn
        '
        Me.AlfiankdsupDataGridViewTextBoxColumn.DataPropertyName = "alfian_kd_sup"
        Me.AlfiankdsupDataGridViewTextBoxColumn.HeaderText = "Kode Supplier"
        Me.AlfiankdsupDataGridViewTextBoxColumn.Name = "AlfiankdsupDataGridViewTextBoxColumn"
        '
        'AlfiankdbrgDataGridViewTextBoxColumn
        '
        Me.AlfiankdbrgDataGridViewTextBoxColumn.DataPropertyName = "alfian_kd_brg"
        Me.AlfiankdbrgDataGridViewTextBoxColumn.HeaderText = "Kode Barang"
        Me.AlfiankdbrgDataGridViewTextBoxColumn.Name = "AlfiankdbrgDataGridViewTextBoxColumn"
        '
        'AlfianjumbeliDataGridViewTextBoxColumn
        '
        Me.AlfianjumbeliDataGridViewTextBoxColumn.DataPropertyName = "alfian_jum_beli"
        Me.AlfianjumbeliDataGridViewTextBoxColumn.HeaderText = "Jumlah Beli"
        Me.AlfianjumbeliDataGridViewTextBoxColumn.Name = "AlfianjumbeliDataGridViewTextBoxColumn"
        '
        'AlfianhrgbeliDataGridViewTextBoxColumn
        '
        Me.AlfianhrgbeliDataGridViewTextBoxColumn.DataPropertyName = "alfian_hrg_beli"
        Me.AlfianhrgbeliDataGridViewTextBoxColumn.HeaderText = "Harga Beli"
        Me.AlfianhrgbeliDataGridViewTextBoxColumn.Name = "AlfianhrgbeliDataGridViewTextBoxColumn"
        '
        'AlfiantransaksiBindingSource
        '
        Me.AlfiantransaksiBindingSource.DataMember = "alfian_transaksi"
        Me.AlfiantransaksiBindingSource.DataSource = Me.Db_toko_pbd_if21dxDataSet5
        '
        'Db_toko_pbd_if21dxDataSet5
        '
        Me.Db_toko_pbd_if21dxDataSet5.DataSetName = "db_toko_pbd_if21dxDataSet5"
        Me.Db_toko_pbd_if21dxDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Alfian_transaksiTableAdapter
        '
        Me.Alfian_transaksiTableAdapter.ClearBeforeFill = True
        '
        'Alfian_supplierTableAdapter
        '
        Me.Alfian_supplierTableAdapter.ClearBeforeFill = True
        '
        'Alfian_barangTableAdapter
        '
        Me.Alfian_barangTableAdapter.ClearBeforeFill = True
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
        Me.IconPictureBox1.Location = New System.Drawing.Point(472, 212)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.IconPictureBox1.TabIndex = 55
        Me.IconPictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(0, 522)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(824, 1)
        Me.Label1.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(823, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 522)
        Me.Label8.TabIndex = 81
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 523)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.ALFIAN_BTNEDIT)
        Me.Controls.Add(Me.ALFIAN_BTNHAPUS)
        Me.Controls.Add(Me.ALFIAN_BTNEXIT)
        Me.Controls.Add(Me.ALFIAN_BTNADD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ALFIAN_CMBCARI)
        Me.Controls.Add(Me.ALFIAN_TXTCARI)
        Me.Controls.Add(Me.ALFIAN_TBLTRANSAKSI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormTransaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AlfianbarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlfiansupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALFIAN_TBLTRANSAKSI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlfiantransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ALFIAN_BTNEDIT As Button
    Friend WithEvents ALFIAN_BTNHAPUS As Button
    Friend WithEvents ALFIAN_BTNEXIT As Button
    Friend WithEvents ALFIAN_BTNADD As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ALFIAN_CMBKODEBRG As ComboBox
    Friend WithEvents ALFIAN_CMBKODESUP As ComboBox
    Friend WithEvents ALFIAN_DTTGL As DateTimePicker
    Friend WithEvents ALFIAN_TXTHARGABELI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ALFIAN_TXTJUMBELI As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ALFIAN_TXTKODETRAN As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ALFIAN_CMBCARI As ComboBox
    Friend WithEvents ALFIAN_TXTCARI As TextBox
    Friend WithEvents ALFIAN_TBLTRANSAKSI As DataGridView
    Friend WithEvents Db_toko_pbd_if21dxDataSet5 As db_toko_pbd_if21dxDataSet5
    Friend WithEvents AlfiantransaksiBindingSource As BindingSource
    Friend WithEvents Alfian_transaksiTableAdapter As db_toko_pbd_if21dxDataSet5TableAdapters.alfian_transaksiTableAdapter
    Friend WithEvents AlfiankdbeliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiantglbeliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiankdsupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiankdbrgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianjumbeliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianhrgbeliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Db_toko_pbd_if21dxDataSet3 As db_toko_pbd_if21dxDataSet3
    Friend WithEvents AlfiansupplierBindingSource As BindingSource
    Friend WithEvents Alfian_supplierTableAdapter As db_toko_pbd_if21dxDataSet3TableAdapters.alfian_supplierTableAdapter
    Friend WithEvents Db_toko_pbd_if21dxDataSet1 As db_toko_pbd_if21dxDataSet1
    Friend WithEvents AlfianbarangBindingSource As BindingSource
    Friend WithEvents Alfian_barangTableAdapter As db_toko_pbd_if21dxDataSet1TableAdapters.alfian_barangTableAdapter
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
End Class
