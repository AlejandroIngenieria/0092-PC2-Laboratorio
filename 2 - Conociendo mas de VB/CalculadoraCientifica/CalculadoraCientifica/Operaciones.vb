Module Operaciones
    'Usamos Public para que las variables y funciones sean accesibles en otros lugares del programa, como el Form1
    Public n As Decimal = 0
    Public m As Decimal = 0
    Public resultado As Decimal = 0
    Public descripcion As String = ""

    '--------------SUBRUTINAS PARA REALIZAR LAS OPERACIONES----------------
    'Subrutina para limpiar los campos del formulario y reiniciar las variables
    Public Sub Limpiar()
        'Limpiar controles del formulario
        Form1.txtN.Text = ""
        Form1.txtM.Text = ""
        Form1.check1.Checked = False
        Form1.check2.Checked = False
        Form1.sumar.Checked = False
        Form1.restar.Checked = False
        Form1.multiplicar.Checked = False
        Form1.dividir.Checked = False
        Form1.potencia.Checked = False
        Form1.raiz.Checked = False
        'Reiniciar variables
        n = 0
        m = 0
        resultado = 0
        descripcion = ""
    End Sub

    Public Sub Validar(dato1 As Decimal, dato2 As Decimal)
        'Validación de que se reciba por lo menos un dato
        If dato1 = 0 And dato2 = 0 Then
            MsgBox("Debe ingresar al menos un número")
        End If

    End Sub

    Public Sub MostrarResultado()
        'Mostrar el resultado de la operación
        MsgBox("El resultado es: " & resultado)
    End Sub

    '------------------FUNCIONES PARA REALIZAR LAS OPERACIONES----------------
    'OPERACIONES ARITMÉTICAS BÁSICAS
    'Suma de dos números
    Public Function SumarDatos(dato1 As Decimal, dato2 As Decimal) As Decimal
        'Guardamos el mensaje en la variable descripción por si se selecciona el checkbox2
        descripcion = "Suma de " & dato1 & " y " & dato2
        'Siempre debe ir un retorno de la función
        Return dato1 + dato2
    End Function

    Public Function RestarDatos(dato1 As Decimal, dato2 As Decimal) As Decimal
        'Guardamos el mensaje en la variable descripción por si se selecciona el checkbox2
        descripcion = "Resta de " & dato1 & " y " & dato2
        'Siempre debe ir un retorno de la función
        Return dato1 - dato2
    End Function

    Public Function MultiplicarDatos(dato1 As Decimal, dato2 As Decimal) As Decimal
        'Guardamos el mensaje en la variable descripción por si se selecciona el checkbox2
        descripcion = "Multiplicación de " & dato1 & " y " & dato2
        'Siempre debe ir un retorno de la función
        Return dato1 * dato2
    End Function

    Public Function DividirDatos(dato1 As Decimal, dato2 As Decimal) As Decimal
        'Guardamos el mensaje en la variable descripción por si se selecciona el checkbox2
        descripcion = "División de " & dato1 & " y " & dato2
        ' Validación para evitar división por cero
        If dato2 = 0 Then
            MsgBox("No se puede dividir por cero")
            'Siempre debe ir un retorno de la función
            Return 0
        Else
            'Siempre debe ir un retorno de la función
            Return dato1 / dato2
        End If
    End Function

    'OPERACIONES AVANZADAS
    Public Function PotenciaDatos(base As Decimal, exponente As Decimal) As Decimal
        'Guardamos el mensaje en la variable descripción por si se selecciona el checkbox2
        descripcion = "Potencia de " & base & " elevado a " & exponente
        'Siempre debe ir un retorno de la función
        'Para operaciones más complejas usamos Math que es una clase de .NET que contiene métodos matemáticos
        'En este caso usamos Math.Pow que calcula la potencia de un número
        Return Math.Pow(base, exponente)
    End Function

    Public Function RaizDatos(numero As Decimal) As Decimal
        'Guardamos el mensaje en la variable descripción por si se selecciona el checkbox2
        descripcion = "Raíz cuadrada de " & numero
        ' Validación para evitar calcular la raíz cuadrada de un número negativo
        If numero < 0 Then
            MsgBox("No se puede calcular la raíz cuadrada de un número negativo")
            'Siempre debe ir un retorno de la función
            Return 0
        Else
            'Siempre debe ir un retorno de la función
            'Para operaciones más complejas usamos Math que es una clase de .NET que contiene métodos matemáticos
            'En este caso usamos Math.Sqrt que calcula la raíz cuadrada de un número
            Return Math.Sqrt(numero)
        End If
    End Function


End Module
