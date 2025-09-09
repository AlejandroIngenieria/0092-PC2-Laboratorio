Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        Dim suma = 0
        For i = 1 To 5
            MessageBox.Show("Número: " & i)
            MessageBox.Show("Suma: " & suma)
            suma += i
        Next
        MessageBox.Show("La suma es: " & suma)
    End Sub

    Private Sub btnForStepNegativo_Click(sender As Object, e As EventArgs) Handles btnForStepNegativo.Click
        For i = 10 To 1 Step -1
            MessageBox.Show("Número: " & i)
        Next
    End Sub

    Private Sub btnForEach_Click(sender As Object, e As EventArgs) Handles btnForEach.Click
        Dim nombres() = {"Ana", "Luis", "Marta"}
        For Each n In nombres
            MessageBox.Show("Nombre: " & n)
        Next
    End Sub

    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        Dim i As Integer = 5
        While i > 0
            MessageBox.Show("Número: " & i)
            i -= 1
        End While
    End Sub

    Private Sub btnDoWhilePre_Click(sender As Object, e As EventArgs) Handles btnDoWhilePre.Click
        Dim i = 1
        Do While i <= 5
            MessageBox.Show("Número: " & i)
            i += 1
        Loop
    End Sub

    Private Sub btnDoWhilePost_Click(sender As Object, e As EventArgs) Handles btnDoWhilePost.Click
        Dim j = 6
        Do
            MessageBox.Show("Número: " & j)
            j += 1
        Loop While j <= 5
    End Sub

    Private Sub btnDoUntilPre_Click(sender As Object, e As EventArgs) Handles btnDoUntilPre.Click
        Dim k As Integer = 1
        Do Until k > 5
            MessageBox.Show("Número: " & k)
            k += 1
        Loop
    End Sub

    Private Sub btnDoUntilPost_Click(sender As Object, e As EventArgs) Handles btnDoUntilPost.Click
        Dim m As Integer = 10
        Do
            MessageBox.Show("Valor de m: " & m)
            m += 1
        Loop Until m > 10
    End Sub

    Private Sub btnExitBucle_Click(sender As Object, e As EventArgs) Handles btnExitBucle.Click
        For i As Integer = 1 To 10
            If i = 3 Then Continue For
            If i = 8 Then Exit For
            MessageBox.Show("Número: " & i)
        Next
    End Sub

    Private Sub btnExitWhile_Click(sender As Object, e As EventArgs) Handles btnExitWhile.Click
        Dim i As Integer = 1
        While i <= 10
            If i = 3 Then
                i += 1
                Continue While
            End If
            If i = 8 Then Exit While
            MessageBox.Show("Número: " & i)
            i += 1
        End While
    End Sub

    Private Sub btnEjemplo2_Click(sender As Object, e As EventArgs) Handles btnEjemplo2.Click
        GrupoEstudiantes.Show()
    End Sub
End Class
