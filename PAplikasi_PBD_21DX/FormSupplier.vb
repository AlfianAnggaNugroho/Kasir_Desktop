Imports System.Data.SqlClient
Public Class FormSupplier
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
        ALFIAN_TXTKODESUP.Text = ""
        ALFIAN_TXTNAMAPER.Text = ""
        ALFIAN_TXTPEN.Text = ""
        ALFIAN_TXTNOTELP.Text = ""
        ALFIAN_TXTEMAIL.Text = ""
        ALFIAN_TXTALAMAT.Text = ""
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from alfian_supplier", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "alfian_supplier")
        ALFIAN_TBLSUP.DataSource = (Ds.Tables("alfian_supplier"))
        Call ResetData()

        ALFIAN_TXTKODESUP.MaxLength = 10
        ALFIAN_TXTNAMAPER.MaxLength = 20
        ALFIAN_TXTPEN.MaxLength = 20
        ALFIAN_TXTNOTELP.MaxLength = 15
        ALFIAN_TXTEMAIL.MaxLength = 20
        ALFIAN_TXTALAMAT.MaxLength = 50

        ALFIAN_BTNADD.Text = "Tambah"
        ALFIAN_BTNEDIT.Text = "Edit"
        ALFIAN_BTNHAPUS.Text = "Hapus"
        ALFIAN_BTNEXIT.Text = "Back"
        ALFIAN_BTNADD.Enabled = True
        ALFIAN_BTNEDIT.Enabled = True
        ALFIAN_BTNHAPUS.Enabled = True
        ALFIAN_BTNEXIT.Enabled = True

        ALFIAN_TXTKODESUP.Enabled = False
        ALFIAN_TXTNAMAPER.Enabled = False
        ALFIAN_TXTPEN.Enabled = False
        ALFIAN_TXTNOTELP.Enabled = False
        ALFIAN_TXTEMAIL.Enabled = False
        ALFIAN_TXTALAMAT.Enabled = False
    End Sub

    Sub SiapInput()
        ALFIAN_TXTKODESUP.Enabled = True
        ALFIAN_TXTKODESUP.Focus()
        ALFIAN_TXTNAMAPER.Enabled = True
        ALFIAN_TXTPEN.Enabled = True
        ALFIAN_TXTNOTELP.Enabled = True
        ALFIAN_TXTEMAIL.Enabled = True
        ALFIAN_TXTALAMAT.Enabled = True
    End Sub
    Private Sub FormSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet3.alfian_supplier' table. You can move, or remove it, as needed.
        Me.Alfian_supplierTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet3.alfian_supplier)
        Call KondisiAwal()

        ALFIAN_TBLSUP.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        ALFIAN_TBLSUP.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 11, 54)
        ALFIAN_TBLSUP.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8, FontStyle.Bold)

        ALFIAN_TBLSUP.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        ALFIAN_TBLSUP.EnableHeadersVisualStyles = False

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
            If ALFIAN_TXTKODESUP.Text = "" Or ALFIAN_TXTNAMAPER.Text = "" Or ALFIAN_TXTPEN.Text = "" Or ALFIAN_TXTNOTELP.Text = "" Or ALFIAN_TXTEMAIL.Text = "" Or ALFIAN_TXTALAMAT.Text = "" Then
                MessageBox.Show("Upss! Isi data dengan lengkap", "Warning !")
            Else
                Call Koneksi()
                Cmd = New SqlCommand("Select * from alfian_supplier where alfian_kd_sup = '" & ALFIAN_TXTKODESUP.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MsgBox("The Item code already exists!, you can't duplicate or create a new code")
                    ALFIAN_TXTKODESUP.Focus()
                Else
                    Call Koneksi()
                    Dim InputData As String = "insert into alfian_supplier values ('" & ALFIAN_TXTKODESUP.Text & "','" & ALFIAN_TXTNAMAPER.Text & "','" & ALFIAN_TXTPEN.Text & "','" & ALFIAN_TXTNOTELP.Text & "','" & ALFIAN_TXTEMAIL.Text & "','" & ALFIAN_TXTALAMAT.Text & "')"
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
            ALFIAN_TXTKODESUP.Enabled = False
            ALFIAN_TXTNAMAPER.Focus()
        Else

            If ALFIAN_TXTKODESUP.Text = "" Or ALFIAN_TXTNAMAPER.Text = "" Or ALFIAN_TXTPEN.Text = "" Or ALFIAN_TXTNOTELP.Text = "" Or ALFIAN_TXTEMAIL.Text = "" Or ALFIAN_TXTALAMAT.Text = "" Then
                MessageBox.Show("Upss! Isi data dengan lengkap", "Warning !")
            Else
                Call Koneksi()
                Dim EditData As String = "update alfian_supplier set alfian_nm_per='" & ALFIAN_TXTNAMAPER.Text & "',alfian_nm_pen='" & ALFIAN_TXTPEN.Text & "',alfian_no_telp='" & ALFIAN_TXTNOTELP.Text & "',alfian_email='" & ALFIAN_TXTEMAIL.Text & "',alfian_alamat='" & ALFIAN_TXTALAMAT.Text & "'where alfian_kd_sup='" & ALFIAN_TXTKODESUP.Text & "'"
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
            Dim HapusData As String = "Delete alfian_supplier where alfian_kd_sup='" & ALFIAN_TXTKODESUP.Text & "'"
            Cmd = New SqlCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil di hapus", "Success")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub TXTKODESUP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTKODESUP.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTNAMAPER.Focus()
            If e.KeyChar = Chr(13) Then
                Call Koneksi()
                Cmd = New SqlCommand("Select * From alfian_supplier Where alfian_kd_sup='" & ALFIAN_TXTKODESUP.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    ALFIAN_TXTNAMAPER.Text = Rd.Item("alfian_nm_per")
                    ALFIAN_TXTPEN.Text = Rd.Item("alfian_nm_pen")
                    ALFIAN_TXTNOTELP.Text = Rd.Item("alfian_no_telp")
                    ALFIAN_TXTEMAIL.Text = Rd.Item("alfian_email")
                    ALFIAN_TXTALAMAT.Text = Rd.Item("alfian_alamat")

                Else
                End If
            End If
        End If
    End Sub

    Private Sub ALFIAN_TBLSUP_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ALFIAN_TBLSUP.CellMouseClick
        ALFIAN_TXTKODESUP.Text = ALFIAN_TBLSUP.Rows(e.RowIndex).Cells(0).Value
        ALFIAN_TXTNAMAPER.Text = ALFIAN_TBLSUP.Rows(e.RowIndex).Cells(1).Value
        ALFIAN_TXTPEN.Text = ALFIAN_TBLSUP.Rows(e.RowIndex).Cells(2).Value
        ALFIAN_TXTNOTELP.Text = ALFIAN_TBLSUP.Rows(e.RowIndex).Cells(3).Value
        ALFIAN_TXTEMAIL.Text = ALFIAN_TBLSUP.Rows(e.RowIndex).Cells(4).Value
        ALFIAN_TXTALAMAT.Text = ALFIAN_TBLSUP.Rows(e.RowIndex).Cells(5).Value
    End Sub
    Private Sub TXTCARI_TextChanged(sender As Object, e As EventArgs) Handles ALFIAN_TXTCARI.TextChanged
        If ALFIAN_CMBCARI.SelectedIndex = 0 Then
            Da = New SqlDataAdapter("Select * From alfian_supplier Where alfian_kd_sup like '" & ALFIAN_TXTCARI.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            ALFIAN_TBLSUP.DataSource = Ds.Tables(0)
        Else
            Da = New SqlDataAdapter("Select * From alfian_supplier Where alfian_nm_per like '" & ALFIAN_TXTCARI.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            ALFIAN_TBLSUP.DataSource = Ds.Tables(0)

        End If
    End Sub

    Private Sub TXTNOTELP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTNOTELP.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTEMAIL.Focus()

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TXTNAMAPER_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTNAMAPER.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTPEN.Focus()

        End If
    End Sub

    Private Sub TXTPEN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTPEN.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTNOTELP.Focus()

        End If
    End Sub

    Private Sub TXTEMAIL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTEMAIL.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTALAMAT.Focus()

        End If
    End Sub

End Class