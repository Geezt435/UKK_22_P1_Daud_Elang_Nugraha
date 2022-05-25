Imports System.Drawing.Drawing2D

Public Class FrmHome
    Dim dashboard As New FrmDashboard
    Dim perjalanan As New FrmPerjalanan
    Dim user As New FrmUser

    Private Sub btnperjalanan_Click(sender As Object, e As EventArgs) Handles btnperjalanan.Click
        pnlform.Controls.Clear()
        perjalanan.TopLevel = False
        pnlform.Controls.Add(perjalanan)
        perjalanan.Show()
        btndashboard.BackColor = Color.FromArgb(40, 42, 50)
        btnperjalanan.BackColor = Color.FromArgb(20, 22, 30)
        btnisiuser.BackColor = Color.FromArgb(40, 42, 50)
    End Sub

    Private Sub FrmHome_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        FrmLogin.Visible = True
    End Sub

    Private Sub btnisiuser_Click(sender As Object, e As EventArgs) Handles btnisiuser.Click
        pnlform.Controls.Clear()
        user.TopLevel = False
        pnlform.Controls.Add(user)
        user.Show()
        btndashboard.BackColor = Color.FromArgb(40, 42, 50)
        btnperjalanan.BackColor = Color.FromArgb(40, 42, 50)
        btnisiuser.BackColor = Color.FromArgb(20, 22, 30)
    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        pnlform.Controls.Clear()
        dashboard.TopLevel = False
        pnlform.Controls.Add(dashboard)
        dashboard.Show()
        btndashboard.BackColor = Color.FromArgb(20, 22, 30)
        btnperjalanan.BackColor = Color.FromArgb(40, 42, 50)
        btnisiuser.BackColor = Color.FromArgb(40, 42, 50)
    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlform.Controls.Clear()
        dashboard.TopLevel = False
        pnlform.Controls.Add(dashboard)
        dashboard.Show()
        btndashboard.BackColor = Color.FromArgb(20, 22, 30)
        btnperjalanan.BackColor = Color.FromArgb(40, 42, 50)
        btnisiuser.BackColor = Color.FromArgb(40, 42, 50)
    End Sub
End Class