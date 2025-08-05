Public Class Form8
    ' 📦 DECLARACIÓN DE CONTROLES
    Private WithEvents TableLayoutPanel1 As New TableLayoutPanel()
    Private WithEvents lblTitulo As New Label()
    Private WithEvents txtNombre As New TextBox()
    Private WithEvents txtApellido As New TextBox()
    Private WithEvents rbMasculino As New RadioButton()
    Private WithEvents rbFemenino As New RadioButton()
    Private WithEvents chkTerminos As New CheckBox()
    Private WithEvents btnAceptar As New Button()
    Private WithEvents btnCancelar As New Button()

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' =========================================
        ' 🖼️  CONFIGURACIÓN BÁSICA DEL FORMULARIO
        ' =========================================
        Me.Text = "Formulario con TableLayoutPanel"  ' Título de la ventana
        Me.ClientSize = New Size(500, 300)          ' Tamaño del área cliente (ancho x alto)
        Me.StartPosition = FormStartPosition.CenterScreen ' Centrar en pantalla

        ' =========================================
        ' 🧱 CONFIGURACIÓN DEL TABLELAYOUTPANEL
        ' =========================================
        ' 🔹 Propiedades básicas
        TableLayoutPanel1.Dock = DockStyle.Fill     ' Ocupa todo el espacio del formulario
        TableLayoutPanel1.BackColor = Color.WhiteSmoke ' Color de fondo suave
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single ' Bordes visibles entre celdas

        ' 🔹 CONFIGURACIÓN DE COLUMNAS (2 columnas)
        TableLayoutPanel1.ColumnCount = 2           ' Dividir en 2 columnas
        ' Columna 1: 30% del ancho (para etiquetas)
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 30.0F))
        ' Columna 2: 70% del ancho (para controles de entrada)
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 70.0F))

        ' 🔹 CONFIGURACIÓN DE FILAS (6 filas)
        TableLayoutPanel1.RowCount = 6             ' Dividir en 6 filas
        ' Fila 1: Título (40px de alto)
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 40.0F))
        ' Fila 2: Nombre (30px)
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0F))
        ' Fila 3: Apellido (30px)
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0F))
        ' Fila 4: Género (60px - más alta para los RadioButtons)
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 60.0F))
        ' Fila 5: Términos (30px)
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30.0F))
        ' Fila 6: Botones (50px)
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 50.0F))

        ' =========================================
        ' ✨ AGREGAR CONTROLES A LA TABLA
        ' =========================================

        ' 🔵 FILA 1: TÍTULO (ocupa 2 columnas)
        lblTitulo.Text = "Formulario de Registro"
        lblTitulo.Font = New Font("Arial", 12, FontStyle.Bold) ' Fuente en negrita
        lblTitulo.TextAlign = ContentAlignment.MiddleCenter    ' Texto centrado
        lblTitulo.Dock = DockStyle.Fill                        ' Ocupa toda la celda
        lblTitulo.BackColor = Color.LightBlue                  ' Color de fondo
        TableLayoutPanel1.Controls.Add(lblTitulo, 0, 0)        ' Agregar en columna 0, fila 0
        TableLayoutPanel1.SetColumnSpan(lblTitulo, 2)          ' Expandir 2 columnas

        ' 🔵 FILA 2: NOMBRE
        ' Etiqueta "Nombre" (columna 0)
        Dim lblNombre As New Label()
        lblNombre.Text = "Nombre:"
        lblNombre.TextAlign = ContentAlignment.MiddleRight ' Alineación derecha
        lblNombre.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(lblNombre, 0, 1)    ' Columna 0, Fila 1

        ' Campo de texto (columna 1)
        txtNombre.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(txtNombre, 1, 1)    ' Columna 1, Fila 1

        ' 🔵 FILA 3: APELLIDO
        ' Etiqueta "Apellido" (columna 0)
        Dim lblApellido As New Label()
        lblApellido.Text = "Apellido:"
        lblApellido.TextAlign = ContentAlignment.MiddleRight
        lblApellido.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(lblApellido, 0, 2)  ' Columna 0, Fila 2

        ' Campo de texto (columna 1)
        txtApellido.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(txtApellido, 1, 2)  ' Columna 1, Fila 2

        ' 🔵 FILA 4: GÉNERO
        ' Etiqueta "Género" (columna 0)
        Dim lblGenero As New Label()
        lblGenero.Text = "Género:"
        lblGenero.TextAlign = ContentAlignment.MiddleRight
        lblGenero.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(lblGenero, 0, 3)    ' Columna 0, Fila 3

        ' Panel para contener los RadioButtons (columna 1)
        Dim panelGenero As New Panel()
        panelGenero.Dock = DockStyle.Fill

        ' RadioButton "Masculino"
        rbMasculino.Text = "Masculino"
        rbMasculino.Location = New Point(10, 10)  ' Posición dentro del panel
        panelGenero.Controls.Add(rbMasculino)

        ' RadioButton "Femenino"
        rbFemenino.Text = "Femenino"
        rbFemenino.Location = New Point(10, 35)   ' 25px debajo del primero
        panelGenero.Controls.Add(rbFemenino)

        TableLayoutPanel1.Controls.Add(panelGenero, 1, 3)  ' Columna 1, Fila 3

        ' 🔵 FILA 5: TÉRMINOS (ocupa 2 columnas)
        chkTerminos.Text = "Acepto los términos y condiciones"
        chkTerminos.AutoSize = True  ' Ajusta tamaño automáticamente
        chkTerminos.Dock = DockStyle.Fill
        TableLayoutPanel1.Controls.Add(chkTerminos, 0, 4)  ' Columna 0, Fila 4
        TableLayoutPanel1.SetColumnSpan(chkTerminos, 2)    ' Expandir 2 columnas

        ' 🔵 FILA 6: BOTONES
        ' Botón "Aceptar" (columna 0)
        btnAceptar.Text = "Aceptar"
        btnAceptar.Dock = DockStyle.Fill
        btnAceptar.BackColor = Color.LightGreen
        TableLayoutPanel1.Controls.Add(btnAceptar, 0, 5)   ' Columna 0, Fila 5

        ' Botón "Cancelar" (columna 1)
        btnCancelar.Text = "Cancelar"
        btnCancelar.Dock = DockStyle.Fill
        btnCancelar.BackColor = Color.LightCoral
        TableLayoutPanel1.Controls.Add(btnCancelar, 1, 5)  ' Columna 1, Fila 5

        ' =========================================
        ' 🏁 FINALIZAR - AGREGAR TABLA AL FORMULARIO
        ' =========================================
        Me.Controls.Add(TableLayoutPanel1)
    End Sub

    ' =========================================
    ' 🎯 EVENTOS DE LOS BOTONES
    ' =========================================

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Validación 1: Nombre vacío
        If txtNombre.Text = "" Then
            MessageBox.Show("Debe ingresar su nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub  ' Salir del método
        End If

        ' Validación 2: Apellido vacío
        If txtApellido.Text = "" Then
            MessageBox.Show("Debe ingresar su apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validación 3: Términos no aceptados
        If chkTerminos.Checked = False Then
            MessageBox.Show("Debe aceptar los términos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Determinar género seleccionado
        Dim genero As String = "No especificado"
        If rbMasculino.Checked Then
            genero = "Masculino"
        ElseIf rbFemenino.Checked Then
            genero = "Femenino"
        End If

        ' Mostrar resumen
        MessageBox.Show($"Registro exitoso:{vbCrLf}Nombre: {txtNombre.Text}{vbCrLf}Apellido: {txtApellido.Text}{vbCrLf}Género: {genero}",
                      "Éxito",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Confirmar antes de cancelar
        If MessageBox.Show("¿Está seguro que desea cancelar?", "Confirmar",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.Close()  ' Cerrar el formulario
        End If
    End Sub
End Class