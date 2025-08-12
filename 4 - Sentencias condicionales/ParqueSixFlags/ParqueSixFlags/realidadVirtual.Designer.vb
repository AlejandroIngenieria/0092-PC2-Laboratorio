<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class realidadVirtual
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
        checkPropias = New CheckBox()
        checkAlquiladas = New CheckBox()
        btnVerficar = New Button()
        SuspendLayout()
        ' 
        ' checkPropias
        ' 
        checkPropias.AutoSize = True
        checkPropias.Location = New Point(69, 38)
        checkPropias.Name = "checkPropias"
        checkPropias.Size = New Size(161, 24)
        checkPropias.TabIndex = 0
        checkPropias.Text = "Tiene gafas propias"
        checkPropias.UseVisualStyleBackColor = True
        ' 
        ' checkAlquiladas
        ' 
        checkAlquiladas.AutoSize = True
        checkAlquiladas.Location = New Point(69, 94)
        checkAlquiladas.Name = "checkAlquiladas"
        checkAlquiladas.Size = New Size(186, 24)
        checkAlquiladas.TabIndex = 1
        checkAlquiladas.Text = "Alquilo gafas al parque"
        checkAlquiladas.UseVisualStyleBackColor = True
        ' 
        ' btnVerficar
        ' 
        btnVerficar.Location = New Point(72, 154)
        btnVerficar.Name = "btnVerficar"
        btnVerficar.Size = New Size(202, 47)
        btnVerficar.TabIndex = 2
        btnVerficar.Text = "Verificar"
        btnVerficar.UseVisualStyleBackColor = True
        ' 
        ' realidadVirtual
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVerficar)
        Controls.Add(checkAlquiladas)
        Controls.Add(checkPropias)
        Name = "realidadVirtual"
        Text = "realidadVirtual"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents checkPropias As CheckBox
    Friend WithEvents checkAlquiladas As CheckBox
    Friend WithEvents btnVerficar As Button
End Class
