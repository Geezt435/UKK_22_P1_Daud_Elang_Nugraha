Imports System.Data.SqlClient
Public Class FrmCatatanPerjalanan
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub tampildata()
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_perjalanan"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()

        DataGridView1.Columns(0).HeaderText = "ID Perjalanan"
        DataGridView1.Columns(1).HeaderText = "Tanggal"
        DataGridView1.Columns(2).HeaderText = "Jam"
        DataGridView1.Columns(3).HeaderText = "Lokasi"
        DataGridView1.Columns(4).HeaderText = "Suhu Tubuh"

        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub FrmCatatanPerjalanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=db_22_P1_Daud_Elang_Nugraha;Integrated Security=True"
        tampildata()
        rbASC.Checked = True
    End Sub

    Private Sub btnurutkan_Click(sender As Object, e As EventArgs) Handles btnurutkan.Click
        Dim orderby As String = "DESC"
        If rbASC.Checked Then
            orderby = "ASC"
        ElseIf rbDESC.Checked Then
            orderby = "DESC"
        End If

        Dim jenisdata As String = "id_perjalanan"
        If cburutan.Text = "ID" Then
            jenisdata = "id_perjalanan"
        ElseIf cburutan.Text = "Tanggal" Then
            jenisdata = "tanggal"
        ElseIf cburutan.Text = "Waktu" Then
            jenisdata = "waktu"
        ElseIf cburutan.Text = "Lokasi" Then
            jenisdata = "lokasi"
        ElseIf cburutan.Text = "Suhu Tubuh" Then
            jenisdata = "suhu"
        End If

        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_perjalanan ORDER BY '" & jenisdata & "' " & orderby & ";"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_perjalanan WHERE id_perjalanan LIKE '%" & txtcari.Text &
            "%' OR tanggal LIKE '%" & txtcari.Text & "%' OR waktu LIKE '%" & txtcari.Text &
            "%' OR lokasi LIKE '%" & txtcari.Text & "%' OR suhu LIKE '%" & txtcari.Text & "%'"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        Dim dt As New DataTable
        dt.Load(rd)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub
End Class