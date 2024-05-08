Imports System.Data.SqlClient
Public Class FormRegister
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim Ds As DataSet
    Dim MyDB As String
    Sub Koneksi()
        MyDB = "Data Source=LAPTOP-BK925EA8\SQLTENYOM;Initial Catalog=db_toko_pbd_if21dx;Integrated Security=True"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Sub KondisiAwal()
        CMBKODE.Text = ""
        ALFIAN_TXTUSERNAME.Text = ""
        ALFIAN_TXTPASS.Text = ""
        CMBLEVEL.Items.Clear()
        CMBKODE.Enabled = False
        ALFIAN_TXTUSERNAME.Enabled = False
        ALFIAN_TXTPASS.Enabled = False
        CMBLEVEL.Enabled = False

        REGISTER.Enabled = True
        BTNEDIT.Enabled = True
        BTNCANCEL.Enabled = True
        BTNDELETE.Enabled = True

        REGISTER.Text = "Register"
        BTNEDIT.Text = "Edit"
        BTNCANCEL.Text = "Cancel"
        BTNDELETE.Text = "Delete"

        Call Koneksi()
        Da = New SqlDataAdapter("Select alfian_kd_peg, alfian_username, alfian_level From alfian_login", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "alfian_login")
        TBLAKUN.DataSource = Ds.Tables("alfian_login")
        TBLAKUN.ReadOnly = True

    End Sub
    Sub SiapInput()
        CMBKODE.Enabled = True
        ALFIAN_TXTUSERNAME.Enabled = True
        ALFIAN_TXTPASS.Enabled = True
        CMBLEVEL.Enabled = True
        CMBLEVEL.Items.Add("ADMIN")
        CMBLEVEL.Items.Add("USER")
    End Sub
    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet8.alfian_login' table. You can move, or remove it, as needed.
        Me.Alfian_loginTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet8.alfian_login)
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet2.alfian_pegawai' table. You can move, or remove it, as needed.
        Me.Alfian_pegawaiTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet2.alfian_pegawai)
        Call KondisiAwal()

        TBLAKUN.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        TBLAKUN.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 11, 54)
        TBLAKUN.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8.5, FontStyle.Bold)
        TBLAKUN.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        TBLAKUN.EnableHeadersVisualStyles = False

    End Sub

    Private Sub CMBKODE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CMBKODE.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * From alfian_pegawai Where alfian_kd_peg='" & CMBKODE.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MessageBox.Show("Kode Pegawai tidak terdaftar!", "Eror!")
                CMBKODE.Focus()

            Else
                CMBKODE.Text = Rd.Item("alfian_kd_peg")
                ALFIAN_TXTUSERNAME.Text = Rd.Item("alfian_nm_peg")
                ALFIAN_TXTPASS.Focus()
            End If
        End If
    End Sub

    Private Sub ALFIAN_TXTPASS_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTPASS.KeyPress
        If e.KeyChar = Chr(13) Then
            CMBLEVEL.Focus()
        End If
    End Sub
    Private Sub CMBLEVEL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CMBLEVEL.KeyPress
        If e.KeyChar = Chr(13) Then
            REGISTER.Focus()
        End If
    End Sub

    Private Sub TXTREGISTER_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TXTREGISTER.LinkClicked
        Me.Close()

    End Sub

    Private Sub REGISTER_Click(sender As Object, e As EventArgs) Handles REGISTER.Click
        If REGISTER.Text = "Register" Then
            REGISTER.Text = "SAVE"
            BTNEDIT.Enabled = False
            BTNDELETE.Enabled = False
            BTNCANCEL.Text = "CANCEL"
            Call SiapInput()
        Else
            If CMBKODE.Text = "" Or ALFIAN_TXTUSERNAME.Text = "" Or ALFIAN_TXTPASS.Text = "" Or CMBLEVEL.Text = "" Then
                MsgBox("Silahkan isi semua data dengan lengkap!")
            Else
                Call Koneksi()
                Cmd = New SqlCommand("Select * from alfian_login where alfian_kd_peg = '" & CMBKODE.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MsgBox("Akun Sudah Ada!, Silahkan Buat Yang Baru")
                    CMBKODE.Focus()
                Else
                    Call Koneksi()
                    Dim SimpanAkun As String = "Insert into alfian_login values('" & CMBKODE.Text & "','" & ALFIAN_TXTUSERNAME.Text & "','" & ALFIAN_TXTPASS.Text & "','" & CMBLEVEL.Text & "')"
                    Cmd = New SqlCommand(SimpanAkun, Conn)
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Akun Berhasil Dibuat", "Success")
                    Call KondisiAwal()
                End If
            End If
        End If
    End Sub
    Private Sub BTNEDIT_Click(sender As Object, e As EventArgs) Handles BTNEDIT.Click
        If BTNEDIT.Text = "Edit" Then
            BTNEDIT.Text = "SAVE"
            REGISTER.Enabled = False
            BTNDELETE.Enabled = False
            BTNCANCEL.Text = "CANCEL"
            Call SiapInput()
            CMBKODE.Enabled = False
        Else
            If CMBKODE.Text = "" Or ALFIAN_TXTUSERNAME.Text = "" Or ALFIAN_TXTPASS.Text = "" Or CMBLEVEL.Text = "" Then
                MsgBox("Silahkan isi semua data dengan lengkap!")
            Else
                Call Koneksi()
                Dim UpdateAkun As String = "Update alfian_login set alfian_username='" & ALFIAN_TXTUSERNAME.Text & "',alfian_kunci='" & ALFIAN_TXTPASS.Text & "',alfian_level='" & CMBLEVEL.Text & "' where alfian_kd_peg='" & CMBKODE.Text & "'"
                Cmd = New SqlCommand(UpdateAkun, Conn)
                Cmd.ExecuteNonQuery()
                MessageBox.Show("Akun Berhasil Diedit", "Success")
                Call KondisiAwal()
            End If
        End If
    End Sub
    Private Sub BTNDELETE_Click(sender As Object, e As EventArgs) Handles BTNDELETE.Click
        If BTNDELETE.Text = "Delete" Then
            BTNDELETE.Text = "DELETE"
            REGISTER.Enabled = False
            BTNEDIT.Enabled = False
            BTNCANCEL.Text = "CANCEL"
        Else
            If CMBKODE.Text = "" Or ALFIAN_TXTUSERNAME.Text = "" Then
                MsgBox("Pilih Akun yang ingin dihapus terlebih dahulu!")
            Else
                If MessageBox.Show("Apakah anda ingin menghapus Akun ini ?", "", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Call Koneksi()
                    Dim HapusAkun As String = "Delete alfian_login where alfian_kd_peg ='" & CMBKODE.Text & "'"
                    Cmd = New SqlCommand(HapusAkun, Conn)
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Akun berhasil di hapus", "Success")
                    Call KondisiAwal()
                Else
                End If
            End If
        End If
    End Sub

    Private Sub TBLAKUN_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles TBLAKUN.CellMouseClick
        CMBKODE.Text = TBLAKUN.Rows(e.RowIndex).Cells(0).Value
        ALFIAN_TXTUSERNAME.Text = TBLAKUN.Rows(e.RowIndex).Cells(1).Value
        'ALFIAN_TXTPASS.Text = TBLAKUN.Rows(e.RowIndex).Cells(2).Value
        CMBLEVEL.Text = TBLAKUN.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click
        Call KondisiAwal()
    End Sub
End Class