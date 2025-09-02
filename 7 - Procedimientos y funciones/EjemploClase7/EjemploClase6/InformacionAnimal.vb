Public Class InformacionAnimal
    Private Sub InformacionAnimal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuramos la picturebox para que la imagen se ajuste al tamaño del picturebox
        picInfo.Load(animalSeleccionado.URL)
        picInfo.SizeMode = PictureBoxSizeMode.StretchImage
        ' Mostramos la informacion del animal seleccionado
        txtNombre.Text = animalSeleccionado.Nombre
        txtEdad.Text = animalSeleccionado.Edad.ToString()
        txtEspecie.Text = animalSeleccionado.Especie

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ' Actualizamos la informacion del animal seleccionado con los datos ingresados en los textbox
        animalSeleccionado.Nombre = txtNombre.Text
        animalSeleccionado.Edad = Integer.Parse(txtEdad.Text)
        animalSeleccionado.Especie = txtEspecie.Text
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Eliminamos el animal seleccionado de la lista de animales
        listaAnimales.Remove(animalSeleccionado)
    End Sub
End Class