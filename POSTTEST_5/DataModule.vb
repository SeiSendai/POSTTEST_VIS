Imports MySqlConnector

Module DataModule
    Public Function GetAllOperators() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_operator, nama, kelas, REPEAT('★', rarity) AS rarity FROM tb_operator ORDER BY id_operator ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal tampil data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
    Public Function SimpanOperator(id As String, nama As String, kelas As String, rarity As Integer) As Boolean
        Try
            Dim query As String = "INSERT INTO tb_operator VALUES (@id, @nama, @kelas, @rarity)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kelas", kelas)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function UpdateOperator(id As String, nama As String, kelas As String, rarity As Integer) As Boolean
        Try
            Dim query As String = "UPDATE tb_operator SET nama=@nama, kelas=@kelas, rarity=@rarity WHERE id_operator=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@kelas", kelas)
                    cmd.Parameters.AddWithValue("@rarity", rarity)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal update: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function HapusOperator(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tb_operator WHERE id_operator=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal hapus: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function CariOperator(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT id_operator, nama, kelas, REPEAT('★', rarity) AS rarity FROM tb_operator " &
                                 "WHERE nama LIKE @key OR id_operator LIKE @key"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@key", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            Return GetAllOperators()
        End Try
        Return dt
    End Function
End Module