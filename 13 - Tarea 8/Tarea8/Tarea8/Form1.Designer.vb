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
        txtPlaca = New TextBox()
        cboTipo = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtInicial = New TextBox()
        txtFinal = New TextBox()
        MenuStrip1 = New MenuStrip()
        btnCalcular = New ToolStripMenuItem()
        btnMostrar = New ToolStripMenuItem()
        btnConsultar = New ToolStripMenuItem()
        btnActualizar = New ToolStripMenuItem()
        btnEstadisticas = New ToolStripMenuItem()
        btnEliminar = New ToolStripMenuItem()
        btnLimpiar = New ToolStripMenuItem()
        btnLimpiarVectores = New ToolStripMenuItem()
        btnSalir = New ToolStripMenuItem()
        dgvDatos = New DataGridView()
        MenuStrip1.SuspendLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 105)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 20)
        Label1.TabIndex = 0
        Label1.Text = "Ingresar número de placa"
        ' 
        ' txtPlaca
        ' 
        txtPlaca.Location = New Point(243, 102)
        txtPlaca.Name = "txtPlaca"
        txtPlaca.PlaceholderText = "Número de placa"
        txtPlaca.Size = New Size(232, 27)
        txtPlaca.TabIndex = 1
        ' 
        ' cboTipo
        ' 
        cboTipo.FormattingEnabled = True
        cboTipo.Items.AddRange(New Object() {"Tipo 1", "Tipo 2", "Tipo 3", "Tipo 4"})
        cboTipo.Location = New Point(243, 160)
        cboTipo.Name = "cboTipo"
        cboTipo.Size = New Size(232, 28)
        cboTipo.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(207, 20)
        Label2.TabIndex = 3
        Label2.Text = "Seleccionar tipo de auto (1-4)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(156, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(167, 41)
        Label3.TabIndex = 4
        Label3.Text = "Kilometraje"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(105, 42)
        Label4.Name = "Label4"
        Label4.Size = New Size(259, 41)
        Label4.TabIndex = 5
        Label4.Text = "Información inicial"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(94, 319)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 20)
        Label5.TabIndex = 6
        Label5.Text = "Inicial"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(94, 374)
        Label6.Name = "Label6"
        Label6.Size = New Size(40, 20)
        Label6.TabIndex = 7
        Label6.Text = "Final"
        ' 
        ' txtInicial
        ' 
        txtInicial.Location = New Point(165, 316)
        txtInicial.Name = "txtInicial"
        txtInicial.PlaceholderText = "Kilometraje inicial"
        txtInicial.Size = New Size(232, 27)
        txtInicial.TabIndex = 8
        ' 
        ' txtFinal
        ' 
        txtFinal.Location = New Point(165, 371)
        txtFinal.Name = "txtFinal"
        txtFinal.PlaceholderText = "Kilometraje final"
        txtFinal.Size = New Size(232, 27)
        txtFinal.TabIndex = 9
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {btnCalcular, btnMostrar, btnConsultar, btnActualizar, btnEstadisticas, btnEliminar, btnLimpiar, btnLimpiarVectores, btnSalir})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1375, 28)
        MenuStrip1.TabIndex = 10
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(76, 24)
        btnCalcular.Text = "Calcular"
        ' 
        ' btnMostrar
        ' 
        btnMostrar.Name = "btnMostrar"
        btnMostrar.Size = New Size(74, 24)
        btnMostrar.Text = "Mostrar"
        ' 
        ' btnConsultar
        ' 
        btnConsultar.Name = "btnConsultar"
        btnConsultar.Size = New Size(85, 24)
        btnConsultar.Text = "Consultar"
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(89, 24)
        btnActualizar.Text = "Actualizar"
        ' 
        ' btnEstadisticas
        ' 
        btnEstadisticas.Name = "btnEstadisticas"
        btnEstadisticas.Size = New Size(99, 24)
        btnEstadisticas.Text = "Estadísticas"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(77, 24)
        btnEliminar.Text = "Eliminar"
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(73, 24)
        btnLimpiar.Text = "Limpiar"
        ' 
        ' btnLimpiarVectores
        ' 
        btnLimpiarVectores.Name = "btnLimpiarVectores"
        btnLimpiarVectores.Size = New Size(132, 24)
        btnLimpiarVectores.Text = "Limpiar vectores"
        ' 
        ' btnSalir
        ' 
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(52, 24)
        btnSalir.Text = "Salir"
        ' 
        ' dgvDatos
        ' 
        dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDatos.Location = New Point(503, 42)
        dgvDatos.Name = "dgvDatos"
        dgvDatos.RowHeadersWidth = 51
        dgvDatos.Size = New Size(846, 457)
        dgvDatos.TabIndex = 11
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1375, 513)
        Controls.Add(dgvDatos)
        Controls.Add(txtFinal)
        Controls.Add(txtInicial)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cboTipo)
        Controls.Add(txtPlaca)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Sistema de renta de autos"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(dgvDatos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPlaca As TextBox
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtInicial As TextBox
    Friend WithEvents txtFinal As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnCalcular As ToolStripMenuItem
    Friend WithEvents btnMostrar As ToolStripMenuItem
    Friend WithEvents btnConsultar As ToolStripMenuItem
    Friend WithEvents btnActualizar As ToolStripMenuItem
    Friend WithEvents btnEliminar As ToolStripMenuItem
    Friend WithEvents btnLimpiar As ToolStripMenuItem
    Friend WithEvents btnSalir As ToolStripMenuItem
    Friend WithEvents btnEstadisticas As ToolStripMenuItem
    Friend WithEvents dgvDatos As DataGridView
    Friend WithEvents btnLimpiarVectores As ToolStripMenuItem

End Class
