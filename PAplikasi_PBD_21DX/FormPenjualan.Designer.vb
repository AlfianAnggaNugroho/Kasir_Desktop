<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPenjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenjualan))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBSTOK = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LBHARGA = New System.Windows.Forms.Label()
        Me.LBNAMABRG = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ALFIAN_CMBKODEBRG = New System.Windows.Forms.ComboBox()
        Me.AlfianbarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet1 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet1()
        Me.ALFIAN_TXTJUM = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ALFIAN_DTTGL = New System.Windows.Forms.DateTimePicker()
        Me.ALFIAN_TXTKODETRAN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBTOTAL = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.BTNRESET = New System.Windows.Forms.Button()
        Me.LBNAMAPEG = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ALFIAN_CMBKODEPEG = New System.Windows.Forms.ComboBox()
        Me.AlfianpegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet2 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet2()
        Me.ALFIAN_BTNTAMBAH = New System.Windows.Forms.Button()
        Me.ALFIAN_TBLTRANSAKSI = New System.Windows.Forms.DataGridView()
        Me.LBITEM = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LBKEMBALI = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTPEM = New System.Windows.Forms.TextBox()
        Me.ALFIAN_BTNSIMPAN = New System.Windows.Forms.Button()
        Me.LBLJAM = New System.Windows.Forms.Label()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.Alfian_barangTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet1TableAdapters.alfian_barangTableAdapter()
        Me.Alfian_pegawaiTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet2TableAdapters.alfian_pegawaiTableAdapter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AlfianbarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlfianpegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALFIAN_TBLTRANSAKSI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBSTOK)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.LBHARGA)
        Me.GroupBox1.Controls.Add(Me.LBNAMABRG)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_CMBKODEBRG)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTJUM)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_DTTGL)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTKODETRAN)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LBTOTAL)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(19, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(786, 164)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA TRANSAKSI"
        '
        'LBSTOK
        '
        Me.LBSTOK.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSTOK.ForeColor = System.Drawing.Color.White
        Me.LBSTOK.Location = New System.Drawing.Point(721, 114)
        Me.LBSTOK.Name = "LBSTOK"
        Me.LBSTOK.Size = New System.Drawing.Size(40, 26)
        Me.LBSTOK.TabIndex = 106
        Me.LBSTOK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(674, 114)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 26)
        Me.Label30.TabIndex = 105
        Me.Label30.Text = "Stock :"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBHARGA
        '
        Me.LBHARGA.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBHARGA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBHARGA.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBHARGA.ForeColor = System.Drawing.Color.Black
        Me.LBHARGA.Location = New System.Drawing.Point(582, 76)
        Me.LBHARGA.Name = "LBHARGA"
        Me.LBHARGA.Size = New System.Drawing.Size(187, 26)
        Me.LBHARGA.TabIndex = 104
        Me.LBHARGA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBNAMABRG
        '
        Me.LBNAMABRG.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBNAMABRG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBNAMABRG.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNAMABRG.ForeColor = System.Drawing.Color.Black
        Me.LBNAMABRG.Location = New System.Drawing.Point(131, 112)
        Me.LBNAMABRG.Name = "LBNAMABRG"
        Me.LBNAMABRG.Size = New System.Drawing.Size(255, 26)
        Me.LBNAMABRG.TabIndex = 103
        Me.LBNAMABRG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(499, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 26)
        Me.Label6.TabIndex = 102
        Me.Label6.Text = "Jumlah Beli"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(498, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 26)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Harga     Rp."
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 26)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Nama Barang"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 26)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Kode Barang"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ALFIAN_CMBKODEBRG
        '
        Me.ALFIAN_CMBKODEBRG.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBKODEBRG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_CMBKODEBRG.DataSource = Me.AlfianbarangBindingSource
        Me.ALFIAN_CMBKODEBRG.DisplayMember = "alfian_kd_brg"
        Me.ALFIAN_CMBKODEBRG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ALFIAN_CMBKODEBRG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ALFIAN_CMBKODEBRG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_CMBKODEBRG.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBKODEBRG.FormattingEnabled = True
        Me.ALFIAN_CMBKODEBRG.Location = New System.Drawing.Point(131, 79)
        Me.ALFIAN_CMBKODEBRG.Name = "ALFIAN_CMBKODEBRG"
        Me.ALFIAN_CMBKODEBRG.Size = New System.Drawing.Size(127, 21)
        Me.ALFIAN_CMBKODEBRG.TabIndex = 99
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
        'ALFIAN_TXTJUM
        '
        Me.ALFIAN_TXTJUM.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTJUM.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTJUM.ForeColor = System.Drawing.Color.Black
        Me.ALFIAN_TXTJUM.Location = New System.Drawing.Point(582, 112)
        Me.ALFIAN_TXTJUM.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTJUM.Name = "ALFIAN_TXTJUM"
        Me.ALFIAN_TXTJUM.Size = New System.Drawing.Size(76, 25)
        Me.ALFIAN_TXTJUM.TabIndex = 98
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(272, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 26)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Tanggal Transaksi"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ALFIAN_DTTGL
        '
        Me.ALFIAN_DTTGL.CalendarMonthBackground = System.Drawing.Color.AliceBlue
        Me.ALFIAN_DTTGL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_DTTGL.CustomFormat = ""
        Me.ALFIAN_DTTGL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ALFIAN_DTTGL.Location = New System.Drawing.Point(392, 30)
        Me.ALFIAN_DTTGL.Name = "ALFIAN_DTTGL"
        Me.ALFIAN_DTTGL.Size = New System.Drawing.Size(107, 22)
        Me.ALFIAN_DTTGL.TabIndex = 25
        Me.ALFIAN_DTTGL.Value = New Date(2022, 11, 18, 0, 0, 0, 0)
        '
        'ALFIAN_TXTKODETRAN
        '
        Me.ALFIAN_TXTKODETRAN.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTKODETRAN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ALFIAN_TXTKODETRAN.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTKODETRAN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_TXTKODETRAN.Location = New System.Drawing.Point(131, 27)
        Me.ALFIAN_TXTKODETRAN.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTKODETRAN.Name = "ALFIAN_TXTKODETRAN"
        Me.ALFIAN_TXTKODETRAN.Size = New System.Drawing.Size(127, 26)
        Me.ALFIAN_TXTKODETRAN.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 26)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kode Transaksi"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBTOTAL
        '
        Me.LBTOTAL.BackColor = System.Drawing.Color.Transparent
        Me.LBTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBTOTAL.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTOTAL.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LBTOTAL.Location = New System.Drawing.Point(618, 18)
        Me.LBTOTAL.Name = "LBTOTAL"
        Me.LBTOTAL.Size = New System.Drawing.Size(160, 49)
        Me.LBTOTAL.TabIndex = 80
        Me.LBTOTAL.Text = "0"
        Me.LBTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(555, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(57, 19)
        Me.Label25.TabIndex = 72
        Me.Label25.Text = "TOTAL"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(581, 38)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(32, 19)
        Me.Label29.TabIndex = 73
        Me.Label29.Text = "Rp."
        '
        'BTNRESET
        '
        Me.BTNRESET.BackColor = System.Drawing.Color.White
        Me.BTNRESET.FlatAppearance.BorderSize = 0
        Me.BTNRESET.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNRESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNRESET.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRESET.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNRESET.Location = New System.Drawing.Point(639, 189)
        Me.BTNRESET.Name = "BTNRESET"
        Me.BTNRESET.Size = New System.Drawing.Size(80, 26)
        Me.BTNRESET.TabIndex = 94
        Me.BTNRESET.Text = "Reset"
        Me.BTNRESET.UseVisualStyleBackColor = False
        '
        'LBNAMAPEG
        '
        Me.LBNAMAPEG.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LBNAMAPEG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBNAMAPEG.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBNAMAPEG.Location = New System.Drawing.Point(404, 188)
        Me.LBNAMAPEG.Name = "LBNAMAPEG"
        Me.LBNAMAPEG.Size = New System.Drawing.Size(184, 26)
        Me.LBNAMAPEG.TabIndex = 93
        Me.LBNAMAPEG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(294, 186)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 26)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Nama Pegawai"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(40, 189)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 26)
        Me.Label22.TabIndex = 91
        Me.Label22.Text = "Kode Pegawai"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ALFIAN_CMBKODEPEG
        '
        Me.ALFIAN_CMBKODEPEG.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBKODEPEG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_CMBKODEPEG.DataSource = Me.AlfianpegawaiBindingSource
        Me.ALFIAN_CMBKODEPEG.DisplayMember = "alfian_kd_peg"
        Me.ALFIAN_CMBKODEPEG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ALFIAN_CMBKODEPEG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ALFIAN_CMBKODEPEG.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_CMBKODEPEG.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBKODEPEG.FormattingEnabled = True
        Me.ALFIAN_CMBKODEPEG.Location = New System.Drawing.Point(150, 191)
        Me.ALFIAN_CMBKODEPEG.Name = "ALFIAN_CMBKODEPEG"
        Me.ALFIAN_CMBKODEPEG.Size = New System.Drawing.Size(127, 21)
        Me.ALFIAN_CMBKODEPEG.TabIndex = 90
        Me.ALFIAN_CMBKODEPEG.ValueMember = "alfian_kd_peg"
        '
        'AlfianpegawaiBindingSource
        '
        Me.AlfianpegawaiBindingSource.DataMember = "alfian_pegawai"
        Me.AlfianpegawaiBindingSource.DataSource = Me.Db_toko_pbd_if21dxDataSet2
        '
        'Db_toko_pbd_if21dxDataSet2
        '
        Me.Db_toko_pbd_if21dxDataSet2.DataSetName = "db_toko_pbd_if21dxDataSet2"
        Me.Db_toko_pbd_if21dxDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALFIAN_BTNTAMBAH
        '
        Me.ALFIAN_BTNTAMBAH.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNTAMBAH.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ALFIAN_BTNTAMBAH.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNTAMBAH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ALFIAN_BTNTAMBAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNTAMBAH.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNTAMBAH.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNTAMBAH.Location = New System.Drawing.Point(725, 189)
        Me.ALFIAN_BTNTAMBAH.Name = "ALFIAN_BTNTAMBAH"
        Me.ALFIAN_BTNTAMBAH.Size = New System.Drawing.Size(80, 26)
        Me.ALFIAN_BTNTAMBAH.TabIndex = 89
        Me.ALFIAN_BTNTAMBAH.Text = "Tambah"
        Me.ALFIAN_BTNTAMBAH.UseVisualStyleBackColor = False
        '
        'ALFIAN_TBLTRANSAKSI
        '
        Me.ALFIAN_TBLTRANSAKSI.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.ALFIAN_TBLTRANSAKSI.AllowUserToResizeColumns = False
        Me.ALFIAN_TBLTRANSAKSI.AllowUserToResizeRows = False
        Me.ALFIAN_TBLTRANSAKSI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALFIAN_TBLTRANSAKSI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ALFIAN_TBLTRANSAKSI.BackgroundColor = System.Drawing.Color.White
        Me.ALFIAN_TBLTRANSAKSI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ALFIAN_TBLTRANSAKSI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
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
        Me.ALFIAN_TBLTRANSAKSI.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ALFIAN_TBLTRANSAKSI.DefaultCellStyle = DataGridViewCellStyle2
        Me.ALFIAN_TBLTRANSAKSI.GridColor = System.Drawing.Color.White
        Me.ALFIAN_TBLTRANSAKSI.Location = New System.Drawing.Point(19, 232)
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
        Me.ALFIAN_TBLTRANSAKSI.Size = New System.Drawing.Size(786, 183)
        Me.ALFIAN_TBLTRANSAKSI.TabIndex = 95
        '
        'LBITEM
        '
        Me.LBITEM.BackColor = System.Drawing.Color.Transparent
        Me.LBITEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBITEM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBITEM.ForeColor = System.Drawing.Color.White
        Me.LBITEM.Location = New System.Drawing.Point(773, 469)
        Me.LBITEM.Name = "LBITEM"
        Me.LBITEM.Size = New System.Drawing.Size(28, 26)
        Me.LBITEM.TabIndex = 100
        Me.LBITEM.Text = "Item"
        Me.LBITEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(519, 432)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(84, 26)
        Me.Label28.TabIndex = 99
        Me.Label28.Text = "Pembayaran"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBKEMBALI
        '
        Me.LBKEMBALI.BackColor = System.Drawing.Color.White
        Me.LBKEMBALI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBKEMBALI.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBKEMBALI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.LBKEMBALI.Location = New System.Drawing.Point(615, 469)
        Me.LBKEMBALI.Name = "LBKEMBALI"
        Me.LBKEMBALI.Size = New System.Drawing.Size(152, 26)
        Me.LBKEMBALI.TabIndex = 98
        Me.LBKEMBALI.Text = "0"
        Me.LBKEMBALI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(541, 469)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(63, 26)
        Me.Label26.TabIndex = 97
        Me.Label26.Text = "Kembali"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ALFIAN_TXTPEM
        '
        Me.ALFIAN_TXTPEM.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTPEM.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTPEM.ForeColor = System.Drawing.Color.Black
        Me.ALFIAN_TXTPEM.Location = New System.Drawing.Point(615, 432)
        Me.ALFIAN_TXTPEM.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTPEM.Name = "ALFIAN_TXTPEM"
        Me.ALFIAN_TXTPEM.Size = New System.Drawing.Size(190, 27)
        Me.ALFIAN_TXTPEM.TabIndex = 96
        '
        'ALFIAN_BTNSIMPAN
        '
        Me.ALFIAN_BTNSIMPAN.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNSIMPAN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ALFIAN_BTNSIMPAN.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNSIMPAN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ALFIAN_BTNSIMPAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNSIMPAN.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNSIMPAN.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNSIMPAN.Location = New System.Drawing.Point(19, 432)
        Me.ALFIAN_BTNSIMPAN.Name = "ALFIAN_BTNSIMPAN"
        Me.ALFIAN_BTNSIMPAN.Size = New System.Drawing.Size(89, 33)
        Me.ALFIAN_BTNSIMPAN.TabIndex = 101
        Me.ALFIAN_BTNSIMPAN.Text = "SIMPAN"
        Me.ALFIAN_BTNSIMPAN.UseVisualStyleBackColor = False
        '
        'LBLJAM
        '
        Me.LBLJAM.BackColor = System.Drawing.Color.Transparent
        Me.LBLJAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLJAM.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLJAM.ForeColor = System.Drawing.Color.White
        Me.LBLJAM.Location = New System.Drawing.Point(16, 477)
        Me.LBLJAM.Name = "LBLJAM"
        Me.LBLJAM.Size = New System.Drawing.Size(89, 26)
        Me.LBLJAM.TabIndex = 102
        Me.LBLJAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(130, 437)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 103
        '
        'Alfian_barangTableAdapter
        '
        Me.Alfian_barangTableAdapter.ClearBeforeFill = True
        '
        'Alfian_pegawaiTableAdapter
        '
        Me.Alfian_pegawaiTableAdapter.ClearBeforeFill = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.Label1.TabIndex = 104
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
        Me.Label8.TabIndex = 105
        '
        'FormPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 523)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxCrystalReport1)
        Me.Controls.Add(Me.ALFIAN_BTNSIMPAN)
        Me.Controls.Add(Me.LBLJAM)
        Me.Controls.Add(Me.LBITEM)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.LBKEMBALI)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.ALFIAN_TXTPEM)
        Me.Controls.Add(Me.ALFIAN_TBLTRANSAKSI)
        Me.Controls.Add(Me.BTNRESET)
        Me.Controls.Add(Me.LBNAMAPEG)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.ALFIAN_CMBKODEPEG)
        Me.Controls.Add(Me.ALFIAN_BTNTAMBAH)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormPenjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AlfianbarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlfianpegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALFIAN_TBLTRANSAKSI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ALFIAN_DTTGL As DateTimePicker
    Friend WithEvents ALFIAN_TXTKODETRAN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LBTOTAL As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents LBSTOK As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents LBHARGA As Label
    Friend WithEvents LBNAMABRG As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ALFIAN_CMBKODEBRG As ComboBox
    Friend WithEvents ALFIAN_TXTJUM As TextBox
    Friend WithEvents BTNRESET As Button
    Friend WithEvents LBNAMAPEG As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ALFIAN_CMBKODEPEG As ComboBox
    Friend WithEvents ALFIAN_BTNTAMBAH As Button
    Friend WithEvents ALFIAN_TBLTRANSAKSI As DataGridView
    Friend WithEvents LBITEM As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents LBKEMBALI As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents ALFIAN_TXTPEM As TextBox
    Friend WithEvents ALFIAN_BTNSIMPAN As Button
    Friend WithEvents LBLJAM As Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
    Friend WithEvents Db_toko_pbd_if21dxDataSet1 As db_toko_pbd_if21dxDataSet1
    Friend WithEvents AlfianbarangBindingSource As BindingSource
    Friend WithEvents Alfian_barangTableAdapter As db_toko_pbd_if21dxDataSet1TableAdapters.alfian_barangTableAdapter
    Friend WithEvents Db_toko_pbd_if21dxDataSet2 As db_toko_pbd_if21dxDataSet2
    Friend WithEvents AlfianpegawaiBindingSource As BindingSource
    Friend WithEvents Alfian_pegawaiTableAdapter As db_toko_pbd_if21dxDataSet2TableAdapters.alfian_pegawaiTableAdapter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
End Class
