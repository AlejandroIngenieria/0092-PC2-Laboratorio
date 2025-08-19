Module Listas
    Public numeros As New List(Of Integer) ' Creamos una lista de enteros
    Public usuarios As New List(Of Usuario) ' Esta es una lista de objetos de la clase Usuario

    ' Creamos una lista simple con numeros enteros
    Sub ListaEnteros()
        ' Declaramos una lista de enteros
        ' Añadimos elementos a la lista
        numeros.Add(5) ' Indice 0
        numeros.Add(3) ' Indice 1
        numeros.Add(8) ' Indice 2
        numeros.Add(1) ' Indice 3
        numeros.Add(2) ' Indice 4
        ' Mostramos los elementos de la lista
        Dim mensaje As String = "Elementos de la lista: " & vbCrLf & numeros(0) & vbCrLf & numeros(1) & vbCrLf & numeros(2) & vbCrLf & numeros(3) & vbCrLf & numeros(4)

        ' metodo removeAt
        numeros.RemoveAt(2)
        ' Mostramos los elementos de la lista después de eliminar el elemento en el índice 2
        ' la lista ahora tiene 4 elementos por lo que el índice se reduce y en este caso desaparece el número 8
        Dim mensajeDespues As String = "Elementos de la lista después de eliminar el índice 2: " & vbCrLf & numeros(0) & vbCrLf & numeros(1) & vbCrLf & numeros(2) & vbCrLf & numeros(3)
        ' Mostramos los mensajes en MessageBox
        MessageBox.Show(mensaje)
        MessageBox.Show(mensajeDespues)
    End Sub

    Sub ListaUsuarios()
        ' user1 es un objeto de la clase Usuario
        Dim user1 As New Usuario("Juan", "Pérez", 30, "juan@mail.com", "12345")
        ' Mensaje para indicar que se ha creado el objeto user1
        usuarios.Add(user1)
        MessageBox.Show("Usuario creado: " & user1.nombre & " " & user1.apellido)
        ' user2 es otro objeto de la clase Usuario
        Dim user2 As New Usuario("Ana", "Gómez", 25, "ana@mail.com", "67890")
        ' Mensaje para indicar que se ha creado el objeto user2
        usuarios.Add(user2)
        MessageBox.Show("Usuario creado: " & user2.nombre & " " & user2.apellido)
    End Sub

End Module
