<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Mahasiswa
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
        Me.BSimpan = New System.Windows.Forms.Button()
        Me.TbNIRM = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbKelas = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LvTabelMahasiswa = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BHapusTerpilih = New System.Windows.Forms.Button()
        Me.BHapusSemua = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BSimpan
        '
        Me.BSimpan.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BSimpan.Location = New System.Drawing.Point(190, 262)
        Me.BSimpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BSimpan.Name = "BSimpan"
        Me.BSimpan.Size = New System.Drawing.Size(196, 73)
        Me.BSimpan.TabIndex = 26
        Me.BSimpan.Text = "Simpan"
        Me.BSimpan.UseVisualStyleBackColor = True
        '
        'TbNIRM
        '
        Me.TbNIRM.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNIRM.Location = New System.Drawing.Point(190, 13)
        Me.TbNIRM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbNIRM.Name = "TbNIRM"
        Me.TbNIRM.Size = New System.Drawing.Size(324, 63)
        Me.TbNIRM.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 50)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "NIRM :"
        '
        'TbNama
        '
        Me.TbNama.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbNama.Location = New System.Drawing.Point(190, 96)
        Me.TbNama.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.Size = New System.Drawing.Size(664, 63)
        Me.TbNama.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 50)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nama :"
        '
        'TbKelas
        '
        Me.TbKelas.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbKelas.Location = New System.Drawing.Point(190, 184)
        Me.TbKelas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TbKelas.Name = "TbKelas"
        Me.TbKelas.Size = New System.Drawing.Size(223, 63)
        Me.TbKelas.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 184)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 50)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Kelas :"
        '
        'LvTabelMahasiswa
        '
        Me.LvTabelMahasiswa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LvTabelMahasiswa.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.LvTabelMahasiswa.FullRowSelect = True
        Me.LvTabelMahasiswa.GridLines = True
        Me.LvTabelMahasiswa.Location = New System.Drawing.Point(9, 357)
        Me.LvTabelMahasiswa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LvTabelMahasiswa.Name = "LvTabelMahasiswa"
        Me.LvTabelMahasiswa.Size = New System.Drawing.Size(738, 232)
        Me.LvTabelMahasiswa.TabIndex = 33
        Me.LvTabelMahasiswa.UseCompatibleStateImageBehavior = False
        Me.LvTabelMahasiswa.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIRM"
        Me.ColumnHeader1.Width = 196
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 424
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Kelas"
        Me.ColumnHeader3.Width = 271
        '
        'BHapusTerpilih
        '
        Me.BHapusTerpilih.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BHapusTerpilih.Location = New System.Drawing.Point(748, 357)
        Me.BHapusTerpilih.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BHapusTerpilih.Name = "BHapusTerpilih"
        Me.BHapusTerpilih.Size = New System.Drawing.Size(200, 115)
        Me.BHapusTerpilih.TabIndex = 34
        Me.BHapusTerpilih.Text = "Hapus Terpilih"
        Me.BHapusTerpilih.UseVisualStyleBackColor = True
        '
        'BHapusSemua
        '
        Me.BHapusSemua.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BHapusSemua.Location = New System.Drawing.Point(750, 476)
        Me.BHapusSemua.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BHapusSemua.Name = "BHapusSemua"
        Me.BHapusSemua.Size = New System.Drawing.Size(200, 115)
        Me.BHapusSemua.TabIndex = 34
        Me.BHapusSemua.Text = "Hapus Semua"
        Me.BHapusSemua.UseVisualStyleBackColor = True
        '
        'Form_Data_Mahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 597)
        Me.Controls.Add(Me.BHapusSemua)
        Me.Controls.Add(Me.BHapusTerpilih)
        Me.Controls.Add(Me.LvTabelMahasiswa)
        Me.Controls.Add(Me.TbKelas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbNIRM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BSimpan)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_Data_Mahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Data Mahasiswa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BSimpan As System.Windows.Forms.Button
    Friend WithEvents TbNIRM As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TbKelas As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LvTabelMahasiswa As System.Windows.Forms.ListView
    Friend WithEvents BHapusTerpilih As System.Windows.Forms.Button
    Friend WithEvents BHapusSemua As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
