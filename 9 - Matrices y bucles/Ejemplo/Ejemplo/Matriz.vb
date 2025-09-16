Public Class Matriz
    ' Matriz de 3x3
    Dim matriz(2, 2) As Integer 'Es una matriz de 3x3 porque se toma en cuenta el 0

    Private Sub btnAgregarMatriz_Click(sender As Object, e As EventArgs) Handles btnAgregarMatriz.Click
        Dim fila, col, valor As Integer

        If Not Integer.TryParse(txtFila.Text, fila) OrElse
           Not Integer.TryParse(txtCol.Text, col) OrElse
           Not Integer.TryParse(txtValor.Text, valor) Then
            MessageBox.Show("Ingrese valores numéricos válidos")
            Exit Sub
        End If

        If fila < 0 Or fila > 2 Or col < 0 Or col > 2 Then
            MessageBox.Show("Posición fuera de rango (0 a 2)")
            Exit Sub
        End If

        matriz(fila, col) = valor
        MessageBox.Show($"Valor {valor} agregado en posición ({fila},{col})")

        txtFila.Clear()
        txtCol.Clear()
        txtValor.Clear()
    End Sub

    Private Sub btnMostrarMatriz_Click(sender As Object, e As EventArgs) Handles btnMostrarMatriz.Click
        dgvMatriz.Rows.Clear()
        dgvMatriz.Columns.Clear()

        ' Configurar columnas
        For j As Integer = 0 To matriz.GetLength(1) - 1
            dgvMatriz.Columns.Add("Col" & j, "Col " & j)
        Next

        ' Llenar con los valores de la matriz
        For i As Integer = 0 To matriz.GetLength(0) - 1
            Dim fila As New List(Of String)
            For j As Integer = 0 To matriz.GetLength(1) - 1
                fila.Add(matriz(i, j).ToString())
            Next
            dgvMatriz.Rows.Add(fila.ToArray())
        Next
    End Sub

    Private Sub Matriz_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class