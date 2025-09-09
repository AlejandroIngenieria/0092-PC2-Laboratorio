Public Class Estudiante
    Public Property Nombre As String
    Public Property Edad As Integer

    Public Sub New(nombre As String, edad As Integer)
        Me.Nombre = nombre
        Me.Edad = edad
    End Sub

    Public Function Datos() As String
        Return $"Nombre: {Nombre}, Edad: {Edad}"
    End Function

End Class
