<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Operator_Logika
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
        Me.lb_hasil = New System.Windows.Forms.Label()
        Me.TbHasil = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BAnd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbNilai1 = New System.Windows.Forms.ComboBox()
        Me.CbNilai2 = New System.Windows.Forms.ComboBox()
        Me.BOr = New System.Windows.Forms.Button()
        Me.BXor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lb_hasil
        '
        Me.lb_hasil.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_hasil.Location = New System.Drawing.Point(340, 338)
        Me.lb_hasil.Name = "lb_hasil"
        Me.lb_hasil.Size = New System.Drawing.Size(544, 64)
        Me.lb_hasil.TabIndex = 28
        Me.lb_hasil.Text = "Hasil"
        Me.lb_hasil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TbHasil
        '
        Me.TbHasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TbHasil.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbHasil.Location = New System.Drawing.Point(340, 405)
        Me.TbHasil.Name = "TbHasil"
        Me.TbHasil.ReadOnly = True
        Me.TbHasil.Size = New System.Drawing.Size(544, 77)
        Me.TbHasil.TabIndex = 27
        Me.TbHasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 64)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nilai Ke-2"
        '
        'BAnd
        '
        Me.BAnd.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BAnd.Location = New System.Drawing.Point(340, 215)
        Me.BAnd.Name = "BAnd"
        Me.BAnd.Size = New System.Drawing.Size(150, 90)
        Me.BAnd.TabIndex = 25
        Me.BAnd.Text = "And"
        Me.BAnd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 64)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nilai Ke-1"
        '
        'CbNilai1
        '
        Me.CbNilai1.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold)
        Me.CbNilai1.FormattingEnabled = True
        Me.CbNilai1.Items.AddRange(New Object() {"True", "False"})
        Me.CbNilai1.Location = New System.Drawing.Point(340, 17)
        Me.CbNilai1.Name = "CbNilai1"
        Me.CbNilai1.Size = New System.Drawing.Size(544, 72)
        Me.CbNilai1.TabIndex = 29
        '
        'CbNilai2
        '
        Me.CbNilai2.Font = New System.Drawing.Font("Mongolian Baiti", 36.0!, System.Drawing.FontStyle.Bold)
        Me.CbNilai2.FormattingEnabled = True
        Me.CbNilai2.Items.AddRange(New Object() {"True", "False"})
        Me.CbNilai2.Location = New System.Drawing.Point(340, 124)
        Me.CbNilai2.Name = "CbNilai2"
        Me.CbNilai2.Size = New System.Drawing.Size(544, 72)
        Me.CbNilai2.TabIndex = 29
        '
        'BOr
        '
        Me.BOr.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BOr.Location = New System.Drawing.Point(546, 215)
        Me.BOr.Name = "BOr"
        Me.BOr.Size = New System.Drawing.Size(150, 90)
        Me.BOr.TabIndex = 25
        Me.BOr.Text = "Or"
        Me.BOr.UseVisualStyleBackColor = True
        '
        'BXor
        '
        Me.BXor.Font = New System.Drawing.Font("Mongolian Baiti", 32.0!, System.Drawing.FontStyle.Bold)
        Me.BXor.Location = New System.Drawing.Point(734, 215)
        Me.BXor.Name = "BXor"
        Me.BXor.Size = New System.Drawing.Size(150, 90)
        Me.BXor.TabIndex = 25
        Me.BXor.Text = "Xor"
        Me.BXor.UseVisualStyleBackColor = True
        '
        'Form_Operator_Logika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 514)
        Me.Controls.Add(Me.CbNilai2)
        Me.Controls.Add(Me.CbNilai1)
        Me.Controls.Add(Me.lb_hasil)
        Me.Controls.Add(Me.TbHasil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BXor)
        Me.Controls.Add(Me.BOr)
        Me.Controls.Add(Me.BAnd)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Operator_Logika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Operator Logika"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_hasil As System.Windows.Forms.Label
    Friend WithEvents TbHasil As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BAnd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbNilai1 As System.Windows.Forms.ComboBox
    Friend WithEvents CbNilai2 As System.Windows.Forms.ComboBox
    Friend WithEvents BOr As System.Windows.Forms.Button
    Friend WithEvents BXor As System.Windows.Forms.Button
End Class
