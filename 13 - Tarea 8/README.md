## Diseño del formulario

### Elementos principales
| Tipo de control | Nombre       | Propósito / Texto                |
| --------------- | ------------ | -------------------------------- |
| Label           | `Label4`     | Título: “Información inicial”    |
| Label           | `Label1`     | “Ingresar número de placa”       |
| TextBox         | `txtPlaca`   | Ingreso del número de placa      |
| Label           | `Label2`     | “Seleccionar tipo de auto (1–4)” |
| ComboBox        | `cboTipo`    | Selección del tipo de auto       |
| Label           | `Label3`     | Título “Kilometraje”             |
| Label           | `Label5`     | “Inicial”                        |
| TextBox         | `txtInicial` | Ingreso de km inicial            |
| Label           | `Label6`     | “Final”                          |
| TextBox         | `txtFinal`   | Ingreso de km final              |
| DataGridView    | `dgvDatos`   | Muestra los datos almacenados    |
| MenuStrip       | `MenuStrip1` | Barra de menú principal          |


### Elementos del MenuStrip
| Nombre               | Texto visible    | Acción                                  |
| -------------------- | ---------------- | --------------------------------------- |
| `btnCalcular`        | Calcular         | Calcula y guarda en vectores            |
| `btnMostrar`         | Mostrar          | Muestra los registros en la tabla       |
| `btnConsultar`       | Consultar        | Busca un registro por placa             |
| `btnActualizar`      | Actualizar       | Modifica datos de un registro existente |
| `btnEstadisticas`    | Estadísticas     | Muestra totales y promedio              |
| `btnEliminar`        | Eliminar         | Elimina un registro específico          |
| `btnLimpiar`         | Limpiar          | Limpia los campos visuales              |
| `btnLimpiarVectores` | Limpiar vectores | Reinicia todos los vectores             |
| `btnSalir`           | Salir            | Cierra el programa con confirmación     |

## Modulo para declarar los arreglos y variables
```vb
Module Datos
    ' Arreglos para almacenar la información de los vehículos
    Public placa(6) As String
    Public tipo(6) As Integer
    Public kmInicial(6) As Double
    Public kmFinal(6) As Double
    Public pago(6) As Double
    ' Contador para llevar el registro del número de vehículos ingresados
    Public contador As Integer = 0
End Module
```

## Lógica del Form1
### Evento Load
Inicialmente declaramos las columnas del **DataGriVview**.
Hacemos esto porque no estamos usando alguna estructura como un **objeto** para que el **DataGridView** pueda decifrar las columnas.
```vb
Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    If dgvDatos.Columns.Count = 0 Then
        dgvDatos.Columns.Add("Placa", "Placa")
        dgvDatos.Columns.Add("Tipo", "Tipo")
        dgvDatos.Columns.Add("KmInicial", "KmInicial")
        dgvDatos.Columns.Add("KmFinal", "KmFinal")
        dgvDatos.Columns.Add("Pago", "Pago")
    End If
End Sub
```

### Subrutina para Calcular
Realizamos el calulo del pago y guardamos los resultados en los vectores.

```vb
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

```

### Subrutina para mostrar los registros
Con ayuda del contador que incrementa en cada calculo usamos un **ciclo For** para recorrer los arreglos y agregarlos uno a uno al **DataGridView**.
```vb
Private Sub Mostrar()
    dgvDatos.Rows.Clear()
    For i As Integer = 0 To contador - 1
        dgvDatos.Rows.Add(placa(i), tipo(i), kmInicial(i), kmFinal(i), pago(i))
    Next
End Sub
```

### Subrutina para consultar una placa en específico
```vb
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
```

### Subrutina para actualizar un registro
Usamos un **ciclo For** para recorrer el array de placa y encontrar alguna que coincida.
Tomamos los textos de los **textboxes** para reescribir el registro y posterior recalculamos el **pago**.
```vb
Private Sub Actualizar()
    Dim buscar As String = txtPlaca.Text
    Dim encontrado As Boolean = False

    For i As Integer = 0 To contador - 1
        If placa(i) = buscar Then
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
```

### Subrutina para eliminar un registro
Al igual que con actualizar usamos el texto del textbox de placas para luego con un ciclo For buscar en el array de placa alguna que coincida y posterior a ello los registros que esten un indice despues del registro a eliminar los retrosedemos un paso hacia atras para borrar por completo el registro objetivo.

```vb
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
```

### Subrutina para limpiar los controles
Aquí simplemente limpiamos lo que ve el usuario en el programa pero no afectamos los datos.
```vb
Private Sub Limpiar()
    txtPlaca.Clear()
    txtInicial.Clear()
    txtFinal.Clear()
    cboTipo.SelectedIndex = -1
    dgvDatos.Rows.Clear()
End Sub
```

### Subrutina para limpiar los vectores
Aqui afectamos los datos directamente borrando todos los registros en su totalidad.
```vb
Private Sub LimpiarVectores()
    contador = 0
    Array.Clear(placa, 0, placa.Length)
    Array.Clear(tipo, 0, tipo.Length)
    Array.Clear(kmInicial, 0, kmInicial.Length)
    Array.Clear(kmFinal, 0, kmFinal.Length)
    Array.Clear(pago, 0, pago.Length)
    MsgBox("Vectores limpiados.")
End Sub
```

### Subrutina de estadisticas
Ejemplo si se solicitara el cálculo de algunas estadísticas.
```vb
Private Sub Estadisticas()
    If contador = 0 Then
        MsgBox("No hay registros.")
        Exit Sub
    End If

    Dim total As Double = 0
    For i As Integer = 0 To contador - 1
        total += pago(i)
    Next

    MsgBox("Autos rentados: " & contador & vbCrLf &
           "Total general: Q" & total & vbCrLf &
           "Promedio: Q" & Format(total / contador, "0.00"))
End Sub
```

### Subrutina para salir del programa
```vb
Private Sub Salir()
    If MsgBox("¿Desea salir del programa?", vbYesNo + vbQuestion) = vbYes Then
        End
    End If
End Sub
```

## Conexión de las subrutinas con los botones del MenuStrip
```vb
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
```

## Flujo de uso

1. Ingresar placa, tipo de auto y kilometrajes.
2. Clic en Calcular → Guarda y calcula el pago.
3. Clic en Mostrar → Visualiza todos los registros.
4. Consultar, Actualizar o Eliminar por número de placa.
5. Estadísticas → Total de autos y pagos.
6. Limpiar → Borra los campos visuales.
7. Limpiar vectores → Reinicia el programa completamente.
8. Salir → Cierra el sistema con confirmación.

## Resultados
* Permite hasta 7 registros.
* Calcula correctamente el pago total.
* Muestra, busca, actualiza y elimina sin errores.
* El DataGridView refleja todos los cambios.
* Los mensajes guían al usuario correctamente.