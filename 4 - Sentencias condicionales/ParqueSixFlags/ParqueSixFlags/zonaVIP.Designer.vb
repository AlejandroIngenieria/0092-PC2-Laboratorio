<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zonaVIP
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
        checkVIP = New CheckBox()
        checkSanciones = New CheckBox()
        btnVerificar = New Button()
        SuspendLayout()
        ' 
        ' checkVIP
        ' 
        checkVIP.AutoSize = True
        checkVIP.Location = New Point(110, 57)
        checkVIP.Name = "checkVIP"
        checkVIP.Size = New Size(135, 24)
        checkVIP.TabIndex = 0
        checkVIP.Text = "Es miembro VIP"
        checkVIP.UseVisualStyleBackColor = True
        ' 
        ' checkSanciones
        ' 
        checkSanciones.AutoSize = True
        checkSanciones.Location = New Point(106, 121)
        checkSanciones.Name = "checkSanciones"
        checkSanciones.Size = New Size(212, 24)
        checkSanciones.TabIndex = 1
        checkSanciones.Text = "Tiene sanciones registradas"
        checkSanciones.UseVisualStyleBackColor = True
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Location = New Point(114, 195)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(200, 76)
        btnVerificar.TabIndex = 2
        btnVerificar.Text = "Verificar"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' zonaVIP
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVerificar)
        Controls.Add(checkSanciones)
        Controls.Add(checkVIP)
        Name = "zonaVIP"
        Text = "zonaVIP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents checkVIP As CheckBox
    Friend WithEvents checkSanciones As CheckBox
    Friend WithEvents btnVerificar As Button
End Class
