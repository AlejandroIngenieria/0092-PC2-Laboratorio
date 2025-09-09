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
        btnForNext = New Button()
        btnForStepNegativo = New Button()
        btnForEach = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnDoWhilePost = New Button()
        btnDoWhilePre = New Button()
        btnWhile = New Button()
        btnDoUntilPost = New Button()
        btnDoUntilPre = New Button()
        Label3 = New Label()
        btnExitBucle = New Button()
        btnExitWhile = New Button()
        btnEjemplo2 = New Button()
        SuspendLayout()
        ' 
        ' btnForNext
        ' 
        btnForNext.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForNext.Location = New Point(35, 88)
        btnForNext.Name = "btnForNext"
        btnForNext.Size = New Size(485, 152)
        btnForNext.TabIndex = 0
        btnForNext.Text = "For (Next)"
        btnForNext.UseVisualStyleBackColor = True
        ' 
        ' btnForStepNegativo
        ' 
        btnForStepNegativo.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForStepNegativo.Location = New Point(526, 88)
        btnForStepNegativo.Name = "btnForStepNegativo"
        btnForStepNegativo.Size = New Size(485, 152)
        btnForStepNegativo.TabIndex = 1
        btnForStepNegativo.Text = "For con Step negativo"
        btnForStepNegativo.UseVisualStyleBackColor = True
        ' 
        ' btnForEach
        ' 
        btnForEach.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnForEach.Location = New Point(1017, 88)
        btnForEach.Name = "btnForEach"
        btnForEach.Size = New Size(485, 152)
        btnForEach.TabIndex = 2
        btnForEach.Text = "For Each"
        btnForEach.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(625, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(326, 74)
        Label1.TabIndex = 3
        Label1.Text = "Ciclo For"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(589, 254)
        Label2.Name = "Label2"
        Label2.Size = New Size(407, 74)
        Label2.TabIndex = 7
        Label2.Text = "Ciclo While"
        ' 
        ' btnDoWhilePost
        ' 
        btnDoWhilePost.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDoWhilePost.Location = New Point(1040, 337)
        btnDoWhilePost.Name = "btnDoWhilePost"
        btnDoWhilePost.Size = New Size(485, 152)
        btnDoWhilePost.TabIndex = 6
        btnDoWhilePost.Text = "Do While (post-test)"
        btnDoWhilePost.UseVisualStyleBackColor = True
        ' 
        ' btnDoWhilePre
        ' 
        btnDoWhilePre.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDoWhilePre.Location = New Point(549, 337)
        btnDoWhilePre.Name = "btnDoWhilePre"
        btnDoWhilePre.Size = New Size(485, 152)
        btnDoWhilePre.TabIndex = 5
        btnDoWhilePre.Text = "Do While (pre-test)"
        btnDoWhilePre.UseVisualStyleBackColor = True
        ' 
        ' btnWhile
        ' 
        btnWhile.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnWhile.Location = New Point(58, 337)
        btnWhile.Name = "btnWhile"
        btnWhile.Size = New Size(485, 152)
        btnWhile.TabIndex = 4
        btnWhile.Text = "While...End While"
        btnWhile.UseVisualStyleBackColor = True
        ' 
        ' btnDoUntilPost
        ' 
        btnDoUntilPost.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDoUntilPost.Location = New Point(802, 495)
        btnDoUntilPost.Name = "btnDoUntilPost"
        btnDoUntilPost.Size = New Size(485, 152)
        btnDoUntilPost.TabIndex = 9
        btnDoUntilPost.Text = "Do Until (post-test)"
        btnDoUntilPost.UseVisualStyleBackColor = True
        ' 
        ' btnDoUntilPre
        ' 
        btnDoUntilPre.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDoUntilPre.Location = New Point(311, 495)
        btnDoUntilPre.Name = "btnDoUntilPre"
        btnDoUntilPre.Size = New Size(485, 152)
        btnDoUntilPre.TabIndex = 8
        btnDoUntilPre.Text = "Do Until (pre-test)"
        btnDoUntilPre.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Showcard Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(77, 650)
        Label3.Name = "Label3"
        Label3.Size = New Size(992, 148)
        Label3.TabIndex = 10
        Label3.Text = "Exit For / Exit While / " & vbLf & "Continue For / Continue While"
        ' 
        ' btnExitBucle
        ' 
        btnExitBucle.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExitBucle.Location = New Point(86, 801)
        btnExitBucle.Name = "btnExitBucle"
        btnExitBucle.Size = New Size(485, 152)
        btnExitBucle.TabIndex = 11
        btnExitBucle.Text = "EXIT For"
        btnExitBucle.UseVisualStyleBackColor = True
        ' 
        ' btnExitWhile
        ' 
        btnExitWhile.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExitWhile.Location = New Point(577, 801)
        btnExitWhile.Name = "btnExitWhile"
        btnExitWhile.Size = New Size(485, 152)
        btnExitWhile.TabIndex = 12
        btnExitWhile.Text = "EXIT While"
        btnExitWhile.UseVisualStyleBackColor = True
        ' 
        ' btnEjemplo2
        ' 
        btnEjemplo2.BackColor = SystemColors.ActiveCaption
        btnEjemplo2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEjemplo2.Location = New Point(1084, 804)
        btnEjemplo2.Name = "btnEjemplo2"
        btnEjemplo2.Size = New Size(485, 152)
        btnEjemplo2.TabIndex = 13
        btnEjemplo2.Text = "Ir a ejemplo 2"
        btnEjemplo2.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1581, 968)
        Controls.Add(btnEjemplo2)
        Controls.Add(btnExitWhile)
        Controls.Add(btnExitBucle)
        Controls.Add(Label3)
        Controls.Add(btnDoUntilPost)
        Controls.Add(btnDoUntilPre)
        Controls.Add(Label2)
        Controls.Add(btnDoWhilePost)
        Controls.Add(btnDoWhilePre)
        Controls.Add(btnWhile)
        Controls.Add(Label1)
        Controls.Add(btnForEach)
        Controls.Add(btnForStepNegativo)
        Controls.Add(btnForNext)
        Name = "Form1"
        Text = "Ejemplos básicos"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnForNext As Button
    Friend WithEvents btnForStepNegativo As Button
    Friend WithEvents btnForEach As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDoWhilePost As Button
    Friend WithEvents btnDoWhilePre As Button
    Friend WithEvents btnWhile As Button
    Friend WithEvents btnDoUntilPost As Button
    Friend WithEvents btnDoUntilPre As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExitBucle As Button
    Friend WithEvents btnExitWhile As Button
    Friend WithEvents btnEjemplo2 As Button

End Class
