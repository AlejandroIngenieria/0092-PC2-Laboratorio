Module animalManager

    ' Declarar una lista de animales
    Public listaAnimales As New List(Of Animal)

    Public Sub inicializarAnimales()
        ' Crear instancias de animales y agregarlas a la lista
        Dim animal1 As New Animal("Firulais", 3, "Perro", "https://i.pinimg.com/736x/10/41/c8/1041c828bf2c8ba7132670143c9dae23.jpg")
        Dim animal2 As New Animal("Michi", 2, "Gato", "https://i.pinimg.com/1200x/b9/2f/01/b92f01a51b642867703419149c6e1eb0.jpg")
        Dim animal3 As New Animal("Nemo", 1, "Pez", "https://i.pinimg.com/736x/1d/b7/c9/1db7c99139f9ea801128193f9d7a62c2.jpg")
        Dim animal4 As New Animal("Polly", 4, "Jaguar", "https://i.pinimg.com/1200x/d9/37/92/d93792c18c80779c7106e8bb2324924c.jpg")
        listaAnimales.Add(animal1)
        listaAnimales.Add(animal2)
        listaAnimales.Add(animal3)
        listaAnimales.Add(animal4)
    End Sub


End Module
