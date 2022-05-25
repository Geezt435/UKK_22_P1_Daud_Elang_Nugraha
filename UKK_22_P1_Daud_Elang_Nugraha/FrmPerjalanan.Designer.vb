<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPerjalanan
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtsuhu = New System.Windows.Forms.TextBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnlapor = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.dttanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtjam2 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtjam1 = New System.Windows.Forms.TextBox()
        Me.txtlokasi = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cburutan = New System.Windows.Forms.ComboBox()
        Me.btnurutkan = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbASC = New System.Windows.Forms.RadioButton()
        Me.rbDESC = New System.Windows.Forms.RadioButton()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(165, 77)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 18)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(21, 14)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 18)
        Me.Label8.TabIndex = 107
        Me.Label8.Text = "ID Perjalanan"
        '
        'txtsuhu
        '
        Me.txtsuhu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtsuhu.Location = New System.Drawing.Point(141, 137)
        Me.txtsuhu.Margin = New System.Windows.Forms.Padding(2)
        Me.txtsuhu.Name = "txtsuhu"
        Me.txtsuhu.Size = New System.Drawing.Size(70, 23)
        Me.txtsuhu.TabIndex = 98
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtid.Location = New System.Drawing.Point(142, 12)
        Me.txtid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(69, 23)
        Me.txtid.TabIndex = 108
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(53, 45)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Tanggal"
        '
        'btnlapor
        '
        Me.btnlapor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnlapor.FlatAppearance.BorderSize = 0
        Me.btnlapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlapor.Font = New System.Drawing.Font("DFPOP1-W9", 12.0!)
        Me.btnlapor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlapor.Location = New System.Drawing.Point(958, 168)
        Me.btnlapor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnlapor.Name = "btnlapor"
        Me.btnlapor.Size = New System.Drawing.Size(76, 31)
        Me.btnlapor.TabIndex = 134
        Me.btnlapor.Text = "Laporan"
        Me.btnlapor.UseVisualStyleBackColor = False
        '
        'btnbatal
        '
        Me.btnbatal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnbatal.FlatAppearance.BorderSize = 0
        Me.btnbatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbatal.Font = New System.Drawing.Font("DFPOP1-W9", 12.0!)
        Me.btnbatal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnbatal.Location = New System.Drawing.Point(852, 168)
        Me.btnbatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(73, 31)
        Me.btnbatal.TabIndex = 92
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = False
        '
        'btnhapus
        '
        Me.btnhapus.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnhapus.FlatAppearance.BorderSize = 0
        Me.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhapus.Font = New System.Drawing.Font("DFPOP1-W9", 12.0!)
        Me.btnhapus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnhapus.Location = New System.Drawing.Point(745, 168)
        Me.btnhapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(70, 31)
        Me.btnhapus.TabIndex = 91
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnubah.FlatAppearance.BorderSize = 0
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Font = New System.Drawing.Font("DFPOP1-W9", 12.0!)
        Me.btnubah.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnubah.Location = New System.Drawing.Point(637, 168)
        Me.btnubah.Margin = New System.Windows.Forms.Padding(2)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(63, 31)
        Me.btnubah.TabIndex = 90
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnsimpan
        '
        Me.btnsimpan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsimpan.FlatAppearance.BorderSize = 0
        Me.btnsimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsimpan.Font = New System.Drawing.Font("DFPOP1-W9", 12.0!)
        Me.btnsimpan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsimpan.Location = New System.Drawing.Point(511, 168)
        Me.btnsimpan.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(82, 31)
        Me.btnsimpan.TabIndex = 89
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = False
        '
        'dttanggal
        '
        Me.dttanggal.CustomFormat = "dd MMMM yyyy"
        Me.dttanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.dttanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dttanggal.Location = New System.Drawing.Point(141, 43)
        Me.dttanggal.Margin = New System.Windows.Forms.Padding(2)
        Me.dttanggal.Name = "dttanggal"
        Me.dttanggal.Size = New System.Drawing.Size(162, 23)
        Me.dttanggal.TabIndex = 102
        '
        'txtjam2
        '
        Me.txtjam2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtjam2.Location = New System.Drawing.Point(178, 74)
        Me.txtjam2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjam2.Name = "txtjam2"
        Me.txtjam2.Size = New System.Drawing.Size(24, 23)
        Me.txtjam2.TabIndex = 100
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnlapor)
        Me.Panel3.Controls.Add(Me.btnbatal)
        Me.Panel3.Controls.Add(Me.btnhapus)
        Me.Panel3.Controls.Add(Me.txtid)
        Me.Panel3.Controls.Add(Me.btnubah)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.btnsimpan)
        Me.Panel3.Controls.Add(Me.dttanggal)
        Me.Panel3.Controls.Add(Me.txtsuhu)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtjam2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtjam1)
        Me.Panel3.Controls.Add(Me.txtlokasi)
        Me.Panel3.Location = New System.Drawing.Point(19, 11)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1052, 217)
        Me.Panel3.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(78, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Jam"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(71, 137)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Suhu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Schadow BT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(65, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "Lokasi"
        '
        'txtjam1
        '
        Me.txtjam1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtjam1.Location = New System.Drawing.Point(141, 74)
        Me.txtjam1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtjam1.Name = "txtjam1"
        Me.txtjam1.Size = New System.Drawing.Size(24, 23)
        Me.txtjam1.TabIndex = 88
        '
        'txtlokasi
        '
        Me.txtlokasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.txtlokasi.Location = New System.Drawing.Point(141, 105)
        Me.txtlokasi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtlokasi.Name = "txtlokasi"
        Me.txtlokasi.Size = New System.Drawing.Size(176, 23)
        Me.txtlokasi.TabIndex = 97
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(110, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(70, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(19, 244)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 42
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1052, 251)
        Me.DataGridView1.TabIndex = 113
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cburutan)
        Me.Panel1.Controls.Add(Me.btnurutkan)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.rbASC)
        Me.Panel1.Controls.Add(Me.rbDESC)
        Me.Panel1.Controls.Add(Me.txtcari)
        Me.Panel1.Location = New System.Drawing.Point(0, 532)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1103, 127)
        Me.Panel1.TabIndex = 135
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1115, 10)
        Me.Panel2.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Location = New System.Drawing.Point(927, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 24)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Pencarian Data :"
        '
        'cburutan
        '
        Me.cburutan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cburutan.FormattingEnabled = True
        Me.cburutan.Items.AddRange(New Object() {"ID", "Tanggal", "Waktu", "Lokasi", "Suhu Tubuh"})
        Me.cburutan.Location = New System.Drawing.Point(283, 31)
        Me.cburutan.Name = "cburutan"
        Me.cburutan.Size = New System.Drawing.Size(165, 21)
        Me.cburutan.TabIndex = 106
        '
        'btnurutkan
        '
        Me.btnurutkan.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnurutkan.FlatAppearance.BorderSize = 0
        Me.btnurutkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnurutkan.Font = New System.Drawing.Font("DFPOP1-W9", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnurutkan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnurutkan.Location = New System.Drawing.Point(283, 63)
        Me.btnurutkan.Name = "btnurutkan"
        Me.btnurutkan.Size = New System.Drawing.Size(165, 30)
        Me.btnurutkan.TabIndex = 109
        Me.btnurutkan.Text = "URUTKAN"
        Me.btnurutkan.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Location = New System.Drawing.Point(15, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(214, 24)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Urutkan berdasarkan :"
        '
        'rbASC
        '
        Me.rbASC.AutoSize = True
        Me.rbASC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbASC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbASC.Location = New System.Drawing.Point(20, 62)
        Me.rbASC.Name = "rbASC"
        Me.rbASC.Size = New System.Drawing.Size(77, 21)
        Me.rbASC.TabIndex = 104
        Me.rbASC.TabStop = True
        Me.rbASC.Text = "Menaik"
        Me.rbASC.UseVisualStyleBackColor = True
        '
        'rbDESC
        '
        Me.rbDESC.AutoSize = True
        Me.rbDESC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDESC.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.rbDESC.Location = New System.Drawing.Point(131, 63)
        Me.rbDESC.Name = "rbDESC"
        Me.rbDESC.Size = New System.Drawing.Size(89, 21)
        Me.rbDESC.TabIndex = 105
        Me.rbDESC.TabStop = True
        Me.rbDESC.Text = "Menurun"
        Me.rbDESC.UseVisualStyleBackColor = True
        '
        'txtcari
        '
        Me.txtcari.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcari.Location = New System.Drawing.Point(872, 70)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(214, 23)
        Me.txtcari.TabIndex = 96
        '
        'FrmPerjalanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1098, 658)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPerjalanan"
        Me.Text = "FrmPerjalanan"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtsuhu As System.Windows.Forms.TextBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnlapor As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents dttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtjam2 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtjam1 As System.Windows.Forms.TextBox
    Friend WithEvents txtlokasi As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cburutan As System.Windows.Forms.ComboBox
    Friend WithEvents btnurutkan As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rbASC As System.Windows.Forms.RadioButton
    Friend WithEvents rbDESC As System.Windows.Forms.RadioButton
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
End Class
