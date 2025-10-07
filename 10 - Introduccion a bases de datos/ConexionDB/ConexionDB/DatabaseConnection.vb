' Importamos la librería del conector de MySQL
Imports MySqlConnector

' Clase que gestiona la conexión con la base de datos MySQL
Public Class DatabaseConnection
    Private connectionString As String

    ' Constructor de la clase: define la cadena de conexión
    Public Sub New()
        ' Cambia estos valores según tu entorno
        connectionString = "Server=localhost;Database=tu_base_de_datos;Uid=root;Pwd=tu_constraseña;Allow User Variables=True"
    End Sub

    ' Método que devuelve una conexión lista para usarse
    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    ' Método para probar si la conexión funciona correctamente
    Public Function TestConnection() As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                MessageBox.Show("✅ Conexión exitosa a la base de datos.")
                Return True
            End Using
        Catch ex As Exception
            MessageBox.Show($"❌ Error de conexión: {ex.Message}" & vbCrLf &
                           "Verifica que MySQL esté ejecutándose y las credenciales sean correctas.")
            Return False
        End Try
    End Function
End Class
