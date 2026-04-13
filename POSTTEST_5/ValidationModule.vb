Module ValidationModule
    Public Function ValidasiInput(id As String, nama As String, rarityStr As String) As Boolean
        If String.IsNullOrWhiteSpace(id) Or String.IsNullOrWhiteSpace(nama) Then
            Return False
        End If

        Dim r As Integer
        If Integer.TryParse(rarityStr, r) Then
            Return (r >= 1 And r <= 6)
        End If

        Return False
    End Function
End Module