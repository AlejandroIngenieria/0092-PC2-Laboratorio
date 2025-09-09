<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarAnimal
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
        txtEspecie = New TextBox()
        txtEdad = New TextBox()
        txtURL = New TextBox()
        btnAgregar = New Button()
        btnCancelar = New Button()
        SuspendLayout()
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(74, 42)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "Ingresa el nombre del animalito"
        txtNombre.Size = New Size(650, 27)
        txtNombre.TabIndex = 0
        ' 
        ' txtEspecie
        ' 
        txtEspecie.Location = New Point(74, 115)
        txtEspecie.Name = "txtEspecie"
        txtEspecie.PlaceholderText = "Ingresa la especie del animalito"
        txtEspecie.Size = New Size(650, 27)
        txtEspecie.TabIndex = 1
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(74, 202)
        txtEdad.Name = "txtEdad"
        txtEdad.PlaceholderText = "Ingresa la edad del animalito"
        txtEdad.Size = New Size(650, 27)
        txtEdad.TabIndex = 2
        ' 
        ' txtURL
        ' 
        txtURL.Location = New Point(74, 298)
        txtURL.Name = "txtURL"
        txtURL.PlaceholderText = "Ingresa el URL de la imagen"
        txtURL.Size = New Size(650, 27)
        txtURL.TabIndex = 3
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(173, 366)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(207, 51)
        btnAgregar.TabIndex = 4
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(409, 366)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(207, 51)
        btnCancelar.TabIndex = 5
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' AgregarAnimal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnCancelar)
        Controls.Add(btnAgregar)
        Controls.Add(txtURL)
        Controls.Add(txtEdad)
        Controls.Add(txtEspecie)
        Controls.Add(txtNombre)
        Name = "AgregarAnimal"
        Text = "AgregarAnimal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEspecie As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtURL As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
End Class
