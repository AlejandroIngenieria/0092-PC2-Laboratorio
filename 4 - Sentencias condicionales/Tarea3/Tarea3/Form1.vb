Public Class Form1

    ' Declaración de controles
    Private lblInstrucciones As Label
    Private chkCompra As CheckBox
    Private chkVenta As CheckBox
    Private lblMoneda As Label
    Private cmbMoneda As ComboBox
    Private lblCantidadCompra As Label
    Private txtCantidadCompra As TextBox
    Private lblCantidadVenta As Label
    Private txtCantidadVenta As TextBox
    Private btnCalcular As Button
    Private btnLimpiar As Button
    Private btnSalir As Button
    Private lblResultado As Label

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configura el tamaño del formulario para un diseño más amplio
        Size = New Size(800, 600)
        Text = "Casa de Cambios"

        ' Crea y posiciona la etiqueta de instrucciones con más espacio
        lblInstrucciones = New Label()
        lblInstrucciones.Location = New Point(20, 20)
        lblInstrucciones.Text = "Seleccione transacción(es) y moneda. Ingrese cantidades según corresponda."
        lblInstrucciones.AutoSize = True
        Controls.Add(lblInstrucciones)

        ' Crea checkbox para Compra
        chkCompra = New CheckBox()
        chkCompra.Location = New Point(20, 70)
        chkCompra.Text = "Compra (Quetzales a Moneda Extranjera)"
        chkCompra.AutoSize = True
        Controls.Add(chkCompra)

        ' Crea checkbox para Venta
        chkVenta = New CheckBox()
        chkVenta.Location = New Point(20, 110)
        chkVenta.Text = "Venta (Moneda Extranjera a Quetzales)"
        chkVenta.AutoSize = True
        Controls.Add(chkVenta)

        ' Crea etiqueta para selección de moneda
        lblMoneda = New Label()
        lblMoneda.Location = New Point(20, 160)
        lblMoneda.Text = "Seleccione Moneda:"
        lblMoneda.AutoSize = True
        Controls.Add(lblMoneda)

        ' Crea ComboBox para monedas
        cmbMoneda = New ComboBox()
        cmbMoneda.Location = New Point(200, 160)
        cmbMoneda.Width = 250
        cmbMoneda.Items.AddRange(New String() {"Dólar (Q7.69 por USD)", "Peso Mexicano (Q0.38 por MXN)", "Euro (Q8.79 por EUR)", "Colón Costarricense (Q0.012 por CRC)"})
        Controls.Add(cmbMoneda)

        ' Crea etiqueta y textbox para cantidad en compra
        lblCantidadCompra = New Label()
        lblCantidadCompra.Location = New Point(50, 210)
        lblCantidadCompra.Text = "Cantidad Quetzales para Compra:"
        lblCantidadCompra.AutoSize = True
        Controls.Add(lblCantidadCompra)

        txtCantidadCompra = New TextBox()
        txtCantidadCompra.Location = New Point(400, 210)
        txtCantidadCompra.Width = 250
        Controls.Add(txtCantidadCompra)

        ' Crea etiqueta y textbox para cantidad en venta
        lblCantidadVenta = New Label()
        lblCantidadVenta.Location = New Point(50, 260)
        lblCantidadVenta.Text = "Cantidad Moneda Extranjera para Venta:"
        lblCantidadVenta.AutoSize = True
        Controls.Add(lblCantidadVenta)

        txtCantidadVenta = New TextBox()
        txtCantidadVenta.Location = New Point(400, 260)
        txtCantidadVenta.Width = 250
        Controls.Add(txtCantidadVenta)

        ' Crea botón Calcular
        btnCalcular = New Button()
        btnCalcular.Location = New Point(20, 310)
        btnCalcular.Text = "Calcular Total"
        btnCalcular.Size = New Size(120, 30)
        AddHandler btnCalcular.Click, AddressOf btnCalcular_Click
        Controls.Add(btnCalcular)

        ' Crea botón Limpiar
        btnLimpiar = New Button()
        btnLimpiar.Location = New Point(160, 310)
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.Size = New Size(120, 30)
        AddHandler btnLimpiar.Click, AddressOf btnLimpiar_Click
        Controls.Add(btnLimpiar)

        ' Crea botón Salir
        btnSalir = New Button()
        btnSalir.Location = New Point(300, 310)
        btnSalir.Text = "Salir"
        btnSalir.Size = New Size(120, 30)
        AddHandler btnSalir.Click, AddressOf btnSalir_Click
        Controls.Add(btnSalir)

        ' Crea etiqueta para resultado
        lblResultado = New Label()
        lblResultado.Location = New Point(20, 360)
        lblResultado.Text = "Resultado: "
        lblResultado.AutoSize = True
        lblResultado.Width = 450
        Controls.Add(lblResultado)
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs)
        ' Llama al procedimiento de validación y cálculo
        ValidarYCalcular()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        ' Llama al procedimiento para limpiar controles
        LimpiarControles()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        ' Pregunta al usuario si desea salir
        If MessageBox.Show("¿Desea salir de la aplicación?", "Confirmar Salida", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub ValidarYCalcular()
        ' Inicia bloque de manejo de errores
        Try
            ' Verifica si se seleccionó al menos una transacción
            If Not chkCompra.Checked And Not chkVenta.Checked Then
                MessageBox.Show("Debe seleccionar al menos una transacción: Compra o Venta.")
                Return
            End If

            ' Verifica selección de moneda
            If cmbMoneda.SelectedIndex = -1 Then
                MessageBox.Show("Debe seleccionar una moneda.")
                Return
            End If

            ' Obtiene tasa de cambio según moneda seleccionada
            Dim tasa As Decimal
            Dim moneda As String = cmbMoneda.SelectedItem.ToString()
            If moneda.Contains("Dólar") Then
                tasa = 7.69D
            ElseIf moneda.Contains("Peso") Then
                tasa = 0.38D
            ElseIf moneda.Contains("Euro") Then
                tasa = 8.79D
            ElseIf moneda.Contains("Colón") Then
                tasa = 0.012D
            End If

            Dim totalFinal As Decimal = 0D

            ' Procesa compra si está seleccionada
            If chkCompra.Checked Then
                Dim quetzalesCompra As Decimal
                If Not Decimal.TryParse(txtCantidadCompra.Text, quetzalesCompra) OrElse quetzalesCompra <= 0 Then
                    MessageBox.Show("La cantidad para compra debe ser un número positivo.")
                    Return
                End If
                Dim montoCompra As Decimal = CambioMoneda.CalcularCompra(quetzalesCompra, tasa)
                Dim comisionCompra As Decimal = CambioMoneda.CalcularComision(montoCompra, 0.025D)
                totalFinal += montoCompra + comisionCompra
            End If

            ' Procesa venta si está seleccionada
            If chkVenta.Checked Then
                Dim monedaVenta As Decimal
                If Not Decimal.TryParse(txtCantidadVenta.Text, monedaVenta) OrElse monedaVenta <= 0 Then
                    MessageBox.Show("La cantidad para venta debe ser un número positivo.")
                    Return
                End If
                Dim montoVenta As Decimal = CambioMoneda.CalcularVenta(monedaVenta, tasa)
                Dim comisionVenta As Decimal = CambioMoneda.CalcularComision(montoVenta, 0.03D)
                totalFinal += montoVenta + comisionVenta
            End If

            ' Muestra el resultado
            MostrarResultado(totalFinal)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message)
        End Try
    End Sub

    Private Sub MostrarResultado(total As Decimal)
        ' Procedimiento para mostrar el resultado en la etiqueta
        lblResultado.Text = "Total final a pagar (incluyendo comisión): Q" & total.ToString("N2")
    End Sub

    Private Sub LimpiarControles()
        ' Procedimiento para limpiar todos los controles
        chkCompra.Checked = False
        chkVenta.Checked = False
        cmbMoneda.SelectedIndex = -1
        txtCantidadCompra.Text = ""
        txtCantidadVenta.Text = ""
        lblResultado.Text = "Resultado: "
    End Sub

End Class