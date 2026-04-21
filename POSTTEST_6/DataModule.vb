Imports MySqlConnector

Module DataModule
    Public Function GetAllFaksi() As DataTable
        Dim dt As New DataTable()
        Using conn = GetConnection()
            Dim da As New MySqlDataAdapter("SELECT * FROM tb_faksi", conn)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Sub SimpanFaksi(id As String, nm As String)
        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO tb_faksi VALUES (@id, @nm)", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nm", nm)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub UbahFaksi(id As String, nm As String)
        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("UPDATE tb_faksi SET nama_faksi=@nm WHERE id_faksi=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nm", nm)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub HapusFaksi(id As String)
        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM tb_faksi WHERE id_faksi=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function GetOperatorByFaksi(idFk As String) As DataTable
        Dim dt As New DataTable()
        If idFk Is Nothing OrElse idFk.Contains("DataRowView") Then Return dt
        Using conn = GetConnection()
            Dim query As String = "SELECT id_operator, nama, kelas, REPEAT('★', rarity) AS rarity, deskripsi FROM tb_operator WHERE id_faksi = @id"
            Dim da As New MySqlDataAdapter(query, conn)
            da.SelectCommand.Parameters.AddWithValue("@id", idFk)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    Public Sub SimpanOp(id As String, nm As String, kls As String, rar As Integer, fk As String, desc As String)
        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("INSERT INTO tb_operator VALUES (@id, @nm, @kls, @rar, @desc, @fk)", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.Parameters.AddWithValue("@nm", nm)
            cmd.Parameters.AddWithValue("@kls", kls)
            cmd.Parameters.AddWithValue("@rar", rar)
            cmd.Parameters.AddWithValue("@desc", desc)
            cmd.Parameters.AddWithValue("@fk", fk)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Function CariOperator(idFk As String, keyword As String) As DataTable
            Dim dt As New DataTable()
            If idFk Is Nothing OrElse idFk.Contains("DataRowView") Then Return dt
            Using conn = GetConnection()
                Dim query As String = "SELECT id_operator, nama, kelas, REPEAT('★', rarity) AS rarity, deskripsi FROM tb_operator " &
                                 "WHERE id_faksi = @id AND (nama LIKE @key OR id_operator LIKE @key)"
                Dim da As New MySqlDataAdapter(query, conn)
                da.SelectCommand.Parameters.AddWithValue("@id", idFk)
                da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                da.Fill(dt)
            End Using
            Return dt
        End Function
    Public Sub UbahOp(id As String, nm As String, kls As String, rar As Integer, fk As String, desc As String)
        Using conn = GetConnection()
            conn.Open()
            Dim query As String = "UPDATE tb_operator SET nama=@nm, kelas=@kls, rarity=@rar, deskripsi=@desc, id_faksi=@fk WHERE id_operator=@id"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nm", nm)
                cmd.Parameters.AddWithValue("@kls", kls)
                cmd.Parameters.AddWithValue("@rar", rar)
                cmd.Parameters.AddWithValue("@desc", desc)
                cmd.Parameters.AddWithValue("@fk", fk)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
    Public Sub HapusOp(id As String)
        Using conn = GetConnection()
            conn.Open()
            Dim cmd As New MySqlCommand("DELETE FROM tb_operator WHERE id_operator=@id", conn)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Module