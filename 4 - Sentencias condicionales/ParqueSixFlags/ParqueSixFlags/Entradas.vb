Public Class Entradas
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim itemSeleccionado As String
        'Operador ternadio
        If radioTipo1.Checked Then
            itemSeleccionado = 1
        ElseIf radioTipo2.Checked Then
            itemSeleccionado = 2
        ElseIf radioTipo3.Checked Then
            itemSeleccionado = 3
        ElseIf radioTipo4.Checked Then
            itemSeleccionado = 4
        Else
            itemSeleccionado = 0
        End If

        Select Case itemSeleccionado
            Case 1
                MsgBox("Montaña rusa")
            Case 2
                MsgBox("Casa del terror")
            Case 3
                MsgBox("Realidad virtual")
            Case 4
                MsgBox("Zona VIP")
            Case Else
                MsgBox("Por favor compre una entrada")
        End Select
    End Sub
End Class