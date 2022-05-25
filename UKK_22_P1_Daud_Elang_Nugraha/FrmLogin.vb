Imports System.Data.SqlClient
Public Class FrmLogin
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub ClearText()
        txtnik.Text = ""
        txtnama.Text = ""
        txtnama.Select()
    End Sub

    Sub Login()
        If txtnama.Text = "" Or txtnik.Text = "" Then
            MsgBox("NIK dan Nama Lengkap wajib diisi!", MsgBoxStyle.Exclamation, "Login")
            ClearText()
        Else
            cn.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=db_22_P1_Daud_Elang_Nugraha;Integrated Security=True"
            cmd.Connection = cn
            cn.Open()
            cmd.CommandText = "SELECT nik, username, hak FROM tb_user WHERE nik='" & txtnik.Text &
                "' and username='" & txtnama.Text & "'"
            Dim rd As SqlDataReader = cmd.ExecuteReader
            rd.Read()

            ' Kenapa tidak bisa rd hak sebelumnya karena charnya 10, jadinya ada spasi, contoh "admin     " daripada "admin"
            ' Jadinya ndak kebaca, makanya diubah jadi char(5) menggantikan char(10), serta "member    " diubah menjadi "membr"
            If rd.HasRows Then
                If (rd("hak") = "admin") Then
                    FrmHome.btndashboard.Enabled = True
                    FrmHome.btnisiuser.Enabled = True
                    FrmHome.btnperjalanan.Enabled = True
                ElseIf (rd("hak") = "membr") Then
                    FrmHome.btndashboard.Enabled = True
                    FrmHome.btnisiuser.Enabled = False
                    FrmHome.btnperjalanan.Enabled = False
                Else
                    FrmHome.btndashboard.Enabled = False
                    FrmHome.btnisiuser.Enabled = False
                    FrmHome.btnperjalanan.Enabled = False
                End If
                FrmHome.txtnama.Text = (rd("username"))
                FrmHome.txtnik.Text = (rd("nik"))
                If (rd("hak")) = "admin" Then
                    FrmHome.txthak.Text = "Admin"
                ElseIf (rd("hak")) = "membr" Then
                    FrmHome.txthak.Text = "Member"
                End If
                FrmHome.Show()
                Me.Visible = False
                ClearText()
            Else
                MsgBox("NIK dan Nama Lengkap salah!", MsgBoxStyle.Critical)
                ClearText()
            End If
        End If
        cn.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Login()
    End Sub

    Private Sub btndaftar_Click(sender As Object, e As EventArgs) Handles btndaftar.Click
        FrmDaftar.Show()
        Me.Visible = False
        ClearText()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtnik.MaxLength = 6
    End Sub

    Private Sub txtnik_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnik.KeyDown
        If (e.KeyValue = 13) Then
            txtnama.Select()
        End If
    End Sub

    Private Sub txtnik_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnik.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txtnama_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnama.KeyDown
        If (e.KeyValue = 13) Then
            Login()
        End If
    End Sub
End Class