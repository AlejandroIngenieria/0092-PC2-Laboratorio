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
        btnCargar = New Button()
        dtpFecha = New DateTimePicker()
        txtId = New TextBox()
        Label2 = New Label()
        btnEliminar = New Button()
        btnEditar = New Button()
        btnAgregar = New Button()
        txtURL = New TextBox()
        txtLetra = New TextBox()
        txtArtista = New TextBox()
        txtNombre = New TextBox()
        dgvCanciones = New DataGridView()
        tabFavoritos = New TabPage()
        flpFavoritos = New FlowLayoutPanel()
        TabPage3 = New TabPage()
        flpCanciones = New FlowLayoutPanel()
        TabControl1.SuspendLayout()
        tabCanciones.SuspendLayout()
        CType(dgvCanciones, ComponentModel.ISupportInitialize).BeginInit()
        tabFavoritos.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 28.2F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 59)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(230, 49)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "correo"
        txtEmail.Size = New Size(323, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(585, 49)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(323, 27)
        txtPassword.TabIndex = 2
        ' 
        ' btnCargarUsuario
        ' 
        btnCargarUsuario.Location = New Point(942, 47)
        btnCargarUsuario.Name = "btnCargarUsuario"
        btnCargarUsuario.Size = New Size(256, 35)
        btnCargarUsuario.TabIndex = 3
        btnCargarUsuario.Text = "Cargar usuario"
        btnCargarUsuario.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabCanciones)
        TabControl1.Controls.Add(tabFavoritos)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(39, 112)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1680, 901)
        TabControl1.TabIndex = 4
        ' 
        ' tabCanciones
        ' 
        tabCanciones.Controls.Add(btnCargar)
        tabCanciones.Controls.Add(dtpFecha)
        tabCanciones.Controls.Add(txtId)
        tabCanciones.Controls.Add(Label2)
        tabCanciones.Controls.Add(btnEliminar)
        tabCanciones.Controls.Add(btnEditar)
        tabCanciones.Controls.Add(btnAgregar)
        tabCanciones.Controls.Add(txtURL)
        tabCanciones.Controls.Add(txtLetra)
        tabCanciones.Controls.Add(txtArtista)
        tabCanciones.Controls.Add(txtNombre)
        tabCanciones.Controls.Add(dgvCanciones)
        tabCanciones.Location = New Point(4, 29)
        tabCanciones.Name = "tabCanciones"
        tabCanciones.Padding = New Padding(3)
        tabCanciones.Size = New Size(1672, 868)
        tabCanciones.TabIndex = 0
        tabCanciones.Text = "Admin-canciones"
        tabCanciones.UseVisualStyleBackColor = True
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(1215, 569)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(447, 66)
        btnCargar.TabIndex = 13
        btnCargar.Text = "Cargar"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Location = New Point(1211, 340)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(450, 27)
        dtpFecha.TabIndex = 12
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(1214, 87)
        txtId.Name = "txtId"
        txtId.PlaceholderText = "Id del usuario"
        txtId.Size = New Size(451, 27)
        txtId.TabIndex = 11
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1215, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(440, 46)
        Label2.TabIndex = 10
        Label2.Text = "Canción seleccionada"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(1212, 785)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(447, 66)
        btnEliminar.TabIndex = 9
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Location = New Point(1212, 713)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(447, 66)
        btnEditar.TabIndex = 7
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(1212, 641)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(447, 66)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' txtURL
        ' 
        txtURL.Location = New Point(1211, 399)
        txtURL.Name = "txtURL"
        txtURL.PlaceholderText = "URL"
        txtURL.Size = New Size(451, 27)
        txtURL.TabIndex = 5
        ' 
        ' txtLetra
        ' 
        txtLetra.Location = New Point(1211, 267)
        txtLetra.Name = "txtLetra"
        txtLetra.PlaceholderText = "Letra"
        txtLetra.Size = New Size(451, 27)
        txtLetra.TabIndex = 3
        ' 
        ' txtArtista
        ' 
        txtArtista.Location = New Point(1211, 201)
        txtArtista.Name = "txtArtista"
        txtArtista.PlaceholderText = "Artista"
        txtArtista.Size = New Size(451, 27)
        txtArtista.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(1211, 143)
        txtNombre.Name = "txtNombre"
        txtNombre.PlaceholderText = "Nombre"
        txtNombre.Size = New Size(451, 27)
        txtNombre.TabIndex = 1
        ' 
        ' dgvCanciones
        ' 
        dgvCanciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCanciones.Location = New Point(22, 22)
        dgvCanciones.Name = "dgvCanciones"
        dgvCanciones.RowHeadersWidth = 51
        dgvCanciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCanciones.Size = New Size(1170, 832)
        dgvCanciones.TabIndex = 0
        ' 
        ' tabFavoritos
        ' 
        tabFavoritos.Controls.Add(flpFavoritos)
        tabFavoritos.Location = New Point(4, 29)
        tabFavoritos.Name = "tabFavoritos"
        tabFavoritos.Padding = New Padding(3)
        tabFavoritos.Size = New Size(1672, 868)
        tabFavoritos.TabIndex = 1
        tabFavoritos.Text = "User-Favoritos"
        tabFavoritos.UseVisualStyleBackColor = True
        ' 
        ' flpFavoritos
        ' 
        flpFavoritos.Location = New Point(17, 12)
        flpFavoritos.Name = "flpFavoritos"
        flpFavoritos.Size = New Size(1639, 845)
        flpFavoritos.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(flpCanciones)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1672, 868)
        TabPage3.TabIndex = 2
        TabPage3.Text = "User-canciones"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' flpCanciones
        ' 
        flpCanciones.Location = New Point(19, 17)
        flpCanciones.Name = "flpCanciones"
        flpCanciones.Size = New Size(1635, 840)
        flpCanciones.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1773, 1020)
        Controls.Add(TabControl1)
        Controls.Add(btnCargarUsuario)
        Controls.Add(txtPassword)
        Controls.Add(txtEmail)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "SQL Scripts"
        TabControl1.ResumeLayout(False)
        tabCanciones.ResumeLayout(False)
        tabCanciones.PerformLayout()
        CType(dgvCanciones, ComponentModel.ISupportInitialize).EndInit()
        tabFavoritos.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnCargarUsuario As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabCanciones As TabPage
    Friend WithEvents txtURL As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtLetra As TextBox
    Friend WithEvents txtArtista As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents dgvCanciones As DataGridView
    Friend WithEvents tabFavoritos As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnVer As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnCargar As Button
    Friend WithEvents flpFavoritos As FlowLayoutPanel
    Friend WithEvents flpCanciones As FlowLayoutPanel

End Class
