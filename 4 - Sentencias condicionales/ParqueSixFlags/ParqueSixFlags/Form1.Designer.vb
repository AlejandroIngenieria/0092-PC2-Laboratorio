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
        btnMonRusa = New Button()
        btnCasaTerror = New Button()
        btnInfantil = New Button()
        btnVIP = New Button()
        btnEspectaculos = New Button()
        btnVR = New Button()
        btnEspecial = New Button()
        btnEntradas = New Button()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btnMonRusa
        ' 
        btnMonRusa.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMonRusa.Location = New Point(40, 233)
        btnMonRusa.Name = "btnMonRusa"
        btnMonRusa.Size = New Size(325, 147)
        btnMonRusa.TabIndex = 0
        btnMonRusa.Text = "Montaña rusa"
        btnMonRusa.UseVisualStyleBackColor = True
        ' 
        ' btnCasaTerror
        ' 
        btnCasaTerror.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCasaTerror.Location = New Point(371, 233)
        btnCasaTerror.Name = "btnCasaTerror"
        btnCasaTerror.Size = New Size(325, 147)
        btnCasaTerror.TabIndex = 1
        btnCasaTerror.Text = "Casa del terror"
        btnCasaTerror.UseVisualStyleBackColor = True
        ' 
        ' btnInfantil
        ' 
        btnInfantil.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInfantil.Location = New Point(371, 386)
        btnInfantil.Name = "btnInfantil"
        btnInfantil.Size = New Size(325, 147)
        btnInfantil.TabIndex = 2
        btnInfantil.Text = "Zona infantil"
        btnInfantil.UseVisualStyleBackColor = True
        ' 
        ' btnVIP
        ' 
        btnVIP.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVIP.Location = New Point(40, 386)
        btnVIP.Name = "btnVIP"
        btnVIP.Size = New Size(325, 147)
        btnVIP.TabIndex = 3
        btnVIP.Text = "Zona VIP"
        btnVIP.UseVisualStyleBackColor = True
        ' 
        ' btnEspectaculos
        ' 
        btnEspectaculos.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEspectaculos.Location = New Point(702, 233)
        btnEspectaculos.Name = "btnEspectaculos"
        btnEspectaculos.Size = New Size(325, 147)
        btnEspectaculos.TabIndex = 4
        btnEspectaculos.Text = "Espectáculos"
        btnEspectaculos.UseVisualStyleBackColor = True
        ' 
        ' btnVR
        ' 
        btnVR.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVR.Location = New Point(1033, 233)
        btnVR.Name = "btnVR"
        btnVR.Size = New Size(325, 147)
        btnVR.TabIndex = 5
        btnVR.Text = "Realidad virtual"
        btnVR.UseVisualStyleBackColor = True
        ' 
        ' btnEspecial
        ' 
        btnEspecial.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEspecial.Location = New Point(702, 386)
        btnEspecial.Name = "btnEspecial"
        btnEspecial.Size = New Size(325, 147)
        btnEspecial.TabIndex = 6
        btnEspecial.Text = "Descuentos"
        btnEspecial.UseVisualStyleBackColor = True
        ' 
        ' btnEntradas
        ' 
        btnEntradas.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEntradas.Location = New Point(1033, 386)
        btnEntradas.Name = "btnEntradas"
        btnEntradas.Size = New Size(325, 147)
        btnEntradas.TabIndex = 7
        btnEntradas.Text = "Entradas"
        btnEntradas.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(55, 85)
        Label1.Name = "Label1"
        Label1.Size = New Size(1286, 81)
        Label1.TabIndex = 8
        Label1.Text = "Sistema de restricciones del parque Six Flags"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(40, 539)
        Button1.Name = "Button1"
        Button1.Size = New Size(325, 147)
        Button1.TabIndex = 9
        Button1.Text = "Prueba"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1386, 738)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Controls.Add(btnEntradas)
        Controls.Add(btnEspecial)
        Controls.Add(btnVR)
        Controls.Add(btnEspectaculos)
        Controls.Add(btnVIP)
        Controls.Add(btnInfantil)
        Controls.Add(btnCasaTerror)
        Controls.Add(btnMonRusa)
        Name = "Form1"
        Text = "Parque Six Flags"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnMonRusa As Button
    Friend WithEvents btnCasaTerror As Button
    Friend WithEvents btnInfantil As Button
    Friend WithEvents btnVIP As Button
    Friend WithEvents btnEspectaculos As Button
    Friend WithEvents btnVR As Button
    Friend WithEvents btnEspecial As Button
    Friend WithEvents btnEntradas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button

End Class
