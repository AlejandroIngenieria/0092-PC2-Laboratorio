Module animalManager

    ' Declarar una lista de animales
    Public listaAnimales As New List(Of Animal)

    Public Sub inicializarAnimales()
        ' Crear instancias de animales y agregarlas a la lista
        Dim animal1 As New Animal("Firulais", 3, "Perro", "https://i.pinimg.com/736x/10/41/c8/1041c828bf2c8ba7132670143c9dae23.jpg")
        Dim animal2 As New Animal("Michi", 2, "Gato", "https://i.pinimg.com/1200x/b9/2f/01/b92f01a51b642867703419149c6e1eb0.jpg")
        Dim animal3 As New Animal("Nemo", 1, "Pez", "https://i.pinimg.com/736x/1d/b7/c9/1db7c99139f9ea801128193f9d7a62c2.jpg")
        Dim animal4 As New Animal("Polly", 4, "Jaguar", "https://i.pinimg.com/1200x/d9/37/92/d93792c18c80779c7106e8bb2324924c.jpg")
        Dim animal5 As New Animal("Bobby", 5, "Puma", "https://i.pinimg.com/1200x/78/3c/29/783c29a932074f11c72fe72ef2de00c6.jpg")
        Dim animal6 As New Animal("Luna", 3, "Tiburon", "https://i.pinimg.com/1200x/bb/64/71/bb6471d302078f2283d06b700cdc9112.jpg")
        Dim animal7 As New Animal("Goldie", 1, "Pez globo", "https://i.pinimg.com/736x/47/f6/7a/47f67a5dfa8472c93161d8fd9133e512.jpg")
        Dim animal8 As New Animal("Max", 6, "Elefante", "https://i.pinimg.com/1200x/47/62/27/476227e3ea946132794866fcd6c10b79.jpg")
        listaAnimales.Add(animal1)
        listaAnimales.Add(animal2)
        listaAnimales.Add(animal3)
        listaAnimales.Add(animal4)
        listaAnimales.Add(animal5)
        listaAnimales.Add(animal6)
        listaAnimales.Add(animal7)
        listaAnimales.Add(animal8)
    End Sub


End Module
