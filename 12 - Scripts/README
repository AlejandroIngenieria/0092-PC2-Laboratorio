## 🧩 Elementos visuales en el `TabLogin`

| Control   | Nombre             | Propósito                   |
| --------- | ------------------ | --------------------------- |
| `TextBox` | `txtEmail`         | Ingresar email del usuario  |
| `TextBox` | `txtPassword`      | Ingresar contraseña         |
| `Button`  | `btnCargarUsuario` | Inicia sesión y carga datos |

---

## 💾 Código — Login en Visual Basic

Coloca este código en el mismo `Form1.vb`:

```vb
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
                TabControl1.SelectedTab = tabCanciones

            Else
                MessageBox.Show("Usuario o contraseña incorrectos.")
            End If

        End Using
    Catch ex As Exception
        MessageBox.Show("Error al cargar usuario: " & ex.Message)
    End Try
End Sub
```

---

## 🧠 Explicación del código

| Parte                                                           | Función                                                               |
| --------------------------------------------------------------- | --------------------------------------------------------------------- |
| `currentUserId`                                                 | Guarda el ID del usuario autenticado (lo usaremos en las otras tabs). |
| `btnCargarUsuario_Click`                                        | Evento del botón de login.                                            |
| `SELECT id, nombre FROM usuario WHERE email=@e AND password=@p` | Verifica si existe un usuario con esas credenciales.                  |
| `reader.Read()`                                                 | Si encuentra el usuario, inicia sesión.                               |
| `TabControl1.SelectedTab = tabCanciones`                        | Cambia automáticamente a la pestaña de canciones.                     |

---

# 🎵 TAB 1 — CRUD DE CANCIONES

---

## 🧩 1️⃣ Preparar el Formulario

### 🔹 Elementos visuales en el `TabPage1`

1. Dentro del `TabControl1`, selecciona la **primera pestaña** y nómbrala `tabCanciones`.
   Cambia su propiedad `Text` a **“Canciones (CRUD)”**.

2. Agrega los siguientes controles:

| Tipo de Control  | Nombre         | Texto / Propósito           |
| ---------------- | -------------- | --------------------------- |
| `DataGridView`   | `dgvCanciones` | Muestra todas las canciones |
| `TextBox`        | `txtId`        | ID (solo lectura, opcional) |
| `TextBox`        | `txtNombre`    | Nombre de la canción        |
| `TextBox`        | `txtArtista`   | Artista                     |
| `TextBox`        | `txtLetra`     | Letra                       |
| `DateTimePicker` | `dtpFecha`     | Fecha de creación           |
| `TextBox`        | `txtURL`       | URL de la imagen            |
| `Button`         | `btnCargar`    | “Cargar canciones”          |
| `Button`         | `btnAgregar`   | “Agregar”                   |
| `Button`         | `btnEditar`    | “Editar”                    |
| `Button`         | `btnEliminar`  | “Eliminar”                  |

> 💡 Consejo: puedes poner los botones en una fila debajo del `DataGridView`
> y los campos a la derecha para un diseño claro.

---

## ⚙️ 2️⃣ Importaciones necesarias

En la parte superior del `Form1.vb`:

```vb
Imports MySqlConnector
Imports System.Data
```

---

## 💾 3️⃣ Agregar la función para obtener la conexión

Coloca esta clase al inicio del mismo archivo o mantenla aparte si ya la tienes:

```vb
Imports MySqlConnector

Public Class ConnectionDB
    Private connectionString As String

    ' Constructor de la clase: define la cadena de conexión
    Public Sub New()
        ' Cambia estos valores según tu entorno
        connectionString = "Server=localhost;Database=nombre-de-la-base-de-datos;Uid=root;Pwd=tu-contraseña;Allow User Variables=True"
    End Sub

    ' Método que devuelve una conexión lista para usarse
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    ' Método para probar si la conexión funciona correctamente
    Public Function TestConnection() As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                MessageBox.Show("✅ Conexión exitosa a la base de datos.")
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show($"❌ Error de conexión: {ex.Message}" & vbCrLf &
                           "Verifica que MySQL esté ejecutándose y las credenciales sean correctas.")
            Return False
        End Try
    End Function
End Class
```

---

## 🧠 4️⃣ Código CRUD — todo dentro del Form

Abajo del `Public Class Form1`, agrega el siguiente código:

---

### 🔸 Mostrar todas las canciones

```vb
Private Sub CargarCanciones()
    Try
        Using conn = (New ConnectionDB).GetConnection()
            Dim query As String = "SELECT * FROM cancion"
            Dim cmd As New MySqlCommand(query, conn)
            Dim dt As New DataTable()
            conn.Open()
            dt.Load(cmd.ExecuteReader())
            dgvCanciones.DataSource = dt
        End Using
    Catch ex As Exception
        MessageBox.Show("Error al cargar canciones: " & ex.Message)
    End Try
End Sub
```

👉 **Explicación:**

* Se abre la conexión.
* Se ejecuta `SELECT * FROM cancion`.
* Se llena un `DataTable` y se asigna al `DataGridView`.

---

### 🔸 Agregar canción

```vb
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
```

👉 **Explicación:**

* Inserta la canción usando parámetros.
* Recarga la tabla y limpia los campos.

---

### 🔸 Editar canción

```vb
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
```

👉 **Explicación:**

* Usa `UPDATE cancion` con parámetros.
* Requiere que haya un `id` seleccionado en `txtId`.

---

### 🔸 Eliminar canción

```vb
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
```

👉 **Explicación:**

* Pide confirmación antes de eliminar.
* Usa `DELETE FROM cancion WHERE id=@id`.

---

### 🔸 Evento para cargar los datos del DataGridView a los TextBox

```vb
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

```

👉 **Explicación:**

* Cuando el usuario hace clic en una fila, los datos se cargan a los TextBox.

---

### 🔸 Cargar al iniciar o al presionar el botón

```vb
Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
    CargarCanciones()
End Sub

Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    CargarCanciones()
End Sub
```

---

### 🔸 Limpiar campos (opcional pero útil)

```vb
Private Sub LimpiarCampos()
    txtId.Clear()
    txtNombre.Clear()
    txtArtista.Clear()
    txtLetra.Clear()
    txtURL.Clear()
    dtpFecha.Value = Date.Now
End Sub
```

---

## 🧮 5️⃣ Flujo del CRUD

| Acción           | Query que ejecuta                  | Método              |
| ---------------- | ---------------------------------- | ------------------- |
| Cargar canciones | `SELECT * FROM cancion`            | `CargarCanciones()` |
| Agregar          | `INSERT INTO cancion ...`          | `btnAgregar_Click`  |
| Editar           | `UPDATE cancion ... WHERE id=@id`  | `btnEditar_Click`   |
| Eliminar         | `DELETE FROM cancion WHERE id=@id` | `btnEliminar_Click` |

---

## 🧠 6️⃣ Resultado esperado

* Al abrir el formulario, se cargan todas las canciones.
* Al seleccionar una fila, los datos se muestran en los TextBox.
* Al agregar, editar o eliminar, la tabla se actualiza inmediatamente.

---
# 🎵 TAB 2 — Mostrar canciones favoritas del usuario logueado

## 🧩 Estructura recomendada en el formulario

| Control           | Nombre         | Propósito                                                                      |
| ----------------- | -------------- | ------------------------------------------------------------------------------ |
| `TabPage`         | `tabFavoritos` | Pestaña donde se mostrarán los favoritos                                       |
| `FlowLayoutPanel` | `flpFavoritos` | Contenedor dinámico de las canciones favoritas (propiedad `AutoScroll = True`) |

---

## 💾 Código completo — Cargar canciones favoritas visualmente

Agrega este método al **mismo formulario** donde ya tienes el login y las tabs:

```vb
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
                    pic.Image = My.Resources.default_image ' ⚠️ Agrega una imagen por defecto en Resources
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
```

---

## ⚙️ Código del botón “Eliminar de favoritos”

```vb
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
```

---

## 🧠 Cómo usarlo

Después de iniciar sesión correctamente (en tu botón de login), puedes llamar:

```vb
CargarFavoritos()
TabControl1.SelectedTab = tabFavoritos
```

---
# 🎵 TAB 3 — Mostrar todas las canciones y agregar/eliminar de favoritos
* **“Agregar a Favoritos”** si el usuario **no** la tiene en favoritos
* **“Eliminar de Favoritos”** si **ya la tiene agregada**

Todo esto lo haremos con un `FlowLayoutPanel` llamado **`flpCanciones`**, muy similar al de favoritos.

---

## 🧩 Estructura recomendada en el formulario

| Control           | Nombre               | Propósito                                                  |
| ----------------- | -------------------- | ---------------------------------------------------------- |
| `TabPage`         | `tabCancionesVisual` | Pestaña donde se mostrarán todas las canciones             |
| `FlowLayoutPanel` | `flpCanciones`       | Contenedor visual dinámico (propiedad `AutoScroll = True`) |

---

## 💾 Código completo — Mostrar todas las canciones visualmente

Agrega este código en tu formulario:

```vb
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
                    pic.Image = My.Resources.default_image ' imagen por defecto
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
```

---

## ⚙️ Código para los botones dinámicos

### ➕ Agregar a Favoritos

```vb
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
```

### ❌ Eliminar de Favoritos

```vb
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
```

---

## 🧠 Cómo usarlo

Después del login exitoso, puedes llamar:

```vb
CargarTodasLasCanciones()
TabControl1.SelectedTab = tabCancionesVisual
```

Y cada vez que agregues o elimines una canción, el contenido se actualizará automáticamente.

---