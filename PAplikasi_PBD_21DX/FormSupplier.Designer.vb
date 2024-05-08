<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSupplier))
        Me.ALFIAN_CMBCARI = New System.Windows.Forms.ComboBox()
        Me.ALFIAN_TXTCARI = New System.Windows.Forms.TextBox()
        Me.ALFIAN_BTNEDIT = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNHAPUS = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNEXIT = New System.Windows.Forms.Button()
        Me.ALFIAN_BTNADD = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ALFIAN_TXTALAMAT = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTNOTELP = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTKODESUP = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTPEN = New System.Windows.Forms.TextBox()
        Me.ALFIAN_TXTNAMAPER = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ALFIAN_TBLSUP = New System.Windows.Forms.DataGridView()
        Me.AlfiankdsupDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiannmperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiannmpenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiannotelpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianemailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianalamatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiansupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet3 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet3()
        Me.Alfian_supplierTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet3TableAdapters.alfian_supplierTableAdapter()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ALFIAN_TBLSUP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlfiansupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ALFIAN_CMBCARI
        '
        Me.ALFIAN_CMBCARI.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_CMBCARI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ALFIAN_CMBCARI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_CMBCARI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_CMBCARI.ForeColor = System.Drawing.Color.White
        Me.ALFIAN_CMBCARI.FormattingEnabled = True
        Me.ALFIAN_CMBCARI.Items.AddRange(New Object() {"Kode Supplier", "Nama Perusahaan"})
        Me.ALFIAN_CMBCARI.Location = New System.Drawing.Point(703, 212)
        Me.ALFIAN_CMBCARI.Name = "ALFIAN_CMBCARI"
        Me.ALFIAN_CMBCARI.Size = New System.Drawing.Size(101, 21)
        Me.ALFIAN_CMBCARI.TabIndex = 45
        '
        'ALFIAN_TXTCARI
        '
        Me.ALFIAN_TXTCARI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ALFIAN_TXTCARI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ALFIAN_TXTCARI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTCARI.Location = New System.Drawing.Point(520, 211)
        Me.ALFIAN_TXTCARI.Name = "ALFIAN_TXTCARI"
        Me.ALFIAN_TXTCARI.Size = New System.Drawing.Size(177, 26)
        Me.ALFIAN_TXTCARI.TabIndex = 44
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
        Me.ALFIAN_BTNEDIT.Location = New System.Drawing.Point(184, 212)
        Me.ALFIAN_BTNEDIT.Name = "ALFIAN_BTNEDIT"
        Me.ALFIAN_BTNEDIT.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNEDIT.TabIndex = 42
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
        Me.ALFIAN_BTNHAPUS.Location = New System.Drawing.Point(103, 212)
        Me.ALFIAN_BTNHAPUS.Name = "ALFIAN_BTNHAPUS"
        Me.ALFIAN_BTNHAPUS.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNHAPUS.TabIndex = 43
        Me.ALFIAN_BTNHAPUS.Text = "Delete"
        Me.ALFIAN_BTNHAPUS.UseVisualStyleBackColor = False
        '
        'ALFIAN_BTNEXIT
        '
        Me.ALFIAN_BTNEXIT.BackColor = System.Drawing.Color.White
        Me.ALFIAN_BTNEXIT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ALFIAN_BTNEXIT.FlatAppearance.BorderSize = 0
        Me.ALFIAN_BTNEXIT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ALFIAN_BTNEXIT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_BTNEXIT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_BTNEXIT.Location = New System.Drawing.Point(22, 212)
        Me.ALFIAN_BTNEXIT.Name = "ALFIAN_BTNEXIT"
        Me.ALFIAN_BTNEXIT.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNEXIT.TabIndex = 41
        Me.ALFIAN_BTNEXIT.Text = "Back"
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
        Me.ALFIAN_BTNADD.Location = New System.Drawing.Point(265, 212)
        Me.ALFIAN_BTNADD.Name = "ALFIAN_BTNADD"
        Me.ALFIAN_BTNADD.Size = New System.Drawing.Size(75, 28)
        Me.ALFIAN_BTNADD.TabIndex = 40
        Me.ALFIAN_BTNADD.Text = "Add Data"
        Me.ALFIAN_BTNADD.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTALAMAT)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTEMAIL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTNOTELP)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTKODESUP)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTPEN)
        Me.GroupBox1.Controls.Add(Me.ALFIAN_TXTNAMAPER)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(20, 288)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(784, 218)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA SUPPLIER"
        '
        'ALFIAN_TXTALAMAT
        '
        Me.ALFIAN_TXTALAMAT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTALAMAT.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTALAMAT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTALAMAT.Location = New System.Drawing.Point(571, 134)
        Me.ALFIAN_TXTALAMAT.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTALAMAT.Multiline = True
        Me.ALFIAN_TXTALAMAT.Name = "ALFIAN_TXTALAMAT"
        Me.ALFIAN_TXTALAMAT.Size = New System.Drawing.Size(194, 62)
        Me.ALFIAN_TXTALAMAT.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(453, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Alamat"
        '
        'ALFIAN_TXTEMAIL
        '
        Me.ALFIAN_TXTEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTEMAIL.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTEMAIL.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTEMAIL.Location = New System.Drawing.Point(571, 82)
        Me.ALFIAN_TXTEMAIL.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTEMAIL.Name = "ALFIAN_TXTEMAIL"
        Me.ALFIAN_TXTEMAIL.Size = New System.Drawing.Size(194, 23)
        Me.ALFIAN_TXTEMAIL.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(453, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Email"
        '
        'ALFIAN_TXTNOTELP
        '
        Me.ALFIAN_TXTNOTELP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTNOTELP.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTNOTELP.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTNOTELP.Location = New System.Drawing.Point(571, 34)
        Me.ALFIAN_TXTNOTELP.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTNOTELP.Name = "ALFIAN_TXTNOTELP"
        Me.ALFIAN_TXTNOTELP.Size = New System.Drawing.Size(194, 23)
        Me.ALFIAN_TXTNOTELP.TabIndex = 13
        '
        'ALFIAN_TXTKODESUP
        '
        Me.ALFIAN_TXTKODESUP.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTKODESUP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ALFIAN_TXTKODESUP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTKODESUP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ALFIAN_TXTKODESUP.Location = New System.Drawing.Point(195, 38)
        Me.ALFIAN_TXTKODESUP.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTKODESUP.Name = "ALFIAN_TXTKODESUP"
        Me.ALFIAN_TXTKODESUP.Size = New System.Drawing.Size(217, 26)
        Me.ALFIAN_TXTKODESUP.TabIndex = 12
        '
        'ALFIAN_TXTPEN
        '
        Me.ALFIAN_TXTPEN.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTPEN.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTPEN.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTPEN.Location = New System.Drawing.Point(196, 154)
        Me.ALFIAN_TXTPEN.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTPEN.Name = "ALFIAN_TXTPEN"
        Me.ALFIAN_TXTPEN.Size = New System.Drawing.Size(217, 23)
        Me.ALFIAN_TXTPEN.TabIndex = 11
        '
        'ALFIAN_TXTNAMAPER
        '
        Me.ALFIAN_TXTNAMAPER.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ALFIAN_TXTNAMAPER.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTNAMAPER.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTNAMAPER.Location = New System.Drawing.Point(195, 94)
        Me.ALFIAN_TXTNAMAPER.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTNAMAPER.Name = "ALFIAN_TXTNAMAPER"
        Me.ALFIAN_TXTNAMAPER.Size = New System.Drawing.Size(217, 23)
        Me.ALFIAN_TXTNAMAPER.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(453, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Nomor Telepon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nama Penanggung Jawab"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nama Perusahaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Kode Supplier"
        '
        'ALFIAN_TBLSUP
        '
        Me.ALFIAN_TBLSUP.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.ALFIAN_TBLSUP.AllowUserToResizeColumns = False
        Me.ALFIAN_TBLSUP.AllowUserToResizeRows = False
        Me.ALFIAN_TBLSUP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ALFIAN_TBLSUP.AutoGenerateColumns = False
        Me.ALFIAN_TBLSUP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ALFIAN_TBLSUP.BackgroundColor = System.Drawing.Color.White
        Me.ALFIAN_TBLSUP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ALFIAN_TBLSUP.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ALFIAN_TBLSUP.ColumnHeadersHeight = 26
        Me.ALFIAN_TBLSUP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ALFIAN_TBLSUP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlfiankdsupDataGridViewTextBoxColumn, Me.AlfiannmperDataGridViewTextBoxColumn, Me.AlfiannmpenDataGridViewTextBoxColumn, Me.AlfiannotelpDataGridViewTextBoxColumn, Me.AlfianemailDataGridViewTextBoxColumn, Me.AlfianalamatDataGridViewTextBoxColumn})
        Me.ALFIAN_TBLSUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ALFIAN_TBLSUP.DataSource = Me.AlfiansupplierBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ALFIAN_TBLSUP.DefaultCellStyle = DataGridViewCellStyle2
        Me.ALFIAN_TBLSUP.Location = New System.Drawing.Point(20, 20)
        Me.ALFIAN_TBLSUP.Name = "ALFIAN_TBLSUP"
        Me.ALFIAN_TBLSUP.RightToLeft = System.Windows.Forms.RightToLeft.No
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ALFIAN_TBLSUP.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ALFIAN_TBLSUP.RowHeadersVisible = False
        Me.ALFIAN_TBLSUP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ALFIAN_TBLSUP.Size = New System.Drawing.Size(784, 176)
        Me.ALFIAN_TBLSUP.TabIndex = 38
        '
        'AlfiankdsupDataGridViewTextBoxColumn
        '
        Me.AlfiankdsupDataGridViewTextBoxColumn.DataPropertyName = "alfian_kd_sup"
        Me.AlfiankdsupDataGridViewTextBoxColumn.HeaderText = "Kode Supplier"
        Me.AlfiankdsupDataGridViewTextBoxColumn.Name = "AlfiankdsupDataGridViewTextBoxColumn"
        '
        'AlfiannmperDataGridViewTextBoxColumn
        '
        Me.AlfiannmperDataGridViewTextBoxColumn.DataPropertyName = "alfian_nm_per"
        Me.AlfiannmperDataGridViewTextBoxColumn.HeaderText = "Nama Perusahaan"
        Me.AlfiannmperDataGridViewTextBoxColumn.Name = "AlfiannmperDataGridViewTextBoxColumn"
        '
        'AlfiannmpenDataGridViewTextBoxColumn
        '
        Me.AlfiannmpenDataGridViewTextBoxColumn.DataPropertyName = "alfian_nm_pen"
        Me.AlfiannmpenDataGridViewTextBoxColumn.HeaderText = "Penanggung Jawab"
        Me.AlfiannmpenDataGridViewTextBoxColumn.Name = "AlfiannmpenDataGridViewTextBoxColumn"
        '
        'AlfiannotelpDataGridViewTextBoxColumn
        '
        Me.AlfiannotelpDataGridViewTextBoxColumn.DataPropertyName = "alfian_no_telp"
        Me.AlfiannotelpDataGridViewTextBoxColumn.HeaderText = "No.Telepon"
        Me.AlfiannotelpDataGridViewTextBoxColumn.Name = "AlfiannotelpDataGridViewTextBoxColumn"
        '
        'AlfianemailDataGridViewTextBoxColumn
        '
        Me.AlfianemailDataGridViewTextBoxColumn.DataPropertyName = "alfian_email"
        Me.AlfianemailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.AlfianemailDataGridViewTextBoxColumn.Name = "AlfianemailDataGridViewTextBoxColumn"
        '
        'AlfianalamatDataGridViewTextBoxColumn
        '
        Me.AlfianalamatDataGridViewTextBoxColumn.DataPropertyName = "alfian_alamat"
        Me.AlfianalamatDataGridViewTextBoxColumn.HeaderText = "Alamat"
        Me.AlfianalamatDataGridViewTextBoxColumn.Name = "AlfianalamatDataGridViewTextBoxColumn"
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
        'Alfian_supplierTableAdapter
        '
        Me.Alfian_supplierTableAdapter.ClearBeforeFill = True
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
        Me.IconPictureBox1.Location = New System.Drawing.Point(490, 211)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(28, 25)
        Me.IconPictureBox1.TabIndex = 46
        Me.IconPictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(823, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1, 523)
        Me.Label1.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label8.Location = New System.Drawing.Point(0, 522)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(823, 1)
        Me.Label8.TabIndex = 81
        '
        'FormSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 523)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Controls.Add(Me.ALFIAN_CMBCARI)
        Me.Controls.Add(Me.ALFIAN_TXTCARI)
        Me.Controls.Add(Me.ALFIAN_BTNEDIT)
        Me.Controls.Add(Me.ALFIAN_BTNHAPUS)
        Me.Controls.Add(Me.ALFIAN_BTNEXIT)
        Me.Controls.Add(Me.ALFIAN_BTNADD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ALFIAN_TBLSUP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormSupplier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ALFIAN_TBLSUP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlfiansupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ALFIAN_CMBCARI As ComboBox
    Friend WithEvents ALFIAN_TXTCARI As TextBox
    Friend WithEvents ALFIAN_BTNEDIT As Button
    Friend WithEvents ALFIAN_BTNHAPUS As Button
    Friend WithEvents ALFIAN_BTNEXIT As Button
    Friend WithEvents ALFIAN_BTNADD As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ALFIAN_TXTALAMAT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ALFIAN_TXTEMAIL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ALFIAN_TXTNOTELP As TextBox
    Friend WithEvents ALFIAN_TXTKODESUP As TextBox
    Friend WithEvents ALFIAN_TXTPEN As TextBox
    Friend WithEvents ALFIAN_TXTNAMAPER As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ALFIAN_TBLSUP As DataGridView
    Friend WithEvents Db_toko_pbd_if21dxDataSet3 As db_toko_pbd_if21dxDataSet3
    Friend WithEvents AlfiansupplierBindingSource As BindingSource
    Friend WithEvents Alfian_supplierTableAdapter As db_toko_pbd_if21dxDataSet3TableAdapters.alfian_supplierTableAdapter
    Friend WithEvents AlfiankdsupDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiannmperDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiannmpenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiannotelpDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianemailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianalamatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
End Class
