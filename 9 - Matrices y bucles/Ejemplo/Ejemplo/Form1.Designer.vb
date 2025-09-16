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
        btnVector = New Button()
        btnMatriz = New Button()
        SuspendLayout()
        ' 
        ' btnVector
        ' 
        btnVector.Location = New Point(51, 82)
        btnVector.Name = "btnVector"
        btnVector.Size = New Size(697, 97)
        btnVector.TabIndex = 0
        btnVector.Text = "Ejemplo Vector"
        btnVector.UseVisualStyleBackColor = True
        ' 
        ' btnMatriz
        ' 
        btnMatriz.Location = New Point(51, 231)
        btnMatriz.Name = "btnMatriz"
        btnMatriz.Size = New Size(697, 97)
        btnMatriz.TabIndex = 1
        btnMatriz.Text = "Ejemplo Matriz"
        btnMatriz.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnMatriz)
        Controls.Add(btnVector)
        Name = "Form1"
        Text = "Ejemplo Clase 9"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnVector As Button
    Friend WithEvents btnMatriz As Button

End Class
