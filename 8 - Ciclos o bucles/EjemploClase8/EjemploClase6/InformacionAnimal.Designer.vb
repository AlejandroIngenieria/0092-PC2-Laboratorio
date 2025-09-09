<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformacionAnimal
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
        picInfo = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNombre = New TextBox()
        txtEdad = New TextBox()
        txtEspecie = New TextBox()
        btnActualizar = New Button()
        btnEliminar = New Button()
        CType(picInfo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picInfo
        ' 
        picInfo.Location = New Point(20, 44)
        picInfo.Name = "picInfo"
        picInfo.Size = New Size(417, 387)
        picInfo.TabIndex = 0
        picInfo.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(443, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(134, 41)
        Label1.TabIndex = 1
        Label1.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(443, 175)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 41)
        Label2.TabIndex = 2
        Label2.Text = "Edad"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(443, 295)
        Label3.Name = "Label3"
        Label3.Size = New Size(121, 41)
        Label3.TabIndex = 3
        Label3.Text = "Especie"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(603, 58)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(286, 27)
        txtNombre.TabIndex = 4
        ' 
        ' txtEdad
        ' 
        txtEdad.Location = New Point(603, 189)
        txtEdad.Name = "txtEdad"
        txtEdad.Size = New Size(286, 27)
        txtEdad.TabIndex = 5
        ' 
        ' txtEspecie
        ' 
        txtEspecie.Location = New Point(603, 309)
        txtEspecie.Name = "txtEspecie"
        txtEspecie.Size = New Size(286, 27)
        txtEspecie.TabIndex = 6
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(465, 378)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(199, 52)
        btnActualizar.TabIndex = 7
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(690, 378)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(199, 52)
        btnEliminar.TabIndex = 8
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' InformacionAnimal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(975, 450)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(txtEspecie)
        Controls.Add(txtEdad)
        Controls.Add(txtNombre)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picInfo)
        Name = "InformacionAnimal"
        Text = "InformacionAnimal"
        CType(picInfo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picInfo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtEspecie As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnEliminar As Button
End Class
