Public Class Form5
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

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ' Validación del nombre (versión simple sin IsNullOrEmpty)
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