Module Arrays

    ' Ejemplo de array de cadenas de texto pero únicamente declaración del arreglo
    Sub ArrayCadenas()
        ' Declaramos un arreglo de cadenas de texto
        Dim nombres(5) As String ' Arreglo de 6 elementos (0 a 5)
        ' Insertamos valores en el arreglo
        nombres(0) = "Juan"
        nombres(1) = "María"
        nombres(2) = "Pedro"
        nombres(3) = "Ana"
        nombres(4) = "Luis"
        nombres(5) = "Laura"

        ' Mostramos los valores del arreglo
        MessageBox.Show("Primer nombre: " & nombres(0)) ' Juan
        MessageBox.Show("Segundo nombre: " & nombres(1)) ' María
        MessageBox.Show("Tercer nombre: " & nombres(2)) ' Pedro
        MessageBox.Show("Cuarto nombre: " & nombres(3)) ' Ana
        MessageBox.Show("Quinto nombre: " & nombres(4)) ' Luis
        MessageBox.Show("Sexto nombre: " & nombres(5)) ' Laura
    End Sub

    ' Ejemplo de array de enteros con operaciones básicas e inicialización del arreglo
    Sub ArrayEnteros()
        ' Declaramos un arreglo de enteros
        Dim numeros() As Integer = {5, 3, 8, 1, 2} ' Esto es lo mismo que Dim numeros(4) As Integer e ir asigando valores

        ' 1. Array.Sort → Ordena el arreglo
        Array.Sort(numeros)
        ' imprimimos todos los elementos del arreglo ordenado en un MessageBox usando vbCrLf para saltos de línea
        Dim mensaje As String = "Elementos ordenados: " & vbCrLf & numeros(0) & vbCrLf & numeros(1) & vbCrLf & numeros(2) & vbCrLf & numeros(3) & vbCrLf & numeros(4)
        MessageBox.Show(mensaje)

        ' 2. Array.Reverse → Invierte el orden
        Array.Reverse(numeros)
        Dim mensajeInvertido As String = "Elementos Invertidos: " & vbCrLf & numeros(0) & vbCrLf & numeros(1) & vbCrLf & numeros(2) & vbCrLf & numeros(3) & vbCrLf & numeros(4)
        MessageBox.Show(mensajeInvertido)

        ' 3. Array.IndexOf → Devuelve el índice de un valor
        Dim indice As Integer = Array.IndexOf(numeros, 3)
        MessageBox.Show("Índice del valor 3: " & indice)

        ' 4. Array.Clear → Limpia elementos
        ' Limpia el arreglo desde un índice específico
        ' En este caso, limpia desde el índice 1 y elimina 2 elementos
        ' Esto significa que el elemento en el índice 1 y 2 serán limpiados (establecidos a 0)
        MessageBox.Show("Antes de limpiar Clear(): " & vbCrLf & numeros(0) & vbCrLf & numeros(1) & vbCrLf & numeros(2) & vbCrLf & numeros(3) & vbCrLf & numeros(4))
        ' Limpia el arreglo desde el índice 1 y elimina 2 elementos
        Array.Clear(numeros, 1, 2) ' Limpia desde índice 1, 2 elementos
        ' Mostramos los elementos después de limpiar
        Dim mensajeLimpio As String = "Elementos después de Clear(): " & vbCrLf & numeros(0) & vbCrLf & numeros(1) & vbCrLf & numeros(2) & vbCrLf & numeros(3) & vbCrLf & numeros(4)
        MessageBox.Show(mensajeLimpio)
    End Sub

End Module
