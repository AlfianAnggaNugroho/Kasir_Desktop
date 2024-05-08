Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Public Class FormDashboard
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim Ds As DataSet
    Dim MyDB As String
    Sub Koneksi()
        MyDB = "data source=LAPTOP-BK925EA8\SQLTENYOM;initial catalog=db_toko_pbd_if21dx;integrated security=true"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True
    Dim isCollapsed3 As Boolean = True
    Dim isCollapsed4 As Boolean = True

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Sub SwitchPanel(ByVal panel As Form)
        PANUTAMA.Controls.Clear()
        panel.TopLevel = False
        PANUTAMA.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SwitchPanel(FormChart)

        PanelTransaksi.Size = PanelTransaksi.MinimumSize
        PanelMaster.Size = PanelMaster.MinimumSize
        DropPanelCetak.Size = DropPanelCetak.MinimumSize
        PanelAcc.Size = DropPanelCetak.MinimumSize

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            R1.Visible = False
            D1.Visible = True
            D1.BackColor = Color.FromArgb(28, 40, 51)
            DROPTRANS.BackColor = Color.FromArgb(28, 40, 51)
            PanelTransaksi.Height += 10
            If PanelTransaksi.Size = PanelTransaksi.MaximumSize Then
                Timer1.Stop()
                isCollapsed = False
                BTNL1.Visible = True
            End If
        Else
            R1.Visible = True
            D1.Visible = False
            R1.BackColor = Color.Transparent
            DROPTRANS.BackColor = Color.Transparent
            PanelTransaksi.Height -= 10
            If PanelTransaksi.Size = PanelTransaksi.MinimumSize Then
                Timer1.Stop()
                isCollapsed = True
                BTNL1.Visible = False
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed2 Then
            R2.Visible = False
            D2.Visible = True
            D2.BackColor = Color.FromArgb(28, 40, 51)
            DropMaster.BackColor = Color.FromArgb(28, 40, 51)
            PanelMaster.Height += 10
            If PanelMaster.Size = PanelMaster.MaximumSize Then
                Timer2.Stop()
                isCollapsed2 = False
                BTNL2.Visible = True
            End If
        Else
            R2.Visible = True
            D2.Visible = False
            R2.BackColor = Color.Transparent
            DropMaster.BackColor = Color.Transparent
            PanelMaster.Height -= 10
            If PanelMaster.Size = PanelMaster.MinimumSize Then
                Timer2.Stop()
                isCollapsed2 = True
                BTNL2.Visible = False
            End If
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If isCollapsed3 Then
            R3.Visible = False
            D3.Visible = True
            D3.BackColor = Color.FromArgb(28, 40, 51)
            DropLaporan.BackColor = Color.FromArgb(28, 40, 51)
            DropPanelCetak.Height += 10
            If DropPanelCetak.Size = DropPanelCetak.MaximumSize Then
                Timer3.Stop()
                isCollapsed3 = False
                BTNL3.Visible = True
            End If
        Else
            R3.Visible = True
            D3.Visible = False
            R3.BackColor = Color.Transparent
            DropLaporan.BackColor = Color.Transparent
            DropPanelCetak.Height -= 10
            If DropPanelCetak.Size = DropPanelCetak.MinimumSize Then
                Timer3.Stop()
                isCollapsed3 = True
                BTNL3.Visible = False
            End If
        End If
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If isCollapsed4 Then
            R4.Visible = False
            D4.Visible = True
            D4.BackColor = Color.FromArgb(28, 40, 51)
            DropAccount.BackColor = Color.FromArgb(28, 40, 51)
            PanelAcc.Height += 10
            If PanelAcc.Size = PanelAcc.MaximumSize Then
                Timer5.Stop()
                isCollapsed4 = False
                BTNL4.Visible = True
            End If
        Else
            R4.Visible = True
            D4.Visible = False
            R4.BackColor = Color.Transparent
            DropAccount.BackColor = Color.Transparent
            PanelAcc.Height -= 10
            If PanelAcc.Size = PanelAcc.MinimumSize Then
                Timer5.Stop()
                isCollapsed4 = True
                BTNL4.Visible = False
            End If
        End If
    End Sub
    Private Sub DROPTRANS_Click(sender As Object, e As EventArgs) Handles DROPTRANS.Click
        isCollapsed2 = False
        isCollapsed3 = False
        isCollapsed4 = False
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer5.Start()
    End Sub

    Private Sub DropMaster_Click(sender As Object, e As EventArgs) Handles DropMaster.Click
        isCollapsed = False
        isCollapsed3 = False
        isCollapsed4 = False
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer5.Start()
    End Sub

    Private Sub DropLaporan_Click(sender As Object, e As EventArgs) Handles DropLaporan.Click
        isCollapsed = False
        isCollapsed2 = False
        isCollapsed4 = False
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer5.Start()
    End Sub
    Private Sub DropAccount_Click(sender As Object, e As EventArgs) Handles DropAccount.Click
        isCollapsed = False
        isCollapsed2 = False
        isCollapsed3 = False
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer5.Start()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        If MessageBox.Show("Apakah anda ingin keluar ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            FormLogin.Show()
            Me.Close()
        Else
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        If MessageBox.Show("Apakah anda ingin keluar ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            FormLogin.Close()
        Else
        End If
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
            FormBarang.WindowState = FormWindowState.Normal.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnPenjualan_Click(sender As Object, e As EventArgs) Handles BtnPenjualan.Click
        FormBarang.Close()
        FormSupplier.Close()
        FormPegawai.Close()
        FormTransaksi.Close()
        FormChart.Close()

        LBFORM.Text = "PENJUALAN"
        SwitchPanel(FormPenjualan)
    End Sub
    Private Sub BtnBarang_Click(sender As Object, e As EventArgs) Handles BtnBarang.Click
        FormSupplier.Close()
        FormPenjualan.Close()
        FormPegawai.Close()
        FormTransaksi.Close()
        FormChart.Close()

        LBFORM.Text = "MASTER BARANG"
        SwitchPanel(FormBarang)
    End Sub

    Private Sub BtnSupplier_Click(sender As Object, e As EventArgs) Handles BtnSupplier.Click
        FormBarang.Close()
        FormPenjualan.Close()
        FormPegawai.Close()
        FormTransaksi.Close()
        FormChart.Close()

        LBFORM.Text = "MASTER SUPPLIER"
        SwitchPanel(FormSupplier)
    End Sub

    Private Sub BtnPegawai_Click(sender As Object, e As EventArgs) Handles BtnPegawai.Click
        FormBarang.Close()
        FormPenjualan.Close()
        FormSupplier.Close()
        FormTransaksi.Close()
        FormChart.Close()

        LBFORM.Text = "MASTER PEGAWAI"
        SwitchPanel(FormPegawai)
    End Sub

    Private Sub BtnTransaksi_Click(sender As Object, e As EventArgs)
        FormBarang.Close()
        FormSupplier.Close()
        FormPegawai.Close()
        FormPenjualan.Close()
        FormChart.Close()

        LBFORM.Text = "PEMBELIAN"
        SwitchPanel(FormTransaksi)
    End Sub

    Private Sub BtnLaporan_Click(sender As Object, e As EventArgs) Handles BtnLaporan.Click
        FormCetak.ShowDialog()
    End Sub

    Private Sub PANTOP_MouseMove(sender As Object, e As MouseEventArgs) Handles PANTOP.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BTNDASH_Click(sender As Object, e As EventArgs) Handles BTNDASH.Click
        FormBarang.Close()
        FormSupplier.Close()
        FormPegawai.Close()
        FormTransaksi.Close()
        FormPenjualan.Close()

        LBFORM.Text = "DASHBOARD"
        SwitchPanel(FormChart)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        LBLJAM.Text = TimeOfDay
    End Sub

    Private Sub BtnTransaksi_Click_1(sender As Object, e As EventArgs) Handles BtnTransaksi.Click
        FormBarang.Close()
        FormSupplier.Close()
        FormPegawai.Close()
        FormPenjualan.Close()
        FormChart.Close()

        LBFORM.Text = "PEMBELIAN"
        SwitchPanel(FormTransaksi)
    End Sub

    Private Sub BtnAcSetting_Click(sender As Object, e As EventArgs) Handles BtnAcSetting.Click
        FormRegister.ShowDialog()
    End Sub

    Private Sub BtnCetakBeli_Click(sender As Object, e As EventArgs) Handles BtnCetakBeli.Click
        FormCetakBeli.ShowDialog()
    End Sub
End Class
