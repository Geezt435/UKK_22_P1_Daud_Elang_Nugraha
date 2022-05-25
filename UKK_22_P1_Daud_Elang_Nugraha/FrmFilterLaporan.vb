Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Public Class FrmFilterLaporan
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand

    Sub Simplify()
        txtid.MaxLength = 6
        suhu1.MaxLength = 2
        suhu2.MaxLength = 2
        koma1.MaxLength = 1
        koma2.MaxLength = 1
    End Sub

    Private Sub btncetak_Click(sender As Object, e As EventArgs) Handles btncetak.Click
        Dim Lap As New ReportDocument
        Lap.Load("LaporanPerjalanan.rpt")
        If urutid.Checked = True Then
            FrmLaporanPerjalanan.CrystalReportViewer1.SelectionFormula = "{tb_perjalanan.id_perjalanan} = '" & txtid.Text & "'"
        ElseIf uruttgl.Checked = True Then
            FrmLaporanPerjalanan.CrystalReportViewer1.SelectionFormula = "{tb_perjalanan.tanggal}>='" & tgl1.Value.ToString("yyyy-MM-dd") &
            "' AND {tb_perjalanan.tanggal}<='" & tgl2.Value.ToString("yyyy-MM-dd") & "'"
        ElseIf urutwaktu.Checked = True Then
            FrmLaporanPerjalanan.CrystalReportViewer1.SelectionFormula = "{tb_perjalanan.waktu} = '" & txtwaktu.Text & "'"
        ElseIf urutlokasi.Checked = True Then
            FrmLaporanPerjalanan.CrystalReportViewer1.SelectionFormula = "{tb_perjalanan.lokasi} = '" & txtlokasi.Text & "'"
        ElseIf urutsuhu.Checked = True Then
            FrmLaporanPerjalanan.CrystalReportViewer1.SelectionFormula = "{tb_perjalanan.suhu}>=" & suhu1.Text & "." & koma2.Text &
            " AND {tb_perjalanan.suhu}<=" & suhu2.Text & "." & koma2.Text
        End If
        FrmLaporanPerjalanan.CrystalReportViewer1.ReportSource = Lap
        FrmLaporanPerjalanan.CrystalReportViewer1.RefreshReport()
        FrmLaporanPerjalanan.ShowDialog()
    End Sub

    Private Sub btnklr_Click(sender As Object, e As EventArgs) Handles btnklr.Click
        Me.Close()
    End Sub

    Private Sub FrmFilterLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Data Source=.\SQLEXPRESS;Initial Catalog=db_22_P1_Daud_Elang_Nugraha;Integrated Security=True"
        urutid.Checked = True
        id_relation()
        Simplify()
    End Sub

    Private Sub txtwaktu_TextChanged(sender As Object, e As EventArgs) Handles txtwaktu.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_perjalanan WHERE waktu = '" & txtwaktu.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtlokasi_TextChanged(sender As Object, e As EventArgs) Handles txtlokasi.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_perjalanan WHERE lokasi = '" & txtlokasi.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        cn.Open()
        cmd.Connection = cn
        cmd.CommandText = "SELECT * FROM tb_perjalanan WHERE id_perjalanan = '" & txtid.Text & "'"
        cmd.ExecuteNonQuery()
        Dim rd As SqlDataReader = cmd.ExecuteReader
        rd.Read()
        rd.Close()
        cn.Close()
    End Sub

    Sub id_relation()
        Try
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New SqlDataAdapter("SELECT * FROM tb_perjalanan", cn)
            da.Fill(dt)
            Dim r As DataRow
            txtid.AutoCompleteCustomSource.Clear()
            txtwaktu.AutoCompleteCustomSource.Clear()
            txtlokasi.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txtid.AutoCompleteCustomSource.Add(r.Item(0).ToString)
                txtwaktu.AutoCompleteCustomSource.Add(r.Item(2).ToString)
                txtlokasi.AutoCompleteCustomSource.Add(r.Item(3).ToString)
            Next
        Catch ex As Exception
            cn.Close()
        End Try
    End Sub

    Private Sub suhu1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles suhu1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub koma1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles koma1.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub suhu2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles suhu2.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub koma2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles koma2.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub
End Class