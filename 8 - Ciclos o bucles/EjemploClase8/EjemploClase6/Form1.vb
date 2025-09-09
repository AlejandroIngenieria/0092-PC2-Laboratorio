Public Class Form1
    Private Sub MiSubrutinaConParametros(nombre As String, edad As Integer)
        MessageBox.Show($"Nombre: {nombre}, Edad: {edad}")
    End Sub

    Public Sub mostrarInfoAnimal(animal As Animal)
        MessageBox.Show($"Nombre: {animal.Nombre}{vbCrLf}Edad: {animal.Edad}{vbCrLf}Especie: {animal.Especie}")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarAnimales()


        For Each animal In listaAnimales
            ' Vamos a añadir un picturebox y un label por cada animal en la lista, lo agregaremos a un panel individual y este panel al flowlayout
            ' Aqui declaramos el panel
            Dim panel1 As New Panel()
            ' Ajustamos las propiedades del panel
            panel1.Width = 400 'Ancho del panel
            panel1.Height = 500 ' Alto del panel
            panel1.BorderStyle = BorderStyle.FixedSingle ' Borde del panel
            panel1.BackColor = ColorTranslator.FromHtml("#3F4F44") ' Color de fondo del panel
            flowPanel.Controls.Add(panel1) ' Agregamos el panel al flowlayout
            Dim picAnimal1 As New PictureBox() ' Declaramos el picturebox
            ' Ajustamos las propiedades del picturebox
            picAnimal1.Width = 400 'Ancho del picturebox
            picAnimal1.Height = 400 ' Alto del picturebox
            picAnimal1.SizeMode = PictureBoxSizeMode.StretchImage ' Ajustamos la imagen al tamaño del picturebox
            picAnimal1.Load(animal.URL)
            panel1.Controls.Add(picAnimal1)
            Dim lblAnimal1 As New Label()
            lblAnimal1.ForeColor = Color.White
            lblAnimal1.Text = animal.Nombre & " - " & animal.Especie & " - " & animal.Edad & " años"
            lblAnimal1.Top = picAnimal1.Bottom + 10
            lblAnimal1.Width = 400
            panel1.Controls.Add(lblAnimal1)
            AddHandler lblAnimal1.Click, Sub(s, ev) mostrarInfoAnimal(animal)
            AddHandler picAnimal1.Click, Sub(s, ev) mostrarInfoAnimal(animal)
            AddHandler panel1.Click, Sub(s, ev) mostrarInfoAnimal(animal)
        Next

        ActualizarGrid()

        ' Agregar la imagen al picturebox piclogo
        piclogo.Load("https://i.pinimg.com/736x/0d/d3/cf/0dd3cfaf001a903e769bdf263dc885af.jpg")
        piclogo.SizeMode = PictureBoxSizeMode.StretchImage


    End Sub

    Private Sub btnAdminAgregar_Click(sender As Object, e As EventArgs) Handles btnAdminAgregar.Click
        ' Si el fomulario esta abierto esperar a que se cierre para ejecutar el siguiente codigo
        AgregarAnimal.Show()
    End Sub

    Public Sub ActualizarGrid()
        gridAnimales.DataSource = Nothing
        gridAnimales.DataSource = listaAnimales
        gridAnimales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

End Class
