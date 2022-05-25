<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilterLaporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFilterLaporan))
        Me.txtlokasi = New System.Windows.Forms.TextBox()
        Me.txtwaktu = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.koma2 = New System.Windows.Forms.TextBox()
        Me.koma1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.suhu2 = New System.Windows.Forms.TextBox()
        Me.suhu1 = New System.Windows.Forms.TextBox()
        Me.tgl2 = New System.Windows.Forms.DateTimePicker()
        Me.tgl1 = New System.Windows.Forms.DateTimePicker()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.urutsuhu = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnklr = New System.Windows.Forms.Button()
        Me.urutwaktu = New System.Windows.Forms.RadioButton()
        Me.uruttgl = New System.Windows.Forms.RadioButton()
        Me.urutid = New System.Windows.Forms.RadioButton()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.urutlokasi = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtlokasi
        '
        Me.txtlokasi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtlokasi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtlokasi.Location = New System.Drawing.Point(157, 129)
        Me.txtlokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtlokasi.Name = "txtlokasi"
        Me.txtlokasi.Size = New System.Drawing.Size(224, 20)
        Me.txtlokasi.TabIndex = 68
        '
        'txtwaktu
        '
        Me.txtwaktu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtwaktu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtwaktu.Location = New System.Drawing.Point(157, 102)
        Me.txtwaktu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtwaktu.Name = "txtwaktu"
        Me.txtwaktu.Size = New System.Drawing.Size(78, 20)
        Me.txtwaktu.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(285, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 18)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = ","
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.DarkGray
        Me.Label4.Location = New System.Drawing.Point(179, 164)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 18)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = ","
        '
        'koma2
        '
        Me.koma2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.koma2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.koma2.Location = New System.Drawing.Point(299, 159)
        Me.koma2.Margin = New System.Windows.Forms.Padding(2)
        Me.koma2.Name = "koma2"
        Me.koma2.Size = New System.Drawing.Size(14, 20)
        Me.koma2.TabIndex = 64
        '
        'koma1
        '
        Me.koma1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.koma1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.koma1.Location = New System.Drawing.Point(195, 159)
        Me.koma1.Margin = New System.Windows.Forms.Padding(2)
        Me.koma1.Name = "koma1"
        Me.koma1.Size = New System.Drawing.Size(14, 20)
        Me.koma1.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(218, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 18)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "S/d"
        '
        'suhu2
        '
        Me.suhu2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.suhu2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.suhu2.Location = New System.Drawing.Point(263, 159)
        Me.suhu2.Margin = New System.Windows.Forms.Padding(2)
        Me.suhu2.Name = "suhu2"
        Me.suhu2.Size = New System.Drawing.Size(19, 20)
        Me.suhu2.TabIndex = 61
        '
        'suhu1
        '
        Me.suhu1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.suhu1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.suhu1.Location = New System.Drawing.Point(158, 159)
        Me.suhu1.Margin = New System.Windows.Forms.Padding(2)
        Me.suhu1.Name = "suhu1"
        Me.suhu1.Size = New System.Drawing.Size(18, 20)
        Me.suhu1.TabIndex = 60
        '
        'tgl2
        '
        Me.tgl2.CustomFormat = "dd MMMM yyyy"
        Me.tgl2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tgl2.Location = New System.Drawing.Point(331, 74)
        Me.tgl2.Margin = New System.Windows.Forms.Padding(2)
        Me.tgl2.Name = "tgl2"
        Me.tgl2.Size = New System.Drawing.Size(132, 20)
        Me.tgl2.TabIndex = 59
        '
        'tgl1
        '
        Me.tgl1.CustomFormat = "dd MMMM yyyy"
        Me.tgl1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tgl1.Location = New System.Drawing.Point(157, 74)
        Me.tgl1.Margin = New System.Windows.Forms.Padding(2)
        Me.tgl1.Name = "tgl1"
        Me.tgl1.Size = New System.Drawing.Size(140, 20)
        Me.tgl1.TabIndex = 58
        '
        'txtid
        '
        Me.txtid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtid.Location = New System.Drawing.Point(157, 46)
        Me.txtid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(65, 20)
        Me.txtid.TabIndex = 57
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(296, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 18)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "S/d"
        '
        'urutsuhu
        '
        Me.urutsuhu.AutoSize = True
        Me.urutsuhu.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.urutsuhu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.urutsuhu.Location = New System.Drawing.Point(12, 159)
        Me.urutsuhu.Margin = New System.Windows.Forms.Padding(2)
        Me.urutsuhu.Name = "urutsuhu"
        Me.urutsuhu.Size = New System.Drawing.Size(66, 22)
        Me.urutsuhu.TabIndex = 55
        Me.urutsuhu.TabStop = True
        Me.urutsuhu.Text = "Suhu"
        Me.urutsuhu.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 24)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Urutkan berdasarkan :"
        '
        'btnklr
        '
        Me.btnklr.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnklr.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnklr.FlatAppearance.BorderSize = 2
        Me.btnklr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnklr.Font = New System.Drawing.Font("DFPOP1-W9", 12.0!)
        Me.btnklr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnklr.Location = New System.Drawing.Point(11, 219)
        Me.btnklr.Margin = New System.Windows.Forms.Padding(2)
        Me.btnklr.Name = "btnklr"
        Me.btnklr.Size = New System.Drawing.Size(114, 33)
        Me.btnklr.TabIndex = 53
        Me.btnklr.Text = "Kembali"
        Me.btnklr.UseVisualStyleBackColor = False
        '
        'urutwaktu
        '
        Me.urutwaktu.AutoSize = True
        Me.urutwaktu.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.urutwaktu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.urutwaktu.Location = New System.Drawing.Point(12, 102)
        Me.urutwaktu.Margin = New System.Windows.Forms.Padding(2)
        Me.urutwaktu.Name = "urutwaktu"
        Me.urutwaktu.Size = New System.Drawing.Size(77, 22)
        Me.urutwaktu.TabIndex = 51
        Me.urutwaktu.TabStop = True
        Me.urutwaktu.Text = "Waktu"
        Me.urutwaktu.UseVisualStyleBackColor = True
        '
        'uruttgl
        '
        Me.uruttgl.AutoSize = True
        Me.uruttgl.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.uruttgl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.uruttgl.Location = New System.Drawing.Point(12, 74)
        Me.uruttgl.Margin = New System.Windows.Forms.Padding(2)
        Me.uruttgl.Name = "uruttgl"
        Me.uruttgl.Size = New System.Drawing.Size(87, 22)
        Me.uruttgl.TabIndex = 50
        Me.uruttgl.TabStop = True
        Me.uruttgl.Text = "Tanggal"
        Me.uruttgl.UseVisualStyleBackColor = True
        '
        'urutid
        '
        Me.urutid.AutoSize = True
        Me.urutid.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.urutid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.urutid.Location = New System.Drawing.Point(12, 46)
        Me.urutid.Margin = New System.Windows.Forms.Padding(2)
        Me.urutid.Name = "urutid"
        Me.urutid.Size = New System.Drawing.Size(130, 22)
        Me.urutid.TabIndex = 49
        Me.urutid.TabStop = True
        Me.urutid.Text = "ID Perjalanan"
        Me.urutid.UseVisualStyleBackColor = True
        '
        'btncetak
        '
        Me.btncetak.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btncetak.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btncetak.FlatAppearance.BorderSize = 2
        Me.btncetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncetak.Font = New System.Drawing.Font("DFPOP1-W9", 12.0!)
        Me.btncetak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btncetak.Location = New System.Drawing.Point(362, 219)
        Me.btncetak.Margin = New System.Windows.Forms.Padding(2)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(101, 33)
        Me.btncetak.TabIndex = 48
        Me.btncetak.Text = "Cetak"
        Me.btncetak.UseVisualStyleBackColor = False
        '
        'urutlokasi
        '
        Me.urutlokasi.AutoSize = True
        Me.urutlokasi.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.urutlokasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.urutlokasi.Location = New System.Drawing.Point(12, 131)
        Me.urutlokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.urutlokasi.Name = "urutlokasi"
        Me.urutlokasi.Size = New System.Drawing.Size(77, 22)
        Me.urutlokasi.TabIndex = 52
        Me.urutlokasi.TabStop = True
        Me.urutlokasi.Text = "Lokasi"
        Me.urutlokasi.UseVisualStyleBackColor = True
        '
        'FrmFilterLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(474, 263)
        Me.Controls.Add(Me.txtlokasi)
        Me.Controls.Add(Me.txtwaktu)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.koma2)
        Me.Controls.Add(Me.koma1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.suhu2)
        Me.Controls.Add(Me.suhu1)
        Me.Controls.Add(Me.tgl2)
        Me.Controls.Add(Me.tgl1)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.urutsuhu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnklr)
        Me.Controls.Add(Me.urutwaktu)
        Me.Controls.Add(Me.uruttgl)
        Me.Controls.Add(Me.urutid)
        Me.Controls.Add(Me.btncetak)
        Me.Controls.Add(Me.urutlokasi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmFilterLaporan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtlokasi As System.Windows.Forms.TextBox
    Friend WithEvents txtwaktu As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents koma2 As System.Windows.Forms.TextBox
    Friend WithEvents koma1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents suhu2 As System.Windows.Forms.TextBox
    Friend WithEvents suhu1 As System.Windows.Forms.TextBox
    Friend WithEvents tgl2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents tgl1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents urutsuhu As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnklr As System.Windows.Forms.Button
    Friend WithEvents urutwaktu As System.Windows.Forms.RadioButton
    Friend WithEvents uruttgl As System.Windows.Forms.RadioButton
    Friend WithEvents urutid As System.Windows.Forms.RadioButton
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents urutlokasi As System.Windows.Forms.RadioButton
End Class
