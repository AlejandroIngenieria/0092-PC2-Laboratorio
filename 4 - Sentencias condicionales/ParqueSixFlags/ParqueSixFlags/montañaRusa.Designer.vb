<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class montañaRusa
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
        Label1 = New Label()
        Label2 = New Label()
        txtEstatura = New TextBox()
        txtEdad = New TextBox()
        btnVerificar = New Button()
        checkAcompañado = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 0
        Label1.Text = "Estatura"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(281, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 1
        Label2.Text = "Edad"
        ' 
        ' txtEstatura
        ' 
        txtEstatura.Location = New Point(96, 29)
        txtEstatura.Name = "txtEstatura"
        txtEstatura.Size = New Size(162, 27)
        txtEstatura.TabIndex = 2
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(342, 29)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(162, 27)
        txtEdad.TabIndex = 3
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Location = New Point(547, 99)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(158, 34)
        btnVerificar.TabIndex = 4
        btnVerificar.Text = "Verficar acceso"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' checkAcompañado
        ' 
        checkAcompañado.AutoSize = True
        checkAcompañado.Location = New Point(545, 31)
        checkAcompañado.Name = "checkAcompañado"
        checkAcompañado.Size = New Size(160, 24)
        checkAcompañado.TabIndex = 5
        checkAcompañado.Text = "Viene acompañado"
        checkAcompañado.UseVisualStyleBackColor = True
        ' 
        ' montañaRusa
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(checkAcompañado)
        Controls.Add(btnVerificar)
        Controls.Add(txtEdad)
        Controls.Add(txtEstatura)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "montañaRusa"
        Text = "montañaRusa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtEstatura As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents btnVerificar As Button
    Friend WithEvents checkAcompañado As CheckBox
End Class
