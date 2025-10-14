Imports MySqlConnector

Public Class Form1
    Private db As New ConnectionDB()

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim correo As String = txtCorreo.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If correo = "" Or password = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "SELECT * FROM usuario WHERE email=@correo AND password=@password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@correo", correo)
                    cmd.Parameters.AddWithValue("@password", password)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Guardar información en el módulo global
                            GlobalUser.UsuarioID = Convert.ToInt32(reader("id"))
                            GlobalUser.Nombre = reader("nombre").ToString()
                            GlobalUser.Email = reader("email").ToString()

                            Dim esAdmin = reader("admin").ToString().ToLower()
                            MessageBox.Show($"Bienvenido {GlobalUser.Nombre}")

                            ' Abrir el formulario correspondiente
                            If esAdmin = "si" Or esAdmin = "1" Then
                                Dim frmAdmin As New FormAdmin()
                                frmAdmin.Show()
                                Hide()
                            Else
                                Dim frmUsuario As New FormUsuario()
                                frmUsuario.Show()
                                Hide()
                            End If
                        Else
                            MessageBox.Show("Correo o contraseña incorrectos.")
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al iniciar sesión: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        FormRegistro.Show()
        Hide()
    End Sub
End Class
