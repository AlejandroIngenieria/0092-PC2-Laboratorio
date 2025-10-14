Imports MySqlConnector

Public Class FormAdmin
    ' Instancia de la clase de conexión a la base de datos
    Private db As New ConnectionDB()

    '-----------------------------------------------
    ' CARGA DEL FORMULARIO
    '-----------------------------------------------
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarUsuarios()
        CargarAnimales()
    End Sub

    '-----------------------------------------------
    ' CRUD DE USUARIOS
    '-----------------------------------------------
    Private Sub CargarUsuarios()
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "SELECT id, nombre, apellido, username, email, admin FROM usuario"
                Dim adapter As New MySqlDataAdapter(query, conn)
                ' Estructura de la tabla que me va permitir llenar el DataGridView
                Dim table As New DataTable()
                adapter.Fill(table)
                ' Llenamos el datagridview
                dgvUsuarios.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar usuarios: " & ex.Message)
        End Try
    End Sub

    ' Metodo para actualizar los campos del formulario cuando se selecciona una fila en el DataGridView
    Private Sub dgvUsuarios_SelectionChanged(sender As Object, e As EventArgs) Handles dgvUsuarios.SelectionChanged
        If dgvUsuarios.SelectedRows.Count = 0 Then Return

        Dim row = dgvUsuarios.SelectedRows(0)
        txtNombreU.Text = row.Cells("nombre").Value.ToString()
        txtApellidoU.Text = If(row.Cells("apellido").Value IsNot DBNull.Value, row.Cells("apellido").Value.ToString(), "")
        txtUsernameU.Text = If(row.Cells("username").Value IsNot DBNull.Value, row.Cells("username").Value.ToString(), "")
        txtEmailU.Text = row.Cells("email").Value.ToString()
        chkAdminU.Checked = row.Cells("admin").Value.ToString().ToLower() = "si"

        ' Deja la contraseña vacía para no mostrarla
        txtPasswordU.Text = ""
    End Sub

    Private Sub dgvAnimales_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAnimales.SelectionChanged
        If dgvAnimales.SelectedRows.Count = 0 Then Return

        Dim row = dgvAnimales.SelectedRows(0)
        txtNombreA.Text = row.Cells("nombre").Value.ToString()
        txtEdadA.Text = If(row.Cells("edad").Value IsNot DBNull.Value, row.Cells("edad").Value.ToString(), "")
        txtUrlA.Text = If(row.Cells("url").Value IsNot DBNull.Value, row.Cells("url").Value.ToString(), "")
    End Sub


    Private Sub btnAgregarU_Click(sender As Object, e As EventArgs) Handles btnAgregarU.Click
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO usuario (nombre, apellido, username, email, password, fechaCreacion, admin)
                                       VALUES (@nombre, @apellido, @username, @correo, @password, CURDATE(), @admin)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombreU.Text)
                    cmd.Parameters.AddWithValue("@apellido", txtApellidoU.Text)
                    cmd.Parameters.AddWithValue("@username", txtUsernameU.Text)
                    cmd.Parameters.AddWithValue("@correo", txtEmailU.Text)
                    cmd.Parameters.AddWithValue("@password", txtPasswordU.Text)
                    cmd.Parameters.AddWithValue("@admin", If(chkAdminU.Checked, "si", "no"))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuario agregado correctamente.")
                    CargarUsuarios()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub btnActualizarU_Click(sender As Object, e As EventArgs) Handles btnActualizarU.Click
        If dgvUsuarios.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un usuario para actualizar.")
            Return
        End If

        Dim id As Integer = dgvUsuarios.SelectedRows(0).Cells("id").Value

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE usuario SET nombre=@nombre, apellido=@apellido, username=@username, 
                                       email=@correo, password=@password, admin=@admin WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nombre", txtNombreU.Text)
                    cmd.Parameters.AddWithValue("@apellido", txtApellidoU.Text)
                    cmd.Parameters.AddWithValue("@username", txtUsernameU.Text)
                    cmd.Parameters.AddWithValue("@correo", txtEmailU.Text)
                    cmd.Parameters.AddWithValue("@password", txtPasswordU.Text)
                    cmd.Parameters.AddWithValue("@admin", If(chkAdminU.Checked, "si", "no"))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuario actualizado correctamente.")
                    CargarUsuarios()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarU_Click(sender As Object, e As EventArgs) Handles btnEliminarU.Click
        If dgvUsuarios.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un usuario para eliminar.")
            Return
        End If

        Dim id As Integer = dgvUsuarios.SelectedRows(0).Cells("id").Value

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM usuario WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Usuario eliminado correctamente.")
                    CargarUsuarios()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefrescarU_Click(sender As Object, e As EventArgs) Handles btnRefrescarU.Click
        CargarUsuarios()
    End Sub

    '-----------------------------------------------
    ' CRUD DE ANIMALES
    '-----------------------------------------------
    Private Sub CargarAnimales()
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "SELECT id, nombre, edad, url FROM animal"
                Dim adapter As New MySqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                dgvAnimales.DataSource = table
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar animales: " & ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarA_Click(sender As Object, e As EventArgs) Handles btnAgregarA.Click
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "INSERT INTO animal (id, nombre, edad, url)
                                       VALUES (NULL, @nombre, @edad, @url)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", txtNombreA.Text)
                    cmd.Parameters.AddWithValue("@edad", txtEdadA.Text)
                    cmd.Parameters.AddWithValue("@url", txtUrlA.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Animal agregado correctamente.")
                    CargarAnimales()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar animal: " & ex.Message)
        End Try
    End Sub

    Private Sub btnActualizarA_Click(sender As Object, e As EventArgs) Handles btnActualizarA.Click
        If dgvAnimales.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un animal para actualizar.")
            Return
        End If

        Dim id As Integer = dgvAnimales.SelectedRows(0).Cells("id").Value

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "UPDATE animal SET nombre=@nombre, edad=@edad, url=@url WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nombre", txtNombreA.Text)
                    cmd.Parameters.AddWithValue("@edad", txtEdadA.Text)
                    cmd.Parameters.AddWithValue("@url", txtUrlA.Text)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Animal actualizado correctamente.")
                    CargarAnimales()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar animal: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminarA_Click(sender As Object, e As EventArgs) Handles btnEliminarA.Click
        If dgvAnimales.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un animal para eliminar.")
            Return
        End If

        Dim id As Integer = dgvAnimales.SelectedRows(0).Cells("id").Value

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM animal WHERE id=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Animal eliminado correctamente.")
                    CargarAnimales()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar animal: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRefrescarA_Click(sender As Object, e As EventArgs) Handles btnRefrescarA.Click
        CargarAnimales()
    End Sub
End Class
