Public Class Form1
    ' Inicialmente al cargar el formulario crearemos las columnas del DataGridView
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear columnas solo si no existen
        If dgvDatos.Columns.Count = 0 Then
            dgvDatos.Columns.Add("Placa", "Placa")
            dgvDatos.Columns.Add("Tipo", "Tipo")
            dgvDatos.Columns.Add("KmInicial", "KmInicial")
            dgvDatos.Columns.Add("KmFinal", "KmFinal")
            dgvDatos.Columns.Add("Pago", "Pago")
        End If
    End Sub

    ' Subrutinas para manejar la lógica del programa
    Private Sub Calcular()
        If contador <= 6 Then
            Dim placaNum As String = txtPlaca.Text
            Dim tipoAuto As Integer = cboTipo.SelectedIndex + 1
            Dim inicial As Double = Val(txtInicial.Text)
            Dim final As Double = Val(txtFinal.Text)

            If placaNum = "" Or inicial >= final Then
                MsgBox("Datos inválidos")
                Exit Sub
            End If

            Dim kmRecorridos As Double = final - inicial
            Dim precioBase As Double
            Dim precioKm As Double

            Select Case tipoAuto
                Case 1 : precioBase = 500
                Case 2 : precioBase = 400
                Case 3 : precioBase = 300
                Case 4 : precioBase = 200
            End Select

            If kmRecorridos <= 100 Then
                precioKm = 3
            ElseIf kmRecorridos <= 200 Then
                precioKm = 4
            Else
                precioKm = 5
            End If

            Dim total As Double = precioBase + (kmRecorridos * precioKm)

            placa(contador) = placaNum
            tipo(contador) = tipoAuto
            kmInicial(contador) = inicial
            kmFinal(contador) = final
            pago(contador) = total

            contador += 1
            MsgBox("Datos guardados exitosamente.")
        Else
            MsgBox("Límite de registros alcanzado.")
        End If
    End Sub

    Private Sub Mostrar()
        dgvDatos.Rows.Clear()
        For i As Integer = 0 To contador - 1
            dgvDatos.Rows.Add(placa(i), tipo(i), kmInicial(i), kmFinal(i), pago(i))
        Next
    End Sub

    Private Sub Consultar()
        Dim buscar As String = txtPlaca.Text
        Dim encontrado As Boolean = False

        For i As Integer = 0 To contador - 1
            If placa(i) = buscar Then
                cboTipo.SelectedIndex = tipo(i) - 1
                txtInicial.Text = kmInicial(i)
                txtFinal.Text = kmFinal(i)
                MsgBox("Registro encontrado.")
                encontrado = True
                Exit For
            End If
        Next

        If Not encontrado Then
            MsgBox("Placa no encontrada.")
        End If
    End Sub

    Private Sub Actualizar()
        Dim buscar As String = txtPlaca.Text
        Dim encontrado As Boolean = False

        For i As Integer = 0 To contador - 1
            If placa(i) = buscar Then
                ' Actualizar datos base
                tipo(i) = cboTipo.SelectedIndex + 1
                kmInicial(i) = Val(txtInicial.Text)
                kmFinal(i) = Val(txtFinal.Text)

                ' Recalcular el pago
                Dim kmRecorridos As Double = kmFinal(i) - kmInicial(i)
                Dim precioBase As Double
                Dim precioKm As Double

                Select Case tipo(i)
                    Case 1 : precioBase = 500
                    Case 2 : precioBase = 400
                    Case 3 : precioBase = 300
                    Case 4 : precioBase = 200
                End Select

                If kmRecorridos <= 100 Then
                    precioKm = 3
                ElseIf kmRecorridos <= 200 Then
                    precioKm = 4
                Else
                    precioKm = 5
                End If

                pago(i) = precioBase + (kmRecorridos * precioKm)

                MsgBox("Registro actualizado correctamente.")
                encontrado = True
                Exit For
            End If
        Next

        If Not encontrado Then
            MsgBox("Placa no encontrada.")
        End If
    End Sub


    Private Sub Eliminar()
        Dim buscar As String = txtPlaca.Text

        For i As Integer = 0 To contador - 1
            If placa(i) = buscar Then
                For j As Integer = i To contador - 2
                    placa(j) = placa(j + 1)
                    tipo(j) = tipo(j + 1)
                    kmInicial(j) = kmInicial(j + 1)
                    kmFinal(j) = kmFinal(j + 1)
                    pago(j) = pago(j + 1)
                Next
                contador -= 1
                MsgBox("Registro eliminado.")
                Exit Sub
            End If
        Next
        MsgBox("Placa no encontrada.")
    End Sub


    Private Sub Limpiar()
        ' limpiar los campos de entrada
        txtPlaca.Clear()
        txtInicial.Clear()
        txtFinal.Clear()
        cboTipo.SelectedIndex = -1
        dgvDatos.Rows.Clear()

    End Sub

    Private Sub LimpiarVectores()
        contador = 0
        Array.Clear(placa, 0, placa.Length)
        Array.Clear(tipo, 0, tipo.Length)
        Array.Clear(kmInicial, 0, kmInicial.Length)
        Array.Clear(kmFinal, 0, kmFinal.Length)
        Array.Clear(pago, 0, pago.Length)
        MsgBox("Vectores limpiados.")
    End Sub

    Private Sub Salir()
        If MsgBox("¿Desea salir del programa?", vbYesNo + vbQuestion) = vbYes Then
            End
        End If
    End Sub

    Private Sub Estadisticas()
        Dim total As Double = 0
        For i As Integer = 0 To contador - 1
            total += pago(i)
        Next
        MsgBox("Autos rentados: " & contador & vbCrLf &
           "Total general: Q" & total & vbCrLf &
           "Promedio: Q" & Format(total / contador, "0.00"))
    End Sub

    ' Asignación de eventos a los botones
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Calcular()
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Mostrar()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Consultar()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Actualizar()
    End Sub

    Private Sub btnEstadisticas_Click(sender As Object, e As EventArgs) Handles btnEstadisticas.Click
        Estadisticas()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Eliminar()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Limpiar()
    End Sub

    Private Sub btnLimpiarVectores_Click(sender As Object, e As EventArgs) Handles btnLimpiarVectores.Click
        LimpiarVectores()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Salir()
    End Sub

End Class
