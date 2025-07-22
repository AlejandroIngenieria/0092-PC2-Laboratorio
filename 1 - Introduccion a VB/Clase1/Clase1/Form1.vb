Public Class Form1
    Private Sub btnE1_Click(sender As Object, e As EventArgs) Handles btnE1.Click
        'Es un comentario de una sola línea
        'Declaración de variables
        Dim edad As Integer
        'Declaración de variables de tipo String
        edad = txtE1.Text
        'Uso de condicionales
        If edad >= 18 Then
            labelE1.Text = "Eres mayor de edad"
        Else
            labelE1.Text = "Eres menor de edad"
        End If
    End Sub

    Private Sub btnE2_Click(sender As Object, e As EventArgs) Handles btnE2.Click
        'Declaración de variables
        Dim numero As Integer
        'Almacenar el contenido del TextBox en la variable
        numero = txtE2.Text
        'Condicion para saber si es posivito o negativo
        If numero >= 0 Then
            labelE2.Text = "El numero es positivo"
        Else
            labelE2.Text = "El numero es negativo"
        End If
    End Sub

    Private Sub btnE3_Click(sender As Object, e As EventArgs) Handles btnE3.Click
        'Declarar una variable para guardar la contraseña
        Dim password As String

        'Almacenar el contenido del TextBox en la variable
        password = txtE3.Text
        'Condición para verificar la contraseña
        'Sintaxis de If
        'If condición Then <- obligatorio
        'Codigo que quieres que se ejecute si la condición es verdadera <- obligatorio
        'Else <- opcional
        'Codigo que quieres que se ejecute si la condición es falsa <- opcional
        'End If <- obligatorio
        If password = "1234" Then
            labelE3.Text = "Acceso condedido"
        Else
            labelE3.Text = "Acceso no concedido"
        End If
    End Sub

    Private Sub btnE4_Click(sender As Object, e As EventArgs) Handles btnE4.Click
        Dim numero As Double
        numero = txtE4.Text
        'Mod lo que nos devuelve es el residuo de la división
        If numero Mod 2 = 0 Then
            labelE4.Text = "Es par"
            MsgBox(numero Mod 2)
        Else
            labelE4.Text = "Es impar"
            MsgBox(numero Mod 2)
        End If
    End Sub

    Private Sub btnE5_Click(sender As Object, e As EventArgs) Handles btnE5.Click
        Dim calificacion As Integer
        calificacion = txtE5.Text
        If calificacion >= 61 And calificacion < 100 Then
            MsgBox("Aprobado")
        ElseIf calificacion > 100 Then
            MsgBox("Calificación no válida")
        Else
            MsgBox("Reprobado")
        End If
    End Sub
End Class
