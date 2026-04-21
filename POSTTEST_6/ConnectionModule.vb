Imports MySqlConnector

Module ConnectionModule
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection("Server=localhost;Port=3306;Database=db_arknights;User ID=root;Password=;")
    End Function
End Module