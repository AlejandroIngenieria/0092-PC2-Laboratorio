Imports System.Net
Imports MySqlConnector

Public Class Form1
    ' -------------------------------------------------------------------------------
    ' -------------------------------------------------------------------------------
    ' CODIGO PARA EL LOGIN
    ' -------------------------------------------------------------------------------
    ' -------------------------------------------------------------------------------

    ' Variable global para guardar el usuario actual
    Private currentUserId As Integer = -1

    Private Sub btnCargarUsuario_Click(sender As Object, e As EventArgs) Handles btnCargarUsuario.Click
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If email = "" Or password = "" Then
            MessageBox.Show("Por favor, ingresa correo y contraseña.")
            Exit Sub
        End If

        Try
            Using conn = (New ConnectionDB).GetConnection()
                Dim query As String = "SELECT id, nombre FROM usuario WHERE email=@e AND password=@p"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@e", email)
                cmd.Parameters.AddWithValue("@p", password)

                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    currentUserId = reader.GetInt32("id")
                    Dim nombreUsuario As String = reader.GetString("nombre")
                    MessageBox.Show("Bienvenido, " & nombreUsuario & " 👋")

                    ' Cambia de pestaña automáticamente a la de canciones
                    CargarFavoritos()
                    CargarTodasLasCanciones()
                    TabControl1.SelectedTab = tabCanciones

                Else
                    MessageBox.Show("Usuario o contraseña incorrectos.")
                End If

            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar usuario: " & ex.Message)
        End Try
    End Sub

    ' -------------------------------------------------------------------------------
    ' -------------------------------------------------------------------------------
    ' CODIGO PARA EL CRUD DE CANCIONES
    ' -------------------------------------------------------------------------------
    ' -------------------------------------------------------------------------------
    Private Sub CargarCanciones()
        Try
            Using conn = (New ConnectionDB).GetConnection()
                Dim query As String = "SELECT * FROM cancion"
                Dim cmd As New MySqlCommand(query, conn)
                ' Crear un DataTable para cargar los datos
                Dim dt As New DataTable()
                conn.Open()
                dt.Load(cmd.ExecuteReader())
                ' Asignar el DataTable como fuente de datos del DataGridView
                dgvCanciones.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar canciones: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCanciones()
    End Sub

    ' Agregar nueva canción
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Using conn = (New ConnectionDB).GetConnection()
                Dim query As String = "INSERT INTO cancion (nombre, artista, letra, fechaCreacion, url) VALUES (@n, @a, @l, @f, @u)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@n", txtNombre.Text)
                cmd.Parameters.AddWithValue("@a", txtArtista.Text)
                cmd.Parameters.AddWithValue("@l", txtLetra.Text)
                cmd.Parameters.AddWithValue("@f", dtpFecha.Value)
                cmd.Parameters.AddWithValue("@u", txtURL.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("✅ Canción agregada correctamente.")
                CargarCanciones()
                LimpiarCampos()
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error al agregar canción: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If txtId.Text = "" Then
            MessageBox.Show("Selecciona una canción primero.")
            Exit Sub
        End If

        Try
            Using conn = (New ConnectionDB).GetConnection()
                Dim query As String = "UPDATE cancion SET nombre=@n, artista=@a, letra=@l, fechaCreacion=@f, url=@u WHERE id=@id"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@n", txtNombre.Text)
                cmd.Parameters.AddWithValue("@a", txtArtista.Text)
                cmd.Parameters.AddWithValue("@l", txtLetra.Text)
                cmd.Parameters.AddWithValue("@f", dtpFecha.Value)
                cmd.Parameters.AddWithValue("@u", txtURL.Text)
                cmd.Parameters.AddWithValue("@id", txtId.Text)

                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("✅ Canción actualizada correctamente.")
                CargarCanciones()
                LimpiarCampos()
            End Using
        Catch ex As Exception
            MessageBox.Show("❌ Error al actualizar: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtId.Text = "" Then
            MessageBox.Show("Selecciona una canción primero.")
            Exit Sub
        End If

        If MessageBox.Show("¿Seguro que deseas eliminar esta canción?", "Confirmar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Using conn = (New ConnectionDB).GetConnection()
                    Dim query As String = "DELETE FROM cancion WHERE id=@id"
                    Dim cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", txtId.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("🗑️ Canción eliminada correctamente.")
                    CargarCanciones()
                    LimpiarCampos()
                End Using
            Catch ex As Exception
                MessageBox.Show("❌ Error al eliminar: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dgvCanciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCanciones.CellClick
        ' Verifica que se haya hecho clic en una fila válida (no en encabezado)
        If e.RowIndex < 0 Then Exit Sub

        Dim row As DataGridViewRow = dgvCanciones.Rows(e.RowIndex)

        ' Usa Try-Catch para evitar errores inesperados
        Try
            ' Validar que las celdas no sean nulas antes de asignar
            txtId.Text = If(IsDBNull(row.Cells("id").Value), "", row.Cells("id").Value.ToString())
            txtNombre.Text = If(IsDBNull(row.Cells("nombre").Value), "", row.Cells("nombre").Value.ToString())
            txtArtista.Text = If(IsDBNull(row.Cells("artista").Value), "", row.Cells("artista").Value.ToString())
            txtLetra.Text = If(IsDBNull(row.Cells("letra").Value), "", row.Cells("letra").Value.ToString())
            txtURL.Text = If(IsDBNull(row.Cells("url").Value), "", row.Cells("url").Value.ToString())

            ' Verificar fecha (si no hay valor, usar la fecha actual)
            If IsDBNull(row.Cells("fechaCreacion").Value) OrElse row.Cells("fechaCreacion").Value Is Nothing Then
                dtpFecha.Value = DateTime.Now
            Else
                dtpFecha.Value = Convert.ToDateTime(row.Cells("fechaCreacion").Value)
            End If

        Catch ex As Exception
            MessageBox.Show("⚠️ No se pudo cargar la información de la fila seleccionada: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        CargarCanciones()
    End Sub

    Private Sub LimpiarCampos()
        txtId.Clear()
        txtNombre.Clear()
        txtArtista.Clear()
        txtLetra.Clear()
        txtURL.Clear()
        dtpFecha.Value = Date.Now
    End Sub

    ' -------------------------------------------------------------------------------
    ' -------------------------------------------------------------------------------
    ' CODIGO PARA PARA LAS CANCIONES FAVORITAS
    ' -------------------------------------------------------------------------------
    ' -------------------------------------------------------------------------------
    ' Método para cargar las canciones favoritas del usuario logueado
    Private Sub CargarFavoritos()
        flpFavoritos.Controls.Clear()

        If currentUserId <= 0 Then
            MessageBox.Show("Debes iniciar sesión primero.")
            Exit Sub
        End If

        Try
            Using conn = (New ConnectionDB).GetConnection()
                Dim query As String = "
                SELECT c.id, c.nombre, c.artista, c.url
                FROM favorito f
                INNER JOIN cancion c ON f.idCancion = c.id
                WHERE f.idusuario = @uid
            "

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", currentUserId)
                conn.Open()

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ' Crear contenedor visual para cada canción
                    Dim panelCancion As New Panel()
                    panelCancion.Width = 180
                    panelCancion.Height = 220
                    panelCancion.Margin = New Padding(10)
                    panelCancion.BackColor = Color.FromArgb(245, 245, 245)

                    ' PictureBox con la imagen de la canción
                    Dim pic As New PictureBox()
                    pic.Width = 160
                    pic.Height = 120
                    pic.SizeMode = PictureBoxSizeMode.StretchImage
                    pic.Top = 10
                    pic.Left = 10

                    ' Cargar imagen desde la URL (si falla, usa imagen por defecto)
                    Try
                        Dim request As WebRequest = WebRequest.Create(reader("url").ToString())
                        Using response As WebResponse = request.GetResponse()
                            Using stream As IO.Stream = response.GetResponseStream()
                                pic.Image = Image.FromStream(stream)
                            End Using
                        End Using
                    Catch
                        MessageBox.Show("No se pudo cargar la imagen de la canción: " & reader("nombre").ToString())
                    End Try

                    ' Label con nombre de la canción
                    Dim lblNombre As New Label()
                    lblNombre.Text = reader("nombre").ToString() & " - " & reader("artista").ToString()
                    lblNombre.AutoSize = False
                    lblNombre.Width = 160
                    lblNombre.Height = 40
                    lblNombre.Top = 135
                    lblNombre.Left = 10
                    lblNombre.TextAlign = ContentAlignment.MiddleCenter

                    ' Botón para eliminar de favoritos
                    Dim btnEliminar As New Button()
                    btnEliminar.Text = "Eliminar"
                    btnEliminar.Width = 160
                    btnEliminar.Height = 30
                    btnEliminar.Top = 180
                    btnEliminar.Left = 10
                    btnEliminar.Tag = reader("id") ' Guardamos el ID de la canción
                    AddHandler btnEliminar.Click, AddressOf EliminarFavorito_Click

                    ' Agregar todo al panel
                    panelCancion.Controls.Add(pic)
                    panelCancion.Controls.Add(lblNombre)
                    panelCancion.Controls.Add(btnEliminar)

                    ' Agregar panel al FlowLayoutPanel
                    flpFavoritos.Controls.Add(panelCancion)
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar favoritos: " & ex.Message)
        End Try
    End Sub


    Private Sub EliminarFavorito_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idCancion As Integer = CInt(btn.Tag)

        If currentUserId <= 0 Then
            MessageBox.Show("Debes iniciar sesión primero.")
            Exit Sub
        End If

        Try
            Using conn = (New ConnectionDB).GetConnection()
                Dim query As String = "DELETE FROM favorito WHERE idusuario=@uid AND idCancion=@cid"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", currentUserId)
                cmd.Parameters.AddWithValue("@cid", idCancion)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Canción eliminada de favoritos.")
            CargarFavoritos() ' Recargar la vista

        Catch ex As Exception
            MessageBox.Show("Error al eliminar de favoritos: " & ex.Message)
        End Try
    End Sub

    ' -------------------------------------------------------------------------------
    ' -------------------------------------------------------------------------------
    ' CODIGO PARA VER TODAS LAS CANCIONES
    ' -------------------------------------------------------------------------------
    ' -------------------------------------------------------------------------------
    Private Sub CargarTodasLasCanciones()
        flpCanciones.Controls.Clear()

        If currentUserId <= 0 Then
            MessageBox.Show("Debes iniciar sesión primero.")
            Exit Sub
        End If

        Try
            Using conn = (New ConnectionDB).GetConnection()
                Dim query As String = "
                SELECT c.id, c.nombre, c.artista, c.url,
                       CASE WHEN f.id IS NULL THEN 0 ELSE 1 END AS esFavorita
                FROM cancion c
                LEFT JOIN favorito f ON c.id = f.idCancion AND f.idusuario = @uid
            "

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", currentUserId)
                conn.Open()

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    ' Crear panel contenedor
                    Dim panel As New Panel()
                    panel.Width = 180
                    panel.Height = 220
                    panel.Margin = New Padding(10)
                    panel.BackColor = Color.FromArgb(245, 245, 245)

                    ' Crear PictureBox
                    Dim pic As New PictureBox()
                    pic.Width = 160
                    pic.Height = 120
                    pic.SizeMode = PictureBoxSizeMode.StretchImage
                    pic.Top = 10
                    pic.Left = 10

                    Try
                        Dim request As WebRequest = WebRequest.Create(reader("url").ToString())
                        Using response As WebResponse = request.GetResponse()
                            Using stream As IO.Stream = response.GetResponseStream()
                                pic.Image = Image.FromStream(stream)
                            End Using
                        End Using
                    Catch
                        MessageBox.Show("No se pudo cargar la imagen de la canción: " & reader("nombre").ToString())
                    End Try

                    ' Label con título y artista
                    Dim lbl As New Label()
                    lbl.Text = reader("nombre").ToString() & " - " & reader("artista").ToString()
                    lbl.AutoSize = False
                    lbl.Width = 160
                    lbl.Height = 40
                    lbl.Top = 135
                    lbl.Left = 10
                    lbl.TextAlign = ContentAlignment.MiddleCenter

                    ' Botón dinámico
                    Dim btn As New Button()
                    btn.Width = 160
                    btn.Height = 30
                    btn.Top = 180
                    btn.Left = 10
                    btn.Tag = reader("id")

                    ' Si ya es favorita, botón dice “Eliminar”, si no “Agregar”
                    Dim esFavorita As Boolean = CBool(reader("esFavorita"))
                    If esFavorita Then
                        btn.Text = "Eliminar de Favoritos"
                        AddHandler btn.Click, AddressOf EliminarDeFavoritos_Click
                    Else
                        btn.Text = "Agregar a Favoritos"
                        AddHandler btn.Click, AddressOf AgregarAFavoritos_Click
                    End If

                    ' Añadir todo al panel
                    panel.Controls.Add(pic)
                    panel.Controls.Add(lbl)
                    panel.Controls.Add(btn)

                    ' Agregar panel al FlowLayoutPanel
                    flpCanciones.Controls.Add(panel)
                End While
            End Using

        Catch ex As Exception
            MessageBox.Show("Error al cargar canciones: " & ex.Message)
        End Try
    End Sub

    Private Sub AgregarAFavoritos_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idCancion As Integer = CInt(btn.Tag)

        Try
            Using conn = (New ConnectionDB).GetConnection()
                Dim query As String = "INSERT INTO favorito (idusuario, idCancion) VALUES (@uid, @cid)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", currentUserId)
                cmd.Parameters.AddWithValue("@cid", idCancion)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Canción agregada a favoritos 🎵")
            CargarTodasLasCanciones() ' refresca la vista

        Catch ex As Exception
            MessageBox.Show("Error al agregar a favoritos: " & ex.Message)
        End Try
    End Sub

    Private Sub EliminarDeFavoritos_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim idCancion As Integer = CInt(btn.Tag)

        Try
            Using conn = (New ConnectionDB).GetConnection()
                Dim query As String = "DELETE FROM favorito WHERE idusuario=@uid AND idCancion=@cid"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@uid", currentUserId)
                cmd.Parameters.AddWithValue("@cid", idCancion)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Canción eliminada de favoritos 🗑️")
            CargarTodasLasCanciones()

        Catch ex As Exception
            MessageBox.Show("Error al eliminar de favoritos: " & ex.Message)
        End Try
    End Sub

    Private Sub tabFavoritos_Click(sender As Object, e As EventArgs) Handles tabFavoritos.Click
        CargarFavoritos()
        CargarTodasLasCanciones()
    End Sub

    Private Sub tabCancionesVisual_Click(sender As Object, e As EventArgs) Handles tabCancionesVisual.Click
        CargarTodasLasCanciones()
        CargarFavoritos()
    End Sub
End Class
