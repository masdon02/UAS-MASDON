Public Class Form1


    Private Sub B_Tambah_Click(sender As Object, e As EventArgs) Handles B_Tambah.Click
        Dim nilai1 As Integer
        nilai1 = Tb_Nilai1.Text

        Dim nilai2 As Integer
        nilai2 = Tb_Nilai2.Text

        Dim hasil As Integer
        hasil = nilai1 + nilai2

        Dim Pesan As String
        Pesan = nilai1 & " + " & nilai2 & " = " & hasil        
        tb_hasil.Text = Pesan
        lb_hasil.Text = "Hasil Tambah"

    End Sub

    Private Sub B_Kurang_Click(sender As Object, e As EventArgs) Handles B_Kurang.Click

        Dim var_nilai_1 As Integer
        var_nilai_1 = Tb_Nilai1.Text

        Dim var_nilai_2 As Integer
        var_nilai_2 = Tb_Nilai2.Text

        Dim var_hasil As Integer
        var_hasil = var_nilai_1 - var_nilai_2

        Dim pesan As String
        pesan = var_nilai_1 & " - " & var_nilai_2 & " = " & var_hasil
        'MsgBox(pesan, , "Hasil Kurang")
        tb_hasil.Text = pesan
        lb_hasil.Text = "Hasil Kurang"

    End Sub

    Private Sub B_Kali_Click(sender As Object, e As EventArgs) Handles B_Kali.Click
        Dim var_nilai_1 As Integer
        var_nilai_1 = Tb_Nilai1.Text

        Dim var_nilai_2 As Integer
        var_nilai_2 = Tb_Nilai2.Text

        Dim var_hasil As Integer
        var_hasil = var_nilai_1 * var_nilai_2

        Dim pesan As String
        pesan = var_nilai_1 & " x " & var_nilai_2 & " = " & var_hasil
        'MsgBox(pesan, , "Hasil Kali")
        tb_hasil.Text = pesan
        lb_hasil.Text = "Hasil Kali"

    End Sub

    Private Sub B_Bagi_Click(sender As Object, e As EventArgs) Handles B_Bagi.Click
        Dim var_nilai_1 As Integer
        var_nilai_1 = Tb_Nilai1.Text

        Dim var_nilai_2 As Integer
        var_nilai_2 = Tb_Nilai2.Text

        Dim var_hasil As Integer
        var_hasil = var_nilai_1 / var_nilai_2

        Dim pesan As String
        pesan = var_nilai_1 & " : " & var_nilai_2 & " = " & var_hasil
        'MsgBox(pesan, , "Hasil Bagi")
        tb_hasil.Text = pesan
        lb_hasil.Text = "Hasil Bagi"

    End Sub

    Private Sub B_Sisa_Bagi_Click(sender As Object, e As EventArgs) Handles B_Sisa_Bagi.Click
        Dim var_nilai_1 As Integer
        var_nilai_1 = Tb_Nilai1.Text

        Dim var_nilai_2 As Integer
        var_nilai_2 = Tb_Nilai2.Text

        Dim var_hasil As Integer
        var_hasil = var_nilai_1 Mod var_nilai_2

        Dim pesan As String
        pesan = var_nilai_1 & "  Mod " & var_nilai_2 & " = " & var_hasil
        tb_hasil.Text = pesan
        lb_hasil.Text = "Hasil Sisa Bagi"

    End Sub

    Private Sub B_Pangkat_Click(sender As Object, e As EventArgs) Handles B_Pangkat.Click
        Dim var_nilai_1 As Integer
        var_nilai_1 = Tb_Nilai1.Text

        Dim var_nilai_2 As Integer
        var_nilai_2 = Tb_Nilai2.Text

        Dim var_hasil As Integer
        var_hasil = var_nilai_1 ^ var_nilai_2

        Dim pesan As String
        pesan = var_nilai_1 & " ^ " & var_nilai_2 & " = " & var_hasil
        tb_hasil.Text = pesan
        lb_hasil.Text = "Hasil Pangkat"

    End Sub
End Class
