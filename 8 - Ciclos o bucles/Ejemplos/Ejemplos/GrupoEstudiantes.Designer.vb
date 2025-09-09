<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrupoEstudiantes
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
        flpEstudiantes = New FlowLayoutPanel()
        btnGenerar = New Button()
        SuspendLayout()
        ' 
        ' flpEstudiantes
        ' 
        flpEstudiantes.AutoScroll = True
        flpEstudiantes.FlowDirection = FlowDirection.TopDown
        flpEstudiantes.Location = New Point(57, 35)
        flpEstudiantes.Name = "flpEstudiantes"
        flpEstudiantes.Size = New Size(1302, 742)
        flpEstudiantes.TabIndex = 0
        flpEstudiantes.WrapContents = False
        ' 
        ' btnGenerar
        ' 
        btnGenerar.BackColor = SystemColors.ActiveCaption
        btnGenerar.Font = New Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGenerar.Location = New Point(57, 783)
        btnGenerar.Name = "btnGenerar"
        btnGenerar.Size = New Size(1302, 112)
        btnGenerar.TabIndex = 1
        btnGenerar.Text = "Generar estudiantes"
        btnGenerar.UseVisualStyleBackColor = False
        ' 
        ' GrupoEstudiantes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        ClientSize = New Size(1406, 927)
        Controls.Add(btnGenerar)
        Controls.Add(flpEstudiantes)
        Name = "GrupoEstudiantes"
        Text = "GrupoEstudiantes"
        ResumeLayout(False)
    End Sub

    Friend WithEvents flpEstudiantes As FlowLayoutPanel
    Friend WithEvents btnGenerar As Button
End Class
