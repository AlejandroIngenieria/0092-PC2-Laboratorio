<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vector
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
        txtVector = New TextBox()
        btnAgregarVector = New Button()
        btnMostrarVector = New Button()
        lstVector = New ListBox()
        SuspendLayout()
        ' 
        ' txtVector
        ' 
        txtVector.Location = New Point(32, 24)
        txtVector.Name = "txtVector"
        txtVector.PlaceholderText = "Ingrese un número"
        txtVector.Size = New Size(415, 27)
        txtVector.TabIndex = 0
        ' 
        ' btnAgregarVector
        ' 
        btnAgregarVector.Location = New Point(484, 12)
        btnAgregarVector.Name = "btnAgregarVector"
        btnAgregarVector.Size = New Size(280, 51)
        btnAgregarVector.TabIndex = 1
        btnAgregarVector.Text = "Agregar al vector"
        btnAgregarVector.UseVisualStyleBackColor = True
        ' 
        ' btnMostrarVector
        ' 
        btnMostrarVector.Location = New Point(242, 371)
        btnMostrarVector.Name = "btnMostrarVector"
        btnMostrarVector.Size = New Size(280, 55)
        btnMostrarVector.TabIndex = 2
        btnMostrarVector.Text = "Mostrar vector"
        btnMostrarVector.UseVisualStyleBackColor = True
        ' 
        ' lstVector
        ' 
        lstVector.FormattingEnabled = True
        lstVector.Location = New Point(198, 69)
        lstVector.Name = "lstVector"
        lstVector.Size = New Size(380, 284)
        lstVector.TabIndex = 3
        ' 
        ' Vector
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstVector)
        Controls.Add(btnMostrarVector)
        Controls.Add(btnAgregarVector)
        Controls.Add(txtVector)
        Name = "Vector"
        Text = "Vector"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtVector As TextBox
    Friend WithEvents btnAgregarVector As Button
    Friend WithEvents btnMostrarVector As Button
    Friend WithEvents lstVector As ListBox
End Class
