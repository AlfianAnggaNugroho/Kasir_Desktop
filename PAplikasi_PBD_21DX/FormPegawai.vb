Imports System.Data.SqlClient
Public Class FormPegawai
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
        ALFIAN_TXTKODEPEG.Text = ""
        ALFIAN_TXTNAMAPEG.Text = ""
        ALFIAN_TXTTEMPAT.Text = ""
        ALFIAN_CMBPENDIDIKAN.Text = ""
        ALFIAN_CMBJABATAN.Text = ""
        ALFIAN_TXTNOTELP.Text = ""
        ALFIAN_TXTALAMAT.Text = ""
    End Sub
    Sub KondisiAwal()
        Call Koneksi()
        Da = New SqlDataAdapter("Select * from alfian_pegawai", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "alfian_pegawai")
        ALFIAN_TBLPEGAWAI.DataSource = (Ds.Tables("alfian_pegawai"))
        Call ResetData()

        ALFIAN_CMBPENDIDIKAN.Items.Clear()
        ALFIAN_CMBPENDIDIKAN.Items.Add("SD")
        ALFIAN_CMBPENDIDIKAN.Items.Add("SMP")
        ALFIAN_CMBPENDIDIKAN.Items.Add("SMA/SMK")
        ALFIAN_CMBPENDIDIKAN.Items.Add("S1")
        ALFIAN_CMBPENDIDIKAN.Items.Add("S2")
        ALFIAN_CMBPENDIDIKAN.Items.Add("S3")
        ALFIAN_CMBPENDIDIKAN.Items.Add("D3")

        ALFIAN_CMBJABATAN.Items.Clear()
        ALFIAN_CMBJABATAN.Items.Add("Kasir")
        ALFIAN_CMBJABATAN.Items.Add("Kepala Toko")
        ALFIAN_CMBJABATAN.Items.Add("Programmer")
        ALFIAN_CMBJABATAN.Items.Add("Administrator")
        ALFIAN_CMBJABATAN.Items.Add("Manager")

        ALFIAN_TXTKODEPEG.MaxLength = 10
        ALFIAN_TXTNAMAPEG.MaxLength = 30
        ALFIAN_TXTTEMPAT.MaxLength = 20
        ALFIAN_TXTNOTELP.MaxLength = 15
        ALFIAN_TXTALAMAT.MaxLength = 30

        ALFIAN_BTNADD.Text = "Add Data"
        ALFIAN_BTNEDIT.Text = "Edit"
        ALFIAN_BTNHAPUS.Text = "Hapus"
        ALFIAN_BTNEXIT.Text = "Back"
        ALFIAN_BTNADD.Enabled = True
        ALFIAN_BTNEDIT.Enabled = True
        ALFIAN_BTNHAPUS.Enabled = True
        ALFIAN_BTNEXIT.Enabled = True

        ALFIAN_TXTKODEPEG.Enabled = False
        ALFIAN_TXTNAMAPEG.Enabled = False
        ALFIAN_TXTTEMPAT.Enabled = False
        ALFIAN_DTTANGGAL.Enabled = False
        ALFIAN_CMBPENDIDIKAN.Enabled = False
        ALFIAN_CMBJABATAN.Enabled = False
        ALFIAN_TXTNOTELP.Enabled = False
        ALFIAN_TXTALAMAT.Enabled = False
    End Sub

    Sub SiapInput()
        ALFIAN_TXTKODEPEG.Enabled = True
        ALFIAN_TXTKODEPEG.Focus()
        ALFIAN_TXTNAMAPEG.Enabled = True
        ALFIAN_TXTTEMPAT.Enabled = True
        ALFIAN_DTTANGGAL.Enabled = True
        ALFIAN_CMBPENDIDIKAN.Enabled = True
        ALFIAN_CMBJABATAN.Enabled = True
        ALFIAN_TXTNOTELP.Enabled = True
        ALFIAN_TXTALAMAT.Enabled = True
    End Sub
    Private Sub FormPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db_toko_pbd_if21dxDataSet4.alfian_pegawai' table. You can move, or remove it, as needed.
        Me.Alfian_pegawaiTableAdapter.Fill(Me.Db_toko_pbd_if21dxDataSet4.alfian_pegawai)
        Call KondisiAwal()
        ALFIAN_TBLPEGAWAI.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        ALFIAN_TBLPEGAWAI.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(204, 11, 54)
        ALFIAN_TBLPEGAWAI.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 8.5, FontStyle.Bold)
        ALFIAN_TBLPEGAWAI.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        ALFIAN_TBLPEGAWAI.EnableHeadersVisualStyles = False

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
            Dim TanggalLahir As String
            TanggalLahir = Format(ALFIAN_DTTANGGAL.Value, "yyyy-MM-dd")
            If ALFIAN_TXTKODEPEG.Text = "" Or ALFIAN_TXTNAMAPEG.Text = "" Or ALFIAN_TXTTEMPAT.Text = "" Or TanggalLahir = "" Or ALFIAN_CMBPENDIDIKAN.Text = "" Or ALFIAN_CMBJABATAN.Text = "" Or ALFIAN_TXTNOTELP.Text = "" Or ALFIAN_TXTALAMAT.Text = "" Then
                MessageBox.Show("Upss! Isi data dengan lengkap", "Warning !")
            Else
                Call Koneksi()
                Cmd = New SqlCommand("Select * from alfian_pegawai where alfian_kd_peg = '" & ALFIAN_TXTKODEPEG.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    MsgBox("The Item code already exists!, you can't duplicate or create a new code")
                    ALFIAN_TXTKODEPEG.Focus()
                Else
                    Call Koneksi()
                    Dim InputData As String = "insert into alfian_pegawai values ('" & ALFIAN_TXTKODEPEG.Text & "','" & ALFIAN_TXTNAMAPEG.Text & "','" & ALFIAN_TXTTEMPAT.Text & "','" & TanggalLahir & "','" & ALFIAN_CMBPENDIDIKAN.Text & "','" & ALFIAN_CMBJABATAN.Text & "','" & ALFIAN_TXTNOTELP.Text & "','" & ALFIAN_TXTALAMAT.Text & "')"
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
            ALFIAN_BTNEDIT.Text = "SAVE"
            ALFIAN_BTNADD.Enabled = False
            ALFIAN_BTNHAPUS.Enabled = False
            ALFIAN_BTNEXIT.Text = "CANCEL"
            Call SiapInput()
            ALFIAN_TXTKODEPEG.Enabled = False
            ALFIAN_TXTNAMAPEG.Focus()
        Else
            Dim TanggalLahir As String
            TanggalLahir = Format(ALFIAN_DTTANGGAL.Value, "yyyy-MM-dd")
            If ALFIAN_TXTKODEPEG.Text = "" Or ALFIAN_TXTNAMAPEG.Text = "" Or ALFIAN_TXTTEMPAT.Text = "" Or TanggalLahir = "" Or ALFIAN_CMBPENDIDIKAN.Text = "" Or ALFIAN_CMBJABATAN.Text = "" Or ALFIAN_TXTNOTELP.Text = "" Or ALFIAN_TXTALAMAT.Text = "" Then
                MessageBox.Show("Upss! Isi data dengan lengkap", "Warning !")
            Else
                Call Koneksi()
                Dim EditDataPeg As String = "update alfian_pegawai set alfian_nm_peg ='" & ALFIAN_TXTNAMAPEG.Text & "',alfian_temp_lhr='" & ALFIAN_TXTTEMPAT.Text & "',alfian_tgl_lahir='" & TanggalLahir & "',alfian_pend='" & ALFIAN_CMBPENDIDIKAN.Text & "',alfian_jab='" & ALFIAN_CMBJABATAN.Text & "',alfian_no_telp='" & ALFIAN_TXTNOTELP.Text & "',alfian_alamat='" & ALFIAN_TXTALAMAT.Text & "' where alfian_kd_peg='" & ALFIAN_TXTKODEPEG.Text & "'"
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
            Dim HapusData As String = "Delete alfian_pegawai where alfian_kd_peg='" & ALFIAN_TXTKODEPEG.Text & "'"
            Cmd = New SqlCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil di hapus", "Success")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub TXTKODEPEG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTKODEPEG.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTNAMAPEG.Focus()
            If e.KeyChar = Chr(13) Then
                Call Koneksi()
                Cmd = New SqlCommand("Select * From alfian_pegawai Where alfian_kd_peg='" & ALFIAN_TXTKODEPEG.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    ALFIAN_TXTNAMAPEG.Text = Rd.Item("alfian_nm_peg")
                    ALFIAN_TXTTEMPAT.Text = Rd.Item("alfian_temp_lhr")
                    ALFIAN_DTTANGGAL.Text = Rd.Item("alfian_tgl_lahir")
                    ALFIAN_CMBPENDIDIKAN.Text = Rd.Item("alfian_pend")
                    ALFIAN_CMBJABATAN.Text = Rd.Item("alfian_jab")
                    ALFIAN_TXTNOTELP.Text = Rd.Item("alfian_no_telp")
                    ALFIAN_TXTALAMAT.Text = Rd.Item("alfian_alamat")
                Else
                End If
            End If
        End If
    End Sub

    Private Sub ALFIAN_TBLPEGAWAI_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles ALFIAN_TBLPEGAWAI.CellMouseClick
        ALFIAN_TXTKODEPEG.Text = ALFIAN_TBLPEGAWAI.Rows(e.RowIndex).Cells(0).Value
        ALFIAN_TXTNAMAPEG.Text = ALFIAN_TBLPEGAWAI.Rows(e.RowIndex).Cells(1).Value
        ALFIAN_TXTTEMPAT.Text = ALFIAN_TBLPEGAWAI.Rows(e.RowIndex).Cells(2).Value
        ALFIAN_DTTANGGAL.Text = ALFIAN_TBLPEGAWAI.Rows(e.RowIndex).Cells(3).Value
        ALFIAN_CMBPENDIDIKAN.Text = ALFIAN_TBLPEGAWAI.Rows(e.RowIndex).Cells(4).Value
        ALFIAN_CMBJABATAN.Text = ALFIAN_TBLPEGAWAI.Rows(e.RowIndex).Cells(5).Value
        ALFIAN_TXTNOTELP.Text = ALFIAN_TBLPEGAWAI.Rows(e.RowIndex).Cells(6).Value
        ALFIAN_TXTALAMAT.Text = ALFIAN_TBLPEGAWAI.Rows(e.RowIndex).Cells(7).Value
    End Sub

    Private Sub TXTCARI_TextChanged(sender As Object, e As EventArgs) Handles ALFIAN_TXTCARI.TextChanged
        If ALFIAN_CMBCARI.SelectedIndex = 0 Then
            Da = New SqlDataAdapter("Select * From alfian_pegawai Where alfian_kd_peg like '" & ALFIAN_TXTCARI.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            ALFIAN_TBLPEGAWAI.DataSource = Ds.Tables(0)
        Else
            Da = New SqlDataAdapter("Select * From alfian_pegawai Where alfian_nm_peg like '" & ALFIAN_TXTCARI.Text & "%'", Conn)
            Ds = New DataSet
            Da.Fill(Ds)
            ALFIAN_TBLPEGAWAI.DataSource = Ds.Tables(0)

        End If
    End Sub

    Private Sub TXTNOTELP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTNOTELP.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTALAMAT.Focus()

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or
            e.KeyChar = vbBack) Then e.Handled = True
    End Sub

    Private Sub TXTNAMAPEG_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTNAMAPEG.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTTEMPAT.Focus()

        End If
    End Sub

    Private Sub TXTTEMPAT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTTEMPAT.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_DTTANGGAL.Focus()

        End If
    End Sub

    Private Sub DTTANGGAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_DTTANGGAL.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_CMBPENDIDIKAN.Focus()

        End If
    End Sub

    Private Sub CMBPENDIDIKAN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_CMBPENDIDIKAN.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_CMBJABATAN.Focus()

        End If
    End Sub

    Private Sub CMBJABATAN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_CMBJABATAN.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_TXTNOTELP.Focus()

        End If
    End Sub

    Private Sub TXTALAMAT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ALFIAN_TXTALAMAT.KeyPress
        If e.KeyChar = Chr(13) Then
            ALFIAN_BTNADD.Focus()

        End If
    End Sub


End Class