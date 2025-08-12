Public Class zonaVIP
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        If checkVIP.Checked AndAlso checkSanciones.Checked Then
            MsgBox("Puede ingresar")
        Else
            MsgBox("No puede ingresar")
        End If
    End Sub
End Class