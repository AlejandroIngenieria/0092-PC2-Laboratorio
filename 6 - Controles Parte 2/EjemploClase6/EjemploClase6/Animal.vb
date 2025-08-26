Public Class Animal
    ' Declarar sus atributos publicos
    Public Property Nombre As String
    Public Property Edad As Integer
    Public Property Especie As String
    Public Property URL As String

    ' Declarar su constructor
    Public Sub New(name As String, age As Integer, species As String, urlImagen As String)
        Nombre = name
        Edad = age
        Especie = species
        URL = urlImagen
    End Sub

End Class
