Imports MySqlConnector

Public Class Cliente
    Private db As New DatabaseConnection()

    ' Obtener todos los clientes
    ' DataTable es una estructura que representa una tabla en memoria
    Public Function ObtenerClientes() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "SELECT id, nombre, correo FROM usuarios"
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener clientes: " & ex.Message)
        End Try
        Return dt
    End Function

    ' Agregar cliente
    Public Sub AgregarCliente(nombre As String, correo As String)
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO usuarios (nombre, correo) VALUES (@nombre, @correo)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@correo", correo)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cliente agregado correctamente.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar cliente: " & ex.Message)
        End Try
    End Sub

    ' Actualizar cliente
    Public Sub ActualizarCliente(id As Integer, nombre As String, correo As String)
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE usuarios SET nombre = @nombre, correo = @correo WHERE id = @id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@nombre", nombre)
                cmd.Parameters.AddWithValue("@correo", correo)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cliente actualizado correctamente.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar cliente: " & ex.Message)
        End Try
    End Sub

    ' Eliminar cliente
    Public Sub EliminarCliente(id As Integer)
        Try
            Using conn = db.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM usuarios WHERE id = @id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Cliente eliminado correctamente.")
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar cliente: " & ex.Message)
        End Try
    End Sub
End Class
