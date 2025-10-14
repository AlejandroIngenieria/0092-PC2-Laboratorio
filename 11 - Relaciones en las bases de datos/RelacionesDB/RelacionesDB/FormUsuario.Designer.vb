<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuario
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        btnFavorito = New Button()
        pbAnimal = New PictureBox()
        dgvAnimales = New DataGridView()
        TabPage2 = New TabPage()
        flpFavoritos = New FlowLayoutPanel()
        TabPage3 = New TabPage()
        lblUsername = New Label()
        lblEmail = New Label()
        lblNombre = New Label()
        TabPage4 = New TabPage()
        flpTodosAnimales = New FlowLayoutPanel()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(pbAnimal, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvAnimales, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Location = New Point(28, 28)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1595, 843)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(btnFavorito)
        TabPage1.Controls.Add(pbAnimal)
        TabPage1.Controls.Add(dgvAnimales)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1587, 810)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Animales Tabla"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' btnFavorito
        ' 
        btnFavorito.Location = New Point(770, 742)
        btnFavorito.Name = "btnFavorito"
        btnFavorito.Size = New Size(773, 54)
        btnFavorito.TabIndex = 2
        btnFavorito.Text = "Agregar a favoritos"
        btnFavorito.UseVisualStyleBackColor = True
        ' 
        ' pbAnimal
        ' 
        pbAnimal.Location = New Point(769, 25)
        pbAnimal.Name = "pbAnimal"
        pbAnimal.Size = New Size(774, 696)
        pbAnimal.TabIndex = 1
        pbAnimal.TabStop = False
        ' 
        ' dgvAnimales
        ' 
        dgvAnimales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAnimales.Location = New Point(19, 25)
        dgvAnimales.Name = "dgvAnimales"
        dgvAnimales.RowHeadersWidth = 51
        dgvAnimales.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAnimales.Size = New Size(718, 771)
        dgvAnimales.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(flpFavoritos)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1587, 810)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Favoritos"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' flpFavoritos
        ' 
        flpFavoritos.Location = New Point(26, 21)
        flpFavoritos.Name = "flpFavoritos"
        flpFavoritos.Size = New Size(1539, 758)
        flpFavoritos.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(lblUsername)
        TabPage3.Controls.Add(lblEmail)
        TabPage3.Controls.Add(lblNombre)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1587, 810)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Perfil"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Location = New Point(52, 197)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(92, 20)
        lblUsername.TabIndex = 2
        lblUsername.Text = "lblUsername"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(52, 115)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(63, 20)
        lblEmail.TabIndex = 1
        lblEmail.Text = "lblEmail"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(52, 35)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(81, 20)
        lblNombre.TabIndex = 0
        lblNombre.Text = "lblNombre"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(flpTodosAnimales)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(1587, 810)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Animales imagen"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' flpTodosAnimales
        ' 
        flpTodosAnimales.Location = New Point(22, 16)
        flpTodosAnimales.Name = "flpTodosAnimales"
        flpTodosAnimales.Size = New Size(1550, 775)
        flpTodosAnimales.TabIndex = 0
        ' 
        ' FormUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1658, 895)
        Controls.Add(TabControl1)
        Name = "FormUsuario"
        Text = "FormUsuario"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(pbAnimal, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvAnimales, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnFavorito As Button
    Friend WithEvents pbAnimal As PictureBox
    Friend WithEvents dgvAnimales As DataGridView
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents flpFavoritos As FlowLayoutPanel
    Friend WithEvents lblUsername As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents flpTodosAnimales As FlowLayoutPanel
End Class
