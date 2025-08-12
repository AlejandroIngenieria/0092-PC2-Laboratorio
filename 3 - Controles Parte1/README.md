# Explicación y Ejemplos de Contenedores en VB.NET

Los contenedores son controles que permiten organizar y agrupar otros controles de forma lógica y visual. Aquí te presento los principales contenedores con ejemplos listos para copiar y pegar en el Form1 por defecto de VB.NET.

## 1. GroupBox

**Explicación**: El GroupBox es un contenedor que agrupa controles relacionados visualmente con un borde y un título. Es ideal para agrupar RadioButtons ya que automáticamente los hace mutuamente excluyentes dentro del mismo GroupBox.

```vb
Public Class Form1
    ' Definición de los GroupBox
    Private GroupBox1 As New GroupBox()
    Private GroupBox2 As New GroupBox()
    Private GroupBox3 As New GroupBox()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración básica del formulario
        Text = "Selección con RadioButtons"
        ClientSize = New Size(600, 400)
        StartPosition = FormStartPosition.CenterScreen

        ' ===== GROUPBOX 1 (Largo) - Selección de Género =====
        GroupBox1.Text = "Género"
        GroupBox1.Font = New Font("Arial", 10, FontStyle.Bold)
        GroupBox1.Size = New Size(550, 100)
        GroupBox1.Location = New Point(20, 20)

        ' RadioButtons para género
        Dim rbMasculino As New RadioButton()
        rbMasculino.Text = "Masculino"
        rbMasculino.Location = New Point(30, 30)
        rbMasculino.AutoSize = True
        rbMasculino.Name = "rbMasculino"

        Dim rbFemenino As New RadioButton()
        rbFemenino.Text = "Femenino"
        rbFemenino.Location = New Point(30, 60)
        rbFemenino.AutoSize = True
        rbFemenino.Name = "rbFemenino"

        GroupBox1.Controls.Add(rbMasculino)
        GroupBox1.Controls.Add(rbFemenino)

        ' ===== GROUPBOX 2 (Corto) - Estado Civil =====
        GroupBox2.Text = "Estado Civil"
        GroupBox2.Font = New Font("Arial", 10, FontStyle.Bold)
        GroupBox2.Size = New Size(250, 120)
        GroupBox2.Location = New Point(20, 140)

        ' RadioButtons para estado civil
        Dim rbSoltero As New RadioButton()
        rbSoltero.Text = "Soltero/a"
        rbSoltero.Location = New Point(20, 30)
        rbSoltero.AutoSize = True
        rbSoltero.Name = "rbSoltero"

        Dim rbCasado As New RadioButton()
        rbCasado.Text = "Casado/a"
        rbCasado.Location = New Point(20, 60)
        rbCasado.AutoSize = True
        rbCasado.Name = "rbCasado"

        Dim rbDivorciado As New RadioButton()
        rbDivorciado.Text = "Divorciado/a"
        rbDivorciado.Location = New Point(20, 90)
        rbDivorciado.AutoSize = True
        rbDivorciado.Name = "rbDivorciado"

        GroupBox2.Controls.Add(rbSoltero)
        GroupBox2.Controls.Add(rbCasado)
        GroupBox2.Controls.Add(rbDivorciado)

        ' ===== GROUPBOX 3 (Corto) - Nivel Educativo =====
        GroupBox3.Text = "Educación"
        GroupBox3.Font = New Font("Arial", 10, FontStyle.Bold)
        GroupBox3.Size = New Size(250, 120)
        GroupBox3.Location = New Point(290, 140)

        ' RadioButtons para educación
        Dim rbPrimaria As New RadioButton()
        rbPrimaria.Text = "Primaria"
        rbPrimaria.Location = New Point(20, 30)
        rbPrimaria.AutoSize = True
        rbPrimaria.Name = "rbPrimaria"

        Dim rbSecundaria As New RadioButton()
        rbSecundaria.Text = "Secundaria"
        rbSecundaria.Location = New Point(20, 60)
        rbSecundaria.AutoSize = True
        rbSecundaria.Name = "rbSecundaria"

        Dim rbUniversidad As New RadioButton()
        rbUniversidad.Text = "Universidad"
        rbUniversidad.Location = New Point(20, 90)
        rbUniversidad.AutoSize = True
        rbUniversidad.Name = "rbUniversidad"

        GroupBox3.Controls.Add(rbPrimaria)
        GroupBox3.Controls.Add(rbSecundaria)
        GroupBox3.Controls.Add(rbUniversidad)

        ' ===== BOTÓN PARA MOSTRAR SELECCIÓN =====
        Dim btnMostrar As New Button()
        btnMostrar.Text = "Mostrar selección"
        btnMostrar.Size = New Size(150, 40)
        btnMostrar.Location = New Point(200, 280)
        AddHandler btnMostrar.Click, AddressOf MostrarSeleccion
        Controls.Add(btnMostrar)

        ' Agregar todos los GroupBox al formulario
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox3)
    End Sub

    Private Sub MostrarSeleccion(sender As Object, e As EventArgs)
        Dim mensaje As String = "Selección actual:" & vbCrLf & vbCrLf

        ' Verificar selección de género (GroupBox1)
        If DirectCast(GroupBox1.Controls("rbMasculino"), RadioButton).Checked Then
            mensaje &= "Género: Masculino" & vbCrLf
        ElseIf DirectCast(GroupBox1.Controls("rbFemenino"), RadioButton).Checked Then
            mensaje &= "Género: Femenino" & vbCrLf
        End If

        ' Verificar estado civil (GroupBox2)
        If DirectCast(GroupBox2.Controls("rbSoltero"), RadioButton).Checked Then
            mensaje &= "Estado Civil: Soltero/a" & vbCrLf
        ElseIf DirectCast(GroupBox2.Controls("rbCasado"), RadioButton).Checked Then
            mensaje &= "Estado Civil: Casado/a" & vbCrLf
        ElseIf DirectCast(GroupBox2.Controls("rbDivorciado"), RadioButton).Checked Then
            mensaje &= "Estado Civil: Divorciado/a" & vbCrLf
        End If

        ' Verificar educación (GroupBox3)
        If DirectCast(GroupBox3.Controls("rbPrimaria"), RadioButton).Checked Then
            mensaje &= "Educación: Primaria" & vbCrLf
        ElseIf DirectCast(GroupBox3.Controls("rbSecundaria"), RadioButton).Checked Then
            mensaje &= "Educación: Secundaria" & vbCrLf
        ElseIf DirectCast(GroupBox3.Controls("rbUniversidad"), RadioButton).Checked Then
            mensaje &= "Educación: Universidad" & vbCrLf
        End If

        MessageBox.Show(mensaje, "Resumen de selección", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
```

## 2. Panel

**Explicación**: El Panel es un contenedor simple sin título que permite agrupar controles. Es útil para organizar secciones de un formulario y puede tener scroll si el contenido excede su tamaño.

```vb
Public Class Form1
    ' Declaración de controles dentro del Panel
    Private WithEvents Panel1 As New Panel()
    Private WithEvents btnAceptar As New Button()
    Private WithEvents btnCancelar As New Button()
    Private WithEvents txtNombre As New TextBox()
    Private WithEvents txtEmail As New TextBox()
    Private WithEvents rbMasculino As New RadioButton()
    Private WithEvents rbFemenino As New RadioButton()
    Private WithEvents chkTerminos As New CheckBox()
    Private WithEvents lblTitulo As New Label()
    Private WithEvents lblNombre As New Label()
    Private WithEvents lblEmail As New Label()
    Private WithEvents lblGenero As New Label()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración del formulario
        Text = "Ejemplo con Panel"
        ClientSize = New Size(400, 350)
        StartPosition = FormStartPosition.CenterScreen

        ' Configuración del Panel
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Size = New Size(350, 250)
        Panel1.Location = New Point(20, 20)

        ' ===== CONTROLES DENTRO DEL PANEL =====

        ' Etiqueta título
        lblTitulo.Text = "Formulario de Registro"
        lblTitulo.Font = New Font("Arial", 12, FontStyle.Bold)
        lblTitulo.AutoSize = True
        lblTitulo.Location = New Point(100, 20)
        Panel1.Controls.Add(lblTitulo)

        ' Campo Nombre
        lblNombre.Text = "Nombre:"
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(30, 60)
        Panel1.Controls.Add(lblNombre)

        txtNombre.Location = New Point(120, 60)
        txtNombre.Size = New Size(200, 20)
        Panel1.Controls.Add(txtNombre)

        ' Campo Email
        lblEmail.Text = "Email:"
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(30, 100)
        Panel1.Controls.Add(lblEmail)

        txtEmail.Location = New Point(120, 100)
        txtEmail.Size = New Size(200, 20)
        Panel1.Controls.Add(txtEmail)

        ' Opciones de Género
        lblGenero.Text = "Género:"
        lblGenero.AutoSize = True
        lblGenero.Location = New Point(30, 140)
        Panel1.Controls.Add(lblGenero)

        rbMasculino.Text = "Masculino"
        rbMasculino.AutoSize = True
        rbMasculino.Location = New Point(120, 140)
        Panel1.Controls.Add(rbMasculino)

        rbFemenino.Text = "Femenino"
        rbFemenino.AutoSize = True
        rbFemenino.Location = New Point(120, 170)
        Panel1.Controls.Add(rbFemenino)

        ' CheckBox términos
        chkTerminos.Text = "Acepto los términos y condiciones"
        chkTerminos.AutoSize = True
        chkTerminos.Location = New Point(30, 200)
        Panel1.Controls.Add(chkTerminos)

        ' Botones
        btnAceptar.Text = "Aceptar"
        btnAceptar.Size = New Size(100, 30)
        btnAceptar.Location = New Point(60, 300)
        btnAceptar.BackColor = Color.LightGreen
        Controls.Add(btnAceptar)

        btnCancelar.Text = "Cancelar"
        btnCancelar.Size = New Size(100, 30)
        btnCancelar.Location = New Point(180, 300)
        btnCancelar.BackColor = Color.LightCoral
        Controls.Add(btnCancelar)

        ' Agregar el Panel al formulario
        Controls.Add(Panel1)
    End Sub

    ' Evento para el botón Aceptar
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Validación del nombre
        If txtNombre.Text = "" Then
            MessageBox.Show("Debe ingresar su nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validación de términos
        If chkTerminos.Checked = False Then
            MessageBox.Show("Debe aceptar los términos y condiciones", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Determinación del género
        Dim genero As String = "No especificado"
        If rbMasculino.Checked Then
            genero = "Masculino"
        ElseIf rbFemenino.Checked Then
            genero = "Femenino"
        End If

        ' Creación del mensaje
        Dim mensaje As String
        mensaje = "Registro exitoso:" & vbCrLf
        mensaje &= "Nombre: " & txtNombre.Text & vbCrLf
        mensaje &= "Email: " & txtEmail.Text & vbCrLf
        mensaje &= "Género: " & genero

        MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Evento para el botón Cancelar
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        End If
    End Sub
End Class
```

## 3. SplitContainer

**Explicación**: El SplitContainer divide el formulario en dos paneles separados por una barra divisora que el usuario puede mover. Ideal para interfaces donde se necesita mostrar información relacionada en dos áreas ajustables.

```vb
Public Class Form1
    Private WithEvents SplitContainer1 As New SplitContainer()
    Private WithEvents btnIzquierda As New Button()
    Private WithEvents btnDerecha As New Button()
    Private WithEvents txtPanel1 As New TextBox()
    Private WithEvents txtPanel2 As New TextBox()
    Private WithEvents rbOpcion1 As New RadioButton()
    Private WithEvents rbOpcion2 As New RadioButton()
    Private WithEvents chkMostrar As New CheckBox()
    Private WithEvents lblPanel1 As New Label()
    Private WithEvents lblPanel2 As New Label()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración del formulario
        Text = "Ejemplo SplitContainer"
        ClientSize = New Size(800, 400)
        StartPosition = FormStartPosition.CenterScreen

        ' Configuración del SplitContainer
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.SplitterDistance = 300 ' Divide en dos paneles iguales
        SplitContainer1.Panel1.BackColor = Color.LightBlue
        SplitContainer1.Panel2.BackColor = Color.LightGreen

        ' ===== CONTROLES EN PANEL IZQUIERDO =====
        lblPanel1.Text = "Panel Izquierdo"
        lblPanel1.Font = New Font("Arial", 10, FontStyle.Bold)
        lblPanel1.AutoSize = True
        lblPanel1.Location = New Point(20, 20)
        SplitContainer1.Panel1.Controls.Add(lblPanel1)

        txtPanel1.Location = New Point(20, 50)
        txtPanel1.Size = New Size(200, 20)
        SplitContainer1.Panel1.Controls.Add(txtPanel1)

        rbOpcion1.Text = "Opción 1"
        rbOpcion1.AutoSize = True
        rbOpcion1.Location = New Point(20, 90)
        SplitContainer1.Panel1.Controls.Add(rbOpcion1)

        rbOpcion2.Text = "Opción 2"
        rbOpcion2.AutoSize = True
        rbOpcion2.Location = New Point(20, 120)
        SplitContainer1.Panel1.Controls.Add(rbOpcion2)

        btnIzquierda.Text = "Copiar a Derecha"
        btnIzquierda.Size = New Size(150, 30)
        btnIzquierda.Location = New Point(20, 160)
        SplitContainer1.Panel1.Controls.Add(btnIzquierda)

        ' ===== CONTROLES EN PANEL DERECHO =====
        lblPanel2.Text = "Panel Derecho"
        lblPanel2.Font = New Font("Arial", 10, FontStyle.Bold)
        lblPanel2.AutoSize = True
        lblPanel2.Location = New Point(20, 20)
        SplitContainer1.Panel2.Controls.Add(lblPanel2)

        txtPanel2.Location = New Point(20, 50)
        txtPanel2.Size = New Size(200, 20)
        SplitContainer1.Panel2.Controls.Add(txtPanel2)

        chkMostrar.Text = "Mostrar texto"
        chkMostrar.AutoSize = True
        chkMostrar.Location = New Point(20, 90)
        SplitContainer1.Panel2.Controls.Add(chkMostrar)

        btnDerecha.Text = "Copiar a Izquierda"
        btnDerecha.Size = New Size(150, 30)
        btnDerecha.Location = New Point(20, 130)
        SplitContainer1.Panel2.Controls.Add(btnDerecha)

        ' Agregar SplitContainer al formulario
        Controls.Add(SplitContainer1)
    End Sub

    Private Sub btnIzquierda_Click(sender As Object, e As EventArgs) Handles btnIzquierda.Click
        ' Copiar texto del panel izquierdo al derecho
        If txtPanel1.Text <> "" Then
            txtPanel2.Text = txtPanel1.Text
        Else
            txtPanel2.Text = "No hay texto"
        End If

        ' Verificar qué RadioButton está seleccionado
        If rbOpcion1.Checked Then
            chkMostrar.Checked = True
        ElseIf rbOpcion2.Checked Then
            chkMostrar.Checked = False
        End If
    End Sub

    Private Sub btnDerecha_Click(sender As Object, e As EventArgs) Handles btnDerecha.Click
        ' Copiar texto del panel derecho al izquierdo
        If txtPanel2.Text = "" Then
            txtPanel1.Text = "Vacío"
        Else
            txtPanel1.Text = txtPanel2.Text
        End If

        ' Cambiar opciones según el CheckBox
        If chkMostrar.Checked Then
            rbOpcion1.Checked = True
        Else
            rbOpcion2.Checked = True
        End If
    End Sub
End Class
```

## 4. TabControl

**Explicación**: El TabControl organiza los controles en pestañas, permitiendo dividir la interfaz en secciones accesibles mediante clic. Ideal para formularios con muchas opciones que se pueden agrupar lógicamente.

```vb
Public Class Form1
    Private WithEvents TabControl1 As New TabControl()
    Private WithEvents TabPage1 As New TabPage() ' Información Personal
    Private WithEvents TabPage2 As New TabPage() ' Configuración
    Private WithEvents TabPage3 As New TabPage() ' Contacto

    ' Controles para TabPage1 (Información Personal)
    Private WithEvents txtNombre As New TextBox()
    Private WithEvents rbHombre As New RadioButton()
    Private WithEvents rbMujer As New RadioButton()
    Private WithEvents btnGuardar As New Button()
    Private WithEvents lblInfo As New Label()

    ' Controles para TabPage2 (Configuración)
    Private WithEvents chkTerminos As New CheckBox()
    Private WithEvents chkNoticias As New CheckBox()
    Private WithEvents txtComentarios As New TextBox()
    Private WithEvents btnEnviar As New Button()
    Private WithEvents lblConfig As New Label()

    ' Controles para TabPage3 (Contacto)
    Private WithEvents txtEmail As New TextBox()
    Private WithEvents txtTelefono As New TextBox()
    Private WithEvents btnContactar As New Button()
    Private WithEvents lblContacto As New Label()
    Private WithEvents chkLlamar As New CheckBox()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración del formulario
        Text = "Formulario con 3 pestañas"
        ClientSize = New Size(500, 400)
        StartPosition = FormStartPosition.CenterScreen

        ' Configuración del TabControl
        TabControl1.Size = New Size(450, 350)
        TabControl1.Location = New Point(20, 20)

        ' Configuración de las pestañas
        TabPage1.Text = "Datos"
        TabPage2.Text = "Opciones"
        TabPage3.Text = "Contacto"

        ' ===== CONTROLES EN TABPAGE1 (DATOS) =====
        lblInfo.Text = "Información personal:"
        lblInfo.AutoSize = True
        lblInfo.Location = New Point(20, 20)
        TabPage1.Controls.Add(lblInfo)

        txtNombre.Location = New Point(20, 50)
        txtNombre.Size = New Size(300, 20)
        TabPage1.Controls.Add(txtNombre)

        rbHombre.Text = "Hombre"
        rbHombre.AutoSize = True
        rbHombre.Location = New Point(20, 90)
        TabPage1.Controls.Add(rbHombre)

        rbMujer.Text = "Mujer"
        rbMujer.AutoSize = True
        rbMujer.Location = New Point(20, 120)
        TabPage1.Controls.Add(rbMujer)

        btnGuardar.Text = "Guardar"
        btnGuardar.Size = New Size(100, 30)
        btnGuardar.Location = New Point(20, 160)
        TabPage1.Controls.Add(btnGuardar)

        ' ===== CONTROLES EN TABPAGE2 (OPCIONES) =====
        lblConfig.Text = "Configuración:"
        lblConfig.AutoSize = True
        lblConfig.Location = New Point(20, 20)
        TabPage2.Controls.Add(lblConfig)

        chkTerminos.Text = "Acepto términos"
        chkTerminos.AutoSize = True
        chkTerminos.Location = New Point(20, 50)
        TabPage2.Controls.Add(chkTerminos)

        chkNoticias.Text = "Recibir noticias"
        chkNoticias.AutoSize = True
        chkNoticias.Location = New Point(20, 80)
        TabPage2.Controls.Add(chkNoticias)

        txtComentarios.Location = New Point(20, 120)
        txtComentarios.Size = New Size(300, 100)
        txtComentarios.Multiline = True
        TabPage2.Controls.Add(txtComentarios)

        btnEnviar.Text = "Enviar"
        btnEnviar.Size = New Size(100, 30)
        btnEnviar.Location = New Point(20, 230)
        TabPage2.Controls.Add(btnEnviar)

        ' ===== CONTROLES EN TABPAGE3 (CONTACTO) =====
        lblContacto.Text = "Datos de contacto:"
        lblContacto.AutoSize = True
        lblContacto.Location = New Point(20, 20)
        TabPage3.Controls.Add(lblContacto)

        txtEmail.Location = New Point(20, 50)
        txtEmail.Size = New Size(300, 20)
        TabPage3.Controls.Add(txtEmail)

        txtTelefono.Location = New Point(20, 90)
        txtTelefono.Size = New Size(300, 20)
        TabPage3.Controls.Add(txtTelefono)

        chkLlamar.Text = "Autorizo contacto telefónico"
        chkLlamar.AutoSize = True
        chkLlamar.Location = New Point(20, 130)
        TabPage3.Controls.Add(chkLlamar)

        btnContactar.Text = "Contactar"
        btnContactar.Size = New Size(100, 30)
        btnContactar.Location = New Point(20, 160)
        TabPage3.Controls.Add(btnContactar)

        ' Agregar pestañas al TabControl
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)

        ' Agregar TabControl al formulario
        Controls.Add(TabControl1)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Ingrese su nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If rbHombre.Checked Then
                MessageBox.Show("Datos de hombre guardados", "Información", MessageBoxButtons.OK)
            ElseIf rbMujer.Checked Then
                MessageBox.Show("Datos de mujer guardados", "Información", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Datos guardados (sin género)", "Información", MessageBoxButtons.OK)
            End If
        End If
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If chkTerminos.Checked = False Then
            MessageBox.Show("Debe aceptar los términos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Preferencias guardadas", "Éxito", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub btnContactar_Click(sender As Object, e As EventArgs) Handles btnContactar.Click
        If txtEmail.Text = "" Then
            MessageBox.Show("Ingrese su email", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If chkLlamar.Checked Then
                If txtTelefono.Text = "" Then
                    MessageBox.Show("Falta número telefónico", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    MessageBox.Show("Contactaremos por teléfono", "Confirmación", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("Contactaremos por email", "Confirmación", MessageBoxButtons.OK)
            End If
        End If
    End Sub
End Class
```

## 5. TableLayoutPanel

**Explicación**: El TableLayoutPanel organiza los controles en una cuadrícula con filas y columnas definidas. Es ideal para formularios que requieren un diseño alineado y estructurado.

```vb
Public Class Form1
    Private WithEvents TableLayoutPanel1 As New TableLayoutPanel()
    Private WithEvents lblTitulo As New Label()
    Private WithEvents txtNombre As New TextBox()
    Private WithEvents txtApellido As New TextBox()
    Private WithEvents rbMasculino As New RadioButton()
    Private WithEvents rbFemenino As New RadioButton()
    Private WithEvents chkTerminos As New CheckBox()
    Private WithEvents btnAceptar As New Button()
    Private WithEvents btnCancelar As New Button()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración básica del formulario
        Text = "Formulario con TableLayoutPanel"
        ClientSize = New Size(500, 300)
        StartPosition = FormStartPosition.CenterScreen

        ' Configuración del TableLayoutPanel
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.BackColor = Color.WhiteSmoke
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single

        ' Configuración de columnas (2 columnas)
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70.0F))

        ' Configuración de filas (6 filas)
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))

        ' Título (ocupa 2 columnas)
        lblTitulo.Text = "Formulario de Registro"
        lblTitulo.Font = New Font("Arial", 12, FontStyle.Bold)
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter
        lblTitulo.Dock = DockStyle.Fill
        lblTitulo.BackColor = Color.LightBlue
        TableLayoutPanel1.Controls.Add(lblTitulo, 0, 0)
        TableLayoutPanel1.SetColumnSpan(lblTitulo, 2)

        ' Fila 2: Nombre
        Dim lblNombre As New Label()
        lblNombre.Text = "Nombre:"
        lblNombre.TextAlign = ContentAlignment.MiddleRight
        lblNombre.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(lblNombre, 0, 1)

        txtNombre.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(txtNombre, 1, 1)

        ' Fila 3: Apellido
        Dim lblApellido As New Label()
        lblApellido.Text = "Apellido:"
        lblApellido.TextAlign = ContentAlignment.MiddleRight
        lblApellido.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(lblApellido, 0, 2)

        txtApellido.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(txtApellido, 1, 2)

        ' Fila 4: Género
        Dim lblGenero As New Label()
        lblGenero.Text = "Género:"
        lblGenero.TextAlign = ContentAlignment.MiddleRight
        lblGenero.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(lblGenero, 0, 3)

        Dim panelGenero As New Panel()
        panelGenero.Dock = DockStyle.Fill

        rbMasculino.Text = "Masculino"
        rbMasculino.Location = New Point(10, 10)
        panelGenero.Controls.Add(rbMasculino)

        rbFemenino.Text = "Femenino"
        rbFemenino.Location = New Point(10, 35)
        panelGenero.Controls.Add(rbFemenino)

        TableLayoutPanel1.Controls.Add(panelGenero, 1, 3)

        ' Fila 5: Términos (ocupa 2 columnas)
        chkTerminos.Text = "Acepto los términos y condiciones"
        chkTerminos.AutoSize = True
        chkTerminos.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(chkTerminos, 0, 4)
        TableLayoutPanel1.SetColumnSpan(chkTerminos, 2)

        ' Fila 6: Botones
        btnAceptar.Text = "Aceptar"
        btnAceptar.Dock = DockStyle.Fill
        btnAceptar.BackColor = Color.LightGreen
        TableLayoutPanel1.Controls.Add(btnAceptar, 0, 5)

        btnCancelar.Text = "Cancelar"
        btnCancelar.Dock = DockStyle.Fill
        btnCancelar.BackColor = Color.LightCoral
        TableLayoutPanel1.Controls.Add(btnCancelar, 1, 5)

        ' Agregar tabla al formulario
        Controls.Add(TableLayoutPanel1)
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtNombre.Text = "" Then
            MessageBox.Show("Debe ingresar su nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtApellido.Text = "" Then
            MessageBox.Show("Debe ingresar su apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If chkTerminos.Checked = False Then
            MessageBox.Show("Debe aceptar los términos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim genero As String = "No especificado"
        If rbMasculino.Checked Then
            genero = "Masculino"
        ElseIf rbFemenino.Checked Then
            genero = "Femenino"
        End If

        MessageBox.Show($"Registro exitoso:{vbCrLf}Nombre: {txtNombre.Text}{vbCrLf}Apellido: {txtApellido.Text}{vbCrLf}Género: {genero}",
                      "Éxito",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        End If
    End Sub
End Class
```

## 6. FlowLayoutPanel

**Explicación**: El FlowLayoutPanel organiza los controles en secuencia, ya sea horizontal o verticalmente, ajustándose automáticamente al espacio disponible. Ideal para listas de controles dinámicas.

```vb
Public Class Form1
    ' Declaración del FlowLayoutPanel
    Private WithEvents FLPanel As New FlowLayoutPanel()
    
    ' Evento para el botón Guardar
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)
        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Estás seguro de guardar los datos?",
            "Confirmar Guardado",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If respuesta = DialogResult.Yes Then
            MessageBox.Show(
                "Datos guardados correctamente",
                "Éxito",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        End If
    End Sub

    ' Evento para el botón Cancelar
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Dim respuesta As DialogResult = MessageBox.Show(
            "¿Deseas cancelar el proceso? Los cambios no se guardarán.",
            "Advertencia",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning
        )

        If respuesta = DialogResult.OK Then
            MessageBox.Show(
                "Operación cancelada",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation
            )
        End If
    End Sub

    ' Evento para el botón Enviar
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs)
        MessageBox.Show(
            "¡Gracias por tus comentarios! Los hemos recibido correctamente.",
            "Mensaje Enviado",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk
        )
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración del formulario
        Text = "Ejemplo FlowLayoutPanel"
        ClientSize = New Size(400, 500)
        StartPosition = FormStartPosition.CenterScreen

        ' Configuración del FLPanel
        FLPanel.FlowDirection = FlowDirection.TopDown ' Organización vertical
        FLPanel.WrapContents = False ' No envolver (scroll vertical)
        FLPanel.AutoScroll = True ' Activar scroll automático
        FLPanel.Padding = New Padding(10) ' Margen interno
        FLPanel.BackColor = Color.LightGray ' Fondo para visualización
        FLPanel.Dock = DockStyle.Fill ' Ocupar todo el formulario

        ' Agregar controles al FLPanel
        ' Título
        Dim lblTitulo As New Label()
        lblTitulo.Text = "Formulario Dinámico"
        lblTitulo.Font = New Font("Arial", 12, FontStyle.Bold)
        lblTitulo.AutoSize = True
        FLPanel.Controls.Add(lblTitulo)

        ' Nombre
        Dim lblNombre As New Label()
        lblNombre.Text = "Nombre:"
        lblNombre.AutoSize = True
        FLPanel.Controls.Add(lblNombre)

        Dim txtNombre As New TextBox()
        txtNombre.Width = 200
        FLPanel.Controls.Add(txtNombre)

        ' Apellido
        Dim lblApellido As New Label()
        lblApellido.Text = "Apellido:"
        lblApellido.AutoSize = True
        FLPanel.Controls.Add(lblApellido)

        Dim txtApellido As New TextBox()
        txtApellido.Width = 200
        FLPanel.Controls.Add(txtApellido)

        ' CheckBoxes
        Dim chkTerminos As New CheckBox()
        chkTerminos.Text = "Acepto los términos y condiciones"
        chkTerminos.AutoSize = True
        FLPanel.Controls.Add(chkTerminos)

        Dim chkNoticias As New CheckBox()
        chkNoticias.Text = "Deseo recibir noticias por correo"
        chkNoticias.AutoSize = True
        FLPanel.Controls.Add(chkNoticias)

        ' RadioButtons
        Dim rbOpcion1 As New RadioButton()
        rbOpcion1.Text = "Opción 1"
        rbOpcion1.AutoSize = True
        FLPanel.Controls.Add(rbOpcion1)

        Dim rbOpcion2 As New RadioButton()
        rbOpcion2.Text = "Opción 2"
        rbOpcion2.AutoSize = True
        FLPanel.Controls.Add(rbOpcion2)

        ' Botón Guardar
        Dim btnGuardar As New Button()
        btnGuardar.Text = "Guardar"
        btnGuardar.Width = 100
        btnGuardar.Height = 30
        FLPanel.Controls.Add(btnGuardar)
        AddHandler btnGuardar.Click, AddressOf btnGuardar_Click

        ' Botón Cancelar
        Dim btnCancelar As New Button()
        btnCancelar.Text = "Cancelar"
        btnCancelar.Width = 100
        btnCancelar.Height = 30
        FLPanel.Controls.Add(btnCancelar)
        AddHandler btnCancelar.Click, AddressOf btnCancelar_Click

        ' Espacio
        Dim lblEspacio As New Label()
        lblEspacio.Text = ""
        lblEspacio.Height = 20
        FLPanel.Controls.Add(lblEspacio)

        ' Comentarios
        Dim lblComentario As New Label()
        lblComentario.Text = "Escribe un comentario:"
        lblComentario.Font = New Font("Arial", 10, FontStyle.Italic)
        lblComentario.AutoSize = True
        FLPanel.Controls.Add(lblComentario)

        Dim txtComentarios As New TextBox()
        txtComentarios.Multiline = True
        txtComentarios.Width = 200
        txtComentarios.Height = 60
        FLPanel.Controls.Add(txtComentarios)

        ' Botón Enviar
        Dim btnEnviar As New Button()
        btnEnviar.Text = "Enviar Comentarios"
        btnEnviar.Width = 150
        btnEnviar.Height = 35
        FLPanel.Controls.Add(btnEnviar)
        AddHandler btnEnviar.Click, AddressOf btnEnviar_Click

        ' Agregar el FLPanel al formulario
        Controls.Add(FLPanel)
    End Sub
End Class
```