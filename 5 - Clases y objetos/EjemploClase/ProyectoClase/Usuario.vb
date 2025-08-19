Public Class Usuario
    ' Declara sus propiedades
    Public Property nombre As String
    Public Property apellido As String
    Public Property edad As Integer
    Public Property correo As String
    Public contraseña As String

    ' Creacción del constructor
    Public Sub New(name As String, lastname As String, age As Integer, email As String, password As String)
        nombre = name
        apellido = lastname
        edad = age
        correo = email
        contraseña = password
    End Sub

    ' Creamos un método para mostrar el correo electrónico
    Public Function MostrarCorreo() As String
        Return "El correo electrónico es: " & correo
    End Function

End Class
