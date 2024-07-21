Public Class Form_Operator_Perbandingan

    Private Sub BSamaDengan_Click(sender As Object, e As EventArgs) Handles BSamaDengan.Click
        Dim var_nilai1 As Integer = TbNilai1.Text
        Dim var_nilai2 As Integer = TbNilai2.Text

        Dim var_hasil As Boolean
        var_hasil = var_nilai1 = var_nilai2

        TbHasil.Text = var_hasil
    End Sub

    Private Sub BTidakSamaDengan_Click(sender As Object, e As EventArgs) Handles BTidakSamaDengan.Click
        Dim var_nilai1 As Integer = TbNilai1.Text
        Dim var_nilai2 As Integer = TbNilai2.Text

        Dim var_hasil As Boolean
        var_hasil = var_nilai1 <> var_nilai2

        TbHasil.Text = var_hasil
    End Sub

    Private Sub BLebihKecil_Click(sender As Object, e As EventArgs) Handles BLebihKecil.Click
        Dim var_nilai1 As Integer = TbNilai1.Text
        Dim var_nilai2 As Integer = TbNilai2.Text

        Dim var_hasil As Boolean
        var_hasil = var_nilai1 < var_nilai2

        TbHasil.Text = var_hasil
    End Sub

    Private Sub BLebihBesar_Click(sender As Object, e As EventArgs) Handles BLebihBesar.Click
        Dim var_nilai1 As Integer = TbNilai1.Text
        Dim var_nilai2 As Integer = TbNilai2.Text

        Dim var_hasil As Boolean
        var_hasil = var_nilai1 > var_nilai2

        TbHasil.Text = var_hasil
    End Sub

    Private Sub BLebihKecilSamaDengan_Click(sender As Object, e As EventArgs) Handles BLebihKecilSamaDengan.Click
        Dim var_nilai1 As Integer = TbNilai1.Text
        Dim var_nilai2 As Integer = TbNilai2.Text

        Dim var_hasil As Boolean
        var_hasil = var_nilai1 <= var_nilai2

        TbHasil.Text = var_hasil
    End Sub

    Private Sub BLebihBesarSamaDengan_Click(sender As Object, e As EventArgs) Handles BLebihBesarSamaDengan.Click
        Dim var_nilai1 As Integer = TbNilai1.Text
        Dim var_nilai2 As Integer = TbNilai2.Text

        Dim var_hasil As Boolean
        var_hasil = var_nilai1 >= var_nilai2

        TbHasil.Text = var_hasil
    End Sub

    Private Sub Form_Operator_Perbandingan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class