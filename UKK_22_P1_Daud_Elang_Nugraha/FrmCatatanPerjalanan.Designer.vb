<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatatanPerjalanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatatanPerjalanan))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cburutan = New System.Windows.Forms.ComboBox()
        Me.btnurutkan = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rbASC = New System.Windows.Forms.RadioButton()
        Me.rbDESC = New System.Windows.Forms.RadioButton()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(0, 543)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1098, 113)
        Me.Panel1.TabIndex = 113
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, -6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1098, 10)
        Me.Panel2.TabIndex = 111
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label5.Location = New System.Drawing.Point(927, 21)
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
        Me.cburutan.Location = New System.Drawing.Point(283, 21)
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
        Me.btnurutkan.Location = New System.Drawing.Point(283, 53)
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
        Me.Label7.Location = New System.Drawing.Point(15, 21)
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
        Me.rbASC.Location = New System.Drawing.Point(20, 52)
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
        Me.rbDESC.Location = New System.Drawing.Point(131, 53)
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
        'DataGridView1
        '
        Me.DataGridView1.AllowDrop = True
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
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
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(32, 22)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.RowHeadersWidth = 42
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1034, 495)
        Me.DataGridView1.TabIndex = 112
        '
        'FrmCatatanPerjalanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1098, 658)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmCatatanPerjalanan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cburutan As System.Windows.Forms.ComboBox
    Friend WithEvents btnurutkan As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents rbASC As System.Windows.Forms.RadioButton
    Friend WithEvents rbDESC As System.Windows.Forms.RadioButton
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
