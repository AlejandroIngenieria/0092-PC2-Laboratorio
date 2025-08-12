Module Facturacion

    Public Function CalcularSubtotal(precio As Decimal, cantidad As Integer) As Decimal
        Return precio * cantidad
    End Function

    Public Function CalcularDescuento(subtotal As Decimal, aplicar As Boolean) As Decimal
        If aplicar Then
            Return subtotal * 0.1D
        Else
            Return 0
        End If
    End Function

    Public Function CalcularIVA(monto As Decimal, aplicar As Boolean) As Decimal
        If aplicar Then
            Return monto * 0.12D
        Else
            Return 0
        End If
    End Function

    Public Function CalcularTotal(subtotal As Decimal, descuento As Decimal, iva As Decimal) As Decimal
        Return subtotal - descuento + iva
    End Function

End Module