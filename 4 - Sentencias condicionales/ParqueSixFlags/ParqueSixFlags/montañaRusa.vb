Public Class montañaRusa
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If txtEstatura.Text >= 1.5 And txtEdad.Text > 12 Then
            MsgBox("Puede ingresar")
        ElseIf txtEdad.Text < 18 And checkAcompañado.Checked Then
            MsgBox("Puede ingresar")
        Else
            MsgBox("No puede ingresar")
        End If
    End Sub
End Class