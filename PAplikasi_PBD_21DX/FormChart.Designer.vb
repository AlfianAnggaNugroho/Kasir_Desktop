<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormChart
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChartPnj = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Db_toko_pbd_if21dxDataSet7 = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet7()
        Me.AlfianpenjualanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alfian_penjualanTableAdapter = New PAplikasi_PBD_21DX.db_toko_pbd_if21dxDataSet7TableAdapters.alfian_penjualanTableAdapter()
        Me.ChartPmb = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartPnj, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_toko_pbd_if21dxDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlfianpenjualanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartPmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconPictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Magento
        Me.IconPictureBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(11, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 78
        Me.IconPictureBox3.Location = New System.Drawing.Point(376, 39)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(78, 78)
        Me.IconPictureBox3.TabIndex = 88
        Me.IconPictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(343, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 28)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "DASHBOARD"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(257, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(291, 15)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "selain itu juga tampilanya juga sangat nyaman dilihat."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(119, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(582, 15)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "sangat berguna untuk mengelola data - data karena dilengkapi beberapa fitur yang " &
    "sangat mudah digunakan"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(200, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(408, 15)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "data digital minimarket yang bisa disimpan dalam waktu yang tak menentu."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(174, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(468, 15)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Aplikasi Bisnis Minimarket ini merupakan aplikasi yang bertujuan sebagai penyimpa" &
    "nan"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(694, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 13)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Alfian angga nugroho"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(586, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "Dikembangkan oleh"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(38, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "1.0 2022"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Versi"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChartPnj
        '
        Me.ChartPnj.BackColor = System.Drawing.Color.Transparent
        Me.ChartPnj.BackSecondaryColor = System.Drawing.Color.White
        Me.ChartPnj.BorderSkin.BorderColor = System.Drawing.Color.White
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea1.AxisX.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisX.Title = "Tanggal ( Bulan )"
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White
        ChartArea1.AxisY.Title = "Pemasukan & Pengeluaran"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.ChartPnj.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.Transparent
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Legend1.ForeColor = System.Drawing.Color.White
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.ChartPnj.Legends.Add(Legend1)
        Me.ChartPnj.Location = New System.Drawing.Point(10, 240)
        Me.ChartPnj.Name = "ChartPnj"
        Me.ChartPnj.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series1.BackSecondaryColor = System.Drawing.Color.White
        Series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.Maroon
        Series1.IsXValueIndexed = True
        Series1.Label = "Rp"
        Series1.LabelBackColor = System.Drawing.Color.Transparent
        Series1.LabelForeColor = System.Drawing.Color.White
        Series1.Legend = "Legend1"
        Series1.Name = "Penjualan"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire
        Series1.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White
        Series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White
        Me.ChartPnj.Series.Add(Series1)
        Me.ChartPnj.Size = New System.Drawing.Size(396, 271)
        Me.ChartPnj.TabIndex = 101
        Me.ChartPnj.Text = "Chart1"
        Title1.BackColor = System.Drawing.Color.Transparent
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Title1.ForeColor = System.Drawing.Color.White
        Title1.Name = "DataPenjualan"
        Title1.Text = "STATISTIK PENJUALAN"
        Me.ChartPnj.Titles.Add(Title1)
        '
        'Db_toko_pbd_if21dxDataSet7
        '
        Me.Db_toko_pbd_if21dxDataSet7.DataSetName = "db_toko_pbd_if21dxDataSet7"
        Me.Db_toko_pbd_if21dxDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlfianpenjualanBindingSource
        '
        Me.AlfianpenjualanBindingSource.DataMember = "alfian_penjualan"
        Me.AlfianpenjualanBindingSource.DataSource = Me.Db_toko_pbd_if21dxDataSet7
        '
        'Alfian_penjualanTableAdapter
        '
        Me.Alfian_penjualanTableAdapter.ClearBeforeFill = True
        '
        'ChartPmb
        '
        Me.ChartPmb.BackColor = System.Drawing.Color.Transparent
        Me.ChartPmb.BackSecondaryColor = System.Drawing.Color.White
        Me.ChartPmb.BorderSkin.BorderColor = System.Drawing.Color.White
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic
        ChartArea2.AxisX.InterlacedColor = System.Drawing.Color.White
        ChartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.LineColor = System.Drawing.Color.Silver
        ChartArea2.AxisX.MajorGrid.Enabled = False
        ChartArea2.AxisX.Title = "Tanggal ( Bulan )"
        ChartArea2.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        ChartArea2.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea2.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.InterlacedColor = System.Drawing.Color.White
        ChartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White
        ChartArea2.AxisY.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.MajorGrid.Enabled = False
        ChartArea2.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.White
        ChartArea2.AxisY.Title = "Pengeluaran"
        ChartArea2.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        ChartArea2.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea2.BackColor = System.Drawing.Color.Transparent
        ChartArea2.BorderColor = System.Drawing.Color.White
        ChartArea2.Name = "ChartArea1"
        Me.ChartPmb.ChartAreas.Add(ChartArea2)
        Legend2.BackColor = System.Drawing.Color.Transparent
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Legend2.ForeColor = System.Drawing.Color.White
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.ChartPmb.Legends.Add(Legend2)
        Me.ChartPmb.Location = New System.Drawing.Point(433, 240)
        Me.ChartPmb.Name = "ChartPmb"
        Me.ChartPmb.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.ChartPmb.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom
        Series2.BackImageTransparentColor = System.Drawing.Color.Transparent
        Series2.BackSecondaryColor = System.Drawing.Color.White
        Series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Teal
        Series2.IsXValueIndexed = True
        Series2.Label = "Rp"
        Series2.LabelBackColor = System.Drawing.Color.Transparent
        Series2.LabelForeColor = System.Drawing.Color.White
        Series2.Legend = "Legend1"
        Series2.Name = "Pembelian"
        Series2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.White
        Series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White
        Me.ChartPmb.Series.Add(Series2)
        Me.ChartPmb.Size = New System.Drawing.Size(382, 271)
        Me.ChartPmb.TabIndex = 102
        Title2.BackColor = System.Drawing.Color.Transparent
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Title2.ForeColor = System.Drawing.Color.White
        Title2.Name = "DataPenjualan"
        Title2.Text = "STATISTIK TRANSAKSI"
        Me.ChartPmb.Titles.Add(Title2)
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
        Me.Label1.TabIndex = 103
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(13, Byte), Integer))
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Location = New System.Drawing.Point(823, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 522)
        Me.Label11.TabIndex = 104
        '
        'FormChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(824, 523)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChartPmb)
        Me.Controls.Add(Me.ChartPnj)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IconPictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormChart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormChart"
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartPnj, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_toko_pbd_if21dxDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlfianpenjualanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartPmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ChartPnj As DataVisualization.Charting.Chart
    Friend WithEvents Db_toko_pbd_if21dxDataSet7 As db_toko_pbd_if21dxDataSet7
    Friend WithEvents AlfianpenjualanBindingSource As BindingSource
    Friend WithEvents Alfian_penjualanTableAdapter As db_toko_pbd_if21dxDataSet7TableAdapters.alfian_penjualanTableAdapter
    Friend WithEvents ChartPmb As DataVisualization.Charting.Chart
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
End Class
