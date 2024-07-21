Public Class Form_Menu_Utama

    Private Sub AritmatikaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AritmatikaToolStripMenuItem.Click
        Form1.MdiParent = Me
        Form1.Show()
    End Sub

    Private Sub PerbandinganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerbandinganToolStripMenuItem.Click
        Form_Operator_Perbandingan.MdiParent = Me
        Form_Operator_Perbandingan.Show()
    End Sub

    Private Sub LogikaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogikaToolStripMenuItem.Click
        Form_Operator_Logika.MdiParent = Me
        Form_Operator_Logika.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub MahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MahasiswaToolStripMenuItem.Click
        Form_Data_Mahasiswa.MdiParent = Me
        Form_Data_Mahasiswa.Show()
    End Sub

    Private Sub DosenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DosenToolStripMenuItem.Click
        Form_Data_Dosen.MdiParent = Me
        Form_Data_Dosen.Show()
    End Sub
End Class