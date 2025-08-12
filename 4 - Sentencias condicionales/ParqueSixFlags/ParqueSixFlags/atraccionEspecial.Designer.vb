<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class atraccionEspecial
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
        txtEdad = New TextBox()
        btnVerificar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(31, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 0
        Label1.Text = "Edad"
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(95, 25)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(157, 27)
        txtEdad.TabIndex = 1
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Location = New Point(286, 20)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(305, 41)
        btnVerificar.TabIndex = 2
        btnVerificar.Text = "Verificar"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' atraccionEspecial
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVerificar)
        Controls.Add(txtEdad)
        Controls.Add(Label1)
        Name = "atraccionEspecial"
        Text = "Descuentos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents btnVerificar As Button
End Class
