<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class zonaInfantil
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
        Verificar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 0
        Label1.Text = "Edad"
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(111, 33)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(272, 27)
        txtEdad.TabIndex = 1
        ' 
        ' Verificar
        ' 
        Verificar.Location = New Point(406, 33)
        Verificar.Name = "Verificar"
        Verificar.Size = New Size(221, 40)
        Verificar.TabIndex = 2
        Verificar.Text = "Verificar"
        Verificar.UseVisualStyleBackColor = True
        ' 
        ' zonaInfantil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Verificar)
        Controls.Add(txtEdad)
        Controls.Add(Label1)
        Name = "zonaInfantil"
        Text = "zonaInfantil"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents Verificar As Button
End Class
