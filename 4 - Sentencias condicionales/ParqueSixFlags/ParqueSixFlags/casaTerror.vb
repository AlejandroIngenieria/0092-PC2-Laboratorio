Public Class casaTerror
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If txtEdad.Text > 15 Or checkPermiso.Checked Then
            MsgBox("Puede ingresar")
        Else
            MsgBox("No puede ingresar")
        End If
    End Sub
End Class