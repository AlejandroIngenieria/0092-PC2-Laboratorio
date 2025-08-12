<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class casaTerror
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
        checkPermiso = New CheckBox()
        Label1 = New Label()
        txtEdad = New TextBox()
        btnVerificar = New Button()
        SuspendLayout()
        ' 
        ' checkPermiso
        ' 
        checkPermiso.AutoSize = True
        checkPermiso.Location = New Point(80, 24)
        checkPermiso.Name = "checkPermiso"
        checkPermiso.Size = New Size(245, 24)
        checkPermiso.TabIndex = 0
        checkPermiso.Text = "Tiene permiso firmado por tutor"
        checkPermiso.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(66, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 20)
        Label1.TabIndex = 1
        Label1.Text = "Edad"
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(126, 78)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(139, 27)
        txtEdad.TabIndex = 2
        ' 
        ' btnVerificar
        ' 
        btnVerificar.Location = New Point(71, 154)
        btnVerificar.Name = "btnVerificar"
        btnVerificar.Size = New Size(228, 71)
        btnVerificar.TabIndex = 3
        btnVerificar.Text = "Verificar"
        btnVerificar.UseVisualStyleBackColor = True
        ' 
        ' casaTerror
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnVerificar)
        Controls.Add(txtEdad)
        Controls.Add(Label1)
        Controls.Add(checkPermiso)
        Name = "casaTerror"
        Text = "casaTerror"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents checkPermiso As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents btnVerificar As Button
End Class
