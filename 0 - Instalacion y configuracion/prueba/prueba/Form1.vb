Public Class Form1
    Private Sub btnE1_Click(sender As Object, e As EventArgs) Handles btnE1.Click
        Dim edad As Integer
        edad = CInt(txtE1.Text)

        If edad >= 18 Then
            labelE1.Text = "Puedes votar"
        End If

        If edad < 18 Then
            labelE1.Text = "No puedes votar"
        End If

    End Sub

    Private Sub btnE2_Click(sender As Object, e As EventArgs) Handles btnE2.Click
        Dim numero As Integer
        numero = CInt(txtE2.Text)

        If numero > 0 Then
            labelE2.Text = "Positivo"
        End If

        If numero < 0 Then
            labelE2.Text = "Negativo"
        End If
    End Sub

    Private Sub btnE3_Click(sender As Object, e As EventArgs) Handles btnE3.Click
        Dim password As String
        password = txtE3.Text

        If password = "1234" Then
            labelE3.Text = "Contraseña correcta"
        Else
            labelE3.Text = "Contraseña incorrecta"
        End If

    End Sub

    Private Sub btnE4_Click(sender As Object, e As EventArgs) Handles btnE4.Click
        Dim numero As Integer
        numero = CInt(txtE4.Text)

        If numero Mod 2 = 0 Then
            labelE4.Text = "Par"
        Else
            labelE4.Text = "Impar"
        End If
    End Sub

    Private Sub btnE5_Click(sender As Object, e As EventArgs) Handles btnE5.Click
        Dim nota As Integer
        nota = CInt(txtE5.Text)

        If nota > 60 Then
            labelE5.Text = "Aprobado"
        Else
            labelE5.Text = "Reprobado"
        End If
    End Sub
End Class
