Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Usamos Try-Catch para manejar errores de conversión
        Try
            n = Decimal.Parse(txtN.Text)
        Catch ex As Exception
            'Si ocurre un error, mostramos un mensaje al usuario
            MsgBox("Por favor ingresa un numero en N")
        End Try

        'los <radioButtons> en su propiedad <Checked> nos indican si están seleccionados o no
        'Son del tipo Boolean por lo que su resultado es True o False
        'Solamente los podemos comparar con True o False
        'True significa que el radioButton está seleccionado
        'False significa que el radioButton no está seleccionado
        'Lo mismo es para los <checkBoxes>
        If raiz.Checked = False Then
            'Si el radioButton de Raíz no está seleccionado, entonces pedimos el segundo número
            'Usamos Try-Catch para manejar errores de conversión
            Try
                'Parsear datos para validar que sean el tipo que esperamos, en este caso Decimal
                m = Decimal.Parse(txtM.Text)
            Catch ex As Exception
                'Si ocurre un error, mostramos un mensaje al usuario
                MsgBox("Por favor ingresa un numero en M")
            End Try
        Else
        End If



        'Aqui llamamos a la subrutina
        Validar(n, m)

        'Aqui operamos con los radioButtons
        If sumar.Checked Then
            'Aqui llamamos a la funcion SumarDatos
            resultado = SumarDatos(n, m)
        ElseIf restar.Checked Then
            'Aqui llamamos a la funcion RestarDatos
            resultado = RestarDatos(n, m)
        ElseIf multiplicar.Checked Then
            'Aqui llamamos a la funcion MultiplicarDatos
            resultado = MultiplicarDatos(n, m)
        ElseIf dividir.Checked Then
            'Aqui llamamos a la funcion DividirDatos
            resultado = DividirDatos(n, m)
        ElseIf potencia.Checked Then
            'Aqui llamamos a la funcion PotenciaDatos
            resultado = PotenciaDatos(n, m)
        ElseIf raiz.Checked Then
            'Aqui llamamos a la funcion RaizDatos
            resultado = RaizDatos(n)
        Else
            'Si no se selecciona ninguna operación, mostramos un mensaje
            MsgBox("Debe seleccionar una operación")
        End If

        'Aqui operamos con los checkBoxes
        'Aqui mostramos el resultado con 2 decimales si el checkBox1 esta seleccionado
        If check1.Checked Then
            'Redondeamos el resultado a 2 decimales
            'Math.Round nos permite redondear un número a la cantidad de decimales que le indiquemos
            resultado = Math.Round(resultado, 2)
        End If

        If check2.Checked Then
            'Si el checkBox2 está seleccionado, mostramos la descripción de la operación
            MsgBox(descripcion)
        End If


        ' Llamamos a la subrutina para mostrar el resultado
        MostrarResultado()

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Llamamos a la subrutina Limpiar para reiniciar los campos y variables
        Limpiar()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'Close() cierra el formulario actual
        'End() finaliza la aplicación
        'En este caso, solo queremos cerrar el formulario
        Close()
    End Sub
End Class
