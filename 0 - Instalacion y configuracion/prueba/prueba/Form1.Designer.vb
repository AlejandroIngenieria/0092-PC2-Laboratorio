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
        BotonRojo = New Button()
        BotonCafe = New Button()
        SuspendLayout()
        ' 
        ' BotonRojo
        ' 
        BotonRojo.BackColor = Color.Brown
        BotonRojo.Font = New Font("Segoe UI", 16F)
        BotonRojo.ForeColor = Color.White
        BotonRojo.Location = New Point(134, 547)
        BotonRojo.Name = "BotonRojo"
        BotonRojo.Size = New Size(431, 83)
        BotonRojo.TabIndex = 0
        BotonRojo.Text = "Button1"
        BotonRojo.UseVisualStyleBackColor = False
        ' 
        ' BotonCafe
        ' 
        BotonCafe.BackColor = Color.Peru
        BotonCafe.Font = New Font("Segoe UI", 16F)
        BotonCafe.ForeColor = SystemColors.ButtonHighlight
        BotonCafe.Location = New Point(134, 171)
        BotonCafe.Name = "BotonCafe"
        BotonCafe.Size = New Size(431, 160)
        BotonCafe.TabIndex = 1
        BotonCafe.Text = "Button2"
        BotonCafe.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(703, 781)
        Controls.Add(BotonCafe)
        Controls.Add(BotonRojo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BotonRojo As Button
    Friend WithEvents BotonCafe As Button

End Class
