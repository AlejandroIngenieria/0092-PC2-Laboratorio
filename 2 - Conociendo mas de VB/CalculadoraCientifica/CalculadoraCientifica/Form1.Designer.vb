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
        txtN = New TextBox()
        txtM = New TextBox()
        sumar = New RadioButton()
        restar = New RadioButton()
        multiplicar = New RadioButton()
        dividir = New RadioButton()
        potencia = New RadioButton()
        raiz = New RadioButton()
        check1 = New CheckBox()
        check2 = New CheckBox()
        btnCalcular = New Button()
        btnLimpiar = New Button()
        btnSalir = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 20)
        Label1.TabIndex = 0
        Label1.Text = "Ingrese el primer numero (n)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(216, 20)
        Label2.TabIndex = 1
        Label2.Text = "Ingrese el segundo numero (m)"
        ' 
        ' txtN
        ' 
        txtN.Location = New Point(269, 37)
        txtN.Name = "txtN"
        txtN.Size = New Size(291, 27)
        txtN.TabIndex = 2
        ' 
        ' txtM
        ' 
        txtM.Location = New Point(269, 95)
        txtM.Name = "txtM"
        txtM.Size = New Size(291, 27)
        txtM.TabIndex = 3
        ' 
        ' sumar
        ' 
        sumar.AutoSize = True
        sumar.Location = New Point(27, 184)
        sumar.Name = "sumar"
        sumar.Size = New Size(115, 24)
        sumar.TabIndex = 4
        sumar.TabStop = True
        sumar.Text = "sumar (n+m)"
        sumar.UseVisualStyleBackColor = True
        ' 
        ' restar
        ' 
        restar.AutoSize = True
        restar.Location = New Point(27, 259)
        restar.Name = "restar"
        restar.Size = New Size(108, 24)
        restar.TabIndex = 5
        restar.TabStop = True
        restar.Text = "restar (n-m)"
        restar.UseVisualStyleBackColor = True
        ' 
        ' multiplicar
        ' 
        multiplicar.AutoSize = True
        multiplicar.Location = New Point(27, 337)
        multiplicar.Name = "multiplicar"
        multiplicar.Size = New Size(142, 24)
        multiplicar.TabIndex = 6
        multiplicar.TabStop = True
        multiplicar.Text = "multiplicar (n*m)"
        multiplicar.UseVisualStyleBackColor = True
        ' 
        ' dividir
        ' 
        dividir.AutoSize = True
        dividir.Location = New Point(337, 184)
        dividir.Name = "dividir"
        dividir.Size = New Size(113, 24)
        dividir.TabIndex = 7
        dividir.TabStop = True
        dividir.Text = "dividir (n/m)"
        dividir.UseVisualStyleBackColor = True
        ' 
        ' potencia
        ' 
        potencia.AutoSize = True
        potencia.Location = New Point(337, 259)
        potencia.Name = "potencia"
        potencia.Size = New Size(133, 24)
        potencia.TabIndex = 8
        potencia.TabStop = True
        potencia.Text = "potencia (n^m)"
        potencia.UseVisualStyleBackColor = True
        ' 
        ' raiz
        ' 
        raiz.AutoSize = True
        raiz.Location = New Point(337, 337)
        raiz.Name = "raiz"
        raiz.Size = New Size(146, 24)
        raiz.TabIndex = 9
        raiz.TabStop = True
        raiz.Text = "Raiz cuadrada (n)"
        raiz.UseVisualStyleBackColor = True
        ' 
        ' check1
        ' 
        check1.AutoSize = True
        check1.Location = New Point(598, 40)
        check1.Name = "check1"
        check1.Size = New Size(208, 24)
        check1.TabIndex = 10
        check1.Text = "Resultado con 2 decimales"
        check1.UseVisualStyleBackColor = True
        ' 
        ' check2
        ' 
        check2.AutoSize = True
        check2.Location = New Point(598, 98)
        check2.Name = "check2"
        check2.Size = New Size(217, 24)
        check2.TabIndex = 11
        check2.Text = "Descripcion de la operacion"
        check2.UseVisualStyleBackColor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(12, 444)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(258, 68)
        btnCalcular.TabIndex = 12
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(276, 444)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(258, 68)
        btnLimpiar.TabIndex = 13
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnSalir
        ' 
        btnSalir.Location = New Point(540, 444)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(239, 68)
        btnSalir.TabIndex = 14
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(898, 723)
        Controls.Add(btnSalir)
        Controls.Add(btnLimpiar)
        Controls.Add(btnCalcular)
        Controls.Add(check2)
        Controls.Add(check1)
        Controls.Add(raiz)
        Controls.Add(potencia)
        Controls.Add(dividir)
        Controls.Add(multiplicar)
        Controls.Add(restar)
        Controls.Add(sumar)
        Controls.Add(txtM)
        Controls.Add(txtN)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtN As TextBox
    Friend WithEvents txtM As TextBox
    Friend WithEvents sumar As RadioButton
    Friend WithEvents restar As RadioButton
    Friend WithEvents multiplicar As RadioButton
    Friend WithEvents dividir As RadioButton
    Friend WithEvents potencia As RadioButton
    Friend WithEvents raiz As RadioButton
    Friend WithEvents check1 As CheckBox
    Friend WithEvents check2 As CheckBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button

End Class
