Public Class Form1
    Private cliente As New Cliente()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
        dgvClientes.ReadOnly = True
        dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    ' 🔄 Cargar clientes en el DataGridView
    Private Sub CargarClientes()
        dgvClientes.DataSource = cliente.ObtenerClientes()
    End Sub

    ' ➕ Agregar nuevo cliente
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtNombre.Text = "" Or txtCorreo.Text = "" Then
            MessageBox.Show("Por favor completa todos los campos.")
            Return
        End If

        cliente.AgregarCliente(txtNombre.Text, txtCorreo.Text)
        LimpiarCampos()
        CargarClientes()
    End Sub

    ' ✏️ Actualizar cliente
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtId.Text = "" Then
            MessageBox.Show("Selecciona un cliente para actualizar.")
            Return
        End If

        cliente.ActualizarCliente(CInt(txtId.Text), txtNombre.Text, txtCorreo.Text)
        LimpiarCampos()
        CargarClientes()
    End Sub

    ' ❌ Eliminar cliente
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If txtId.Text = "" Then
            MessageBox.Show("Selecciona un cliente para eliminar.")
            Return
        End If

        Dim confirm As DialogResult = MessageBox.Show("¿Deseas eliminar este cliente?", "Confirmar", MessageBoxButtons.YesNo)
        If confirm = DialogResult.Yes Then
            cliente.EliminarCliente(CInt(txtId.Text))
            LimpiarCampos()
            CargarClientes()
        End If
    End Sub

    ' 📋 Cargar datos del DataGridView al seleccionar fila
    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        If e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = dgvClientes.Rows(e.RowIndex)
            txtId.Text = fila.Cells("id").Value.ToString()
            txtNombre.Text = fila.Cells("nombre").Value.ToString()
            txtCorreo.Text = fila.Cells("correo").Value.ToString()
        End If
    End Sub

    ' 🔄 Botón para recargar datos
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        CargarClientes()
    End Sub

    ' 🧹 Limpiar los campos
    Private Sub LimpiarCampos()
        txtId.Clear()
        txtNombre.Clear()
        txtCorreo.Clear()
    End Sub
End Class