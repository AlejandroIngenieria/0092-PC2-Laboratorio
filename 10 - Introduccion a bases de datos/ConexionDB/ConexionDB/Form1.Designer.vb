<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblId = New Label()
        lblNombre = New Label()
        lblCorreo = New Label()
        txtId = New TextBox()
        txtNombre = New TextBox()
        txtCorreo = New TextBox()
        dgvClientes = New DataGridView()
        btnAgregar = New Button()
        btnActualizar = New Button()
        btnCargar = New Button()
        btnEliminar = New Button()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblId.Location = New Point(22, 39)
        lblId.Name = "lblId"
        lblId.Size = New Size(50, 41)
        lblId.TabIndex = 0
        lblId.Text = "ID"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombre.Location = New Point(22, 127)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(134, 41)
        lblNombre.TabIndex = 1
        lblNombre.Text = "Nombre"
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCorreo.Location = New Point(22, 221)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New Size(113, 41)
        lblCorreo.TabIndex = 2
        lblCorreo.Text = "Correo"
        ' 
        ' txtId
        ' 
        txtId.Enabled = False
        txtId.Location = New Point(193, 39)
        txtId.Name = "txtId"
        txtId.Size = New Size(407, 27)
        txtId.TabIndex = 3
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(193, 141)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(407, 27)
        txtNombre.TabIndex = 4
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New Point(193, 235)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(407, 27)
        txtCorreo.TabIndex = 5
        ' 
        ' dgvClientes
        ' 
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Location = New Point(21, 322)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.RowHeadersWidth = 51
        dgvClientes.Size = New Size(1410, 544)
        dgvClientes.TabIndex = 7
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnAgregar.BackgroundImageLayout = ImageLayout.None
        btnAgregar.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAgregar.ForeColor = SystemColors.ControlText
        btnAgregar.Location = New Point(638, 33)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(335, 94)
        btnAgregar.TabIndex = 8
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnActualizar.BackgroundImageLayout = ImageLayout.None
        btnActualizar.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizar.Location = New Point(1029, 33)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(335, 94)
        btnActualizar.TabIndex = 9
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' btnCargar
        ' 
        btnCargar.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnCargar.BackgroundImageLayout = ImageLayout.None
        btnCargar.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCargar.Location = New Point(1029, 168)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(335, 94)
        btnCargar.TabIndex = 11
        btnCargar.Text = "Cargar datos"
        btnCargar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnEliminar.BackgroundImageLayout = ImageLayout.None
        btnEliminar.Font = New Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.Location = New Point(638, 168)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(335, 94)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1457, 900)
        Controls.Add(btnCargar)
        Controls.Add(btnEliminar)
        Controls.Add(btnActualizar)
        Controls.Add(btnAgregar)
        Controls.Add(dgvClientes)
        Controls.Add(txtCorreo)
        Controls.Add(txtNombre)
        Controls.Add(txtId)
        Controls.Add(lblCorreo)
        Controls.Add(lblNombre)
        Controls.Add(lblId)
        Name = "Form1"
        Text = "Form1"
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblId As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnEliminar As Button

End Class
