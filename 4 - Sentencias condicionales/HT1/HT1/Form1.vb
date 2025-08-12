Public Class Form1

    ' Declaramos los controles de la interfaz
    Private labelNombre As Label
    Private labelCantidad As Label
    Private labelProducto As Label
    Private labelOpciones As Label
    Private txtNombre As TextBox
    Private txtCantidad As TextBox
    Private lblTotal As Label
    Private groupProductos As GroupBox
    Private rbLaptop As RadioButton
    Private rbSmartphone As RadioButton
    Private rbTablet As RadioButton
    Private chkDescuento As CheckBox
    Private chkIVA As CheckBox
    Private btnCalcular As Button
    Private btnLimpiar As Button
    Private btnSalir As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Modificamos el formulario
        Text = "Sistema de facturacion"
        AutoSize = True

        ' Creamos los controles y los posicionamos en el formulario con mejor separación
        ' Label para el nombre del cliente
        labelNombre = New Label()
        labelNombre.Location = New Point(10, 10)
        labelNombre.AutoSize = True
        labelNombre.Text = "Nombre del Cliente:"
        Controls.Add(labelNombre)

        ' TextBox para ingresar el nombre del cliente
        txtNombre = New TextBox()
        txtNombre.Location = New Point(200, 10)
        txtNombre.Width = 200
        Controls.Add(txtNombre)

        ' Label para la cantidad de productos
        labelCantidad = New Label()
        labelCantidad.Location = New Point(10, 50)
        labelCantidad.AutoSize = True
        labelCantidad.Text = "Cantidad de Productos:"
        Controls.Add(labelCantidad)

        ' TextBox para ingresar la cantidad de productos
        txtCantidad = New TextBox()
        txtCantidad.Location = New Point(200, 50)
        txtCantidad.Width = 200
        Controls.Add(txtCantidad)

        ' Label de instrucciones para seleccionar el producto
        labelProducto = New Label()
        labelProducto.Location = New Point(10, 90)
        labelProducto.Text = "Seleccione el Producto:"
        labelProducto.Size = New Size(150, 20)
        Controls.Add(labelProducto)

        ' Grupo de RadioButtons para seleccionar el producto
        groupProductos = New GroupBox()
        groupProductos.Location = New Point(10, 110)
        groupProductos.Size = New Size(340, 100)
        Controls.Add(groupProductos)

        ' RadioButton para Laptop
        rbLaptop = New RadioButton()
        rbLaptop.Location = New Point(10, 20)
        rbLaptop.Text = "Laptop (Q7,000)"
        rbLaptop.AutoSize = True
        groupProductos.Controls.Add(rbLaptop)

        ' RadioButton para Smartphone
        rbSmartphone = New RadioButton()
        rbSmartphone.Location = New Point(10, 50)
        rbSmartphone.Text = "Smartphone (Q3,500)"
        rbSmartphone.AutoSize = True
        groupProductos.Controls.Add(rbSmartphone)

        ' RadioButton para Tablet
        rbTablet = New RadioButton()
        rbTablet.Location = New Point(10, 80)
        rbTablet.Text = "Tablet (Q2,500)"
        rbTablet.AutoSize = True
        groupProductos.Controls.Add(rbTablet)

        ' Label y CheckBoxes para opciones adicionales
        labelOpciones = New Label()
        labelOpciones.Location = New Point(10, 220)
        labelOpciones.Text = "Opciones Adicionales:"
        labelOpciones.Size = New Size(150, 20)
        Controls.Add(labelOpciones)

        ' CheckBox para aplicar descuento y IVA
        ' CheckBox para aplicar descuento
        chkDescuento = New CheckBox()
        chkDescuento.Location = New Point(180, 220)
        chkDescuento.Text = "Aplicar descuento del 10% por promoción"
        chkDescuento.Size = New Size(400, 30)
        Controls.Add(chkDescuento)

        ' CheckBox para aplicar el IVA
        chkIVA = New CheckBox()
        chkIVA.Location = New Point(180, 250)
        chkIVA.Text = "Aplicar IVA del 12%"
        chkIVA.Size = New Size(200, 20)
        Controls.Add(chkIVA)

        ' Label para mostrar el total a pagar
        lblTotal = New Label()
        lblTotal.Location = New Point(10, 290)
        lblTotal.Width = 340
        lblTotal.Text = "Total a Pagar: Q0.00"
        Controls.Add(lblTotal)

        ' Botones para calcular, limpiar y salir
        ' Boton para calcular el total
        btnCalcular = New Button()
        btnCalcular.Location = New Point(10, 330)
        btnCalcular.Text = "Calcular Total"
        btnCalcular.Size = New Size(100, 30)
        ' Usamos AddHandler para asignar el evento Click al botón
        ' Usamos AddressOf para asociar el evento Click con el método btnCalcular_Click
        AddHandler btnCalcular.Click, AddressOf btnCalcular_Click
        Controls.Add(btnCalcular)

        ' Boton para limpiar el formulario
        btnLimpiar = New Button()
        btnLimpiar.Location = New Point(130, 330)
        btnLimpiar.Text = "Limpiar Formulario"
        btnLimpiar.Size = New Size(100, 30)
        ' Usamos AddHandler para asignar el evento Click al botón
        ' Usamos AddressOf para asociar el evento Click con el método btnLimpiar_Click
        AddHandler btnLimpiar.Click, AddressOf btnLimpiar_Click
        Controls.Add(btnLimpiar)

        ' Boton para salir de la aplicacion
        btnSalir = New Button()
        btnSalir.Location = New Point(260, 330)
        btnSalir.Text = "Salir de la Aplicación"
        btnSalir.Size = New Size(200, 30)
        ' Usamos AddHandler para asignar el evento Click al botón
        ' Usamos AddressOf para asociar el evento Click con el método btnSalir_Click
        AddHandler btnSalir.Click, AddressOf btnSalir_Click
        Controls.Add(btnSalir)
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs)
        ValidarYCalcular()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)
        LimpiarControles()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ValidarYCalcular()
        ' Inicia el bloque de manejo de excepciones para capturar errores inesperados.
        Try
            ' Verifica si el campo de nombre está vacío.
            If String.IsNullOrEmpty(txtNombre.Text) Then
                ' Muestra mensaje de error si el nombre está vacío y sale de la subrutina.
                MessageBox.Show("El campo Nombre del Cliente no puede estar vacío. Por favor, ingrese un nombre válido.")
                Return
            End If

            ' Declara variable para almacenar la cantidad.
            Dim cantidad As Integer
            ' Intenta convertir el texto de cantidad a entero y verifica si es mayor que cero.
            If Not Integer.TryParse(txtCantidad.Text, cantidad) OrElse cantidad <= 0 Then
                ' Muestra mensaje de error si la cantidad no es válida y sale de la subrutina.
                MessageBox.Show("El campo Cantidad debe contener un valor numérico entero mayor que cero. Por favor, corrija la entrada.")
                Return
            End If

            ' Inicializa la variable de precio en cero.
            Dim precio As Decimal = 0
            ' Asigna el precio según el producto seleccionado.
            If rbLaptop.Checked Then
                precio = 7000
            ElseIf rbSmartphone.Checked Then
                precio = 3500
            ElseIf rbTablet.Checked Then
                precio = 2500
            Else
                ' Muestra mensaje de error si no se seleccionó producto y sale de la subrutina.
                MessageBox.Show("Debe seleccionar un producto de la lista disponible para proceder con el cálculo.")
                Return
            End If

            ' Calcula el subtotal usando la función del módulo Facturacion.
            Dim subtotal As Decimal = Facturacion.CalcularSubtotal(precio, cantidad)
            ' Calcula el descuento si aplica.
            Dim descuento As Decimal = Facturacion.CalcularDescuento(subtotal, chkDescuento.Checked)
            ' Calcula el IVA sobre el monto después del descuento si aplica.
            Dim iva As Decimal = Facturacion.CalcularIVA(subtotal - descuento, chkIVA.Checked)
            ' Calcula el total final.
            Dim total As Decimal = Facturacion.CalcularTotal(subtotal, descuento, iva)

            ' Actualiza la etiqueta con el total formateado.
            lblTotal.Text = "Total a Pagar: Q" & total.ToString("N2")
            ' Captura cualquier excepción inesperada.
        Catch ex As Exception
            ' Muestra mensaje de error con detalles de la excepción.
            MessageBox.Show("Se ha producido un error inesperado: " & ex.Message & ". Por favor, revise las entradas e intente nuevamente.")
        End Try
    End Sub

    Private Sub LimpiarControles()
        txtNombre.Text = ""
        txtCantidad.Text = ""
        rbLaptop.Checked = False
        rbSmartphone.Checked = False
        rbTablet.Checked = False
        chkDescuento.Checked = False
        chkIVA.Checked = False
        lblTotal.Text = "Total a Pagar: Q0.00"
    End Sub

End Class