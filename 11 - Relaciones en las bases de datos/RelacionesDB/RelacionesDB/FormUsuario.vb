Imports MySqlConnector

Public Class FormUsuario
    ' Conexión a la base de datos
    Private db As New ConnectionDB()

    '-----------------------------------------------
    ' CARGA DEL FORMULARIO
    '-----------------------------------------------
    Private Sub FormUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarAnimales()
        CargarFavoritosVisual()
        CargarTodosAnimalesVisual()
        CargarPerfil()
    End Sub

    '-----------------------------------------------
    ' PESTAÑA ANIMALES
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

    ' Mostrar imagen del animal seleccionado
    Private Sub dgvAnimales_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAnimales.SelectionChanged
        If dgvAnimales.SelectedRows.Count = 0 Then Return

        Dim row = dgvAnimales.SelectedRows(0)
        Dim url As String = If(row.Cells("url").Value IsNot DBNull.Value, row.Cells("url").Value.ToString(), "")
        Try
            ' Cargar imagen con el metodo Load del picturebox
            pbAnimal.Load(url)
        Catch
            pbAnimal.Image = Nothing
        End Try
    End Sub

    Private Sub btnFavorito_Click(sender As Object, e As EventArgs) Handles btnFavorito.Click
        If dgvAnimales.SelectedRows.Count = 0 Then
            MessageBox.Show("Seleccione un animal para marcar como favorito.")
            Return
        End If

        Dim idAnimal As Integer = dgvAnimales.SelectedRows(0).Cells("id").Value

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                ' Verificar si ya es favorito - Esto lo pueden ignorar
                Dim checkQuery As String = "SELECT COUNT(*) FROM favoritos WHERE idUsuario=@usuario AND idAnimal=@animal"
                Using cmdCheck As New MySqlCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@usuario", GlobalUser.UsuarioID)
                    cmdCheck.Parameters.AddWithValue("@animal", idAnimal)
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Este animal ya está en favoritos.")
                        Return
                    End If
                End Using

                ' Insertar favorito
                Dim query As String = "INSERT INTO favoritos (idUsuario, idAnimal) VALUES (@usuario, @animal)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", GlobalUser.UsuarioID)
                    cmd.Parameters.AddWithValue("@animal", idAnimal)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Animal agregado a favoritos ✅")
                    CargarFavoritosVisual()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar favorito: " & ex.Message)
        End Try
    End Sub

    '-----------------------------------------------
    ' PESTAÑA FAVORITOS (FlowLayoutPanel)
    '-----------------------------------------------
    Private Sub CargarFavoritosVisual()
        flpFavoritos.Controls.Clear() ' Limpiar antes de recargar

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "SELECT a.id, a.nombre, a.url 
                                       FROM animal a
                                       INNER JOIN favoritos f ON a.id=f.idAnimal
                                       WHERE f.idUsuario=@usuario"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", GlobalUser.UsuarioID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Crear panel para cada animal
                            Dim panel As New Panel()
                            panel.Width = 150
                            panel.Height = 200
                            panel.Margin = New Padding(5)

                            ' PictureBox
                            Dim pb As New PictureBox()
                            pb.Width = 140
                            pb.Height = 140
                            pb.SizeMode = PictureBoxSizeMode.StretchImage
                            Try
                                pb.Load(reader("url").ToString())
                            Catch
                                pb.Image = Nothing
                            End Try
                            panel.Controls.Add(pb)

                            ' Label con nombre del animal
                            Dim lbl As New Label()
                            lbl.Text = reader("nombre").ToString()
                            lbl.Top = 145
                            lbl.Width = 140
                            lbl.TextAlign = ContentAlignment.MiddleCenter
                            panel.Controls.Add(lbl)

                            ' Guardar ID en variable local
                            Dim idAnimalFav As Integer = Convert.ToInt32(reader("id"))

                            ' Botón eliminar
                            Dim btnEliminar As New Button()
                            btnEliminar.Text = "Eliminar"
                            btnEliminar.Width = 140
                            btnEliminar.Top = 170
                            AddHandler btnEliminar.Click, Sub(senderBtn, eBtn)
                                                              EliminarFavorito(idAnimalFav)
                                                          End Sub
                            panel.Controls.Add(btnEliminar)

                            ' Agregar panel al FlowLayoutPanel
                            flpFavoritos.Controls.Add(panel)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar favoritos: " & ex.Message)
        End Try
    End Sub

    '-----------------------------------------------
    ' PESTAÑA TODOS LOS ANIMALES (FlowLayoutPanel)
    '-----------------------------------------------
    Private Sub CargarTodosAnimalesVisual()
        flpTodosAnimales.Controls.Clear() ' Limpiar antes de recargar

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "SELECT a.id, a.nombre, a.url,
                                   EXISTS(SELECT 1 FROM favoritos f 
                                          WHERE f.idUsuario=@usuario AND f.idAnimal=a.id) AS esFavorito
                                   FROM animal a"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", GlobalUser.UsuarioID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim panel As New Panel()
                            panel.Width = 150
                            panel.Height = 220
                            panel.Margin = New Padding(5)

                            ' PictureBox
                            Dim pb As New PictureBox()
                            pb.Width = 140
                            pb.Height = 140
                            pb.SizeMode = PictureBoxSizeMode.StretchImage
                            Try
                                pb.Load(reader("url").ToString())
                            Catch
                                pb.Image = Nothing
                            End Try
                            panel.Controls.Add(pb)

                            ' Label nombre
                            Dim lbl As New Label()
                            lbl.Text = reader("nombre").ToString()
                            lbl.Top = 145
                            lbl.Width = 140
                            lbl.TextAlign = ContentAlignment.MiddleCenter
                            panel.Controls.Add(lbl)

                            ' Guardar ID local
                            Dim idAnimal As Integer = Convert.ToInt32(reader("id"))
                            Dim esFav As Boolean = Convert.ToBoolean(reader("esFavorito"))

                            ' Botón favorito
                            Dim btnFav As New Button()
                            btnFav.Width = 140
                            btnFav.Top = 170
                            If esFav Then
                                btnFav.Text = "❤️ Favorito"
                                btnFav.Enabled = False
                            Else
                                btnFav.Text = "Agregar a favoritos"
                                AddHandler btnFav.Click, Sub(s, ev)
                                                             AgregarAFavoritos(idAnimal)
                                                         End Sub
                            End If
                            panel.Controls.Add(btnFav)

                            flpTodosAnimales.Controls.Add(panel)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar todos los animales: " & ex.Message)
        End Try
    End Sub

    Private Sub AgregarAFavoritos(idAnimal As Integer)
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim checkQuery As String = "SELECT COUNT(*) FROM favoritos WHERE idUsuario=@usuario AND idAnimal=@animal"
                Using cmdCheck As New MySqlCommand(checkQuery, conn)
                    cmdCheck.Parameters.AddWithValue("@usuario", GlobalUser.UsuarioID)
                    cmdCheck.Parameters.AddWithValue("@animal", idAnimal)
                    Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Este animal ya está en favoritos.")
                        Return
                    End If
                End Using

                ' Insertar favorito
                Dim query As String = "INSERT INTO favoritos (idUsuario, idAnimal) VALUES (@usuario, @animal)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", GlobalUser.UsuarioID)
                    cmd.Parameters.AddWithValue("@animal", idAnimal)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Animal agregado a favoritos ✅")
                    ' Refrescar tanto todos los animales como favoritos
                    CargarTodosAnimalesVisual()
                    CargarFavoritosVisual()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al agregar favorito: " & ex.Message)
        End Try
    End Sub


    Private Sub EliminarFavorito(idAnimal As Integer)
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "DELETE FROM favoritos WHERE idUsuario=@usuario AND idAnimal=@animal"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", GlobalUser.UsuarioID)
                    cmd.Parameters.AddWithValue("@animal", idAnimal)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Animal eliminado de favoritos ✅")
                    CargarFavoritosVisual()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al eliminar favorito: " & ex.Message)
        End Try
    End Sub

    '-----------------------------------------------
    ' PESTAÑA PERFIL
    '-----------------------------------------------
    Private Sub CargarPerfil()
        lblNombre.Text = GlobalUser.Nombre
        lblEmail.Text = GlobalUser.Email

        ' Opcional: cargar username desde BD
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Dim query As String = "SELECT username FROM usuario WHERE id=@usuario"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@usuario", GlobalUser.UsuarioID)
                    Dim result = cmd.ExecuteScalar()
                    lblUsername.Text = If(result IsNot Nothing, result.ToString(), "")
                End Using
            End Using
        Catch ex As Exception
            lblUsername.Text = ""
        End Try
    End Sub
End Class
