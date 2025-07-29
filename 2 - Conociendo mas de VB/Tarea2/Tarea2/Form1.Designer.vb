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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtArroz = New TextBox()
        txtFrijol = New TextBox()
        txtAzucar = New TextBox()
        txtCafe = New TextBox()
        btnCalcular = New Button()
        btnLimpiar = New Button()
        btnSalir = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 133)
        Label1.Name = "Label1"
        Label1.Size = New Size(308, 46)
        Label1.TabIndex = 0
        Label1.Text = "Cantidad en libras"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F)
        Label2.Location = New Point(12, 199)
        Label2.Name = "Label2"
        Label2.Size = New Size(315, 37)
        Label2.TabIndex = 1
        Label2.Text = "Arroz (precio libra Q2.00)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F)
        Label3.Location = New Point(12, 292)
        Label3.Name = "Label3"
        Label3.Size = New Size(311, 37)
        Label3.TabIndex = 2
        Label3.Text = "Frijol (precio libra Q1.75)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F)
        Label4.Location = New Point(12, 387)
        Label4.Name = "Label4"
        Label4.Size = New Size(331, 37)
        Label4.TabIndex = 3
        Label4.Text = "Azúcar (precio libra Q2.50)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 16F)
        Label5.Location = New Point(12, 481)
        Label5.Name = "Label5"
        Label5.Size = New Size(305, 37)
        Label5.TabIndex = 4
        Label5.Text = "Café (precio libra Q1.25)"
        ' 
        ' txtArroz
        ' 
        txtArroz.Location = New Point(393, 209)
        txtArroz.Name = "txtArroz"
        txtArroz.Size = New Size(383, 27)
        txtArroz.TabIndex = 5
        ' 
        ' txtFrijol
        ' 
        txtFrijol.Location = New Point(393, 302)
        txtFrijol.Name = "txtFrijol"
        txtFrijol.Size = New Size(383, 27)
        txtFrijol.TabIndex = 6
        ' 
        ' txtAzucar
        ' 
        txtAzucar.Location = New Point(393, 398)
        txtAzucar.Name = "txtAzucar"
        txtAzucar.Size = New Size(383, 27)
        txtAzucar.TabIndex = 7
        ' 
        ' txtCafe
        ' 
        txtCafe.Location = New Point(393, 491)
        txtCafe.Name = "txtCafe"
        txtCafe.Size = New Size(383, 27)
        txtCafe.TabIndex = 8
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Font = New Font("Segoe UI", 16F)
        btnCalcular.Location = New Point(12, 585)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(239, 70)
        btnCalcular.TabIndex = 9
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Font = New Font("Segoe UI", 16F)
        btnLimpiar.Location = New Point(270, 585)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(239, 70)
        btnLimpiar.TabIndex = 10
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Font = New Font("Segoe UI", 16F)
        btnSalir.Location = New Point(537, 585)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(239, 70)
        btnSalir.TabIndex = 11
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Showcard Gothic", 45F, FontStyle.Bold)
        Label6.Location = New Point(237, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(329, 93)
        Label6.TabIndex = 12
        Label6.Text = "Tarea 2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 676)
        Controls.Add(Label6)
        Controls.Add(btnSalir)
        Controls.Add(btnLimpiar)
        Controls.Add(btnCalcular)
        Controls.Add(txtCafe)
        Controls.Add(txtAzucar)
        Controls.Add(txtFrijol)
        Controls.Add(txtArroz)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Tienda de abarrotes"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtArroz As TextBox
    Friend WithEvents txtFrijol As TextBox
    Friend WithEvents txtAzucar As TextBox
    Friend WithEvents txtCafe As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Label6 As Label

End Class
