Public Class Form7
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

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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