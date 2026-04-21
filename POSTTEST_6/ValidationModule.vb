Module ValidationModule
    Public Function ValidasiOp(ep As ErrorProvider, id As TextBox, nm As TextBox, rar As TextBox) As Boolean
        Dim status As Boolean = True
        ep.Clear()
        If String.IsNullOrWhiteSpace(id.Text) Then ep.SetError(id, "ID Kosong!") : status = False
        If String.IsNullOrWhiteSpace(nm.Text) Then ep.SetError(nm, "Nama Kosong!") : status = False

        Dim r As Integer
        If Not Integer.TryParse(rar.Text, r) OrElse r < 1 OrElse r > 6 Then
            ep.SetError(rar, "Input angka 1-6!")
            status = False
        End If
        Return status
    End Function
End Module