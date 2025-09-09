Public Class AgregarAnimal
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        listaAnimales.Add(New Animal(txtNombre.Text, Integer.Parse(txtEdad.Text), txtEspecie.Text, txtURL.Text))
        ' Cerrar el formulario despues de agregar el animal
        Form1.ActualizarGrid()
        Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        ' Cerrar el formulario sin hacer nada y eliminar los datos ingresados
        Close()
    End Sub
End Class