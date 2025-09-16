<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriz
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
        txtFila = New TextBox()
        txtCol = New TextBox()
        txtValor = New TextBox()
        btnAgregarMatriz = New Button()
        btnMostrarMatriz = New Button()
        dgvMatriz = New DataGridView()
        CType(dgvMatriz, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtFila
        ' 
        txtFila.Location = New Point(69, 21)
        txtFila.Name = "txtFila"
        txtFila.PlaceholderText = "Posición de la fila"
        txtFila.Size = New Size(315, 27)
        txtFila.TabIndex = 0
        ' 
        ' txtCol
        ' 
        txtCol.Location = New Point(414, 21)
        txtCol.Name = "txtCol"
        txtCol.PlaceholderText = "Posición de la columna"
        txtCol.Size = New Size(315, 27)
        txtCol.TabIndex = 1
        ' 
        ' txtValor
        ' 
        txtValor.Location = New Point(69, 83)
        txtValor.Name = "txtValor"
        txtValor.PlaceholderText = "Valor a insertar"
        txtValor.Size = New Size(315, 27)
        txtValor.TabIndex = 2
        ' 
        ' btnAgregarMatriz
        ' 
        btnAgregarMatriz.Location = New Point(407, 83)
        btnAgregarMatriz.Name = "btnAgregarMatriz"
        btnAgregarMatriz.Size = New Size(322, 52)
        btnAgregarMatriz.TabIndex = 3
        btnAgregarMatriz.Text = "Agregar a matriz"
        btnAgregarMatriz.UseVisualStyleBackColor = True
        ' 
        ' btnMostrarMatriz
        ' 
        btnMostrarMatriz.Location = New Point(236, 674)
        btnMostrarMatriz.Name = "btnMostrarMatriz"
        btnMostrarMatriz.Size = New Size(322, 52)
        btnMostrarMatriz.TabIndex = 4
        btnMostrarMatriz.Text = "Mostrar matriz"
        btnMostrarMatriz.UseVisualStyleBackColor = True
        ' 
        ' dgvMatriz
        ' 
        dgvMatriz.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMatriz.Location = New Point(23, 159)
        dgvMatriz.Name = "dgvMatriz"
        dgvMatriz.RowHeadersWidth = 51
        dgvMatriz.Size = New Size(748, 497)
        dgvMatriz.TabIndex = 5
        ' 
        ' Matriz
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 738)
        Controls.Add(dgvMatriz)
        Controls.Add(btnMostrarMatriz)
        Controls.Add(btnAgregarMatriz)
        Controls.Add(txtValor)
        Controls.Add(txtCol)
        Controls.Add(txtFila)
        Name = "Matriz"
        Text = "Matriz"
        CType(dgvMatriz, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFila As TextBox
    Friend WithEvents txtCol As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents btnAgregarMatriz As Button
    Friend WithEvents btnMostrarMatriz As Button
    Friend WithEvents dgvMatriz As DataGridView
End Class
