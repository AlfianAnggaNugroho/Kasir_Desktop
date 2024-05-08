<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCetakBeli
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCetakBeli))
        Me.CR2 = New AxCrystal.AxCrystalReport()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CMBNOTRANS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBPERTRANS = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DTAKHIR = New System.Windows.Forms.DateTimePicker()
        Me.DTAWAL = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CETAKMINGGU = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CMBTAHUN = New System.Windows.Forms.ComboBox()
        Me.CMBBULAN = New System.Windows.Forms.ComboBox()
        Me.CETAKBULAN = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Db_toko_pbd_if21dxDataSet9 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet9()
        Me.AlfiantransaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alfian_transaksiTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet9TableAdapters.alfian_transaksiTableAdapter()
        CType(Me.CR2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Db_toko_pbd_if21dxDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlfiantransaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CR2
        '
        Me.CR2.Enabled = True
        Me.CR2.Location = New System.Drawing.Point(292, 190)
        Me.CR2.Name = "CR2"
        Me.CR2.OcxState = CType(resources.GetObject("CR2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CR2.Size = New System.Drawing.Size(28, 28)
        Me.CR2.TabIndex = 42
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CMBNOTRANS)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.CMBPERTRANS)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(18, 14)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(278, 177)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan Per Transaksi"
        '
        'CMBNOTRANS
        '
        Me.CMBNOTRANS.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBNOTRANS.DataSource = Me.AlfiantransaksiBindingSource
        Me.CMBNOTRANS.DisplayMember = "alfian_kd_beli"
        Me.CMBNOTRANS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMBNOTRANS.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBNOTRANS.ForeColor = System.Drawing.Color.White
        Me.CMBNOTRANS.FormattingEnabled = True
        Me.CMBNOTRANS.ItemHeight = 17
        Me.CMBNOTRANS.Location = New System.Drawing.Point(128, 41)
        Me.CMBNOTRANS.Name = "CMBNOTRANS"
        Me.CMBNOTRANS.Size = New System.Drawing.Size(132, 25)
        Me.CMBNOTRANS.TabIndex = 32
        Me.CMBNOTRANS.ValueMember = "alfian_kd_beli"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Kode Pembelian"
        '
        'CMBPERTRANS
        '
        Me.CMBPERTRANS.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CMBPERTRANS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMBPERTRANS.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMBPERTRANS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBPERTRANS.ForeColor = System.Drawing.Color.White
        Me.CMBPERTRANS.Location = New System.Drawing.Point(19, 124)
        Me.CMBPERTRANS.Name = "CMBPERTRANS"
        Me.CMBPERTRANS.Size = New System.Drawing.Size(241, 32)
        Me.CMBPERTRANS.TabIndex = 5
        Me.CMBPERTRANS.Text = "Cetak Transaksi"
        Me.CMBPERTRANS.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DTAKHIR)
        Me.GroupBox3.Controls.Add(Me.DTAWAL)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.CETAKMINGGU)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(18, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(278, 174)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan Mingguan"
        '
        'DTAKHIR
        '
        Me.DTAKHIR.AccessibleDescription = ""
        Me.DTAKHIR.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTAKHIR.Checked = False
        Me.DTAKHIR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTAKHIR.CustomFormat = ""
        Me.DTAKHIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTAKHIR.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTAKHIR.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTAKHIR.Location = New System.Drawing.Point(137, 82)
        Me.DTAKHIR.Name = "DTAKHIR"
        Me.DTAKHIR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DTAKHIR.Size = New System.Drawing.Size(122, 21)
        Me.DTAKHIR.TabIndex = 34
        Me.DTAKHIR.Value = New Date(2022, 11, 26, 0, 0, 0, 0)
        '
        'DTAWAL
        '
        Me.DTAWAL.AccessibleDescription = ""
        Me.DTAWAL.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DTAWAL.Checked = False
        Me.DTAWAL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTAWAL.CustomFormat = ""
        Me.DTAWAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTAWAL.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTAWAL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTAWAL.Location = New System.Drawing.Point(137, 33)
        Me.DTAWAL.Name = "DTAWAL"
        Me.DTAWAL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DTAWAL.Size = New System.Drawing.Size(123, 21)
        Me.DTAWAL.TabIndex = 30
        Me.DTAWAL.Value = New Date(2022, 11, 26, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tanggall Akhir"
        '
        'CETAKMINGGU
        '
        Me.CETAKMINGGU.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CETAKMINGGU.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CETAKMINGGU.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CETAKMINGGU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CETAKMINGGU.ForeColor = System.Drawing.Color.White
        Me.CETAKMINGGU.Location = New System.Drawing.Point(19, 124)
        Me.CETAKMINGGU.Name = "CETAKMINGGU"
        Me.CETAKMINGGU.Size = New System.Drawing.Size(241, 32)
        Me.CETAKMINGGU.TabIndex = 5
        Me.CETAKMINGGU.Text = "Cetak Mingguan"
        Me.CETAKMINGGU.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Tanggal Awal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CMBTAHUN)
        Me.GroupBox2.Controls.Add(Me.CMBBULAN)
        Me.GroupBox2.Controls.Add(Me.CETAKBULAN)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(317, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(278, 174)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan Bulanan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Tahun"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Bulan"
        '
        'CMBTAHUN
        '
        Me.CMBTAHUN.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CMBTAHUN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBTAHUN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMBTAHUN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBTAHUN.FormattingEnabled = True
        Me.CMBTAHUN.Location = New System.Drawing.Point(102, 81)
        Me.CMBTAHUN.Name = "CMBTAHUN"
        Me.CMBTAHUN.Size = New System.Drawing.Size(157, 24)
        Me.CMBTAHUN.TabIndex = 7
        '
        'CMBBULAN
        '
        Me.CMBBULAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBBULAN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMBBULAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBBULAN.FormattingEnabled = True
        Me.CMBBULAN.ItemHeight = 16
        Me.CMBBULAN.Location = New System.Drawing.Point(102, 33)
        Me.CMBBULAN.Name = "CMBBULAN"
        Me.CMBBULAN.Size = New System.Drawing.Size(157, 24)
        Me.CMBBULAN.TabIndex = 6
        '
        'CETAKBULAN
        '
        Me.CETAKBULAN.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.CETAKBULAN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CETAKBULAN.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CETAKBULAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CETAKBULAN.ForeColor = System.Drawing.Color.White
        Me.CETAKBULAN.Location = New System.Drawing.Point(19, 124)
        Me.CETAKBULAN.Name = "CETAKBULAN"
        Me.CETAKBULAN.Size = New System.Drawing.Size(241, 32)
        Me.CETAKBULAN.TabIndex = 5
        Me.CETAKBULAN.Text = "Cetak Bulanan"
        Me.CETAKBULAN.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(317, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 177)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan Harian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tanggal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.55!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(102, 43)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(157, 20)
        Me.DateTimePicker1.TabIndex = 28
        Me.DateTimePicker1.Value = New Date(2022, 11, 26, 0, 0, 0, 0)
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(19, 123)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(241, 31)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Cetak Harian"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Db_toko_pbd_if21dxDataSet9
        '
        Me.Db_toko_pbd_if21dxDataSet9.DataSetName = "db_toko_pbd_if21dxDataSet9"
        Me.Db_toko_pbd_if21dxDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlfiantransaksiBindingSource
        '
        Me.AlfiantransaksiBindingSource.DataMember = "alfian_transaksi"
        Me.AlfiantransaksiBindingSource.DataSource = Me.Db_toko_pbd_if21dxDataSet9
        '
        'Alfian_transaksiTableAdapter
        '
        Me.Alfian_transaksiTableAdapter.ClearBeforeFill = True
        '
        'FormCetakBeli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(612, 399)
        Me.Controls.Add(Me.CR2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormCetakBeli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Pembelian"
        CType(Me.CR2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Db_toko_pbd_if21dxDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlfiantransaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CR2 As AxCrystal.AxCrystalReport
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CMBNOTRANS As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CMBPERTRANS As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DTAKHIR As DateTimePicker
    Friend WithEvents DTAWAL As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents CETAKMINGGU As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CMBTAHUN As ComboBox
    Friend WithEvents CMBBULAN As ComboBox
    Friend WithEvents CETAKBULAN As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents Db_toko_pbd_if21dxDataSet9 As db_toko_pbd_if21dxDataSet9
    Friend WithEvents AlfiantransaksiBindingSource As BindingSource
    Friend WithEvents Alfian_transaksiTableAdapter As db_toko_pbd_if21dxDataSet9TableAdapters.alfian_transaksiTableAdapter
End Class
