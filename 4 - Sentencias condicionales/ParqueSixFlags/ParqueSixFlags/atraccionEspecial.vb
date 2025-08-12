Public Class atraccionEspecial
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        Dim mensaje As String
        mensaje = If(txtEdad.Text < 12, "Recibe descuento", "No recibe el descuento")
        MsgBox(mensaje)
    End Sub
End Class