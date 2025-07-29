Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Declarar las variables tipo Double para que acepten decimales
        Dim librasDeArroz As Double
        Dim librasDeFrijol As Double
        Dim librasDeAzucar As Double
        Dim librasDeCafe As Double
        Dim totalSinIVA As Double
        Dim iva As Double
        Dim totalConIVA As Double
        Dim descuento As Double
        Dim recargo As Double
        Dim totalAPagar As Double

        'Inciso A
        'Pago inicial: La suma de las multiplicaciones de las libras de cada producto por el precio.
        librasDeArroz = txtArroz.Text
        librasDeFrijol = txtFrijol.Text
        librasDeAzucar = txtAzucar.Text
        librasDeCafe = txtCafe.Text

        librasDeArroz = librasDeArroz * 2
        librasDeFrijol = librasDeFrijol * 1.75
        librasDeAzucar = librasDeAzucar * 2.5
        librasDeCafe = librasDeCafe * 1.25
        totalSinIVA = librasDeArroz + librasDeFrijol + librasDeAzucar + librasDeCafe
        'Mostrar el resultado del inciso A en un MessageBox
        MsgBox("Los resultados del inciso A son:")
        MsgBox(totalSinIVA)

        'Inciso B
        'Calcular el IVA (12%), sobre el resultado del inciso anterior
        iva = totalSinIVA * 0.12
        'Mostrar el resultado del inciso B en un MessageBox
        MsgBox("Los resultados del inciso B son:")
        MsgBox(iva)

        'Inciso C
        'Calcular un pago parcial: resultado del inciso a) más resultado del inciso b) 
        totalConIVA = totalSinIVA + iva
        'Mostrar el resultado del inciso C en un MessageBox
        MsgBox("Los resultados del inciso C son:")
        MsgBox(totalConIVA)

        'Inciso D
        'La tienda hace entrega solo a domicilio y tiene un recargo del 2.5%, este se aplica al inciso c) 
        recargo = totalConIVA * 0.025
        'Mostrar el resultado del inciso D en un MessageBox
        MsgBox("Los resultados del inciso D son:")
        MsgBox(recargo)

        'Inciso E
        'La tienda por aniversario hace un descuento según el monto parcial que haga el cliente, 
        'si el monto gastado es mayor o igual a Q75.00 ese descuento es del 5% sobre el inciso c) 
        'sino cumple la condición el descuento será de cero.

        If totalConIVA >= 75 Then
            descuento = totalConIVA * 0.05
            'Mostrar el resultado del inciso E en un MessageBox
            MsgBox("Los resultados del inciso E son:")
            MsgBox(descuento)
        Else
            MsgBox("Los resultados del inciso E son:")
            MsgBox("No aplica descuento")
        End If

        'Inciso F
        'Luego calcular el total a pagar que sería: resultado del inciso c) más lo del recargo de
        'entrega a domicilio del inciso d) menos lo que obtenga del inciso e)
        totalAPagar = totalConIVA + recargo - descuento
        'Mostrar el resultado del inciso F en un MessageBox
        MsgBox("Los resultados del inciso F son:")
        MsgBox(totalAPagar)


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtArroz.Text = ""
        txtFrijol.Text = ""
        txtAzucar.Text = ""
        txtCafe.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class
