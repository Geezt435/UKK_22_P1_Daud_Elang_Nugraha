<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHome))
        Me.pnlform = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnisiuser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnperjalanan = New System.Windows.Forms.Button()
        Me.btndashboard = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RoundedPanel1 = New UKK_22_P1_Daud_Elang_Nugraha.RoundedPanel()
        Me.txthak = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnik = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlform
        '
        Me.pnlform.AutoSize = True
        Me.pnlform.BackColor = System.Drawing.Color.Black
        Me.pnlform.Location = New System.Drawing.Point(178, -3)
        Me.pnlform.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlform.Name = "pnlform"
        Me.pnlform.Size = New System.Drawing.Size(1098, 658)
        Me.pnlform.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(173, -1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(8, 656)
        Me.Panel2.TabIndex = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.btnisiuser)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.btnperjalanan)
        Me.Panel3.Controls.Add(Me.btndashboard)
        Me.Panel3.Location = New System.Drawing.Point(-4, 242)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(193, 414)
        Me.Panel3.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(15, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "App by Daud Elang N"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("FontAwesome", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(73, 233)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "  "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("FontAwesome", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(73, 119)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "    "
        '
        'btnisiuser
        '
        Me.btnisiuser.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnisiuser.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnisiuser.FlatAppearance.BorderSize = 3
        Me.btnisiuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnisiuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnisiuser.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.btnisiuser.Location = New System.Drawing.Point(37, 269)
        Me.btnisiuser.Margin = New System.Windows.Forms.Padding(2)
        Me.btnisiuser.Name = "btnisiuser"
        Me.btnisiuser.Size = New System.Drawing.Size(113, 55)
        Me.btnisiuser.TabIndex = 4
        Me.btnisiuser.Text = "Data Pengguna"
        Me.btnisiuser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("FontAwesome", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(71, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "   "
        '
        'btnperjalanan
        '
        Me.btnperjalanan.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnperjalanan.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnperjalanan.FlatAppearance.BorderSize = 3
        Me.btnperjalanan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnperjalanan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnperjalanan.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.btnperjalanan.Location = New System.Drawing.Point(35, 154)
        Me.btnperjalanan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnperjalanan.Name = "btnperjalanan"
        Me.btnperjalanan.Size = New System.Drawing.Size(112, 55)
        Me.btnperjalanan.TabIndex = 3
        Me.btnperjalanan.Text = " Data Perjalanan"
        Me.btnperjalanan.UseVisualStyleBackColor = False
        '
        'btndashboard
        '
        Me.btndashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btndashboard.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btndashboard.FlatAppearance.BorderSize = 3
        Me.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndashboard.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.btndashboard.Location = New System.Drawing.Point(36, 53)
        Me.btndashboard.Margin = New System.Windows.Forms.Padding(2)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Size = New System.Drawing.Size(112, 32)
        Me.btndashboard.TabIndex = 1
        Me.btndashboard.Text = "Dasbor"
        Me.btndashboard.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(1, 235)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(192, 8)
        Me.Panel4.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(12, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.RoundedPanel1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(-1, -3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 660)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 112)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.Transparent
        Me.RoundedPanel1.BorderColor = System.Drawing.Color.DimGray
        Me.RoundedPanel1.Controls.Add(Me.txthak)
        Me.RoundedPanel1.Controls.Add(Me.Label7)
        Me.RoundedPanel1.Controls.Add(Me.txtnik)
        Me.RoundedPanel1.Controls.Add(Me.Label5)
        Me.RoundedPanel1.Controls.Add(Me.Label4)
        Me.RoundedPanel1.Controls.Add(Me.txtnama)
        Me.RoundedPanel1.Edge = 50
        Me.RoundedPanel1.Location = New System.Drawing.Point(10, 134)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(156, 81)
        Me.RoundedPanel1.TabIndex = 17
        '
        'txthak
        '
        Me.txthak.AutoSize = True
        Me.txthak.Font = New System.Drawing.Font("OCR A Extended", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthak.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txthak.Location = New System.Drawing.Point(67, 59)
        Me.txthak.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txthak.Name = "txthak"
        Me.txthak.Size = New System.Drawing.Size(40, 12)
        Me.txthak.TabIndex = 17
        Me.txthak.Text = "{hak}"
        Me.txthak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("FontAwesome", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Location = New System.Drawing.Point(24, 56)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = ""
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnik
        '
        Me.txtnik.AutoSize = True
        Me.txtnik.Font = New System.Drawing.Font("OCR A Extended", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnik.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtnik.Location = New System.Drawing.Point(67, 34)
        Me.txtnik.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(40, 12)
        Me.txtnik.TabIndex = 14
        Me.txtnik.Text = "{nik}"
        Me.txtnik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("FontAwesome", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label5.Location = New System.Drawing.Point(21, 32)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 19)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "    "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("FontAwesome", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Turquoise
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(22, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "   "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnama
        '
        Me.txtnama.AutoSize = True
        Me.txtnama.Font = New System.Drawing.Font("OCR A Extended", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.txtnama.Location = New System.Drawing.Point(65, 9)
        Me.txtnama.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(47, 12)
        Me.txtnama.TabIndex = 11
        Me.txtnama.Text = "{nama}"
        Me.txtnama.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 653)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlform)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.RoundedPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlform As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtnik As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnisiuser As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnperjalanan As System.Windows.Forms.Button
    Friend WithEvents btndashboard As System.Windows.Forms.Button
    Friend WithEvents txtnama As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RoundedPanel1 As UKK_22_P1_Daud_Elang_Nugraha.RoundedPanel
    Friend WithEvents txthak As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
