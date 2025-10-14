Imports MySqlConnector

Public Class Animal
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Edad As Integer
    Public Property Url As String

    Private db As New ConnectionDB()

    ' Crear
    Public Function Agregar() As Boolean
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO animal (id, nombre, edad, url) VALUES (@id, @nombre, @edad, @url)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.Parameters.AddWithValue("@nombre", Nombre)
                    cmd.Parameters.AddWithValue("@edad", Edad)
                    cmd.Parameters.AddWithValue("@url", Url)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar animal: " & ex.Message)
            Return False
        End Try
    End Function

    ' Leer
    Public Shared Function ObtenerTodos() As DataTable
        Dim db As New ConnectionDB()
        Dim dt As New DataTable()
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM animal"
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener animales: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Actualizar
    Public Function Actualizar() As Boolean
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE animal SET nombre=@nombre, edad=@edad, url=@url WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.Parameters.AddWithValue("@nombre", Nombre)
                    cmd.Parameters.AddWithValue("@edad", Edad)
                    cmd.Parameters.AddWithValue("@url", Url)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar animal: " & ex.Message)
            Return False
        End Try
    End Function

    ' Eliminar
    Public Function Eliminar() As Boolean
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM animal WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar animal: " & ex.Message)
            Return False
        End Try
    End Function
End Class
