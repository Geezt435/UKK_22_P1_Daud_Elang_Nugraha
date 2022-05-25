Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    Private Function GetRoundPath(ByVal Rect As RectangleF, ByVal radius As Integer) As GraphicsPath
        Dim m As Single = 2.75F
        Dim r2 As Single = radius / 2.0F
        Dim GraphPath As GraphicsPath = New GraphicsPath()
        GraphPath.AddArc(Rect.X + m, Rect.Y + m, radius, radius, 180, 90)
        GraphPath.AddLine(Rect.X + r2 + m, Rect.Y + m, Rect.Width - r2 - m, Rect.Y + m)
        GraphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + m, radius, radius, 270, 90)
        GraphPath.AddLine(Rect.Width - m, Rect.Y + r2, Rect.Width - m, Rect.Height - r2 - m)
        GraphPath.AddArc(Rect.X + Rect.Width - radius - m, Rect.Y + Rect.Height - radius - m, radius, radius, 0, 90)
        GraphPath.AddLine(Rect.Width - r2 - m, Rect.Height - m, Rect.X + r2 - m, Rect.Height - m)
        GraphPath.AddArc(Rect.X + m, Rect.Y + Rect.Height - radius - m, radius, radius, 90, 90)
        GraphPath.AddLine(Rect.X + m, Rect.Height - r2 - m, Rect.X + m, Rect.Y + r2 + m)
        GraphPath.CloseFigure()
        Return GraphPath
    End Function

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim borderRadius As Integer = 50
        Dim borderThickness As Single = 1.75F
        MyBase.OnPaint(e)
        Dim Rect As RectangleF = New RectangleF(0, 0, Me.Width, Me.Height)
        Dim GraphPath As GraphicsPath = GetRoundPath(Rect, borderRadius)
        Me.Region = New Region(GraphPath)

        Using pen As Pen = New Pen(Color.Silver, borderThickness)
            pen.Alignment = PenAlignment.Inset
            e.Graphics.DrawPath(pen, GraphPath)
        End Using
    End Sub
End Class
