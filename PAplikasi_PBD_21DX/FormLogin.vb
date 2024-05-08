Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class FormLogin
    Dim Conn As SqlConnection
    Dim Da As SqlDataAdapter
    Dim Cmd As SqlCommand
    Dim Rd As SqlDataReader
    Dim Ds As DataSet
    Dim Kode As String
    Dim MyDB As String

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Sub Koneksi()
        MyDB = "Data Source=LAPTOP-BK925EA8\SQLTENYOM;Initial Catalog=db_toko_pbd_if21dx;Integrated Security=True"
        Conn = New SqlConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub TXTREGISTER_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TXTREGISTER.LinkClicked
        If TxtUser.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("Silahkan Login sebagai ADMIN untuk mendaftarkan Akun!")
        Else
            Call Koneksi()
            Cmd = New SqlCommand("Select * from alfian_login where alfian_kd_peg='" & TxtUser.Text & "' and alfian_kunci='" & TxtPassword.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                FormRegister.ShowDialog()
            Else
                MsgBox("Username or Password Not found!")
            End If
        End If
    End Sub

    Private Sub FormLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtUser.Focus()
        End If
    End Sub

    Private Sub TxtUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUser.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtPassword.Focus()
        End If
    End Sub

    Private Sub TxtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            BtnLogin.Focus()
        End If
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUser.Text = "" Or TxtPassword.Text = "" Then
            MsgBox("Silahkan Masukan Username dan Password Terlebih Dahulu!", MsgBoxStyle.Exclamation, "Warning")
        Else
            Call Koneksi()
            Cmd = New SqlCommand("Select * from alfian_login where alfian_kd_peg='" & TxtUser.Text & "' and alfian_kunci='" & TxtPassword.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                MessageBox.Show("Login Success!", "Login")
                FormDashboard.Show()
                Me.Hide()
                FormDashboard.LbNamaUser.Text = Rd!alfian_username
                FormDashboard.LbLevelUser.Text = Rd!alfian_level
                If FormDashboard.LbLevelUser.Text = "USER" Then
                    FormDashboard.BtnAcSetting.Enabled = False
                End If
            Else
                MessageBox.Show("Username or Password Not found!")
                TxtPassword.Focus()
            End If
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()

    End Sub

    Private Sub FormLogin_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
End Class