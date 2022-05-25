Imports System.Data.SqlClient
Public Class FrmDaftar
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub Daftar()
        Dim dupeCheck As String = ""
        Using cnObj As New SqlClient.SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=db_22_P1_Daud_Elang_Nugraha;Integrated Security=True")
            Using cmdObj As New SqlClient.SqlCommand("SELECT nik FROM tb_user WHERE nik = '" & txtnik.Text & "'", cnObj)
                cnObj.Open()
                Using readerObj As SqlClient.SqlDataReader = cmdObj.ExecuteReader
                    While readerObj.Read
                        dupeCheck = readerObj("nik").ToString
                    End While
                End Using
                cnObj.Close()
            End Using
        End Using

        If dupeCheck.Contains(txtnik.Text) Then
            MsgBox("NIK tidak boleh duplikat!", MsgBoxStyle.Exclamation, "Registration")
        ElseIf txtnik.Text = "" Then
            MsgBox("NIK tidak boleh dikosongkan!", MsgBoxStyle.Exclamation, "Registration")
        ElseIf txtnik.TextLength < 6 Then
            MsgBox("Panjang NIK tidak boleh dibawah 6!", MsgBoxStyle.Exclamation, "Registration")
        ElseIf txtnama.Text = "" Then
            MsgBox("Nama Lengkap tidak boleh dikosongkan!", MsgBoxStyle.Exclamation, "Registration")
        ElseIf txtnik.Text <> "" And txtnama.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO tb_user VALUES ('" & txtnik.Text &
                "','" & txtnama.Text & "', 'membr')"
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Berhasil mendaftarkan akun!", MsgBoxStyle.Information)
            FrmLogin.Visible = True
            Me.Visible = False
            bersih()
        End If
    End Sub

    Sub bersih()
        txtnik.Text = ""
        txtnama.Text = ""
    End Sub

    Private Sub FrmDaftar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FrmLogin.Visible = True
    End Sub

    Private Sub FrmDaftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=db_22_P1_Daud_Elang_Nugraha;Integrated Security=True"
        txtnik.MaxLength = 6
        txtnama.MaxLength = 20
        txtnik.Select()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmLogin.Visible = True
        bersih()
        txtnik.Select()
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Daftar()
    End Sub

    Private Sub txtnik_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnik.KeyDown
        If (e.KeyValue = 13) Then
            txtnama.Select()
        End If
    End Sub

    Private Sub txtnik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnik.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txtnama_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnama.KeyDown
        If (e.KeyValue = 13) Then
            Daftar()
        End If
    End Sub
End Class