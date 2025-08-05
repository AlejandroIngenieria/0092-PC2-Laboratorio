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
        btnForm = New Button()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' btnForm
        ' 
        btnForm.Location = New Point(24, 40)
        btnForm.Name = "btnForm"
        btnForm.Size = New Size(303, 131)
        btnForm.TabIndex = 0
        btnForm.Text = "Mostrar Formulario normal"
        btnForm.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(357, 40)
        Button1.Name = "Button1"
        Button1.Size = New Size(303, 131)
        Button1.TabIndex = 1
        Button1.Text = "Ocultar Formulario normal"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(24, 201)
        Button2.Name = "Button2"
        Button2.Size = New Size(303, 131)
        Button2.TabIndex = 2
        Button2.Text = "Cerrar Formulario normal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(btnForm)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnForm As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
