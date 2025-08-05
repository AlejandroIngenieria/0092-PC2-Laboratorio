Public Class Form1
    Private Sub btnForm_Click(sender As Object, e As EventArgs) Handles btnForm.Click
        Formulario_normal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Formulario_normal.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Formulario_normal.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer = 10
    End Sub
End Class
