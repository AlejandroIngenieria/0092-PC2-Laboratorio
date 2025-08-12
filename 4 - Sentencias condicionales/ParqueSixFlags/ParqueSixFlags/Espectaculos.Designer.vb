<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Espectaculos
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
        checkPaseEspecial = New CheckBox()
        checkClubFrecuentes = New CheckBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' checkPaseEspecial
        ' 
        checkPaseEspecial.AutoSize = True
        checkPaseEspecial.Location = New Point(88, 39)
        checkPaseEspecial.Name = "checkPaseEspecial"
        checkPaseEspecial.Size = New Size(194, 24)
        checkPaseEspecial.TabIndex = 0
        checkPaseEspecial.Text = "Compro el pase especial"
        checkPaseEspecial.UseVisualStyleBackColor = True
        ' 
        ' checkClubFrecuentes
        ' 
        checkClubFrecuentes.AutoSize = True
        checkClubFrecuentes.Location = New Point(88, 113)
        checkClubFrecuentes.Name = "checkClubFrecuentes"
        checkClubFrecuentes.Size = New Size(288, 24)
        checkClubFrecuentes.TabIndex = 1
        checkClubFrecuentes.Text = "Es parte del club de clientes frecuentes"
        checkClubFrecuentes.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(87, 179)
        Button1.Name = "Button1"
        Button1.Size = New Size(278, 119)
        Button1.TabIndex = 2
        Button1.Text = "Verificar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Espectaculos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(checkClubFrecuentes)
        Controls.Add(checkPaseEspecial)
        Name = "Espectaculos"
        Text = "Espectaculos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents checkPaseEspecial As CheckBox
    Friend WithEvents checkClubFrecuentes As CheckBox
    Friend WithEvents Button1 As Button
End Class
