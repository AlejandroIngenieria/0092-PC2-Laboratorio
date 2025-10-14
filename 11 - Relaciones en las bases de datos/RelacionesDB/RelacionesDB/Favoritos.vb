Imports MySqlConnector

Public Class Favoritos
    Public Property Id As Integer
    Public Property IdUsuario As Integer
    Public Property IdAnimal As Integer

    Private db As New ConnectionDB()

    ' Crear
    Public Function Agregar() As Boolean
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO favoritos (idUsuario, idAnimal) VALUES (@idUsuario, @idAnimal)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idUsuario", IdUsuario)
                    cmd.Parameters.AddWithValue("@idAnimal", IdAnimal)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar favorito: " & ex.Message)
            Return False
        End Try
    End Function

    ' Leer con JOIN
    Public Shared Function ObtenerFavoritos() As DataTable
        Dim db As New ConnectionDB()
        Dim dt As New DataTable()
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "
                    SELECT f.id, u.nombre AS Usuario, a.nombre AS Animal
                    FROM favoritos f
                    INNER JOIN usuario u ON f.idUsuario = u.id
                    INNER JOIN animal a ON f.idAnimal = a.id;"
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener favoritos: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Eliminar
    Public Function Eliminar() As Boolean
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM favoritos WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar favorito: " & ex.Message)
            Return False
        End Try
    End Function
End Class
