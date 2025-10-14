Imports MySqlConnector

Public Class Usuario
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Apellido As String
    Public Property Username As String
    Public Property Email As String
    Public Property Password As String
    Public Property FechaCreacion As Date
    Public Property Admin As String

    Private db As New ConnectionDB()

    ' 🔹 Crear (INSERT)
    Public Function Agregar() As Boolean
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO usuario (nombre, apellido, username, email, password, fechaCreacion, admin) VALUES (@nombre, @apellido, @username, @correo, @password, @fecha, @admin)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", Nombre)
                    cmd.Parameters.AddWithValue("@apellido", Apellido)
                    cmd.Parameters.AddWithValue("@username", Username)
                    cmd.Parameters.AddWithValue("@correo", Email)
                    cmd.Parameters.AddWithValue("@password", Password)
                    cmd.Parameters.AddWithValue("@fecha", FechaCreacion)
                    cmd.Parameters.AddWithValue("@admin", Admin)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar usuario: " & ex.Message)
            Return False
        End Try
    End Function

    ' 🔹 Leer todos (SELECT)
    Public Shared Function ObtenerTodos() As DataTable
        Dim db As New ConnectionDB()
        Dim dt As New DataTable()
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM usuario"
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener usuarios: " & ex.Message)
        End Try
        Return dt
    End Function

    ' 🔹 Actualizar (UPDATE)
    Public Function Actualizar() As Boolean
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE usuario SET nombre=@nombre, apellido=@apellido, username=@username, email=@correo, password=@password, admin=@admin WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.Parameters.AddWithValue("@nombre", Nombre)
                    cmd.Parameters.AddWithValue("@apellido", Apellido)
                    cmd.Parameters.AddWithValue("@username", Username)
                    cmd.Parameters.AddWithValue("@correo", Email)
                    cmd.Parameters.AddWithValue("@password", Password)
                    cmd.Parameters.AddWithValue("@admin", Admin)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar usuario: " & ex.Message)
            Return False
        End Try
    End Function

    ' 🔹 Eliminar (DELETE)
    Public Function Eliminar() As Boolean
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM usuario WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar usuario: " & ex.Message)
            Return False
        End Try
    End Function
End Class
