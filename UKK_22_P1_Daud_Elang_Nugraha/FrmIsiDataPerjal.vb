Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.VisualBasic

Public Class FrmIsiDataPerjal
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub TestJam()
        If txtjam1.Text < 10 And txtjam1.TextLength < 2 Then
            txtjam1.Text = "0" + txtjam1.Text
        End If
        If txtjam2.Text < 10 And txtjam2.TextLength < 2 Then
            txtjam2.Text = "0" + txtjam2.Text
        End If
    End Sub

    Sub PrintNow()
        Dim Lap As New ReportDocument
        Lap.Load("LaporanPerjalanan.rpt")
        FrmLaporanPerjalanan.CrystalReportViewer1.SelectionFormula = "{tb_perjalanan.id_perjalanan} = '" & txtid.Text & "'"
        FrmLaporanPerjalanan.CrystalReportViewer1.ReportSource = Lap
        FrmLaporanPerjalanan.CrystalReportViewer1.RefreshReport()
        FrmLaporanPerjalanan.ShowDialog()
    End Sub

    Sub kodeotomatis()
        Dim kodeauto As Single
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT COUNT(*) AS id_perjalanan FROM tb_perjalanan"
        Dim rd As SqlDataReader = cmd.ExecuteReader
        While rd.Read
            kodeauto = Val(rd.Item("id_perjalanan").ToString) + 1
        End While
        Select Case Len(Trim(kodeauto))
            Case 1 : txtid.Text = "PRJ-00" + Trim(Str(kodeauto))
            Case 2 : txtid.Text = "PRJ-0" + Trim(Str(kodeauto))
            Case 3 : txtid.Text = "PRJ-" + Trim(Str(kodeauto))
        End Select
        rd.Close()
        cn.Close()
    End Sub

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

    Sub bersih()
        txtid.Text = ""
        txtjam1.Text = ""
        txtjam2.Text = ""
        txtlokasi.Text = ""
        txtsuhu.Text = ""
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        bersih()
        kodeotomatis()
    End Sub

    Private Sub FrmIsiDataPerjal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=db_22_P1_Daud_Elang_Nugraha;Integrated Security=True"
        tampildata()
        kodeotomatis()
        txtjam1.MaxLength = 2
        txtjam2.MaxLength = 2
        txtsuhu.MaxLength = 4
        txtid.Enabled = False
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtid.Text = "" Then
            MessageBox.Show("ID tidak boleh dikosongkan!")
        ElseIf txtjam2.Text = "" Then
            MessageBox.Show("Jam harus lengkap dan tidak boleh dikosongkan!")
        ElseIf txtjam1.Text > 24 Then
            MessageBox.Show("Jam harus dibawah 24!")
        ElseIf txtjam2.Text > 59 Then
            MessageBox.Show("Menit harus dibawah 59!")
        ElseIf txtlokasi.Text = "" Then
            MessageBox.Show("Lokasi tidak boleh dikosongkan!")
        ElseIf txtsuhu.Text = "" Then
            MessageBox.Show("Suhu Tubuh tidak boleh dikosongkan!")
        ElseIf txtsuhu.Text > 99.9 Then
            MessageBox.Show("Suhu Tubuh harus dibawah 99.9!")
        ElseIf txtid.Text <> "" And txtjam1.Text <> "" And txtjam2.Text <> "" And txtlokasi.Text <> "" And txtsuhu.Text <> "" Then
            TestJam()
            cn.Open()
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO tb_perjalanan VALUES ('" & txtid.Text &
                "','" & dttanggal.Value.ToString("yyyy-MM-dd") &
                "','" & txtjam1.Text & ":" & txtjam2.Text &
                "','" & txtlokasi.Text & "','" & txtsuhu.Text & "')"
            cmd.ExecuteNonQuery()
            cn.Close()
            MsgBox("Data Perjalanan Berhasil Tersimpan!", MsgBoxStyle.Information)
            tampildata()
            PrintNow()
            bersih()
            kodeotomatis()
        End If
    End Sub

    'Pencarian Data
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

    Private Sub txtsuhu_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtsuhu.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txtjam1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjam1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub txtjam2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjam2.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub btnlapor_Click(sender As Object, e As EventArgs) Handles btnlapor.Click
        FrmFilterLaporan.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim jam1 As String = ""
        Dim jam2 As String = ""
        txtid.Text = DataGridView1.SelectedCells(0).Value
        dttanggal.Value = DataGridView1.SelectedCells(1).Value
        jam1 = DataGridView1.SelectedCells(2).Value
        jam2 = DataGridView1.SelectedCells(2).Value
        txtjam1.Text = jam1.Substring(0, 2)
        txtjam2.Text = jam2.Substring(3)
        txtlokasi.Text = DataGridView1.SelectedCells(3).Value
        txtsuhu.Text = DataGridView1.SelectedCells(4).Value
    End Sub
End Class