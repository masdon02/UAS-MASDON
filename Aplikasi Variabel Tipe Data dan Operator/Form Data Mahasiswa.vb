Public Class Form_Data_Mahasiswa
    Private Sub BSimpan_Click(sender As Object, e As EventArgs) Handles BSimpan.Click

        Dim data As New ListViewItem
        data.Text = TbNIRM.Text
        data.SubItems.Add(TbNama.Text)
        data.SubItems.Add(TbKelas.Text)

        If TbNIRM.Text = "" Or TbNama.Text = "" Or TbKelas.Text = "" Then
            MsgBox("Data tidak boleh kosong.", MsgBoxStyle.Critical)
        Else
            LvTabelMahasiswa.Items.Add(data)
            TbNIRM.Clear()
            TbNama.Clear()
            TbKelas.Clear()
            MsgBox("Data berhasil disimpan.")
        End If


    End Sub

    Private Sub BHapusTerpilih_Click(sender As Object, e As EventArgs) Handles BHapusTerpilih.Click
       If LvTabelMahasiswa.SelectedItems.Count = 0 Then
            MsgBox("Pilih data terlebih dahulu!", MsgBoxStyle.Critical)
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin hapus data terpilih?", MsgBoxStyle.YesNo)
            If pesan = vbYes Then
                LvTabelMahasiswa.SelectedItems(0).Remove()
            End If
        End If

    End Sub

    Private Sub BHapusSemua_Click(sender As Object, e As EventArgs) Handles BHapusSemua.Click
        Dim pesan As String
        pesan = MsgBox("Yakin hapus semua data?", MsgBoxStyle.YesNo)
        If pesan = vbYes Then
            LvTabelMahasiswa.Items.Clear()
        End If
    End Sub

    Private Sub LvTabelMahasiswa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvTabelMahasiswa.SelectedIndexChanged

    End Sub
End Class
