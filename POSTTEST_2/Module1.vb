Module DataModule
    Public Structure Buku
        Dim Judul As String
        Dim Genre As String
    End Structure
    Public DaftarBuku() As Buku
    Public JumlahBuku As Integer = 0
    Public Function CariBukuIndex(ByVal judulCari As String) As Integer
        If JumlahBuku = 0 Then Return -1

        For i As Integer = 0 To JumlahBuku - 1
            If DaftarBuku(i).Judul.ToLower() = judulCari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function
End Module