Public Class GrupoEstudiantes

    ' La lista solo sera accesible dentro de esta clase
    Private estudiantes As New List(Of Estudiante)

    Private Sub GrupoEstudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Crear algunos estudiantes
        Dim estudiante1 As New Estudiante("Ana", 20)
        Dim estudiante2 As New Estudiante("Luis", 22)
        Dim estudiante3 As New Estudiante("Marta", 19)
        estudiantes.Add(estudiante1)
        estudiantes.Add(estudiante2)
        estudiantes.Add(estudiante3)
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        ' Limpiar el flowLayoutPanel antes de agregar nuevos controles
        flpEstudiantes.Controls.Clear()

        ' Recorrer la lista de estudiantes y crear un panel con sus datos en un label\
        For Each estudiante In estudiantes
            Dim panel As New Panel()
            panel.BorderStyle = BorderStyle.FixedSingle
            panel.Width = flpEstudiantes.ClientSize.Width - 25 ' Ajustar el ancho del panel
            panel.Height = 150
            Dim lblDatos As New Label()
            lblDatos.Text = estudiante.Datos()
            lblDatos.Dock = DockStyle.Fill
            lblDatos.TextAlign = ContentAlignment.MiddleCenter
            panel.Controls.Add(lblDatos)
            flpEstudiantes.Controls.Add(panel)
        Next
    End Sub
End Class