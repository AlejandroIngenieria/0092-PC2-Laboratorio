Public Class zonaInfantil
    Private Sub Verificar_Click(sender As Object, e As EventArgs) Handles Verificar.Click
        If Not txtEdad.Text > 12 Then
            MsgBox("Puede ingresar")
        Else
            MsgBox("No puede ingresar")
        End If

    End Sub
End Class