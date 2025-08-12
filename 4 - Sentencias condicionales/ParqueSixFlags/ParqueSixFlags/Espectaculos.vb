Public Class Espectaculos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If checkPaseEspecial.Checked OrElse checkClubFrecuentes.Checked Then
            MsgBox("Puede ingresar")
        Else
            MsgBox("No puede ingresar")
        End If
    End Sub
End Class