<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Dosen
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_NIDN = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TB_GAJI = New System.Windows.Forms.TextBox()
        Me.TB_NAMA_DOSEN = New System.Windows.Forms.TextBox()
        Me.LV_DATA_DOSEN = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TB_PRODI = New System.Windows.Forms.TextBox()
        Me.TB_PENGALAMAN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.B_SIMPAN = New System.Windows.Forms.Button()
        Me.B_HAPUS_TERPILIH = New System.Windows.Forms.Button()
        Me.B_HAPUS_SEMUA = New System.Windows.Forms.Button()
        Me.B_HITUNG_GAJI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(86, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "NIDN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(271, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Tahun"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(139, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Gaji"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(86, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Prodi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(86, 57)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Nama Dosen"
        '
        'TB_NIDN
        '
        Me.TB_NIDN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NIDN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TB_NIDN.Location = New System.Drawing.Point(210, 15)
        Me.TB_NIDN.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TB_NIDN.Name = "TB_NIDN"
        Me.TB_NIDN.Size = New System.Drawing.Size(221, 26)
        Me.TB_NIDN.TabIndex = 34
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(884, 508)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(276, 38)
        Me.TextBox2.TabIndex = 35
        '
        'TB_GAJI
        '
        Me.TB_GAJI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_GAJI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TB_GAJI.Location = New System.Drawing.Point(195, 229)
        Me.TB_GAJI.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TB_GAJI.Name = "TB_GAJI"
        Me.TB_GAJI.ReadOnly = True
        Me.TB_GAJI.Size = New System.Drawing.Size(184, 26)
        Me.TB_GAJI.TabIndex = 36
        '
        'TB_NAMA_DOSEN
        '
        Me.TB_NAMA_DOSEN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_NAMA_DOSEN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TB_NAMA_DOSEN.Location = New System.Drawing.Point(210, 55)
        Me.TB_NAMA_DOSEN.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TB_NAMA_DOSEN.Name = "TB_NAMA_DOSEN"
        Me.TB_NAMA_DOSEN.Size = New System.Drawing.Size(221, 26)
        Me.TB_NAMA_DOSEN.TabIndex = 38
        '
        'LV_DATA_DOSEN
        '
        Me.LV_DATA_DOSEN.BackColor = System.Drawing.Color.Yellow
        Me.LV_DATA_DOSEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LV_DATA_DOSEN.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LV_DATA_DOSEN.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LV_DATA_DOSEN.ForeColor = System.Drawing.Color.Black
        Me.LV_DATA_DOSEN.FullRowSelect = True
        Me.LV_DATA_DOSEN.GridLines = True
        Me.LV_DATA_DOSEN.Location = New System.Drawing.Point(28, 298)
        Me.LV_DATA_DOSEN.Name = "LV_DATA_DOSEN"
        Me.LV_DATA_DOSEN.Size = New System.Drawing.Size(546, 190)
        Me.LV_DATA_DOSEN.TabIndex = 39
        Me.LV_DATA_DOSEN.UseCompatibleStateImageBehavior = False
        Me.LV_DATA_DOSEN.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIDN"
        Me.ColumnHeader1.Width = 92
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "NAMA DOSEN"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 139
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "PRODI"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 80
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "GAJI"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 115
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "GAJI"
        Me.ColumnHeader5.Width = 115
        '
        'TB_PRODI
        '
        Me.TB_PRODI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PRODI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TB_PRODI.Location = New System.Drawing.Point(210, 95)
        Me.TB_PRODI.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TB_PRODI.Name = "TB_PRODI"
        Me.TB_PRODI.Size = New System.Drawing.Size(221, 26)
        Me.TB_PRODI.TabIndex = 40
        '
        'TB_PENGALAMAN
        '
        Me.TB_PENGALAMAN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_PENGALAMAN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TB_PENGALAMAN.Location = New System.Drawing.Point(210, 135)
        Me.TB_PENGALAMAN.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.TB_PENGALAMAN.Name = "TB_PENGALAMAN"
        Me.TB_PENGALAMAN.Size = New System.Drawing.Size(55, 26)
        Me.TB_PENGALAMAN.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(87, 135)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 19)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Pengalaman"
        '
        'B_SIMPAN
        '
        Me.B_SIMPAN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_SIMPAN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.B_SIMPAN.Location = New System.Drawing.Point(390, 229)
        Me.B_SIMPAN.Name = "B_SIMPAN"
        Me.B_SIMPAN.Size = New System.Drawing.Size(75, 26)
        Me.B_SIMPAN.TabIndex = 43
        Me.B_SIMPAN.Text = "Simpan"
        Me.B_SIMPAN.UseVisualStyleBackColor = True
        '
        'B_HAPUS_TERPILIH
        '
        Me.B_HAPUS_TERPILIH.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_HAPUS_TERPILIH.Location = New System.Drawing.Point(599, 307)
        Me.B_HAPUS_TERPILIH.Name = "B_HAPUS_TERPILIH"
        Me.B_HAPUS_TERPILIH.Size = New System.Drawing.Size(112, 61)
        Me.B_HAPUS_TERPILIH.TabIndex = 44
        Me.B_HAPUS_TERPILIH.Text = "Hapus Terpilih"
        Me.B_HAPUS_TERPILIH.UseVisualStyleBackColor = True
        '
        'B_HAPUS_SEMUA
        '
        Me.B_HAPUS_SEMUA.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_HAPUS_SEMUA.Location = New System.Drawing.Point(599, 392)
        Me.B_HAPUS_SEMUA.Name = "B_HAPUS_SEMUA"
        Me.B_HAPUS_SEMUA.Size = New System.Drawing.Size(112, 53)
        Me.B_HAPUS_SEMUA.TabIndex = 45
        Me.B_HAPUS_SEMUA.Text = "Hapus Semua"
        Me.B_HAPUS_SEMUA.UseVisualStyleBackColor = True
        '
        'B_HITUNG_GAJI
        '
        Me.B_HITUNG_GAJI.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_HITUNG_GAJI.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.B_HITUNG_GAJI.Location = New System.Drawing.Point(226, 190)
        Me.B_HITUNG_GAJI.Name = "B_HITUNG_GAJI"
        Me.B_HITUNG_GAJI.Size = New System.Drawing.Size(131, 29)
        Me.B_HITUNG_GAJI.TabIndex = 46
        Me.B_HITUNG_GAJI.Text = "Hitung Gaji"
        Me.B_HITUNG_GAJI.UseVisualStyleBackColor = True
        '
        'Form_Data_Dosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(17.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(732, 516)
        Me.Controls.Add(Me.B_HITUNG_GAJI)
        Me.Controls.Add(Me.B_HAPUS_SEMUA)
        Me.Controls.Add(Me.B_HAPUS_TERPILIH)
        Me.Controls.Add(Me.B_SIMPAN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_PENGALAMAN)
        Me.Controls.Add(Me.TB_PRODI)
        Me.Controls.Add(Me.LV_DATA_DOSEN)
        Me.Controls.Add(Me.TB_NAMA_DOSEN)
        Me.Controls.Add(Me.TB_GAJI)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TB_NIDN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "Form_Data_Dosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Data_Dosen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_NIDN As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TB_GAJI As System.Windows.Forms.TextBox
    Friend WithEvents TB_NAMA_DOSEN As System.Windows.Forms.TextBox
    Friend WithEvents LV_DATA_DOSEN As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TB_PRODI As System.Windows.Forms.TextBox
    Friend WithEvents TB_PENGALAMAN As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents B_SIMPAN As System.Windows.Forms.Button
    Friend WithEvents B_HAPUS_TERPILIH As System.Windows.Forms.Button
    Friend WithEvents B_HAPUS_SEMUA As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents B_HITUNG_GAJI As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
