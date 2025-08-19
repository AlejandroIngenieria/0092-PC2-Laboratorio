Public Class Form1
    Private Sub listaEnteros_Click(sender As Object, e As EventArgs) Handles listaEntero.Click
        ListaEnteros()
    End Sub

    Private Sub listaUsuarios_Click(sender As Object, e As EventArgs) Handles listaUsuario.Click
        ListaUsuarios()
        ' Metodo find por medio de nombre
        Dim usuarioEncontradoNombre As Usuario = usuarios.Find(Function(u) u.nombre = "Juan")
        If usuarioEncontradoNombre IsNot Nothing Then
            MessageBox.Show("Usuario encontrado: " & usuarioEncontradoNombre.nombre & " " & usuarioEncontradoNombre.apellido)
        Else
            MessageBox.Show("Usuario no encontrado.")
        End If

        ' Metodo find por medio de correo electrónico
        Dim usuarioEncontradoCorreo As Usuario = usuarios.Find(Function(u) u.correo = "ana@mail.com")
        If usuarioEncontradoCorreo IsNot Nothing Then
            MessageBox.Show("Usuario encontrado: " & usuarioEncontradoCorreo.nombre & " " & usuarioEncontradoCorreo.apellido)
        Else
            MessageBox.Show("Usuario no encontrado.")
        End If
    End Sub

    Private Sub arrayCadenas_Click(sender As Object, e As EventArgs) Handles arrayCadena.Click
        ArrayCadenas()
    End Sub

    Private Sub arrayEnteros_Click(sender As Object, e As EventArgs) Handles arrayEntero.Click
        ArrayEnteros()
    End Sub
End Class