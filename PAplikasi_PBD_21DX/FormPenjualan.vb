Imports System.Data.SqlClient
Public Class FormPenjualan
    Dim TglTransaksi As String
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
    Sub AddKolom()
        ALFIAN_TBLTRANSAKSI.Columns.Clear()
        ALFIAN_TBLTRANSAKSI.Columns.Add("alfian_kd_brg", "Kode Barang")
        ALFIAN_TBLTRANSAKSI.Columns.Add("alfian_mm_brg", "Nama Barang")
        ALFIAN_TBLTRANSAKSI.Columns.Add("alfian_hrg_jual", "Harga")
        ALFIAN_TBLTRANSAKSI.Columns.Add("alfian_jumlah", "Jumlah")
        ALFIAN_TBLTRANSAKSI.Columns.Add("alfian_subtotal", "Subtotal")
        ALFIAN_TBLTRANSAKSI.Columns.Add("alfian_kd_peg", "Kode Pegawai")
        ALFIAN_TBLTRANSAKSI.Columns.Add("alfian_nm_peg", "Nama Pegawai")
    End Sub
    Sub KondisiAwal()
        Call AddKolom()

        ALFIAN_TXTKODETRAN.Text = ""
        ALFIAN_TXTKODETRAN.Focus()
        ALFIAN_DTTGL.Text = ""
        ALFIAN_CMBKODEBRG.Text = ""
        LBNAMABRG.Text = ""
        LBHARGA.Text = ""
        ALFIAN_TXTJUM.Text = ""
        ALFIAN_CMBKODEPEG.Text = ""
        LBNAMAPEG.Text = ""
        LBTOTAL.Text = "0"
        ALFIAN_TXTPEM.Text = ""
        LBKEMBALI.Text = ""
        LBITEM.Text = ""
        LBSTOK.Text = ""


    End Sub
    Sub RumusCariItem()
        Dim Item As Integer = 0
        For i As Integer = 0 To ALFIAN_TBLTRANSAKSI.Rows.Count - 1
            Item = Item + ALFIAN_TBLTRANSAKSI.Rows(i).Cells(3).Value
            LBITEM.Text = Item
        Next
    End Sub
    Sub RumusTotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To ALFIAN_TBLTRANSAKSI.Rows.Count - 1
            hitung = hitung + ALFIAN_TBLTRANSAKSI.Rows(i).Cells(4).Value
            LBTOTAL.Text = hitung
        Next
    End Sub

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet2.alfian_pegawai' table. You can move, or remove it, as needed.
        Me.Alfian_pegawaiTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet2.alfian_pegawai)
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet1.alfian_barang' table. You can move, or remove it, as needed.
        Me.Alfian_barangTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet1.alfian_barang)
        Call KondisiAwal()
        Call AddKolom()
        LBTOTAL.Text = "0"

        ALFIAN_TBLTRANSAKSI.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        ALFIAN_TBLTRANSAKSI.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 11, 54)
        ALFIAN_TBLTRANSAKSI.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8.5, FontStyle.Bold)
        ALFIAN_TBLTRANSAKSI.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        ALFIAN_TBLTRANSAKSI.EnableHeadersVisualStyles = False

    End Sub
    Private Sub ALFIAN_BTNTAMBAH_Click(sender As Object, e As EventArgs) Handles ALFIAN_BTNTAMBAH.Click
        If LBNAMABRG.Text = "" Or ALFIAN_TXTJUM.Text = "" Or LBNAMAPEG.Text = "" Then
            MsgBox("Silahkan isi data dengan LENGKAP !")
        Else
            If Val(LBSTOK.Text) < Val(ALFIAN_TXTJUM.Text) Then
                MsgBox("Stock Barang Tidak Cukup!!")
                ALFIAN_TXTJUM.Focus()
            Else
                ALFIAN_TBLTRANSAKSI.Rows.Add(New String() {ALFIAN_CMBKODEBRG.Text, LBNAMABRG.Text, LBHARGA.Text, ALFIAN_TXTJUM.Text, Val(LBHARGA.Text) * Val(ALFIAN_TXTJUM.Text), ALFIAN_CMBKODEPEG.Text, LBNAMAPEG.Text})
                Call RumusTotal()
                Call RumusCariItem()
                'Call Koneksi()
                'Dim SimpanTransaksi As String = "Insert into alfian_jual values ('" & ALFIAN_TXTKODETRAN.Text & "','" & ALFIAN_CMBKODEBRG.Text & "','" & LBNAMABRG.Text & "','" & LBHARGA.Text & "','" & ALFIAN_TXTJUM.Text & "')"
                'Cmd = New SqlCommand(SimpanTransaksi, Conn)
                'Cmd.ExecuteNonQuery()

                If MessageBox.Show("Apakah ingin menambah transaksi...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    ALFIAN_CMBKODEBRG.Focus()
                    ALFIAN_TXTKODETRAN.Enabled = False
                    ALFIAN_DTTGL.Enabled = False
                Else
                    ALFIAN_TXTPEM.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub ALFIAN_CMBKODEBRG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ALFIAN_CMBKODEBRG.SelectedIndexChanged
        Call Koneksi()
        Cmd = New SqlCommand("Select * from alfian_barang where alfian_kd_brg = '" & ALFIAN_CMBKODEBRG.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBNAMABRG.Text = Rd!alfian_mm_brg
            LBHARGA.Text = Rd!alfian_hrg_jual
            LBSTOK.Text = Rd!alfian_sisa
        End If

    End Sub

    Private Sub ALFIAN_CMBKODEPEG_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ALFIAN_CMBKODEPEG.SelectedIndexChanged
        Call Koneksi()
        Cmd = New SqlCommand("Select * from alfian_pegawai where alfian_kd_peg = '" & ALFIAN_CMBKODEPEG.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBNAMAPEG.Text = Rd!alfian_nm_peg
        End If

    End Sub

    Private Sub ALFIAN_TXTPEM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTPEM.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(ALFIAN_TXTPEM.Text) < Val(LBTOTAL.Text) Then
                MsgBox("Pembayaran tidak mencukupi !")
                ALFIAN_TXTPEM.Focus()
            ElseIf Val(ALFIAN_TXTPEM.Text) = Val(LBTOTAL.Text) Then
                LBKEMBALI.Text = 0
                ALFIAN_BTNSIMPAN.Focus()
            ElseIf Val(ALFIAN_TXTPEM.Text) > Val(LBTOTAL.Text) Then
                LBKEMBALI.Text = Val(ALFIAN_TXTPEM.Text) - Val(LBTOTAL.Text)
                ALFIAN_BTNSIMPAN.Focus()
            End If
        End If
    End Sub

    Private Sub ALFIAN_BTNSIMPAN_Click(sender As Object, e As EventArgs) Handles ALFIAN_BTNSIMPAN.Click
        If ALFIAN_CMBKODEBRG.Text = "" Or ALFIAN_TXTJUM.Text = "" Or ALFIAN_CMBKODEPEG.Text = "" Or ALFIAN_TXTPEM.Text = "" Or LBKEMBALI.Text = "" Then
            MsgBox("Transaksi tidak ada, Silahkan lakukan transaksi terlebih dahulu!")
        Else
            Call Koneksi()
            Cmd = New SqlCommand("Select * from alfian_penjualan where alfian_kd_trans = '" & ALFIAN_TXTKODETRAN.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MsgBox("The transaction code already exists!, you can't duplicate or create a new code")
                ALFIAN_TXTKODETRAN.Enabled = True
                ALFIAN_DTTGL.Enabled = True
                ALFIAN_TXTKODETRAN.Focus()
            Else
                Call Koneksi()
                TglTransaksi = Format(ALFIAN_DTTGL.Value, "yyyy-MM-dd")
                Dim SimpanTransaksi As String = "Insert into alfian_penjualan values ('" & ALFIAN_TXTKODETRAN.Text & "','" & TglTransaksi & "','" & LBITEM.Text & "','" & LBTOTAL.Text & "','" & ALFIAN_TXTPEM.Text & "','" & LBKEMBALI.Text & "','" & ALFIAN_CMBKODEPEG.Text & "')"
                Cmd = New SqlCommand(SimpanTransaksi, Conn)
                Cmd.ExecuteNonQuery()
                Call Koneksi()
                For Baris As Integer = 0 To ALFIAN_TBLTRANSAKSI.Rows.Count - 2
                    Dim SimpanJual As String = "Insert into alfian_jual values('" & ALFIAN_TXTKODETRAN.Text & "','" & ALFIAN_TBLTRANSAKSI.Rows(Baris).Cells(0).Value & "','" & ALFIAN_TBLTRANSAKSI.Rows(Baris).Cells(1).Value & "','" & ALFIAN_TBLTRANSAKSI.Rows(Baris).Cells(2).Value & "','" & ALFIAN_TBLTRANSAKSI.Rows(Baris).Cells(3).Value & "','" & ALFIAN_TBLTRANSAKSI.Rows(Baris).Cells(4).Value & "')"
                    Cmd = New SqlCommand(SimpanJual, Conn)
                    Cmd.ExecuteNonQuery()
                    Call Koneksi()
                    Cmd = New SqlCommand("Select * from alfian_barang where alfian_kd_brg ='" & ALFIAN_TBLTRANSAKSI.Rows(Baris).Cells(0).Value & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Rd.Read()
                    Call Koneksi()
                    Dim KurangiStok As String = "Update alfian_barang set alfian_sisa = '" & Rd.Item("alfian_sisa") - ALFIAN_TBLTRANSAKSI.Rows(Baris).Cells(3).Value & "' where alfian_kd_brg='" & ALFIAN_TBLTRANSAKSI.Rows(Baris).Cells(0).Value & "'"
                    Cmd = New SqlCommand(KurangiStok, Conn)
                    Cmd.ExecuteNonQuery()
                Next
                If MessageBox.Show("Apakah ingin cetak nota...?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    AxCrystalReport1.SelectionFormula = "totext({alfian_penjualan.alfian_kd_trans})='" & ALFIAN_TXTKODETRAN.Text & "'"
                    AxCrystalReport1.ReportFileName = "Notatransaksi.rpt"
                    AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
                    AxCrystalReport1.RetrieveDataFiles()
                    AxCrystalReport1.Action = 1
                    Call KondisiAwal()
                Else
                    Call KondisiAwal()
                    MessageBox.Show("Transaksi Telah Berhasil Disimpan")
                    ALFIAN_TXTKODETRAN.Enabled = True
                    ALFIAN_DTTGL.Enabled = True
                    ALFIAN_TXTKODETRAN.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub ALFIAN_TXTKODETRAN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTKODETRAN.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_DTTGL.Focus()
        End If
    End Sub

    Private Sub BTNRESET_Click(sender As Object, e As EventArgs) Handles BTNRESET.Click
        'Call Koneksi()
        'Dim HapusData As String = "Delete alfian_jual where alfian_kd_trans ='" & ALFIAN_TXTKODETRAN.Text & "'"
        'Cmd = New SqlCommand(HapusData, Conn)
        'Cmd.ExecuteNonQuery()
        Call KondisiAwal()
        ALFIAN_TXTKODETRAN.Enabled = True
        ALFIAN_DTTGL.Enabled = True
    End Sub

    Private Sub ALFIAN_DTTGL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_DTTGL.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_CMBKODEBRG.Focus()
        End If
    End Sub

    Private Sub ALFIAN_CMBKODEBRG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_CMBKODEBRG.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTJUM.Focus()
            If e.KeyChar = Chr(13) Then
                Call Koneksi()
                Cmd = New SqlCommand("Select * From alfian_barang Where alfian_kd_brg='" & ALFIAN_CMBKODEBRG.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    LBNAMABRG.Text = Rd.Item("alfian_mm_brg")
                    LBHARGA.Text = Rd.Item("alfian_hrg_jual")
                    LBSTOK.Text = Rd.Item("alfian_sisa")
                Else
                End If
            End If
        End If

    End Sub
    Private Sub ALFIAN_TXTJUM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTJUM.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_CMBKODEPEG.Focus()
        End If
    End Sub

    Private Sub ALFIAN_CMBKODEPEG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_CMBKODEPEG.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_BTNTAMBAH.Focus()
            If e.KeyChar = Chr(13) Then
                Call Koneksi()
                Cmd = New SqlCommand("Select * From alfian_pegawai Where alfian_kd_peg='" & ALFIAN_CMBKODEPEG.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    LBNAMAPEG.Text = Rd.Item("alfian_nm_peg")
                Else
                End If
            End If
        End If

    End Sub

    Private Sub ALFIAN_BTNTAMBAH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_BTNTAMBAH.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_CMBKODEBRG.Focus()
        End If
    End Sub

    Private Sub ALFIAN_BTNSIMPAN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_BTNSIMPAN.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTKODETRAN.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLJAM.Text = TimeOfDay
    End Sub

    Private Sub ALFIAN_TBLTRANSAKSI_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ALFIAN_TBLTRANSAKSI.CellMouseClick
        ALFIAN_CMBKODEBRG.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(0).Value
        LBNAMABRG.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(1).Value
        LBHARGA.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(2).Value
        ALFIAN_TXTJUM.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(3).Value
        LBTOTAL.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(4).Value
        ALFIAN_CMBKODEPEG.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(5).Value
        LBNAMAPEG.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(6).Value
    End Sub
End Class