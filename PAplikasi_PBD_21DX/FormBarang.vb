Imports System.Data.SqlClient
Public Class FormBarang
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
        ALFIAN_TXTNAMA.Text = ""
        ALFIAN_TXTDISKON.Text = ""
        ALFIAN_TXTHARGA.Text = ""
        ALFIAN_TXTJUM.Text = ""
        ALFIAN_TXTRUSAK.Text = ""
        ALFIAN_TXTSISA.Text = ""
    End Sub
    Sub KondisiAwal()
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from alfian_barang", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "alfian_barang")
        ALFIAN_TBLBRG.DataSource = (Ds.Tables("alfian_barang"))
        Call ResetData()

        ALFIAN_TXTBARANG.MaxLength = 10
        ALFIAN_TXTNAMA.MaxLength = 20
        ALFIAN_TXTDISKON.MaxLength = 50
        ALFIAN_TXTHARGA.MaxLength = 50
        ALFIAN_TXTJUM.MaxLength = 50
        ALFIAN_TXTRUSAK.MaxLength = 50
        ALFIAN_TXTSISA.MaxLength = 50

        ALFIAN_BTNADD.Text = "Tambah"
        ALFIAN_BTNEDIT.Text = "Edit"
        ALFIAN_BTNHAPUS.Text = "Hapus"
        ALFIAN_BTNEXIT.Text = "Back"
        ALFIAN_BTNADD.Enabled = True
        ALFIAN_BTNEDIT.Enabled = True
        ALFIAN_BTNHAPUS.Enabled = True
        ALFIAN_BTNEXIT.Enabled = True

        ALFIAN_TXTBARANG.Enabled = False
        ALFIAN_TXTNAMA.Enabled = False
        ALFIAN_TXTDISKON.Enabled = False
        ALFIAN_TXTHARGA.Enabled = False
        ALFIAN_TXTJUM.Enabled = False
        ALFIAN_TXTRUSAK.Enabled = False
        ALFIAN_TXTSISA.Enabled = False

    End Sub
    Sub SiapInput()
        ALFIAN_TXTBARANG.Enabled = True
        ALFIAN_TXTBARANG.Focus()
        ALFIAN_TXTNAMA.Enabled = True
        ALFIAN_TXTDISKON.Enabled = True
        ALFIAN_TXTHARGA.Enabled = True
        ALFIAN_TXTJUM.Enabled = True
        ALFIAN_TXTRUSAK.Enabled = True
        ALFIAN_TXTSISA.Enabled = True
    End Sub
    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet1.alfian_barang' table. You can move, or remove it, as needed.
        Me.Alfian_barangTableAdapter1.Fill(Me.Db_toko_pbd_if21dxDataSet1.alfian_barang)
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet.alfian_barang' table. You can move, or remove it, as needed.
        Me.Alfian_barangTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet.alfian_barang)
        Call KondisiAwal()
        ALFIAN_TBLBRG.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        ALFIAN_TBLBRG.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 11, 54)
        ALFIAN_TBLBRG.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8.5, FontStyle.Bold)
        ALFIAN_TBLBRG.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        ALFIAN_TBLBRG.EnableHeadersVisualStyles = False

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
        If ALFIAN_BTNADD.Text = "Tambah" Then
            ALFIAN_BTNADD.Text = "SIMPAN"
            ALFIAN_BTNEDIT.Enabled = False
            ALFIAN_BTNHAPUS.Enabled = False
            ALFIAN_BTNEXIT.Text = "CANCEL"
            Call SiapInput()
        Else
            If ALFIAN_TXTBARANG.Text = "" Or ALFIAN_TXTNAMA.Text = "" Or ALFIAN_TXTDISKON.Text = "" Or ALFIAN_TXTHARGA.Text = "" Or ALFIAN_TXTJUM.Text = "" Or ALFIAN_TXTRUSAK.Text = "" Or ALFIAN_TXTSISA.Text = "" Then
                MessageBox.Show("Upss! Isi data dengan lengkap", "Warning !")
            Else
                Call Koneksi()
                Cmd = New SqlCommand("Select * from alfian_barang where alfian_kd_brg = '" & ALFIAN_TXTBARANG.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MessageBox.Show("The Item code already exists!, you can't duplicate or create a new code", "Warning!")
                    ALFIAN_TXTBARANG.Focus()
                Else
                    Call Koneksi()
                    Dim InputData As String = "insert into alfian_barang values ('" & ALFIAN_TXTBARANG.Text & "','" & ALFIAN_TXTNAMA.Text & "','" & ALFIAN_TXTDISKON.Text & "','" & ALFIAN_TXTHARGA.Text & "','" & ALFIAN_TXTJUM.Text & "','" & ALFIAN_TXTRUSAK.Text & "','" & ALFIAN_TXTSISA.Text & "')"
                    Cmd = New SqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil di input", "Success")
                    Call KondisiAwal()
                End If
            End If
        End If
    End Sub

    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles ALFIAN_BTNEDIT.Click
        If ALFIAN_BTNEDIT.Text = "Edit" Then
            ALFIAN_BTNEDIT.Text = "SIMPAN"
            ALFIAN_BTNADD.Enabled = False
            ALFIAN_BTNHAPUS.Enabled = False
            ALFIAN_BTNEXIT.Text = "CANCEL"
            Call SiapInput()
            ALFIAN_TXTBARANG.Enabled = False
            ALFIAN_TXTNAMA.Focus()
        Else

            If ALFIAN_TXTBARANG.Text = "" Or ALFIAN_TXTNAMA.Text = "" Or ALFIAN_TXTDISKON.Text = "" Or ALFIAN_TXTHARGA.Text = "" Or ALFIAN_TXTJUM.Text = "" Or ALFIAN_TXTRUSAK.Text = "" Or ALFIAN_TXTSISA.Text = "" Then
                MessageBox.Show("Upss! Isi data dengan lengkap", "Warning !")
            Else
                Call Koneksi()
                Dim EditData As String = "update alfian_barang set alfian_mm_brg='" & ALFIAN_TXTNAMA.Text & "',alfian_diskon='" & ALFIAN_TXTDISKON.Text & "',alfian_hrg_jual='" & ALFIAN_TXTHARGA.Text & "',alfian_jumlah='" & ALFIAN_TXTJUM.Text & "',alfian_rusak='" & ALFIAN_TXTRUSAK.Text & "',alfian_sisa='" & ALFIAN_TXTSISA.Text & "'where alfian_kd_brg='" & ALFIAN_TXTBARANG.Text & "'"
                Cmd = New SqlCommand(EditData, Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Data berhasil di edit", "Success")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub BTNHAPUS_Click(sender As Object, e As EventArgs) Handles ALFIAN_BTNHAPUS.Click
        If ALFIAN_BTNHAPUS.Text = "Hapus" Then
            ALFIAN_BTNHAPUS.Text = "HAPUS"
            ALFIAN_BTNADD.Enabled = False
            ALFIAN_BTNEDIT.Enabled = False
            ALFIAN_BTNEXIT.Text = "CANCEL"
            Call SiapInput()
        Else
            Call Koneksi()
            Dim HapusData As String = "Delete alfian_barang where alfian_kd_brg ='" & ALFIAN_TXTBARANG.Text & "'"
            Cmd = New SqlCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil di hapus", "Success")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub TXTBARANG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTBARANG.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTNAMA.Focus()
            If e.KeyChar = Chr(13) Then
                Call Koneksi()
                Cmd = New SqlCommand("Select * From alfian_barang Where alfian_kd_brg='" & ALFIAN_TXTBARANG.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    ALFIAN_TXTNAMA.Text = Rd.Item("alfian_mm_brg")
                    ALFIAN_TXTDISKON.Text = Rd.Item("alfian_diskon")
                    ALFIAN_TXTHARGA.Text = Rd.Item("alfian_hrg_jual")
                    ALFIAN_TXTJUM.Text = Rd.Item("alfian_jumlah")
                    ALFIAN_TXTRUSAK.Text = Rd.Item("alfian_rusak")
                    ALFIAN_TXTSISA.Text = Rd.Item("alfian_sisa")
                Else
                End If
            End If
        End If
    End Sub

    Private Sub ALFIAN_TBLBRG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ALFIAN_TBLBRG.CellMouseClick
        ALFIAN_TXTBARANG.Text = ALFIAN_TBLBRG.Rows(e.RowIndex).Cells(0).Value
        ALFIAN_TXTNAMA.Text = ALFIAN_TBLBRG.Rows(e.RowIndex).Cells(1).Value
        ALFIAN_TXTDISKON.Text = ALFIAN_TBLBRG.Rows(e.RowIndex).Cells(2).Value
        ALFIAN_TXTHARGA.Text = ALFIAN_TBLBRG.Rows(e.RowIndex).Cells(3).Value
        ALFIAN_TXTJUM.Text = ALFIAN_TBLBRG.Rows(e.RowIndex).Cells(4).Value
        ALFIAN_TXTRUSAK.Text = ALFIAN_TBLBRG.Rows(e.RowIndex).Cells(5).Value
        ALFIAN_TXTSISA.Text = ALFIAN_TBLBRG.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub TXTCARI_TextChanged_1(sender As Object, e As EventArgs) Handles ALFIAN_TXTCARI.TextChanged
        If ALFIAN_CMBCARI.SelectedIndex = 0 Then
            Da = New SqlDataAdapter("Select * From alfian_barang Where alfian_kd_brg like '" & ALFIAN_TXTCARI.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            ALFIAN_TBLBRG.DataSource = Ds.Tables(0)
        Else
            Da = New SqlDataAdapter("Select * From alfian_barang Where alfian_mm_brg like '" & ALFIAN_TXTCARI.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            ALFIAN_TBLBRG.DataSource = Ds.Tables(0)

        End If

    End Sub

    Private Sub TXTHARGA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTHARGA.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTJUM.Focus()

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Private Sub TXTNAMA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTNAMA.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTDISKON.Focus()

        End If
    End Sub

    Private Sub TXTDISKON_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTDISKON.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTHARGA.Focus()

        End If
    End Sub

    Private Sub TXTJUM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTJUM.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTRUSAK.Focus()

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TXTRUSAK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTRUSAK.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTSISA.Focus()

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TXTSISA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTSISA.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_BTNADD.Focus()

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then e.Handled = True
    End Sub
End Class