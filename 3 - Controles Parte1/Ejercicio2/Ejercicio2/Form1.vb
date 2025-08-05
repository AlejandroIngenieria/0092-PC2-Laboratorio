Public Class Form1
    ' Declaración de todos los controles
    ' Explicacion de las declaraciones:
    ' Private: El control es accesible solo dentro de la clase Form1.
    ' WithEvents: Permite que el control maneje eventos, como clics de botones.
    ' Aquí los controles son tomados como variables de clase para que puedan ser accedidos por los eventos.
    Private WithEvents txtNombre As TextBox = New TextBox()
    Private WithEvents txtApellido As TextBox = New TextBox()
    Private WithEvents txtCorreo As TextBox = New TextBox()
    Private WithEvents txtTelefono As TextBox = New TextBox()
    Private WithEvents chkTerminos As CheckBox = New CheckBox()
    Private WithEvents chkNoticias As CheckBox = New CheckBox()
    Private WithEvents rbMasculino As RadioButton = New RadioButton()
    Private WithEvents rbFemenino As RadioButton = New RadioButton()
    Private WithEvents rbOtro As RadioButton = New RadioButton()
    Private WithEvents btnGuardar As Button = New Button()
    Private WithEvents btnLimpiar As Button = New Button()
    Private WithEvents btnSalir As Button = New Button()
    Private WithEvents btnForm2 As Button = New Button()
    Private WithEvents btnForm5 As Button = New Button()
    Private WithEvents btnForm6 As Button = New Button()
    Private WithEvents btnForm7 As Button = New Button()
    Private WithEvents btnForm8 As Button = New Button()
    Private WithEvents lblTitulo As Label = New Label()
    Private WithEvents lblNombre As Label = New Label()
    Private WithEvents lblApellido As Label = New Label()
    Private WithEvents lblCorreo As Label = New Label()
    Private WithEvents lblTelefono As Label = New Label()
    Private WithEvents lblGenero As Label = New Label()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' =============================================
        ' CONFIGURACIÓN BÁSICA DEL FORMULARIO PRINCIPAL
        ' =============================================

        ' Text: Establece el título que aparece en la barra superior del formulario
        Text = "Formulario de Registro Completo"

        ' ClientSize: Define el tamaño del área visible del formulario (ancho, alto) en píxeles
        ClientSize = New Size(650, 800)

        ' StartPosition: Determina dónde aparecerá el formulario al abrirse
        ' CenterScreen lo centra en la pantalla del usuario
        StartPosition = FormStartPosition.CenterScreen

        ' BackColor: Establece el color de fondo del formulario
        ' WhiteSmoke es un color gris claro predefinido en .NET
        BackColor = Color.WhiteSmoke

        ' FormBorderStyle: Define el estilo del borde del formulario
        ' FixedDialog impide que el usuario redimensione el formulario
        FormBorderStyle = FormBorderStyle.FixedDialog

        ' MaximizeBox: Desactiva el botón de maximizar (la X en la esquina superior derecha)
        ' False significa que no estará disponible para el usuario
        MaximizeBox = False

        ' =============================================
        ' CREACIÓN Y CONFIGURACIÓN DE CONTROLES
        ' =============================================

        ' ----------------------------
        ' ETIQUETA DE TÍTULO (Label)
        ' ----------------------------
        lblTitulo.Text = "Registro de Usuario"  ' Texto que mostrará la etiqueta
        lblTitulo.Font = New Font("Arial", 14, FontStyle.Bold)  ' Fuente: Arial, tamaño 14, negrita
        lblTitulo.AutoSize = True  ' Ajusta automáticamente el tamaño al contenido del texto
        lblTitulo.Location = New Point(150, 20)  ' Posición (X,Y) desde la esquina superior izquierda
        Controls.Add(lblTitulo)  ' Agrega la etiqueta al formulario

        ' ----------------------------
        ' ETIQUETAS PARA CAMPOS (Labels)
        ' ----------------------------
        ' Cada etiqueta describe qué información debe ingresarse en cada campo

        ' Etiqueta para Nombre
        lblNombre.Text = "Nombre:"  ' Texto descriptivo
        lblNombre.AutoSize = True  ' Se ajusta al tamaño del texto
        lblNombre.Location = New Point(50, 70)  ' Posición (50px desde izquierda, 70px desde arriba)
        Controls.Add(lblNombre)  ' Agregar al formulario

        ' Etiqueta para Apellido
        lblApellido.Text = "Apellido:"
        lblApellido.AutoSize = True
        lblApellido.Location = New Point(50, 110)  ' 110px desde arriba (40px más abajo que Nombre)
        Controls.Add(lblApellido)

        ' Etiqueta para Correo
        lblCorreo.Text = "Correo electrónico:"
        lblCorreo.AutoSize = True
        lblCorreo.Location = New Point(50, 150)  ' 150px desde arriba
        Controls.Add(lblCorreo)

        ' Etiqueta para Teléfono
        lblTelefono.Text = "Teléfono:"
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(50, 190)  ' 190px desde arriba
        Controls.Add(lblTelefono)

        ' Etiqueta para Género
        lblGenero.Text = "Género:"
        lblGenero.AutoSize = True
        lblGenero.Location = New Point(50, 230)  ' 230px desde arriba
        Controls.Add(lblGenero)

        ' ----------------------------
        ' CAMPOS DE TEXTO (TextBox)
        ' ----------------------------
        ' Cada TextBox permite al usuario ingresar información

        ' Campo para Nombre
        txtNombre.Location = New Point(200, 70)  ' Alineado verticalmente con su etiqueta
        txtNombre.Size = New Size(200, 20)  ' Ancho 200px, Alto 20px
        Controls.Add(txtNombre)

        ' Campo para Apellido
        txtApellido.Location = New Point(200, 110)
        txtApellido.Size = New Size(200, 20)
        Controls.Add(txtApellido)

        ' Campo para Correo
        txtCorreo.Location = New Point(200, 150)
        txtCorreo.Size = New Size(200, 20)
        Controls.Add(txtCorreo)

        ' Campo para Teléfono
        txtTelefono.Location = New Point(200, 190)
        txtTelefono.Size = New Size(200, 20)
        Controls.Add(txtTelefono)

        ' ----------------------------
        ' OPCIONES DE GÉNERO (RadioButtons)
        ' ----------------------------
        ' RadioButtons permiten seleccionar UNA sola opción entre varias

        ' Opción Masculino
        rbMasculino.Text = "Masculino"  ' Texto que aparece junto al botón
        rbMasculino.AutoSize = True  ' Ajusta tamaño automáticamente
        rbMasculino.Location = New Point(200, 230)  ' Alineado con su etiqueta
        Controls.Add(rbMasculino)

        ' Opción Femenino
        rbFemenino.Text = "Femenino"
        rbFemenino.AutoSize = True
        rbFemenino.Location = New Point(200, 260)  ' 30px más abajo que Masculino
        Controls.Add(rbFemenino)

        ' Opción Otro
        rbOtro.Text = "Otro"
        rbOtro.AutoSize = True
        rbOtro.Location = New Point(200, 290)  ' 30px más abajo que Femenino
        Controls.Add(rbOtro)

        ' ----------------------------
        ' CASILLAS DE VERIFICACIÓN (CheckBox)
        ' ----------------------------
        ' CheckBox permiten activar/desactivar opciones independientes

        ' Términos y condiciones
        chkTerminos.Text = "Acepto los términos y condiciones"
        chkTerminos.AutoSize = True  ' Ajusta tamaño al texto
        chkTerminos.Location = New Point(50, 330)  ' 330px desde arriba
        Controls.Add(chkTerminos)

        ' Recibir noticias
        chkNoticias.Text = "Deseo recibir noticias y promociones"
        chkNoticias.AutoSize = True
        chkNoticias.Location = New Point(50, 360)  ' 30px más abajo que Términos
        Controls.Add(chkNoticias)

        ' ----------------------------
        ' BOTONES (Button)
        ' ----------------------------

        ' Botón Guardar
        btnGuardar.Text = "Guardar"  ' Texto del botón
        btnGuardar.Size = New Size(100, 35)  ' Ancho 100px, Alto 35px
        btnGuardar.Location = New Point(50, 410)  ' Cerca de la parte inferior
        btnGuardar.BackColor = Color.LightGreen  ' Color de fondo verde claro
        Controls.Add(btnGuardar)

        ' Botón Limpiar
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.Size = New Size(100, 35)
        btnLimpiar.Location = New Point(175, 410)  ' 125px a la derecha de Guardar
        btnLimpiar.BackColor = Color.LightGray  ' Color de fondo gris claro
        Controls.Add(btnLimpiar)

        ' Botón Salir
        btnSalir.Text = "Salir"
        btnSalir.Size = New Size(100, 35)
        btnSalir.Location = New Point(300, 410)  ' 125px a la derecha de Limpiar
        btnSalir.BackColor = Color.LightCoral  ' Color de fondo rojo claro
        Controls.Add(btnSalir)

        ' Botón para abrir Form2
        btnForm2.Text = "Abrir Formulario 2"
        btnForm2.Size = New Size(150, 35)  ' Ancho 150px, Alto 35px
        btnForm2.Location = New Point(50, 460)  ' Cerca de la parte inferior
        Controls.Add(btnForm2)

        ' Botón para abrir Form5
        btnForm5.Text = "Abrir Formulario 5"
        btnForm5.Size = New Size(150, 35)  ' Ancho 150px, Alto 35px
        btnForm5.Location = New Point(250, 460)  ' Cerca de la parte inferior
        Controls.Add(btnForm5)

        ' Botón para abrir Form6
        btnForm6.Text = "Abrir Formulario 6"
        btnForm6.Size = New Size(150, 35)  ' Ancho 150px, Alto 35px
        btnForm6.Location = New Point(50, 510)  ' Cerca de la parte inferior
        Controls.Add(btnForm6)
        ' Botón para abrir Form7
        btnForm7.Text = "Abrir Formulario 7"
        btnForm7.Size = New Size(150, 35)  ' Ancho 150px, Alto 35px
        btnForm7.Location = New Point(250, 510)  ' Cerca de la parte inferior
        Controls.Add(btnForm7)
        ' Botón para abrir Form8
        btnForm8.Text = "Abrir Formulario 8"
        btnForm8.Size = New Size(150, 35)  ' Ancho 150px, Alto 35px
        btnForm8.Location = New Point(150, 560)  ' Cerca de la parte inferior
        Controls.Add(btnForm8)
    End Sub

    ' ========== EVENTOS DE LOS BOTONES ==========

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Validación de campos obligatorios
        If String.IsNullOrEmpty(txtNombre.Text) OrElse String.IsNullOrEmpty(txtApellido.Text) Then
            MessageBox.Show("Por favor complete los campos obligatorios (Nombre y Apellido)",
                          "Campos incompletos",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Warning)
            Return
        End If

        If Not chkTerminos.Checked Then
            MessageBox.Show("Debe aceptar los términos y condiciones para continuar",
                          "Términos no aceptados",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Exclamation)
            Return
        End If

        ' Mostrar resumen de los datos
        Dim genero As String = "No especificado"
        If rbMasculino.Checked Then genero = "Masculino"
        If rbFemenino.Checked Then genero = "Femenino"
        If rbOtro.Checked Then genero = "Otro"

        Dim mensaje As String = $"Datos a guardar:{vbCrLf}{vbCrLf}" &
                               $"Nombre: {txtNombre.Text}{vbCrLf}" &
                               $"Apellido: {txtApellido.Text}{vbCrLf}" &
                               $"Correo: {If(String.IsNullOrEmpty(txtCorreo.Text), "No especificado", txtCorreo.Text)}{vbCrLf}" &
                               $"Teléfono: {If(String.IsNullOrEmpty(txtTelefono.Text), "No especificado", txtTelefono.Text)}{vbCrLf}" &
                               $"Género: {genero}{vbCrLf}" &
                               $"Recibir noticias: {If(chkNoticias.Checked, "Sí", "No")}"

        Dim respuesta As DialogResult = MessageBox.Show(mensaje,
                                                     "Confirmar Registro",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            MessageBox.Show("Registro guardado exitosamente",
                          "Éxito",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        ' Limpiar todos los campos
        txtNombre.Clear()
        txtApellido.Clear()
        txtCorreo.Clear()
        txtTelefono.Clear()

        ' Desmarcar RadioButtons
        rbMasculino.Checked = False
        rbFemenino.Checked = False
        rbOtro.Checked = False

        ' Desmarcar CheckBoxes
        chkTerminos.Checked = False
        chkNoticias.Checked = False

        MessageBox.Show("Formulario limpiado",
                      "Información",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea salir?",
                                                     "Confirmar Salida",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If respuesta = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Form2.Show()
    End Sub

    Private Sub btnForm5_Click(sender As Object, e As EventArgs) Handles btnForm5.Click
        Form5.Show()
    End Sub

    Private Sub btnForm6_Click(sender As Object, e As EventArgs) Handles btnForm6.Click
        Form6.Show()
    End Sub

    Private Sub btnForm7_Click(sender As Object, e As EventArgs) Handles btnForm7.Click
        Form7.Show()
    End Sub

    Private Sub btnForm8_Click(sender As Object, e As EventArgs) Handles btnForm8.Click
        Form8.Show()
    End Sub



End Class
