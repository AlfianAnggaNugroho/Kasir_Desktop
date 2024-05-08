<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPegawai
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPegawai))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ALFIAN_DTTANGGAL = New System.Windows.Forms.DateTimePicker()
        Me.ALFIAN_CMBPENDIDIKAN = New System.Windows.Forms.ComboBox()
        Me.ALFIAN_CMBJABATAN = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTTEMPAT = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTALAMAT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTNOTELP = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTKODEPEG = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTNAMAPEG = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ALFIAN_CMBCARI = New System.Windows.Forms.ComboBox()
        Me.ALFIAN_TXTCARI = New System.Windows.Forms.TextBox()
        Me.ALFIAN_BTNHAPUS = New System.Windows.Forms.Button()
        Me.ALFIAN_TBLPEGAWAI = New System.Windows.Forms.DataGridView()
        Me.AlfiankdpegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiannmpegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiantemplhrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiantgllahirDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianpendDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianjabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiannotelpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianalamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianpegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet4 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet4()
        Me.ALFIAN_BTNEXIT = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNEDIT = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNADD = New System.Windows.Forms.Button()
        Me.Alfian_pegawaiTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet4TableAdapters.alfian_pegawaiTableAdapter()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ALFIAN_TBLPEGAWAI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlfianpegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ALFIAN_DTTANGGAL)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_CMBPENDIDIKAN)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_CMBJABATAN)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTTEMPAT)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTALAMAT)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTNOTELP)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTKODEPEG)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTNAMAPEG)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(20, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 228)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA PEGAWAI"
        '
        'ALFIAN_DTTANGGAL
        '
        Me.ALFIAN_DTTANGGAL.CalendarMonthBackground = System.Drawing.Color.AliceBlue
        Me.ALFIAN_DTTANGGAL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_DTTANGGAL.CustomFormat = "yyyy/MM/dd"
        Me.ALFIAN_DTTANGGAL.Location = New System.Drawing.Point(134, 179)
        Me.ALFIAN_DTTANGGAL.Name = "ALFIAN_DTTANGGAL"
        Me.ALFIAN_DTTANGGAL.Size = New System.Drawing.Size(211, 24)
        Me.ALFIAN_DTTANGGAL.TabIndex = 23
        Me.ALFIAN_DTTANGGAL.Value = New Date(2022, 11, 18, 0, 0, 0, 0)
        '
        'ALFIAN_CMBPENDIDIKAN
        '
        Me.ALFIAN_CMBPENDIDIKAN.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBPENDIDIKAN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_CMBPENDIDIKAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ALFIAN_CMBPENDIDIKAN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ALFIAN_CMBPENDIDIKAN.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBPENDIDIKAN.FormattingEnabled = True
        Me.ALFIAN_CMBPENDIDIKAN.Location = New System.Drawing.Point(572, 38)
        Me.ALFIAN_CMBPENDIDIKAN.Name = "ALFIAN_CMBPENDIDIKAN"
        Me.ALFIAN_CMBPENDIDIKAN.Size = New System.Drawing.Size(188, 23)
        Me.ALFIAN_CMBPENDIDIKAN.TabIndex = 22
        '
        'ALFIAN_CMBJABATAN
        '
        Me.ALFIAN_CMBJABATAN.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBJABATAN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_CMBJABATAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ALFIAN_CMBJABATAN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ALFIAN_CMBJABATAN.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBJABATAN.FormattingEnabled = True
        Me.ALFIAN_CMBJABATAN.Location = New System.Drawing.Point(572, 86)
        Me.ALFIAN_CMBJABATAN.Name = "ALFIAN_CMBJABATAN"
        Me.ALFIAN_CMBJABATAN.Size = New System.Drawing.Size(188, 23)
        Me.ALFIAN_CMBJABATAN.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(473, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 17)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Alamat"
        '
        'ALFIAN_TXTTEMPAT
        '
        Me.ALFIAN_TXTTEMPAT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTTEMPAT.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTTEMPAT.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTTEMPAT.Location = New System.Drawing.Point(134, 133)
        Me.ALFIAN_TXTTEMPAT.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTTEMPAT.Name = "ALFIAN_TXTTEMPAT"
        Me.ALFIAN_TXTTEMPAT.Size = New System.Drawing.Size(245, 23)
        Me.ALFIAN_TXTTEMPAT.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Tempat Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(473, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "No. Telepon"
        '
        'ALFIAN_TXTALAMAT
        '
        Me.ALFIAN_TXTALAMAT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTALAMAT.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTALAMAT.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTALAMAT.Location = New System.Drawing.Point(570, 179)
        Me.ALFIAN_TXTALAMAT.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTALAMAT.Name = "ALFIAN_TXTALAMAT"
        Me.ALFIAN_TXTALAMAT.Size = New System.Drawing.Size(190, 23)
        Me.ALFIAN_TXTALAMAT.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(473, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Jabatan"
        '
        'ALFIAN_TXTNOTELP
        '
        Me.ALFIAN_TXTNOTELP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTNOTELP.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTNOTELP.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTNOTELP.Location = New System.Drawing.Point(570, 133)
        Me.ALFIAN_TXTNOTELP.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTNOTELP.Name = "ALFIAN_TXTNOTELP"
        Me.ALFIAN_TXTNOTELP.Size = New System.Drawing.Size(190, 23)
        Me.ALFIAN_TXTNOTELP.TabIndex = 13
        '
        'ALFIAN_TXTKODEPEG
        '
        Me.ALFIAN_TXTKODEPEG.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTKODEPEG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ALFIAN_TXTKODEPEG.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTKODEPEG.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_TXTKODEPEG.Location = New System.Drawing.Point(134, 38)
        Me.ALFIAN_TXTKODEPEG.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTKODEPEG.Name = "ALFIAN_TXTKODEPEG"
        Me.ALFIAN_TXTKODEPEG.Size = New System.Drawing.Size(245, 26)
        Me.ALFIAN_TXTKODEPEG.TabIndex = 12
        '
        'ALFIAN_TXTNAMAPEG
        '
        Me.ALFIAN_TXTNAMAPEG.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTNAMAPEG.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTNAMAPEG.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTNAMAPEG.Location = New System.Drawing.Point(134, 87)
        Me.ALFIAN_TXTNAMAPEG.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTNAMAPEG.Name = "ALFIAN_TXTNAMAPEG"
        Me.ALFIAN_TXTNAMAPEG.Size = New System.Drawing.Size(245, 23)
        Me.ALFIAN_TXTNAMAPEG.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(473, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Pendidikan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tanggal Lahir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 17)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Nama Pegawai"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Kode Pegawai"
        '
        'ALFIAN_CMBCARI
        '
        Me.ALFIAN_CMBCARI.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBCARI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ALFIAN_CMBCARI.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ALFIAN_CMBCARI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_CMBCARI.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBCARI.FormattingEnabled = True
        Me.ALFIAN_CMBCARI.Items.AddRange(New Object() {"Kode Pegawai", "Nama Pegawai"})
        Me.ALFIAN_CMBCARI.Location = New System.Drawing.Point(703, 212)
        Me.ALFIAN_CMBCARI.Name = "ALFIAN_CMBCARI"
        Me.ALFIAN_CMBCARI.Size = New System.Drawing.Size(101, 21)
        Me.ALFIAN_CMBCARI.TabIndex = 41
        '
        'ALFIAN_TXTCARI
        '
        Me.ALFIAN_TXTCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ALFIAN_TXTCARI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ALFIAN_TXTCARI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTCARI.Location = New System.Drawing.Point(497, 212)
        Me.ALFIAN_TXTCARI.Name = "ALFIAN_TXTCARI"
        Me.ALFIAN_TXTCARI.Size = New System.Drawing.Size(200, 26)
        Me.ALFIAN_TXTCARI.TabIndex = 40
        '
        'ALFIAN_BTNHAPUS
        '
        Me.ALFIAN_BTNHAPUS.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNHAPUS.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNHAPUS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ALFIAN_BTNHAPUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNHAPUS.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNHAPUS.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNHAPUS.Location = New System.Drawing.Point(103, 212)
        Me.ALFIAN_BTNHAPUS.Name = "ALFIAN_BTNHAPUS"
        Me.ALFIAN_BTNHAPUS.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNHAPUS.TabIndex = 39
        Me.ALFIAN_BTNHAPUS.Text = "Delete"
        Me.ALFIAN_BTNHAPUS.UseVisualStyleBackColor = False
        '
        'ALFIAN_TBLPEGAWAI
        '
        Me.ALFIAN_TBLPEGAWAI.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.ALFIAN_TBLPEGAWAI.AllowUserToResizeColumns = False
        Me.ALFIAN_TBLPEGAWAI.AllowUserToResizeRows = False
        Me.ALFIAN_TBLPEGAWAI.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALFIAN_TBLPEGAWAI.AutoGenerateColumns = False
        Me.ALFIAN_TBLPEGAWAI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ALFIAN_TBLPEGAWAI.BackgroundColor = System.Drawing.Color.White
        Me.ALFIAN_TBLPEGAWAI.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.ALFIAN_TBLPEGAWAI.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ALFIAN_TBLPEGAWAI.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ALFIAN_TBLPEGAWAI.ColumnHeadersHeight = 25
        Me.ALFIAN_TBLPEGAWAI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ALFIAN_TBLPEGAWAI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlfiankdpegDataGridViewTextBoxColumn, Me.AlfiannmpegDataGridViewTextBoxColumn, Me.AlfiantemplhrDataGridViewTextBoxColumn, Me.AlfiantgllahirDataGridViewTextBoxColumn, Me.AlfianpendDataGridViewTextBoxColumn, Me.AlfianjabDataGridViewTextBoxColumn, Me.AlfiannotelpDataGridViewTextBoxColumn, Me.AlfianalamatDataGridViewTextBoxColumn})
        Me.ALFIAN_TBLPEGAWAI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_TBLPEGAWAI.DataSource = Me.AlfianpegawaiBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ALFIAN_TBLPEGAWAI.DefaultCellStyle = DataGridViewCellStyle2
        Me.ALFIAN_TBLPEGAWAI.Location = New System.Drawing.Point(20, 20)
        Me.ALFIAN_TBLPEGAWAI.Name = "ALFIAN_TBLPEGAWAI"
        Me.ALFIAN_TBLPEGAWAI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ALFIAN_TBLPEGAWAI.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ALFIAN_TBLPEGAWAI.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ALFIAN_TBLPEGAWAI.RowHeadersVisible = False
        Me.ALFIAN_TBLPEGAWAI.RowHeadersWidth = 30
        Me.ALFIAN_TBLPEGAWAI.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ALFIAN_TBLPEGAWAI.Size = New System.Drawing.Size(784, 176)
        Me.ALFIAN_TBLPEGAWAI.TabIndex = 35
        '
        'AlfiankdpegDataGridViewTextBoxColumn
        '
        Me.AlfiankdpegDataGridViewTextBoxColumn.DataPropertyName = "alfian_kd_peg"
        Me.AlfiankdpegDataGridViewTextBoxColumn.HeaderText = "Kode Pegawai"
        Me.AlfiankdpegDataGridViewTextBoxColumn.Name = "AlfiankdpegDataGridViewTextBoxColumn"
        '
        'AlfiannmpegDataGridViewTextBoxColumn
        '
        Me.AlfiannmpegDataGridViewTextBoxColumn.DataPropertyName = "alfian_nm_peg"
        Me.AlfiannmpegDataGridViewTextBoxColumn.HeaderText = "Nama Pegawai"
        Me.AlfiannmpegDataGridViewTextBoxColumn.Name = "AlfiannmpegDataGridViewTextBoxColumn"
        '
        'AlfiantemplhrDataGridViewTextBoxColumn
        '
        Me.AlfiantemplhrDataGridViewTextBoxColumn.DataPropertyName = "alfian_temp_lhr"
        Me.AlfiantemplhrDataGridViewTextBoxColumn.HeaderText = "Tempat Lahir"
        Me.AlfiantemplhrDataGridViewTextBoxColumn.Name = "AlfiantemplhrDataGridViewTextBoxColumn"
        '
        'AlfiantgllahirDataGridViewTextBoxColumn
        '
        Me.AlfiantgllahirDataGridViewTextBoxColumn.DataPropertyName = "alfian_tgl_lahir"
        Me.AlfiantgllahirDataGridViewTextBoxColumn.HeaderText = "Tgl Lahir"
        Me.AlfiantgllahirDataGridViewTextBoxColumn.Name = "AlfiantgllahirDataGridViewTextBoxColumn"
        '
        'AlfianpendDataGridViewTextBoxColumn
        '
        Me.AlfianpendDataGridViewTextBoxColumn.DataPropertyName = "alfian_pend"
        Me.AlfianpendDataGridViewTextBoxColumn.HeaderText = "Pendidikan"
        Me.AlfianpendDataGridViewTextBoxColumn.Name = "AlfianpendDataGridViewTextBoxColumn"
        '
        'AlfianjabDataGridViewTextBoxColumn
        '
        Me.AlfianjabDataGridViewTextBoxColumn.DataPropertyName = "alfian_jab"
        Me.AlfianjabDataGridViewTextBoxColumn.HeaderText = "Jabatan"
        Me.AlfianjabDataGridViewTextBoxColumn.Name = "AlfianjabDataGridViewTextBoxColumn"
        '
        'AlfiannotelpDataGridViewTextBoxColumn
        '
        Me.AlfiannotelpDataGridViewTextBoxColumn.DataPropertyName = "alfian_no_telp"
        Me.AlfiannotelpDataGridViewTextBoxColumn.HeaderText = "No. Telepon"
        Me.AlfiannotelpDataGridViewTextBoxColumn.Name = "AlfiannotelpDataGridViewTextBoxColumn"
        '
        'AlfianalamatDataGridViewTextBoxColumn
        '
        Me.AlfianalamatDataGridViewTextBoxColumn.DataPropertyName = "alfian_alamat"
        Me.AlfianalamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlfianalamatDataGridViewTextBoxColumn.Name = "AlfianalamatDataGridViewTextBoxColumn"
        '
        'AlfianpegawaiBindingSource
        '
        Me.AlfianpegawaiBindingSource.DataMember = "alfian_pegawai"
        Me.AlfianpegawaiBindingSource.DataSource = Me.Db_toko_pbd_if21dxDataSet4
        '
        'Db_toko_pbd_if21dxDataSet4
        '
        Me.Db_toko_pbd_if21dxDataSet4.DataSetName = "db_toko_pbd_if21dxDataSet4"
        Me.Db_toko_pbd_if21dxDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALFIAN_BTNEXIT
        '
        Me.ALFIAN_BTNEXIT.BackColor = System.Drawing.Color.White
        Me.ALFIAN_BTNEXIT.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNEXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNEXIT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNEXIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEXIT.Location = New System.Drawing.Point(22, 212)
        Me.ALFIAN_BTNEXIT.Name = "ALFIAN_BTNEXIT"
        Me.ALFIAN_BTNEXIT.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNEXIT.TabIndex = 37
        Me.ALFIAN_BTNEXIT.Text = "Logout"
        Me.ALFIAN_BTNEXIT.UseVisualStyleBackColor = False
        '
        'ALFIAN_BTNEDIT
        '
        Me.ALFIAN_BTNEDIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEDIT.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNEDIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ALFIAN_BTNEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNEDIT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNEDIT.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNEDIT.Location = New System.Drawing.Point(184, 212)
        Me.ALFIAN_BTNEDIT.Name = "ALFIAN_BTNEDIT"
        Me.ALFIAN_BTNEDIT.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNEDIT.TabIndex = 38
        Me.ALFIAN_BTNEDIT.Text = "Edit"
        Me.ALFIAN_BTNEDIT.UseVisualStyleBackColor = False
        '
        'ALFIAN_BTNADD
        '
        Me.ALFIAN_BTNADD.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNADD.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ALFIAN_BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNADD.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNADD.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_BTNADD.Location = New System.Drawing.Point(265, 212)
        Me.ALFIAN_BTNADD.Name = "ALFIAN_BTNADD"
        Me.ALFIAN_BTNADD.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNADD.TabIndex = 36
        Me.ALFIAN_BTNADD.Text = "Add Data"
        Me.ALFIAN_BTNADD.UseVisualStyleBackColor = False
        '
        'Alfian_pegawaiTableAdapter
        '
        Me.Alfian_pegawaiTableAdapter.ClearBeforeFill = True
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
        Me.IconPictureBox1.Location = New System.Drawing.Point(466, 212)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.IconPictureBox1.TabIndex = 45
        Me.IconPictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(0, 522)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(824, 1)
        Me.Label2.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(823, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1, 522)
        Me.Label1.TabIndex = 81
        '
        'FormPegawai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ALFIAN_CMBCARI)
        Me.Controls.Add(Me.ALFIAN_TXTCARI)
        Me.Controls.Add(Me.ALFIAN_BTNHAPUS)
        Me.Controls.Add(Me.ALFIAN_TBLPEGAWAI)
        Me.Controls.Add(Me.ALFIAN_BTNEXIT)
        Me.Controls.Add(Me.ALFIAN_BTNEDIT)
        Me.Controls.Add(Me.ALFIAN_BTNADD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormPegawai"
        Me.Text = "FormPegawai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ALFIAN_TBLPEGAWAI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlfianpegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ALFIAN_DTTANGGAL As DateTimePicker
    Friend WithEvents ALFIAN_CMBPENDIDIKAN As ComboBox
    Friend WithEvents ALFIAN_CMBJABATAN As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ALFIAN_TXTTEMPAT As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ALFIAN_TXTALAMAT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ALFIAN_TXTNOTELP As TextBox
    Friend WithEvents ALFIAN_TXTKODEPEG As TextBox
    Friend WithEvents ALFIAN_TXTNAMAPEG As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ALFIAN_CMBCARI As ComboBox
    Friend WithEvents ALFIAN_TXTCARI As TextBox
    Friend WithEvents ALFIAN_BTNHAPUS As Button
    Friend WithEvents ALFIAN_TBLPEGAWAI As DataGridView
    Friend WithEvents ALFIAN_BTNEXIT As Button
    Friend WithEvents ALFIAN_BTNEDIT As Button
    Friend WithEvents ALFIAN_BTNADD As Button
    Friend WithEvents Db_toko_pbd_if21dxDataSet4 As db_toko_pbd_if21dxDataSet4
    Friend WithEvents AlfianpegawaiBindingSource As BindingSource
    Friend WithEvents Alfian_pegawaiTableAdapter As db_toko_pbd_if21dxDataSet4TableAdapters.alfian_pegawaiTableAdapter
    Friend WithEvents AlfiankdpegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiannmpegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiantemplhrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiantgllahirDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianpendDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianjabDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiannotelpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianalamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
