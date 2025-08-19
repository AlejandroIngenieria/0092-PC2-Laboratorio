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
        listaEntero = New Button()
        listaUsuario = New Button()
        arrayEntero = New Button()
        arrayCadena = New Button()
        SuspendLayout()
        ' 
        ' listaEntero
        ' 
        listaEntero.Location = New Point(88, 64)
        listaEntero.Name = "listaEntero"
        listaEntero.Size = New Size(219, 94)
        listaEntero.TabIndex = 0
        listaEntero.Text = "Lista enteros"
        listaEntero.UseVisualStyleBackColor = True
        ' 
        ' listaUsuario
        ' 
        listaUsuario.Location = New Point(351, 64)
        listaUsuario.Name = "listaUsuario"
        listaUsuario.Size = New Size(219, 94)
        listaUsuario.TabIndex = 1
        listaUsuario.Text = "Lista usuarios"
        listaUsuario.UseVisualStyleBackColor = True
        ' 
        ' arrayEntero
        ' 
        arrayEntero.Location = New Point(351, 208)
        arrayEntero.Name = "arrayEntero"
        arrayEntero.Size = New Size(219, 94)
        arrayEntero.TabIndex = 3
        arrayEntero.Text = "Array enteros"
        arrayEntero.UseVisualStyleBackColor = True
        ' 
        ' arrayCadena
        ' 
        arrayCadena.Location = New Point(88, 208)
        arrayCadena.Name = "arrayCadena"
        arrayCadena.Size = New Size(219, 94)
        arrayCadena.TabIndex = 2
        arrayCadena.Text = "Array cadenas"
        arrayCadena.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(arrayEntero)
        Controls.Add(arrayCadena)
        Controls.Add(listaUsuario)
        Controls.Add(listaEntero)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents listaEntero As Button
    Friend WithEvents listaUsuario As Button
    Friend WithEvents arrayEntero As Button
    Friend WithEvents arrayCadena As Button

End Class
