Public Class Vector
    ' Vector de 5 elementos
    Dim vector(4) As Integer ' Vector de 5 posiciones porque se toma en cuenta el 0
    Dim indice As Integer = 0

    Private Sub btnAgregarVector_Click(sender As Object, e As EventArgs) Handles btnAgregarVector.Click
        If indice > 4 Then
            MessageBox.Show("El vector está lleno")
            Exit Sub
        End If

        Dim valor As Integer
        If Integer.TryParse(txtVector.Text, valor) Then
            vector(indice) = valor
            indice += 1
            txtVector.Clear()
            MessageBox.Show("Valor agregado correctamente")
        Else
            MessageBox.Show("Ingrese un número válido")
        End If
    End Sub

    Private Sub btnMostrarVector_Click(sender As Object, e As EventArgs) Handles btnMostrarVector.Click
        lstVector.Items.Clear()
        For Each v As Integer In vector
            lstVector.Items.Add(v)
        Next
    End Sub

    Private Sub Vector_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class