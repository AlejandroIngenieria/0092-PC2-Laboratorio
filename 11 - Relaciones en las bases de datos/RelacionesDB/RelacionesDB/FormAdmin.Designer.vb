<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        tabControlAdmin = New TabControl()
        TabPage1 = New TabPage()
        btnRefrescarU = New Button()
        btnEliminarU = New Button()
        btnActualizarU = New Button()
        btnAgregarU = New Button()
        chkAdminU = New CheckBox()
        txtPasswordU = New TextBox()
        txtUsernameU = New TextBox()
        txtEmailU = New TextBox()
        txtApellidoU = New TextBox()
        txtNombreU = New TextBox()
        dgvUsuarios = New DataGridView()
        TabPage2 = New TabPage()
        btnRefrescarA = New Button()
        btnEliminarA = New Button()
        btnActualizarA = New Button()
        btnAgregarA = New Button()
        txtUrlA = New TextBox()
        txtEdadA = New TextBox()
        txtNombreA = New TextBox()
        dgvAnimales = New DataGridView()
        tabControlAdmin.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(dgvAnimales, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabControlAdmin
        ' 
        tabControlAdmin.Controls.Add(TabPage1)
        tabControlAdmin.Controls.Add(TabPage2)
        tabControlAdmin.Location = New Point(22, 31)
        tabControlAdmin.Name = "tabControlAdmin"
        tabControlAdmin.SelectedIndex = 0
        tabControlAdmin.Size = New Size(1298, 814)
        tabControlAdmin.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnRefrescarU)
        TabPage1.Controls.Add(btnEliminarU)
        TabPage1.Controls.Add(btnActualizarU)
        TabPage1.Controls.Add(btnAgregarU)
        TabPage1.Controls.Add(chkAdminU)
        TabPage1.Controls.Add(txtPasswordU)
        TabPage1.Controls.Add(txtUsernameU)
        TabPage1.Controls.Add(txtEmailU)
        TabPage1.Controls.Add(txtApellidoU)
        TabPage1.Controls.Add(txtNombreU)
        TabPage1.Controls.Add(dgvUsuarios)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1290, 781)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Usuarios"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnRefrescarU
        ' 
        btnRefrescarU.Location = New Point(1135, 582)
        btnRefrescarU.Name = "btnRefrescarU"
        btnRefrescarU.Size = New Size(149, 30)
        btnRefrescarU.TabIndex = 10
        btnRefrescarU.Text = "Refrescar"
        btnRefrescarU.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarU
        ' 
        btnEliminarU.Location = New Point(957, 582)
        btnEliminarU.Name = "btnEliminarU"
        btnEliminarU.Size = New Size(149, 30)
        btnEliminarU.TabIndex = 9
        btnEliminarU.Text = "Eliminar"
        btnEliminarU.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarU
        ' 
        btnActualizarU.Location = New Point(1135, 525)
        btnActualizarU.Name = "btnActualizarU"
        btnActualizarU.Size = New Size(149, 30)
        btnActualizarU.TabIndex = 8
        btnActualizarU.Text = "Actualizar"
        btnActualizarU.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarU
        ' 
        btnAgregarU.Location = New Point(957, 525)
        btnAgregarU.Name = "btnAgregarU"
        btnAgregarU.Size = New Size(149, 30)
        btnAgregarU.TabIndex = 7
        btnAgregarU.Text = "Agregar"
        btnAgregarU.UseVisualStyleBackColor = True
        ' 
        ' chkAdminU
        ' 
        chkAdminU.AutoSize = True
        chkAdminU.Location = New Point(1199, 401)
        chkAdminU.Name = "chkAdminU"
        chkAdminU.Size = New Size(75, 24)
        chkAdminU.TabIndex = 6
        chkAdminU.Text = "Admin"
        chkAdminU.UseVisualStyleBackColor = True
        ' 
        ' txtPasswordU
        ' 
        txtPasswordU.Location = New Point(943, 326)
        txtPasswordU.Name = "txtPasswordU"
        txtPasswordU.Size = New Size(331, 27)
        txtPasswordU.TabIndex = 5
        ' 
        ' txtUsernameU
        ' 
        txtUsernameU.Location = New Point(943, 246)
        txtUsernameU.Name = "txtUsernameU"
        txtUsernameU.Size = New Size(331, 27)
        txtUsernameU.TabIndex = 4
        ' 
        ' txtEmailU
        ' 
        txtEmailU.Location = New Point(943, 166)
        txtEmailU.Name = "txtEmailU"
        txtEmailU.Size = New Size(331, 27)
        txtEmailU.TabIndex = 3
        ' 
        ' txtApellidoU
        ' 
        txtApellidoU.Location = New Point(943, 84)
        txtApellidoU.Name = "txtApellidoU"
        txtApellidoU.Size = New Size(331, 27)
        txtApellidoU.TabIndex = 2
        ' 
        ' txtNombreU
        ' 
        txtNombreU.Location = New Point(943, 20)
        txtNombreU.Name = "txtNombreU"
        txtNombreU.Size = New Size(331, 27)
        txtNombreU.TabIndex = 1
        ' 
        ' dgvUsuarios
        ' 
        dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvUsuarios.Location = New Point(22, 18)
        dgvUsuarios.Name = "dgvUsuarios"
        dgvUsuarios.RowHeadersWidth = 51
        dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvUsuarios.Size = New Size(905, 730)
        dgvUsuarios.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(btnRefrescarA)
        TabPage2.Controls.Add(btnEliminarA)
        TabPage2.Controls.Add(btnActualizarA)
        TabPage2.Controls.Add(btnAgregarA)
        TabPage2.Controls.Add(txtUrlA)
        TabPage2.Controls.Add(txtEdadA)
        TabPage2.Controls.Add(txtNombreA)
        TabPage2.Controls.Add(dgvAnimales)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1290, 781)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Animales"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' btnRefrescarA
        ' 
        btnRefrescarA.Location = New Point(936, 734)
        btnRefrescarA.Name = "btnRefrescarA"
        btnRefrescarA.Size = New Size(338, 37)
        btnRefrescarA.TabIndex = 7
        btnRefrescarA.Text = "Refrescar"
        btnRefrescarA.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarA
        ' 
        btnEliminarA.Location = New Point(936, 642)
        btnEliminarA.Name = "btnEliminarA"
        btnEliminarA.Size = New Size(338, 37)
        btnEliminarA.TabIndex = 6
        btnEliminarA.Text = "Eliminar"
        btnEliminarA.UseVisualStyleBackColor = True
        ' 
        ' btnActualizarA
        ' 
        btnActualizarA.Location = New Point(936, 557)
        btnActualizarA.Name = "btnActualizarA"
        btnActualizarA.Size = New Size(338, 37)
        btnActualizarA.TabIndex = 5
        btnActualizarA.Text = "Actualizar"
        btnActualizarA.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarA
        ' 
        btnAgregarA.Location = New Point(936, 480)
        btnAgregarA.Name = "btnAgregarA"
        btnAgregarA.Size = New Size(338, 37)
        btnAgregarA.TabIndex = 4
        btnAgregarA.Text = "Agregar"
        btnAgregarA.UseVisualStyleBackColor = True
        ' 
        ' txtUrlA
        ' 
        txtUrlA.Location = New Point(936, 353)
        txtUrlA.Name = "txtUrlA"
        txtUrlA.Size = New Size(338, 27)
        txtUrlA.TabIndex = 3
        ' 
        ' txtEdadA
        ' 
        txtEdadA.Location = New Point(936, 247)
        txtEdadA.Name = "txtEdadA"
        txtEdadA.Size = New Size(338, 27)
        txtEdadA.TabIndex = 2
        ' 
        ' txtNombreA
        ' 
        txtNombreA.Location = New Point(936, 154)
        txtNombreA.Name = "txtNombreA"
        txtNombreA.Size = New Size(338, 27)
        txtNombreA.TabIndex = 1
        ' 
        ' dgvAnimales
        ' 
        dgvAnimales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAnimales.Location = New Point(21, 19)
        dgvAnimales.Name = "dgvAnimales"
        dgvAnimales.RowHeadersWidth = 51
        dgvAnimales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAnimales.Size = New Size(890, 752)
        dgvAnimales.TabIndex = 0
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1332, 868)
        Controls.Add(tabControlAdmin)
        Name = "FormAdmin"
        Text = "FormAdmin"
        tabControlAdmin.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(dgvUsuarios, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(dgvAnimales, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabControlAdmin As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtPasswordU As TextBox
    Friend WithEvents txtUsernameU As TextBox
    Friend WithEvents txtEmailU As TextBox
    Friend WithEvents txtApellidoU As TextBox
    Friend WithEvents txtNombreU As TextBox
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents btnRefrescarU As Button
    Friend WithEvents btnEliminarU As Button
    Friend WithEvents btnActualizarU As Button
    Friend WithEvents btnAgregarU As Button
    Friend WithEvents chkAdminU As CheckBox
    Friend WithEvents dgvAnimales As DataGridView
    Friend WithEvents btnRefrescarA As Button
    Friend WithEvents btnEliminarA As Button
    Friend WithEvents btnActualizarA As Button
    Friend WithEvents btnAgregarA As Button
    Friend WithEvents txtUrlA As TextBox
    Friend WithEvents txtEdadA As TextBox
    Friend WithEvents txtNombreA As TextBox
End Class
