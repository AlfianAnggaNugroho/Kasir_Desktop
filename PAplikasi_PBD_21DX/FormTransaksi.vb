Imports System.Data.SqlClient
Public Class FormTransaksi
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
    Sub ResetData()
        ALFIAN_TXTKODETRAN.Text = ""
        ALFIAN_CMBKODESUP.Text = ""
        ALFIAN_CMBKODEBRG.Text = ""
        ALFIAN_TXTJUMBELI.Text = ""
        ALFIAN_TXTHARGABELI.Text = ""
    End Sub
    Sub KondisiAwal()
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from alfian_transaksi", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "alfian_transaksi")
        ALFIAN_TBLTRANSAKSI.DataSource = (Ds.Tables("alfian_transaksi"))
        Call ResetData()

        ALFIAN_TXTKODETRAN.MaxLength = 10

        ALFIAN_BTNADD.Text = "Add Data"
        ALFIAN_BTNEDIT.Text = "Edit"
        ALFIAN_BTNHAPUS.Text = "Delete"
        ALFIAN_BTNEXIT.Text = "Back"
        ALFIAN_BTNADD.Enabled = True
        ALFIAN_BTNEDIT.Enabled = True
        ALFIAN_BTNHAPUS.Enabled = True
        ALFIAN_BTNEXIT.Enabled = True

        ALFIAN_TXTKODETRAN.Enabled = False
        ALFIAN_DTTGL.Enabled = False
        ALFIAN_CMBKODESUP.Enabled = False
        ALFIAN_CMBKODEBRG.Enabled = False
        ALFIAN_TXTJUMBELI.Enabled = False
        ALFIAN_TXTHARGABELI.Enabled = False
    End Sub
    Sub SiapInput()
        ALFIAN_TXTKODETRAN.Enabled = True
        ALFIAN_TXTKODETRAN.Focus()
        ALFIAN_DTTGL.Enabled = True
        ALFIAN_CMBKODESUP.Enabled = True
        ALFIAN_CMBKODEBRG.Enabled = True
        ALFIAN_TXTJUMBELI.Enabled = True
        ALFIAN_TXTHARGABELI.Enabled = True
    End Sub
    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet1.alfian_barang' table. You can move, or remove it, as needed.
        Me.Alfian_barangTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet1.alfian_barang)
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet3.alfian_supplier' table. You can move, or remove it, as needed.
        Me.Alfian_supplierTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet3.alfian_supplier)
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet5.alfian_transaksi' table. You can move, or remove it, as needed.
        Me.Alfian_transaksiTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet5.alfian_transaksi)
        Call KondisiAwal()

        ALFIAN_TBLTRANSAKSI.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        ALFIAN_TBLTRANSAKSI.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 11, 54)
        ALFIAN_TBLTRANSAKSI.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)

        ALFIAN_TBLTRANSAKSI.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        ALFIAN_TBLTRANSAKSI.EnableHeadersVisualStyles = False
    End Sub

    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles ALFIAN_BTNEXIT.Click
        If ALFIAN_BTNEXIT.Text = "Back" Then
            Me.Close()
            FormDashboard.SwitchPanel(FormChart)
        Else
            Call KondisiAwal()
            ALFIAN_BTNADD.Focus()
        End If
    End Sub
    Private Sub BTNADD_Click(sender As Object, e As EventArgs) Handles ALFIAN_BTNADD.Click
        If ALFIAN_BTNADD.Text = "Add Data" Then
            ALFIAN_BTNADD.Text = "SAVE"
            ALFIAN_BTNEDIT.Enabled = False
            ALFIAN_BTNHAPUS.Enabled = False
            ALFIAN_BTNEXIT.Text = "CANCEL"
            Call SiapInput()
        Else
            Dim TglTransaksi As String
            TglTransaksi = Format(ALFIAN_DTTGL.Value, "yyyy-MM-dd")
            If ALFIAN_TXTKODETRAN.Text = "" Or TglTransaksi = "" Or ALFIAN_CMBKODESUP.Text = "" Or ALFIAN_CMBKODEBRG.Text = "" Or ALFIAN_TXTJUMBELI.Text = "" Or ALFIAN_TXTHARGABELI.Text = "" Then
                MessageBox.Show("Upss! Isi data dengan lengkap", "Warning !")
            Else
                Call Koneksi()
                Cmd = New SqlCommand("Select * from alfian_transaksi where alfian_kd_beli = '" & ALFIAN_TXTKODETRAN.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MsgBox("The Item code already exists!, you can't duplicate or create a new code")
                    ALFIAN_TXTKODETRAN.Focus()
                Else
                    Call Koneksi()
                    Dim InputData As String = "insert into alfian_transaksi values ('" & ALFIAN_TXTKODETRAN.Text & "','" & TglTransaksi & "','" & ALFIAN_CMBKODESUP.Text & "','" & ALFIAN_CMBKODEBRG.Text & "','" & ALFIAN_TXTJUMBELI.Text & "','" & ALFIAN_TXTHARGABELI.Text & "')"
                    Cmd = New SqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil di input", "Success")
                    Call Koneksi()
                    Cmd = New SqlCommand("Select * from alfian_barang where alfian_kd_brg ='" & ALFIAN_CMBKODEBRG.Text & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Rd.Read()
                    Call Koneksi()
                    Dim TambahStok As String = "Update alfian_barang set alfian_jumlah = '" & Rd.Item("alfian_jumlah") + Val(ALFIAN_TXTJUMBELI.Text) & "',alfian_sisa = '" & Rd.Item("alfian_sisa") + Val(ALFIAN_TXTJUMBELI.Text) & "' where alfian_kd_brg='" & ALFIAN_CMBKODEBRG.Text & "'"
                    Cmd = New SqlCommand(TambahStok, Conn)
                    Cmd.ExecuteNonQuery()
                    Call KondisiAwal()
                End If
            End If
        End If
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles ALFIAN_BTNEDIT.Click
        If ALFIAN_BTNEDIT.Text = "Edit" Then
            ALFIAN_BTNEDIT.Text = "SAVE"
            ALFIAN_BTNADD.Enabled = False
            ALFIAN_BTNHAPUS.Enabled = False
            ALFIAN_BTNEXIT.Text = "CANCEL"
            Call SiapInput()
            ALFIAN_TXTKODETRAN.Enabled = False
            ALFIAN_DTTGL.Focus()
        Else
            Dim TglTransaksi As String
            TglTransaksi = Format(ALFIAN_DTTGL.Value, "yyyy-MM-dd")
            If ALFIAN_TXTKODETRAN.Text = "" Or TglTransaksi = "" Or ALFIAN_CMBKODESUP.Text = "" Or ALFIAN_CMBKODEBRG.Text = "" Or ALFIAN_TXTJUMBELI.Text = "" Or ALFIAN_TXTHARGABELI.Text = "" Then
                MessageBox.Show("Upss! Isi data dengan lengkap", "Warning !")
            Else
                Call Koneksi()
                Dim EditDataPeg As String = "update alfian_transaksi set alfian_tgl_beli='" & TglTransaksi & "',alfian_kd_sup='" & ALFIAN_CMBKODESUP.Text & "',alfian_kd_brg='" & ALFIAN_CMBKODEBRG.Text & "',alfian_jum_beli='" & ALFIAN_TXTJUMBELI.Text & "',alfian_hrg_beli='" & ALFIAN_TXTHARGABELI.Text & "' where alfian_kd_beli='" & ALFIAN_TXTKODETRAN.Text & "'"
                Cmd = New SqlCommand(EditDataPeg, Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil di edit", "Success")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub BTNHAPUS_Click(sender As Object, e As EventArgs) Handles ALFIAN_BTNHAPUS.Click
        If ALFIAN_BTNHAPUS.Text = "Delete" Then
            ALFIAN_BTNHAPUS.Text = "DELETE"
            ALFIAN_BTNADD.Enabled = False
            ALFIAN_BTNEDIT.Enabled = False
            ALFIAN_BTNEXIT.Text = "CANCEL"
            Call SiapInput()
        Else
            Call Koneksi()
            Dim HapusData As String = "Delete alfian_transaksi where alfian_kd_beli='" & ALFIAN_TXTKODETRAN.Text & "'"
            Cmd = New SqlCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil di hapus", "Success")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub TXTKODETRAN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTKODETRAN.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_DTTGL.Focus()
            If e.KeyChar = Chr(13) Then
                Call Koneksi()
                Cmd = New SqlCommand("Select * From alfian_transaksi Where alfian_kd_beli='" & ALFIAN_TXTKODETRAN.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    ALFIAN_DTTGL.Value = Rd.Item("alfian_tgl_beli")
                    ALFIAN_CMBKODESUP.Text = Rd.Item("alfian_kd_sup")
                    ALFIAN_CMBKODEBRG.Text = Rd.Item("alfian_kd_brg")
                    ALFIAN_TXTJUMBELI.Text = Rd.Item("alfian_jum_beli")
                    ALFIAN_TXTHARGABELI.Text = Rd.Item("alfian_hrg_beli")
                Else
                End If
            End If
        End If
    End Sub

    Private Sub ALFIAN_TBLTRANSAKSI_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ALFIAN_TBLTRANSAKSI.CellMouseClick
        ALFIAN_TXTKODETRAN.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(0).Value
        ALFIAN_DTTGL.Value = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(1).Value
        ALFIAN_CMBKODESUP.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(2).Value
        ALFIAN_CMBKODEBRG.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(3).Value
        ALFIAN_TXTJUMBELI.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(4).Value
        ALFIAN_TXTHARGABELI.Text = ALFIAN_TBLTRANSAKSI.Rows(e.RowIndex).Cells(5).Value
    End Sub
    Private Sub TXTCARI_TextChanged(sender As Object, e As EventArgs) Handles ALFIAN_TXTCARI.TextChanged
        If ALFIAN_CMBCARI.SelectedIndex = 0 Then
            Da = New SqlDataAdapter("Select * From alfian_transaksi Where alfian_kd_beli like '" & ALFIAN_TXTCARI.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            ALFIAN_TBLTRANSAKSI.DataSource = Ds.Tables(0)
        Else
            Da = New SqlDataAdapter("Select * From alfian_transaksi Where alfian_tgl_beli like '" & ALFIAN_TXTCARI.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            ALFIAN_TBLTRANSAKSI.DataSource = Ds.Tables(0)

        End If
    End Sub

    Private Sub TXTJUMBELI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTJUMBELI.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTHARGABELI.Focus()

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TXTHARGABELI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTHARGABELI.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_BTNADD.Focus()

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub DTTGL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_DTTGL.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_CMBKODESUP.Focus()

        End If
    End Sub

    Private Sub CMBKODESUP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_CMBKODESUP.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_CMBKODEBRG.Focus()

        End If
    End Sub

    Private Sub CMBKODEBRG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_CMBKODEBRG.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTJUMBELI.Focus()
            If e.KeyChar = Chr(13) Then
                Call Koneksi()
                Cmd = New SqlCommand("Select * From alfian_barang Where alfian_kd_brg='" & ALFIAN_CMBKODEBRG.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    ALFIAN_TXTHARGABELI.Text = Rd.Item("alfian_hrg_jual")
                Else
                End If
            End If

        End If
    End Sub

    'Private Sub TXTHARGABELI_TextChanged(sender As Object, e As EventArgs) Handles ALFIAN_TXTHARGABELI.TextChanged
    '    Try
    '        If ALFIAN_TXTHARGABELI.Text.Trim() <> "" Then
    '            ALFIAN_TXTHARGABELI.Text = CDec(ALFIAN_TXTHARGABELI.Text).ToString("N0")
    '            ALFIAN_TXTHARGABELI.SelectionStart = ALFIAN_TXTHARGABELI.TextLength
    '        End If
    '    Catch ex As Exception
    '        ALFIAN_TXTHARGABELI.Text = 0
    '    End Try
    'End Sub


End Class