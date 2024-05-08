Imports System.Data.SqlClient
Public Class FormChart
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
    Private Sub FormChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet7.alfian_penjualan' table. You can move, or remove it, as needed.
        Me.Alfian_penjualanTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet7.alfian_penjualan)
        Call Koneksi()
        'Chart Penjualan
        Cmd = New SqlCommand("Select SUM(alfian_subtotal) As penjualan,MONTH(alfian_tgl) As bulan FROM alfian_penjualan WHERE YEAR(alfian_tgl) = YEAR(GETDATE()) GROUP BY MONTH(alfian_tgl)", Conn)
        Rd = Cmd.ExecuteReader
        While Rd.Read
            ChartPnj.Series("Penjualan").Points.AddXY(Rd.Item("bulan"), Rd.Item("penjualan"))
        End While

        Call Pembelian()

    End Sub

    Sub Pembelian()
        'Chart Pembelian
        Call Koneksi()
        Cmd = New SqlCommand("Select SUM(alfian_hrg_beli) As pembelian,MONTH(alfian_tgl_beli) As bulan FROM alfian_transaksi WHERE YEAR(alfian_tgl_beli) = YEAR(GETDATE()) GROUP BY MONTH(alfian_tgl_beli)", Conn)
        Rd = Cmd.ExecuteReader
        While Rd.Read
            ChartPmb.Series("Pembelian").Points.AddXY(Rd.Item("bulan"), Rd.Item("pembelian"))
        End While
    End Sub
End Class