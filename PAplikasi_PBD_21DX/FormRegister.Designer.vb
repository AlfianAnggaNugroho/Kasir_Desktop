<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegister))
        Me.CMBKODE = New System.Windows.Forms.ComboBox()
        Me.AlfianpegawaiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet2 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet2()
        Me.TBLAKUN = New System.Windows.Forms.DataGridView()
        Me.AlfiankdpegDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianusernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfiankunciDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianlevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlfianloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_toko_pbd_if21dxDataSet8 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet8()
        Me.BTNDELETE = New System.Windows.Forms.Button()
        Me.BTNEDIT = New System.Windows.Forms.Button()
        Me.CMBLEVEL = New System.Windows.Forms.ComboBox()
        Me.ALFIAN_TXTUSERNAME = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTREGISTER = New System.Windows.Forms.LinkLabel()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ALFIAN_TXTPASS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.REGISTER = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Alfian_pegawaiTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet2TableAdapters.alfian_pegawaiTableAdapter()
        Me.Alfian_loginTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet8TableAdapters.alfian_loginTableAdapter()
        CType(Me.AlfianpegawaiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLAKUN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlfianloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMBKODE
        '
        Me.CMBKODE.AllowDrop = True
        Me.CMBKODE.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.CMBKODE.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBKODE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMBKODE.DataSource = Me.AlfianpegawaiBindingSource
        Me.CMBKODE.DisplayMember = "alfian_kd_peg"
        Me.CMBKODE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBKODE.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBKODE.ForeColor = System.Drawing.Color.White
        Me.CMBKODE.FormattingEnabled = True
        Me.CMBKODE.Location = New System.Drawing.Point(131, 172)
        Me.CMBKODE.Name = "CMBKODE"
        Me.CMBKODE.Size = New System.Drawing.Size(190, 21)
        Me.CMBKODE.TabIndex = 102
        Me.CMBKODE.ValueMember = "alfian_kd_peg"
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
        'TBLAKUN
        '
        Me.TBLAKUN.AutoGenerateColumns = False
        Me.TBLAKUN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TBLAKUN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TBLAKUN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AlfiankdpegDataGridViewTextBoxColumn, Me.AlfianusernameDataGridViewTextBoxColumn, Me.AlfiankunciDataGridViewTextBoxColumn, Me.AlfianlevelDataGridViewTextBoxColumn})
        Me.TBLAKUN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TBLAKUN.DataSource = Me.AlfianloginBindingSource
        Me.TBLAKUN.Location = New System.Drawing.Point(28, 355)
        Me.TBLAKUN.Name = "TBLAKUN"
        Me.TBLAKUN.RowHeadersVisible = False
        Me.TBLAKUN.Size = New System.Drawing.Size(553, 122)
        Me.TBLAKUN.TabIndex = 101
        '
        'AlfiankdpegDataGridViewTextBoxColumn
        '
        Me.AlfiankdpegDataGridViewTextBoxColumn.DataPropertyName = "alfian_kd_peg"
        Me.AlfiankdpegDataGridViewTextBoxColumn.HeaderText = "Kode"
        Me.AlfiankdpegDataGridViewTextBoxColumn.Name = "AlfiankdpegDataGridViewTextBoxColumn"
        '
        'AlfianusernameDataGridViewTextBoxColumn
        '
        Me.AlfianusernameDataGridViewTextBoxColumn.DataPropertyName = "alfian_username"
        Me.AlfianusernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.AlfianusernameDataGridViewTextBoxColumn.Name = "AlfianusernameDataGridViewTextBoxColumn"
        '
        'AlfiankunciDataGridViewTextBoxColumn
        '
        Me.AlfiankunciDataGridViewTextBoxColumn.DataPropertyName = "alfian_kunci"
        Me.AlfiankunciDataGridViewTextBoxColumn.HeaderText = "alfian_kunci"
        Me.AlfiankunciDataGridViewTextBoxColumn.Name = "AlfiankunciDataGridViewTextBoxColumn"
        Me.AlfiankunciDataGridViewTextBoxColumn.Visible = False
        '
        'AlfianlevelDataGridViewTextBoxColumn
        '
        Me.AlfianlevelDataGridViewTextBoxColumn.DataPropertyName = "alfian_level"
        Me.AlfianlevelDataGridViewTextBoxColumn.HeaderText = "Level Account"
        Me.AlfianlevelDataGridViewTextBoxColumn.Name = "AlfianlevelDataGridViewTextBoxColumn"
        '
        'AlfianloginBindingSource
        '
        Me.AlfianloginBindingSource.DataMember = "alfian_login"
        Me.AlfianloginBindingSource.DataSource = Me.Db_toko_pbd_if21dxDataSet8
        '
        'Db_toko_pbd_if21dxDataSet8
        '
        Me.Db_toko_pbd_if21dxDataSet8.DataSetName = "db_toko_pbd_if21dxDataSet8"
        Me.Db_toko_pbd_if21dxDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTNDELETE
        '
        Me.BTNDELETE.BackColor = System.Drawing.Color.White
        Me.BTNDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNDELETE.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDELETE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.BTNDELETE.Location = New System.Drawing.Point(473, 284)
        Me.BTNDELETE.Name = "BTNDELETE"
        Me.BTNDELETE.Size = New System.Drawing.Size(109, 26)
        Me.BTNDELETE.TabIndex = 100
        Me.BTNDELETE.Text = "Delete"
        Me.BTNDELETE.UseVisualStyleBackColor = False
        '
        'BTNEDIT
        '
        Me.BTNEDIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNEDIT.FlatAppearance.BorderSize = 0
        Me.BTNEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEDIT.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDIT.ForeColor = System.Drawing.Color.White
        Me.BTNEDIT.Location = New System.Drawing.Point(177, 284)
        Me.BTNEDIT.Name = "BTNEDIT"
        Me.BTNEDIT.Size = New System.Drawing.Size(109, 26)
        Me.BTNEDIT.TabIndex = 99
        Me.BTNEDIT.Text = "Edit"
        Me.BTNEDIT.UseVisualStyleBackColor = False
        '
        'CMBLEVEL
        '
        Me.CMBLEVEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBLEVEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMBLEVEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBLEVEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBLEVEL.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBLEVEL.ForeColor = System.Drawing.Color.White
        Me.CMBLEVEL.FormattingEnabled = True
        Me.CMBLEVEL.Items.AddRange(New Object() {"ADMIN", "USER"})
        Me.CMBLEVEL.Location = New System.Drawing.Point(429, 226)
        Me.CMBLEVEL.Name = "CMBLEVEL"
        Me.CMBLEVEL.Size = New System.Drawing.Size(152, 21)
        Me.CMBLEVEL.TabIndex = 98
        '
        'ALFIAN_TXTUSERNAME
        '
        Me.ALFIAN_TXTUSERNAME.AccessibleName = ""
        Me.ALFIAN_TXTUSERNAME.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTUSERNAME.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ALFIAN_TXTUSERNAME.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTUSERNAME.ForeColor = System.Drawing.Color.Black
        Me.ALFIAN_TXTUSERNAME.Location = New System.Drawing.Point(131, 224)
        Me.ALFIAN_TXTUSERNAME.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTUSERNAME.Name = "ALFIAN_TXTUSERNAME"
        Me.ALFIAN_TXTUSERNAME.Size = New System.Drawing.Size(190, 27)
        Me.ALFIAN_TXTUSERNAME.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(352, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 17)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "Level"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(352, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Password"
        '
        'TXTREGISTER
        '
        Me.TXTREGISTER.ActiveLinkColor = System.Drawing.Color.MidnightBlue
        Me.TXTREGISTER.AutoSize = True
        Me.TXTREGISTER.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TXTREGISTER.Location = New System.Drawing.Point(25, 317)
        Me.TXTREGISTER.Name = "TXTREGISTER"
        Me.TXTREGISTER.Size = New System.Drawing.Size(132, 13)
        Me.TXTREGISTER.TabIndex = 94
        Me.TXTREGISTER.TabStop = True
        Me.TXTREGISTER.Text = "Already have an account?"
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.BTNCANCEL.FlatAppearance.BorderSize = 0
        Me.BTNCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCANCEL.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCEL.ForeColor = System.Drawing.Color.White
        Me.BTNCANCEL.Location = New System.Drawing.Point(330, 284)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(109, 26)
        Me.BTNCANCEL.TabIndex = 93
        Me.BTNCANCEL.Text = "Cancel"
        Me.BTNCANCEL.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Kode Pegawai"
        '
        'ALFIAN_TXTPASS
        '
        Me.ALFIAN_TXTPASS.BackColor = System.Drawing.Color.White
        Me.ALFIAN_TXTPASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ALFIAN_TXTPASS.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ALFIAN_TXTPASS.ForeColor = System.Drawing.Color.Black
        Me.ALFIAN_TXTPASS.Location = New System.Drawing.Point(429, 171)
        Me.ALFIAN_TXTPASS.MinimumSize = New System.Drawing.Size(4, 30)
        Me.ALFIAN_TXTPASS.Name = "ALFIAN_TXTPASS"
        Me.ALFIAN_TXTPASS.Size = New System.Drawing.Size(153, 24)
        Me.ALFIAN_TXTPASS.TabIndex = 90
        Me.ALFIAN_TXTPASS.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(161, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 19)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Silahkan Daftarkan Username dan Password"
        '
        'REGISTER
        '
        Me.REGISTER.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.REGISTER.FlatAppearance.BorderSize = 0
        Me.REGISTER.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.REGISTER.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTER.ForeColor = System.Drawing.Color.White
        Me.REGISTER.Location = New System.Drawing.Point(28, 284)
        Me.REGISTER.Name = "REGISTER"
        Me.REGISTER.Size = New System.Drawing.Size(109, 26)
        Me.REGISTER.TabIndex = 88
        Me.REGISTER.Text = "Register"
        Me.REGISTER.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(270, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 28)
        Me.Label3.TabIndex = 87
        Me.Label3.Text = "Account"
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserFriends
        Me.IconPictureBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 69
        Me.IconPictureBox2.Location = New System.Drawing.Point(278, 70)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(69, 69)
        Me.IconPictureBox2.TabIndex = 103
        Me.IconPictureBox2.TabStop = False
        '
        'Alfian_pegawaiTableAdapter
        '
        Me.Alfian_pegawaiTableAdapter.ClearBeforeFill = True
        '
        'Alfian_loginTableAdapter
        '
        Me.Alfian_loginTableAdapter.ClearBeforeFill = True
        '
        'FormRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(607, 496)
        Me.Controls.Add(Me.IconPictureBox2)
        Me.Controls.Add(Me.CMBKODE)
        Me.Controls.Add(Me.TBLAKUN)
        Me.Controls.Add(Me.BTNDELETE)
        Me.Controls.Add(Me.BTNEDIT)
        Me.Controls.Add(Me.CMBLEVEL)
        Me.Controls.Add(Me.ALFIAN_TXTUSERNAME)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTREGISTER)
        Me.Controls.Add(Me.BTNCANCEL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ALFIAN_TXTPASS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.REGISTER)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account"
        CType(Me.AlfianpegawaiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLAKUN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlfianloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents CMBKODE As ComboBox
    Friend WithEvents TBLAKUN As DataGridView
    Friend WithEvents BTNDELETE As Button
    Friend WithEvents BTNEDIT As Button
    Friend WithEvents CMBLEVEL As ComboBox
    Friend WithEvents ALFIAN_TXTUSERNAME As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTREGISTER As LinkLabel
    Friend WithEvents BTNCANCEL As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ALFIAN_TXTPASS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents REGISTER As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Db_toko_pbd_if21dxDataSet2 As db_toko_pbd_if21dxDataSet2
    Friend WithEvents AlfianpegawaiBindingSource As BindingSource
    Friend WithEvents Alfian_pegawaiTableAdapter As db_toko_pbd_if21dxDataSet2TableAdapters.alfian_pegawaiTableAdapter
    Friend WithEvents Db_toko_pbd_if21dxDataSet8 As db_toko_pbd_if21dxDataSet8
    Friend WithEvents AlfianloginBindingSource As BindingSource
    Friend WithEvents Alfian_loginTableAdapter As db_toko_pbd_if21dxDataSet8TableAdapters.alfian_loginTableAdapter
    Friend WithEvents AlfiankdpegDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianusernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfiankunciDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlfianlevelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
