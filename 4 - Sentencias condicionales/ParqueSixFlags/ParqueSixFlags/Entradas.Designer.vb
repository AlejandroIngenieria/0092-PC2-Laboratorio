<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entradas
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
        radioTipo1 = New RadioButton()
        radioTipo2 = New RadioButton()
        radioTipo3 = New RadioButton()
        radioTipo4 = New RadioButton()
        btnVerificar = New Button()
        SuspendLayout()
        ' 
        ' radioTipo1
        ' 
        radioTipo1.AutoSize = True
        radioTipo1.Location = New Point(45, 40)
        radioTipo1.Name = "radioTipo1"
        radioTipo1.Size = New Size(72, 24)
        radioTipo1.TabIndex = 0
        radioTipo1.TabStop = True
        radioTipo1.Text = "Tipo 1"
        radioTipo1.UseVisualStyleBackColor = True
        ' 
        ' radioTipo2
        ' 
        radioTipo2.AutoSize = True
        radioTipo2.Location = New Point(45, 92)
        radioTipo2.Name = "radioTipo2"
        radioTipo2.Size = New Size(72, 24)
        radioTipo2.TabIndex = 1
        radioTipo2.TabStop = True
        radioTipo2.Text = "Tipo 2"
        radioTipo2.UseVisualStyleBackColor = True
        ' 
        ' radioTipo3
        ' 
        radioTipo3.AutoSize = True
        radioTipo3.Location = New Point(45, 149)
        radioTipo3.Name = "radioTipo3"
        radioTipo3.Size = New Size(72, 24)
        radioTipo3.TabIndex = 2
        radioTipo3.TabStop = True
        radioTipo3.Text = "Tipo 3"
        radioTipo3.UseVisualStyleBackColor = True
        ' 
        ' radioTipo4
        ' 
        radioTipo4.AutoSize = True
        radioTipo4.Location = New Point(45, 207)
        radioTipo4.Name = "radioTipo4"
        radioTipo4.Size = New Size(72, 24)
        radioTipo4.TabIndex = 3
        radioTipo4.TabStop = True
        radioTipo4.Text = "Tipo 4"
        radioTipo4.UseVisualStyleBackColor = True
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Font = New Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerificar.Location = New Point(202, 40)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(359, 216)
        btnVerificar.TabIndex = 4
        btnVerificar.Text = "Verificar"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' Entradas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVerificar)
        Controls.Add(radioTipo4)
        Controls.Add(radioTipo3)
        Controls.Add(radioTipo2)
        Controls.Add(radioTipo1)
        Name = "Entradas"
        Text = "Entradas funcion especial"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents radioTipo1 As RadioButton
    Friend WithEvents radioTipo2 As RadioButton
    Friend WithEvents radioTipo3 As RadioButton
    Friend WithEvents radioTipo4 As RadioButton
    Friend WithEvents btnVerificar As Button
End Class
