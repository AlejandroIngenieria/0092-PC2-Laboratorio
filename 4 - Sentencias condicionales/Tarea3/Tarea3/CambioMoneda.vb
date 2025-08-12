' CambioMoneda.vb (Módulo utilizado para cálculos)
Module CambioMoneda

    Public Function CalcularCompra(quetzales As Decimal, tasa As Decimal) As Decimal
        ' Calcula la cantidad de moneda extranjera obtenida por quetzales (Compra: Quetzales a Extranjera)
        Return quetzales / tasa
    End Function

    Public Function CalcularVenta(monedaExtranjera As Decimal, tasa As Decimal) As Decimal
        ' Calcula la cantidad de quetzales obtenidos por moneda extranjera (Venta: Extranjera a Quetzales)
        Return monedaExtranjera * tasa
    End Function

    Public Function CalcularComision(monto As Decimal, porcentaje As Decimal) As Decimal
        ' Calcula la comisión sobre el monto
        Return monto * porcentaje
    End Function

End Module