Public Class Form2
    ' EL NOMBRE DEL FLOW LAYOUT DEBE SER FLPanel para que este código funcione

    ' CRECION DEL EVENTO PARA EL BOTÓN GUARDAR
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

    ' CRECION DEL EVENTO PARA EL BOTÓN CANCELAR
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

    ' CRECION DEL EVENTO PARA EL BOTÓN ENVIAR COMENTARIOS
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs)
        MessageBox.Show(
            "¡Gracias por tus comentarios! Los hemos recibido correctamente.",
            "Mensaje Enviado",
            MessageBoxButtons.OK,
            MessageBoxIcon.Asterisk
        )
    End Sub

    Private Sub btnForm3_Click(sender As Object, e As EventArgs)
        Form3.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Flow Layout Ejemplo"
        ' Configuración inicial del FLPanel
        FLPanel.FlowDirection = FlowDirection.TopDown ' Organización vertical
        FLPanel.WrapContents = False ' No envolver (scroll vertical)
        FLPanel.AutoScroll = True ' Activar scroll automático
        FLPanel.Padding = New Padding(10) ' Margen interno
        FLPanel.BackColor = Color.LightGray ' Fondo para visualización

        ' ===== AGREGAR CONTROLES MANUALMENTE =====

        ' Aqui agrego un label de título
        Dim lblTitulo As New Label()
        lblTitulo.Text = "Formulario Dinámico"
        lblTitulo.Font = New Font("Arial", 12, FontStyle.Bold)
        lblTitulo.AutoSize = True
        FLPanel.Controls.Add(lblTitulo)

        ' Aqui agrego un label con el texto Nombre
        Dim lblNombre As New Label()
        lblNombre.Text = "Nombre:"
        lblNombre.AutoSize = True
        FLPanel.Controls.Add(lblNombre)

        ' Aqui agrego un TextBox para ingresar el nombre
        Dim txtNombre As New TextBox()
        txtNombre.Width = 200
        FLPanel.Controls.Add(txtNombre)

        ' Aqui agrego un label con el texto Apellido
        Dim lblApellido As New Label()
        lblApellido.Text = "Apellido:"
        lblApellido.AutoSize = True
        FLPanel.Controls.Add(lblApellido)

        ' Aqui agrego un TextBox para ingresar el apellido
        Dim txtApellido As New TextBox()
        txtApellido.Width = 200
        FLPanel.Controls.Add(txtApellido)

        ' --- CheckBoxes (Casillas de verificación) ---
        ' Aquí agrego un checkbox para aceptar términos
        Dim chkTerminos As New CheckBox()
        chkTerminos.Text = "Acepto los términos y condiciones"
        chkTerminos.AutoSize = True
        FLPanel.Controls.Add(chkTerminos)

        ' Aquí agrego un checkbox para recibir noticias
        Dim chkNoticias As New CheckBox()
        chkNoticias.Text = "Deseo recibir noticias por correo"
        chkNoticias.AutoSize = True
        FLPanel.Controls.Add(chkNoticias)

        ' --- RadioButtons (Opciones exclusivas) ---
        ' Aquí agrego dos opciones de radio
        Dim rbOpcion1 As New RadioButton()
        rbOpcion1.Text = "Opción 1"
        rbOpcion1.AutoSize = True
        FLPanel.Controls.Add(rbOpcion1)

        Dim rbOpcion2 As New RadioButton()
        rbOpcion2.Text = "Opción 2"
        rbOpcion2.AutoSize = True
        FLPanel.Controls.Add(rbOpcion2)

        ' --- Buttons (Botones) ---
        ' Aquí agrego un botón para guardar
        Dim btnGuardar As New Button()
        btnGuardar.Text = "Guardar"
        btnGuardar.Width = 100
        btnGuardar.Height = 30
        FLPanel.Controls.Add(btnGuardar)

        ' ASIGNAR EVENTO AL BOTÓN GUARDAR
        AddHandler btnGuardar.Click, AddressOf btnGuardar_Click

        ' Aquí agrego un botón para cancelar
        Dim btnCancelar As New Button()
        btnCancelar.Text = "Cancelar"
        btnCancelar.Width = 100
        btnCancelar.Height = 30
        FLPanel.Controls.Add(btnCancelar)

        ' ASIGNAR EVENTO AL BOTÓN CANCELAR
        AddHandler btnCancelar.Click, AddressOf btnCancelar_Click

        ' --- Separador visual (Label vacío como espacio) ---
        Dim lblEspacio As New Label()
        lblEspacio.Text = ""
        lblEspacio.Height = 20
        FLPanel.Controls.Add(lblEspacio)

        ' --- Comentarios ---
        ' Aquí agrego un label para comentarios
        Dim lblComentario As New Label()
        lblComentario.Text = "Escribe un comentario:"
        lblComentario.Font = New Font("Arial", 10, FontStyle.Italic)
        lblComentario.AutoSize = True
        FLPanel.Controls.Add(lblComentario)

        ' Aquí agrego un TextBox para comentarios
        Dim txtComentarios As New TextBox()
        txtComentarios.Multiline = True
        txtComentarios.Width = 200 'Ancho del TextBox
        txtComentarios.Height = 60 'Alto del TextBox
        FLPanel.Controls.Add(txtComentarios)

        ' Aquí agrego un botón para enviar comentarios
        Dim btnEnviar As New Button()
        btnEnviar.Text = "Enviar Comentarios"
        btnEnviar.Width = 150
        btnEnviar.Height = 35
        FLPanel.Controls.Add(btnEnviar)

        ' ASIGNAR EVENTO AL BOTÓN ENVIAR COMENTARIOS
        AddHandler btnEnviar.Click, AddressOf btnEnviar_Click

        Dim btnForm3 As New Button()
        btnForm3.Text = "Abrir Formulario 3"
        btnForm3.Size = New Size(150, 30)
        FLPanel.Controls.Add(btnForm3)

        AddHandler btnForm3.Click, AddressOf btnForm3_Click

    End Sub
End Class