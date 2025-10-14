Imports MySqlConnector

Public Class FormRegistro
    Private db As New ConnectionDB()

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nombre = txtNombre.Text.Trim()
        Dim apellido = txtApellido.Text.Trim()
        Dim email = txtEmail.Text.Trim()
        Dim username = txtUsername.Text.Trim()
        Dim password = txtPassword.Text.Trim()
        Dim admin = If(chkAdmin.Checked, "si", "no")

        If nombre = "" Or email = "" Or password = "" Then
            MessageBox.Show("Nombre, correo y contraseña son obligatorios.")
            Return
        End If

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()

                Dim query As String = "INSERT INTO usuario (nombre, apellido, username, email, password, fechaCreacion, admin) 
                                       VALUES (@nombre, @apellido, @username, @correo, @password, CURDATE(), @admin)"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nombre", nombre)
                    cmd.Parameters.AddWithValue("@apellido", apellido)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@correo", email)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@admin", admin)

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("✅ Usuario registrado correctamente.")
                    Form1.Show()
                    Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error al registrar usuario: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Show()
        Close()
    End Sub
End Class
