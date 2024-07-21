Public Class Form_Operator_Logika
    Private Sub BAnd_Click(sender As Object, e As EventArgs) Handles BAnd.Click
        Dim var_nilai1 As Boolean
        var_nilai1 = CbNilai1.Text

        Dim var_nilai2 As Boolean
        var_nilai2 = CbNilai2.Text

        Dim var_hasil As Boolean
        var_hasil = var_nilai1 And var_nilai2

        TbHasil.Text = var_hasil
    End Sub

    Private Sub BOr_Click(sender As Object, e As EventArgs) Handles BOr.Click
        TbHasil.Text = CBool(CbNilai1.Text) Or CBool(CbNilai2.Text)
    End Sub

    Private Sub BXor_Click(sender As Object, e As EventArgs) Handles BXor.Click
        TbHasil.Text = CBool(CbNilai1.Text) Xor CBool(CbNilai2.Text)
    End Sub
End Class