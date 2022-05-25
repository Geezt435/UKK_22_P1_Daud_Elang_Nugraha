Imports System.Data.SqlClient
Public Class FrmUser
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_user"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "NIK"
        DataGridView1.Columns(1).HeaderText = "Username"
        DataGridView1.Columns(2).HeaderText = "Hak Akses"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Sub bersih()
        txtnik.Text = ""
        txtnama.Text = ""
    End Sub

    Private Sub FrmBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=db_22_P1_Daud_Elang_Nugraha;Integrated Security=True"
        rbASC.Checked = True
        tampildata()
        txtnik.MaxLength = 6
    End Sub

    Private Sub DataGridView1_DoubleClick1(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        txtnik.Text = DataGridView1.SelectedCells(0).Value
        txtnama.Text = DataGridView1.SelectedCells(1).Value
        If DataGridView1.SelectedCells(2).Value = "admin" Then
            cbhak.Text = "Admin"
        Else
            cbhak.Text = "Member"
        End If
        txtnik.Enabled = False
    End Sub

    Private Sub btnbatal_Click_1(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
        txtnik.Enabled = True
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        Dim baris As Integer
        Dim nik As String

        baris = DataGridView1.CurrentCell.RowIndex
        nik = DataGridView1(0, baris).Value.ToString

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "DELETE FROM tb_user WHERE nik = '" + nik + "'"
        cmd.ExecuteNonQuery()
        cn.Close()
        MsgBox("Data User Berhasil Terhapus", MsgBoxStyle.Information, "Users")
        tampildata()
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        Dim hakUser As String = "Admin"
        If cbhak.Text = "Admin" Then
            hakUSer = "admin"
        ElseIf cbhak.Text = "Member" Then
            hakUser = "membr"
        End If

        If txtnik.Text = "" Then
            MsgBox("NIK tidak boleh dikosongkan!", MsgBoxStyle.Exclamation, "Users")
        ElseIf txtnama.Text = "" Then
            MsgBox("Nama Lengkap tidak boleh dikosongkan!", MsgBoxStyle.Exclamation, "Users")
        ElseIf cbhak.Text = "" Then
            MsgBox("Hak Akses tidak boleh dikosongkan!", MsgBoxStyle.Exclamation, "Users")
        ElseIf txtnik.Text <> "" And txtnama.Text <> "" And cbhak.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "UPDATE tb_user SET username='" & txtnama.Text &
                "', hak ='" & hakUser &
                "' WHERE nik ='" & txtnik.Text & "'"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Terubah!", MsgBoxStyle.Information, "Users")
            tampildata()
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
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
            MsgBox("NIK tidak boleh duplikat!", MsgBoxStyle.Exclamation, "Users")
        ElseIf txtnik.Text = "" Then
            MsgBox("NIK tidak boleh dikosongkan!", MsgBoxStyle.Exclamation, "Users")
        ElseIf txtnama.Text = "" Then
            MsgBox("Nama Lengkap tidak boleh dikosongkan!", MsgBoxStyle.Exclamation, "Users")
        ElseIf cbhak.Text = "" Then
            MsgBox("Hak Akses tidak boleh dikosongkan!", MsgBoxStyle.Exclamation, "Users")
        ElseIf txtnik.Text <> "" And txtnama.Text <> "" And cbhak.Text <> "" Then
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO tb_user VALUES ('" & txtnik.Text &
                "','" & txtnama.Text & "','" & cbhak.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            bersih()
            MsgBox("Data User Berhasil Tersimpan!", MsgBoxStyle.Information, "Users")
            tampildata()
        End If
    End Sub

    Private Sub txtcari_TextChanged_1(sender As Object, e As EventArgs)
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_user WHERE nik LIKE '%" & txtcari.Text &
            "%' OR username LIKE '%" & txtcari.Text & "%' OR hak LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    ' Pengurutan Data
    Private Sub btnurutkan_Click(sender As Object, e As EventArgs) Handles btnurutkan.Click
        Dim orderby As String = "DESC"
        If rbASC.Checked Then
            orderby = "ASC"
        ElseIf rbDESC.Checked Then
            orderby = "DESC"
        End If

        Dim jenisdata As String = "nik"
        If cburutan.Text = "NIK" Then
            jenisdata = "nik"
        ElseIf cburutan.Text = "Username" Then
            jenisdata = "username"
        ElseIf cburutan.Text = "Hak" Then
            jenisdata = "hak"
        End If

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_user ORDER BY '" & jenisdata & "' " & orderby & ";"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    ' Pencarian Data
    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_user WHERE nik LIKE '%" & txtcari.Text &
            "%' OR username LIKE '%" & txtcari.Text & "%' OR hak LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub
End Class