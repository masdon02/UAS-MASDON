<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Menu_Utama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AritmatikaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerbandinganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogikaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MatakuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NilaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperatorToolStripMenuItem, Me.DataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(746, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperatorToolStripMenuItem
        '
        Me.OperatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AritmatikaToolStripMenuItem, Me.PerbandinganToolStripMenuItem, Me.LogikaToolStripMenuItem, Me.ToolStripMenuItem1, Me.KeluarToolStripMenuItem})
        Me.OperatorToolStripMenuItem.Name = "OperatorToolStripMenuItem"
        Me.OperatorToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.OperatorToolStripMenuItem.Text = "Operator"
        '
        'AritmatikaToolStripMenuItem
        '
        Me.AritmatikaToolStripMenuItem.Name = "AritmatikaToolStripMenuItem"
        Me.AritmatikaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AritmatikaToolStripMenuItem.Text = "Aritmatika"
        '
        'PerbandinganToolStripMenuItem
        '
        Me.PerbandinganToolStripMenuItem.Name = "PerbandinganToolStripMenuItem"
        Me.PerbandinganToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.PerbandinganToolStripMenuItem.Text = "Perbandingan"
        '
        'LogikaToolStripMenuItem
        '
        Me.LogikaToolStripMenuItem.Name = "LogikaToolStripMenuItem"
        Me.LogikaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.LogikaToolStripMenuItem.Text = "Logika"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(145, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MahasiswaToolStripMenuItem, Me.DosenToolStripMenuItem, Me.MatakuliahToolStripMenuItem, Me.NilaiToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "Data"
        '
        'MahasiswaToolStripMenuItem
        '
        Me.MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        Me.MahasiswaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MahasiswaToolStripMenuItem.Text = "Mahasiswa"
        '
        'DosenToolStripMenuItem
        '
        Me.DosenToolStripMenuItem.Name = "DosenToolStripMenuItem"
        Me.DosenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DosenToolStripMenuItem.Text = "Dosen"
        '
        'MatakuliahToolStripMenuItem
        '
        Me.MatakuliahToolStripMenuItem.Name = "MatakuliahToolStripMenuItem"
        Me.MatakuliahToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MatakuliahToolStripMenuItem.Text = "Matakuliah"
        '
        'NilaiToolStripMenuItem
        '
        Me.NilaiToolStripMenuItem.Name = "NilaiToolStripMenuItem"
        Me.NilaiToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NilaiToolStripMenuItem.Text = "Nilai"
        '
        'Form_Menu_Utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(746, 578)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_Menu_Utama"
        Me.Text = "Form Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AritmatikaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerbandinganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogikaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DosenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatakuliahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NilaiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
