Public Class Form1
    Private Sub perbaruiDGV(ByVal Jumlah As Integer)
        DGV.Rows.Clear()
        If Jumlah > 0 Then
            For i As Integer = 0 To Jumlah - 1
                DGV.Rows.Add(DaftarBuku(i).Judul, DaftarBuku(i).Genre)
            Next
        End If
    End Sub

    ' Button Tambah
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If boxTJudul.Text <> "" And boxTGenre.Text <> "" Then
            ReDim Preserve DaftarBuku(JumlahBuku)

            DaftarBuku(JumlahBuku).Judul = boxTJudul.Text
            DaftarBuku(JumlahBuku).Genre = boxTGenre.Text

            JumlahBuku += 1
            perbaruiDGV(JumlahBuku)

            boxTJudul.Clear()
            boxTGenre.Clear()
            MsgBox("Buku berhasil ditambahkan!")
        Else
            MsgBox("Judul dan Genre tidak boleh kosong!")
        End If
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulHapus As String = boxHJudul.Text
        Dim index As Integer = CariBukuIndex(judulHapus)

        If index <> -1 Then
            For i As Integer = index To JumlahBuku - 2
                DaftarBuku(i) = DaftarBuku(i + 1)
            Next

            JumlahBuku -= 1
            If JumlahBuku > 0 Then
                ReDim Preserve DaftarBuku(JumlahBuku - 1)
            Else
                Erase DaftarBuku
            End If

            perbaruiDGV(JumlahBuku)
            boxHJudul.Clear()
            MsgBox("Buku berhasil dihapus!")
        Else
            MsgBox("Data tidak ditemukan!")
        End If
    End Sub
End Class