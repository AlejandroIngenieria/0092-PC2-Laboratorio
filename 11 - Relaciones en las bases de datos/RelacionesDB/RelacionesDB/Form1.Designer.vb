<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtCorreo = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnRegistro = New Button()
        SuspendLayout()
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(64, 89)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.PlaceholderText = "Correo electronico"
        txtCorreo.Size = New Size(457, 27)
        txtCorreo.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(64, 171)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Contraseña"
        txtPassword.Size = New Size(457, 27)
        txtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(59, 263)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(139, 39)
        btnLogin.TabIndex = 2
        btnLogin.Text = "Iniciar sesion"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnRegistro
        ' 
        btnRegistro.Location = New Point(227, 263)
        btnRegistro.Name = "btnRegistro"
        btnRegistro.Size = New Size(139, 39)
        btnRegistro.TabIndex = 3
        btnRegistro.Text = "Registro"
        btnRegistro.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(589, 450)
        Controls.Add(btnRegistro)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtCorreo)
        Name = "Form1"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnRegistro As Button

End Class
