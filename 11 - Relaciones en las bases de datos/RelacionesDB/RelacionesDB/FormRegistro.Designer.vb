<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtNombre = New TextBox()
        txtApellido = New TextBox()
        txtEmail = New TextBox()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        chkAdmin = New CheckBox()
        btnGuardar = New Button()
        btnRegresar = New Button()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(41, 28)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "Ingresa tu nombre"
        txtNombre.Size = New Size(461, 27)
        txtNombre.TabIndex = 0
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(41, 88)
        txtApellido.Name = "txtApellido"
        txtApellido.PlaceholderText = "Ingresa tu apellido"
        txtApellido.Size = New Size(461, 27)
        txtApellido.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(41, 161)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Ingresa tu Email"
        txtEmail.Size = New Size(461, 27)
        txtEmail.TabIndex = 2
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(41, 232)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Ingresa un username"
        txtUsername.Size = New Size(461, 27)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(41, 310)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Ingresa tu password"
        txtPassword.Size = New Size(461, 27)
        txtPassword.TabIndex = 4
        ' 
        ' chkAdmin
        ' 
        chkAdmin.AutoSize = True
        chkAdmin.Location = New Point(427, 376)
        chkAdmin.Name = "chkAdmin"
        chkAdmin.Size = New Size(75, 24)
        chkAdmin.TabIndex = 5
        chkAdmin.Text = "Admin"
        chkAdmin.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(144, 451)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' btnRegresar
        ' 
        btnRegresar.Location = New Point(303, 451)
        btnRegresar.Name = "btnRegresar"
        btnRegresar.Size = New Size(94, 29)
        btnRegresar.TabIndex = 7
        btnRegresar.Text = "Regresar"
        btnRegresar.UseVisualStyleBackColor = True
        ' 
        ' FormRegistro
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(571, 541)
        Controls.Add(btnRegresar)
        Controls.Add(btnGuardar)
        Controls.Add(chkAdmin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(txtEmail)
        Controls.Add(txtApellido)
        Controls.Add(txtNombre)
        Name = "FormRegistro"
        Text = "Registro"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkAdmin As CheckBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnRegresar As Button
End Class
