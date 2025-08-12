Public Class realidadVirtual
    Private Sub btnVerficar_Click(sender As Object, e As EventArgs) Handles btnVerficar.Click
        If checkPropias.Checked Xor checkAlquiladas.Checked Then
            MsgBox("Puede ingresar")
        Else
            MsgBox("No puede ingresar")
        End If
    End Sub
End Class