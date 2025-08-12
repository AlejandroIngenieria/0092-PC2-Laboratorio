Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim mensaje As String = "Has seleccionado el dia"
        ' typeOf -> verifica el tipo de dato de una variable
        ' Is -> compara el tipo de dato de una variable con otro tipo de dato
        If TypeOf mensaje Is String Then
            MsgBox("Es string")
        Else
            MsgBox("No es texto")
        End If


        Dim itemSelecionado As Integer = ComboBox1.SelectedIndex
        Select Case itemSelecionado
            Case 0
                Label1.Text = "Has seleccionado el dia lunes"
            Case 1
                Label1.Text = "Has seleccionado el dia martes"
            Case 2
                Label1.Text = "Has seleccionado el dia miercoles"
            Case 6
                Label1.Text = "Has seleccionado el dia domingo"
            Case Else
                Label1.Text = "Please select an option."
        End Select
    End Sub

End Class