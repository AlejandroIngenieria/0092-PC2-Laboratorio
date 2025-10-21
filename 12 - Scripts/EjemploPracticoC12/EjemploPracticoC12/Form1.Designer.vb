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
        Label1 = New Label()
        txtEmail = New TextBox()
        txtPassword = New TextBox()
        btnCargarUsuario = New Button()
        TabControl1 = New TabControl()
        tabCanciones = New TabPage()
        txtURL = New TextBox()
        dtpFecha = New DateTimePicker()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnAgregar = New Button()
        btnCargar = New Button()
        Label2 = New Label()
        txtLetra = New TextBox()
        txtArtista = New TextBox()
        txtNombre = New TextBox()
        txtId = New TextBox()
        dgvCanciones = New DataGridView()
        tabFavoritos = New TabPage()
        flpFavoritos = New FlowLayoutPanel()
        tabCancionesVisual = New TabPage()
        flpCanciones = New FlowLayoutPanel()
        TabControl1.SuspendLayout()
        tabCanciones.SuspendLayout()
        CType(dgvCanciones, ComponentModel.ISupportInitialize).BeginInit()
        tabFavoritos.SuspendLayout()
        tabCancionesVisual.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(32, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 20)
        Label1.TabIndex = 0
        Label1.Text = "Login"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(111, 31)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Ingresa tu correo"
        txtEmail.Size = New Size(366, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(507, 31)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Ingresa tu contraseña"
        txtPassword.Size = New Size(366, 27)
        txtPassword.TabIndex = 2
        ' 
        ' btnCargarUsuario
        ' 
        btnCargarUsuario.Location = New Point(904, 24)
        btnCargarUsuario.Name = "btnCargarUsuario"
        btnCargarUsuario.Size = New Size(243, 40)
        btnCargarUsuario.TabIndex = 3
        btnCargarUsuario.Text = "Cargar usuario"
        btnCargarUsuario.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabCanciones)
        TabControl1.Controls.Add(tabFavoritos)
        TabControl1.Controls.Add(tabCancionesVisual)
        TabControl1.Location = New Point(32, 98)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1316, 631)
        TabControl1.TabIndex = 4
        ' 
        ' tabCanciones
        ' 
        tabCanciones.Controls.Add(txtURL)
        tabCanciones.Controls.Add(dtpFecha)
        tabCanciones.Controls.Add(btnEliminar)
        tabCanciones.Controls.Add(btnEditar)
        tabCanciones.Controls.Add(btnAgregar)
        tabCanciones.Controls.Add(btnCargar)
        tabCanciones.Controls.Add(Label2)
        tabCanciones.Controls.Add(txtLetra)
        tabCanciones.Controls.Add(txtArtista)
        tabCanciones.Controls.Add(txtNombre)
        tabCanciones.Controls.Add(txtId)
        tabCanciones.Controls.Add(dgvCanciones)
        tabCanciones.Location = New Point(4, 29)
        tabCanciones.Name = "tabCanciones"
        tabCanciones.Padding = New Padding(3)
        tabCanciones.Size = New Size(1308, 598)
        tabCanciones.TabIndex = 0
        tabCanciones.Text = "Admin-canciones"
        tabCanciones.UseVisualStyleBackColor = True
        ' 
        ' txtURL
        ' 
        txtURL.Location = New Point(852, 409)
        txtURL.Name = "txtURL"
        txtURL.PlaceholderText = "URL de la imagen"
        txtURL.Size = New Size(428, 27)
        txtURL.TabIndex = 12
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Location = New Point(852, 350)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(428, 27)
        dtpFecha.TabIndex = 11
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(1075, 538)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(205, 57)
        btnEliminar.TabIndex = 10
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(852, 538)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(205, 57)
        btnEditar.TabIndex = 9
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(1075, 470)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(205, 57)
        btnAgregar.TabIndex = 8
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(849, 470)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(205, 57)
        btnCargar.TabIndex = 7
        btnCargar.Text = "Cargar"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(852, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(152, 20)
        Label2.TabIndex = 6
        Label2.Text = "Cancion seleccionada"
        ' 
        ' txtLetra
        ' 
        txtLetra.Location = New Point(852, 295)
        txtLetra.Name = "txtLetra"
        txtLetra.PlaceholderText = "Letra"
        txtLetra.Size = New Size(428, 27)
        txtLetra.TabIndex = 4
        ' 
        ' txtArtista
        ' 
        txtArtista.Location = New Point(852, 235)
        txtArtista.Name = "txtArtista"
        txtArtista.PlaceholderText = "artista"
        txtArtista.Size = New Size(428, 27)
        txtArtista.TabIndex = 3
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(852, 177)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "nombre"
        txtNombre.Size = New Size(428, 27)
        txtNombre.TabIndex = 2
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(852, 99)
        txtId.Name = "txtId"
        txtId.PlaceholderText = "id del usuario"
        txtId.Size = New Size(428, 27)
        txtId.TabIndex = 1
        ' 
        ' dgvCanciones
        ' 
        dgvCanciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCanciones.Location = New Point(19, 20)
        dgvCanciones.Name = "dgvCanciones"
        dgvCanciones.RowHeadersWidth = 51
        dgvCanciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCanciones.Size = New Size(811, 564)
        dgvCanciones.TabIndex = 0
        ' 
        ' tabFavoritos
        ' 
        tabFavoritos.Controls.Add(flpFavoritos)
        tabFavoritos.Location = New Point(4, 29)
        tabFavoritos.Name = "tabFavoritos"
        tabFavoritos.Padding = New Padding(3)
        tabFavoritos.Size = New Size(1308, 598)
        tabFavoritos.TabIndex = 1
        tabFavoritos.Text = "User-favoritos"
        tabFavoritos.UseVisualStyleBackColor = True
        ' 
        ' flpFavoritos
        ' 
        flpFavoritos.Location = New Point(27, 22)
        flpFavoritos.Name = "flpFavoritos"
        flpFavoritos.Size = New Size(1257, 573)
        flpFavoritos.TabIndex = 0
        ' 
        ' tabCancionesVisual
        ' 
        tabCancionesVisual.Controls.Add(flpCanciones)
        tabCancionesVisual.Location = New Point(4, 29)
        tabCancionesVisual.Name = "tabCancionesVisual"
        tabCancionesVisual.Size = New Size(1308, 598)
        tabCancionesVisual.TabIndex = 2
        tabCancionesVisual.Text = "User-canciones"
        tabCancionesVisual.UseVisualStyleBackColor = True
        ' 
        ' flpCanciones
        ' 
        flpCanciones.Location = New Point(26, 29)
        flpCanciones.Name = "flpCanciones"
        flpCanciones.Size = New Size(1233, 532)
        flpCanciones.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1403, 755)
        Controls.Add(TabControl1)
        Controls.Add(btnCargarUsuario)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        tabCanciones.ResumeLayout(False)
        tabCanciones.PerformLayout()
        CType(dgvCanciones, ComponentModel.ISupportInitialize).EndInit()
        tabFavoritos.ResumeLayout(False)
        tabCancionesVisual.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCargarUsuario As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabCanciones As TabPage
    Friend WithEvents tabFavoritos As TabPage
    Friend WithEvents dgvCanciones As DataGridView
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLetra As TextBox
    Friend WithEvents txtArtista As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtURL As TextBox
    Friend WithEvents flpFavoritos As FlowLayoutPanel
    Friend WithEvents tabCancionesVisual As TabPage
    Friend WithEvents flpCanciones As FlowLayoutPanel

End Class
