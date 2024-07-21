Public Class Form_Data_Dosen

    Private Sub B_SIMPAN_Click(sender As Object, e As EventArgs) Handles B_SIMPAN.Click
        Dim data As New ListViewItem
        data.Text = TB_NIDN.Text
        data.SubItems.Add(TB_NAMA_DOSEN.Text)
        data.SubItems.Add(TB_PRODI.Text)
        data.SubItems.Add(TB_PENGALAMAN.Text + " Tahun")
        data.SubItems.Add(TB_GAJI.Text)

        If TB_NIDN.Text = "" Or TB_NAMA_DOSEN.Text = "" Or TB_PRODI.Text = "" Then
            MsgBox("Data tidak boleh kosong.", MsgBoxStyle.Critical)
        Else
            LV_DATA_DOSEN.Items.Add(data)
            TB_NIDN.Clear()
            TB_NAMA_DOSEN.Clear()
            TB_PRODI.Clear()
            TB_PENGALAMAN.Clear()
            TB_GAJI.Clear()
            MsgBox("Data berhasil disimpan.")
        End If
    End Sub

    Private Sub B_HAPUS_TERPILIH_Click(sender As Object, e As EventArgs) Handles B_HAPUS_TERPILIH.Click
        If LV_DATA_DOSEN.SelectedItems.Count = 0 Then
            MsgBox("Pilih data terlebih dahulu!", MsgBoxStyle.Critical)
        Else
            Dim pesan As String
            pesan = MsgBox("Yakin hapus data terpilih?", MsgBoxStyle.YesNo)
            If pesan = vbYes Then
                LV_DATA_DOSEN.SelectedItems(0).Remove()
            End If
            pesan = MsgBox("Data Berhasil Dihapus")
        End If
    End Sub

    Private Sub B_HAPUS_SEMUA_Click(sender As Object, e As EventArgs) Handles B_HAPUS_SEMUA.Click
        Dim pesan As String
        pesan = MsgBox("Yakin hapus semua data?", MsgBoxStyle.YesNo)
        If pesan = vbYes Then
            LV_DATA_DOSEN.Items.Clear()
        End If
        pesan = MsgBox("Semua Data Berhasil Dihapus")
    End Sub

    Private Sub B_HITUNG_GAJI_Click(sender As Object, e As EventArgs) Handles B_HITUNG_GAJI.Click
        If TB_PENGALAMAN.Text = "" Then
            MessageBox.Show("Data Pengalaman tidak boleh kosong!")
            Exit Sub
        End If

        Dim Gaji As Integer = 2000000 + (50000 * Integer.Parse(TB_PENGALAMAN.Text))
        TB_GAJI.Text = "Rp. " + Gaji.ToString

    End Sub
End Class