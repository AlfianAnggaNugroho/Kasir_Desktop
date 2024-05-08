Imports System.Data.SqlClient
Public Class FormCetakBeli
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim Ds As DataSet
    Dim Kode As String
    Dim MyDB As String
    Sub Koneksi()
        MyDB = "Data Source=LAPTOP-BK925EA8\SQLTENYOM;Initial Catalog=db_toko_pbd_if21dx;Integrated Security=True"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub
    Private Sub FormCetakBeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet9.alfian_transaksi' table. You can move, or remove it, as needed.
        Me.Alfian_transaksiTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet9.alfian_transaksi)

        CMBBULAN.Items.Clear()
        CMBBULAN.Items.Add("01 - JANUARI")
        CMBBULAN.Items.Add("02 - FEBRUARI")
        CMBBULAN.Items.Add("03 - MARET")
        CMBBULAN.Items.Add("04 - APRIL")
        CMBBULAN.Items.Add("05 - MEI")
        CMBBULAN.Items.Add("06 - JUNI")
        CMBBULAN.Items.Add("07 - JULY")
        CMBBULAN.Items.Add("08 - AGUSTUS")
        CMBBULAN.Items.Add("09 - SEPTEMBER")
        CMBBULAN.Items.Add("10 - OKTOBER")
        CMBBULAN.Items.Add("11 - NOVEMBER")
        CMBBULAN.Items.Add("12 - DESEMBER")

        CMBTAHUN.Items.Clear()
        CMBTAHUN.Text = Date.Now.Year
        For i As Integer = 0 To 5
            CMBTAHUN.Items.Add(Date.Now.Year - i)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call Koneksi()
        CR2.SelectionFormula = "totext({alfian_transaksi.alfian_tgl_beli})='" & Format(DateTimePicker1.Value, "dd/MM/yyyy") & "'"
        CR2.ReportFileName = "LaporanPembelian.rpt"
        CR2.WindowState = Crystal.WindowStateConstants.crptMaximized
        CR2.RetrieveDataFiles()
        CR2.Action = 1
    End Sub

    Private Sub CETAKBULAN_Click(sender As Object, e As EventArgs) Handles CETAKBULAN.Click
        If CMBBULAN.Text = "" Or CMBTAHUN.Text = "" Then
            MsgBox("Silahkan masukan Bulan dan Tahun terlebih dahulu!")
        Else
            Call Koneksi()
            CR2.SelectionFormula = "Month({alfian_transaksi.alfian_tgl_beli})=" & Val(CMBBULAN.Text) & " and year({alfian_transaksi.alfian_tgl_beli})=" & Val(CMBTAHUN.Text)
            CR2.ReportFileName = "LaporanPembelianBulanan.rpt"
            CR2.WindowState = Crystal.WindowStateConstants.crptMaximized
            CR2.RetrieveDataFiles()
            CR2.Action = 1
        End If
    End Sub

    Private Sub CETAKMINGGU_Click(sender As Object, e As EventArgs) Handles CETAKMINGGU.Click
        Dim tglawal As String
        Dim tglakhir As String
        tglawal = Format(DTAWAL.Value, "yyyy, MM, dd")
        tglakhir = Format(DTAKHIR.Value, "yyyy, MM, dd")
        Call Koneksi()
        CR2.SelectionFormula = "{alfian_transaksi.alfian_tgl_beli} in date (" & tglawal & ") to date (" & tglakhir & ")"
        CR2.ReportFileName = "LaporanPembelianMingguan.rpt"
        CR2.WindowState = Crystal.WindowStateConstants.crptMaximized
        CR2.RetrieveDataFiles()
        CR2.Action = 1
    End Sub

    Private Sub CMBPERTRANS_Click(sender As Object, e As EventArgs) Handles CMBPERTRANS.Click
        CR2.SelectionFormula = "totext({alfian_transaksi.alfian_kd_beli})='" & CMBNOTRANS.Text & "'"
        CR2.ReportFileName = "LaporanPerPembelian.rpt"
        CR2.WindowState = Crystal.WindowStateConstants.crptMaximized
        CR2.RetrieveDataFiles()
        CR2.Action = 1
    End Sub

    Private Sub CMBNOTRANS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CMBNOTRANS.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * From alfian_transaksi Where alfian_kd_beli='" & CMBNOTRANS.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                CMBPERTRANS.Focus()
            Else
                MsgBox("Kode Beli Not Found!!!")
                CMBNOTRANS.Focus()
            End If
        End If
    End Sub
End Class