Public Class Form1
    ' Subrutina con parametros propios, donde ingresare el indice del animal en la lista y mostrara su nombre y edad
    Public Sub mostrarInfoAnimal(indice As Integer)
        animalSeleccionado = listaAnimales(indice)
        'MessageBox.Show("Nombre: " & animal.Nombre & vbCrLf & "Edad: " & animal.Edad & " años", "Información del Animal")
        InformacionAnimal.Show()
    End Sub

    Private Sub MiSubrutinaConParametros(nombre As String, edad As Integer)
        MessageBox.Show($"Nombre: {nombre}, Edad: {edad}")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicializarAnimales()

        ' Vamos a añadir un picturebox y un label por cada animal en la lista, lo agregaremos a un panel individual y este panel al flowlayout
        Dim panel1 As New Panel()
        panel1.Width = 400
        panel1.Height = 500
        panel1.BorderStyle = BorderStyle.FixedSingle
        panel1.BackColor = ColorTranslator.FromHtml("#3F4F44")
        flowPanel.Controls.Add(panel1)

        ' Agregar el picturebox y label del animal en la posicion 0 de la lista de animales al panel1
        Dim picAnimal1 As New PictureBox()
        picAnimal1.Width = 400
        picAnimal1.Height = 400
        picAnimal1.SizeMode = PictureBoxSizeMode.StretchImage
        picAnimal1.Load(listaAnimales(0).URL)
        panel1.Controls.Add(picAnimal1)
        Dim lblAnimal1 As New Label()
        lblAnimal1.ForeColor = Color.White
        lblAnimal1.Text = listaAnimales(0).Nombre & " - " & listaAnimales(0).Especie & " - " & listaAnimales(0).Edad & " años"
        lblAnimal1.Top = picAnimal1.Bottom + 10
        lblAnimal1.Width = 400
        panel1.Controls.Add(lblAnimal1)
        AddHandler lblAnimal1.Click, Sub(s, ev) mostrarInfoAnimal(0)
        AddHandler picAnimal1.Click, Sub(s, ev) mostrarInfoAnimal(0)
        AddHandler panel1.Click, Sub(s, ev) mostrarInfoAnimal(0)


        ' Repetir para el animal en la posicion 1 de la lista de animales
        Dim panel2 As New Panel()
        panel2.Width = 400
        panel2.Height = 500
        panel2.BorderStyle = BorderStyle.FixedSingle
        panel2.BackColor = ColorTranslator.FromHtml("#3F4F44")
        flowPanel.Controls.Add(panel2)
        Dim picAnimal2 As New PictureBox()
        picAnimal2.Width = 400
        picAnimal2.Height = 400
        picAnimal2.SizeMode = PictureBoxSizeMode.StretchImage
        picAnimal2.Load(listaAnimales(1).URL)
        panel2.Controls.Add(picAnimal2)
        Dim lblAnimal2 As New Label()
        lblAnimal2.ForeColor = Color.White
        lblAnimal2.Text = listaAnimales(1).Nombre & " - " & listaAnimales(1).Especie & " - " & listaAnimales(1).Edad & " años"
        lblAnimal2.Top = picAnimal2.Bottom + 10
        lblAnimal2.Width = 400
        panel2.Controls.Add(lblAnimal2)
        AddHandler lblAnimal2.Click, Sub(s, ev) mostrarInfoAnimal(1)
        AddHandler picAnimal2.Click, Sub(s, ev) mostrarInfoAnimal(1)
        AddHandler panel2.Click, Sub(s, ev) mostrarInfoAnimal(1)

        ' Repetir para el animal en la posicion 2 de la lista de animales
        Dim panel3 As New Panel()
        panel3.Width = 400
        panel3.Height = 500
        panel3.BorderStyle = BorderStyle.FixedSingle
        panel3.BackColor = ColorTranslator.FromHtml("#3F4F44")
        flowPanel.Controls.Add(panel3)
        Dim picAnimal3 As New PictureBox()
        picAnimal3.Width = 400
        picAnimal3.Height = 400
        picAnimal3.SizeMode = PictureBoxSizeMode.StretchImage
        picAnimal3.Load(listaAnimales(2).URL)
        panel3.Controls.Add(picAnimal3)
        Dim lblAnimal3 As New Label()
        lblAnimal3.ForeColor = Color.White
        lblAnimal3.Text = listaAnimales(2).Nombre & " - " & listaAnimales(2).Especie & " - " & listaAnimales(2).Edad & " años"
        lblAnimal3.Top = picAnimal3.Bottom + 10
        lblAnimal3.Width = 400
        panel3.Controls.Add(lblAnimal3)
        AddHandler lblAnimal3.Click, Sub(s, ev) mostrarInfoAnimal(2)
        AddHandler picAnimal3.Click, Sub(s, ev) mostrarInfoAnimal(2)
        AddHandler panel3.Click, Sub(s, ev) mostrarInfoAnimal(2)

        ' Repetir para el animal en la posicion 3 de la lista de animales
        Dim panel4 As New Panel()
        panel4.Width = 400
        panel4.Height = 500
        panel4.BorderStyle = BorderStyle.FixedSingle
        panel4.BackColor = ColorTranslator.FromHtml("#3F4F44")
        flowPanel.Controls.Add(panel4)
        Dim picAnimal4 As New PictureBox()
        picAnimal4.Width = 400
        picAnimal4.Height = 400
        picAnimal4.SizeMode = PictureBoxSizeMode.StretchImage
        picAnimal4.Load(listaAnimales(3).URL)
        panel4.Controls.Add(picAnimal4)
        Dim lblAnimal4 As New Label()
        lblAnimal4.ForeColor = Color.White
        lblAnimal4.Text = listaAnimales(3).Nombre & " - " & listaAnimales(3).Especie & " - " & listaAnimales(3).Edad & " años"
        lblAnimal4.Top = picAnimal4.Bottom + 10
        lblAnimal4.Width = 400
        panel4.Controls.Add(lblAnimal4)
        AddHandler lblAnimal4.Click, Sub(s, ev) mostrarInfoAnimal(3)
        AddHandler picAnimal4.Click, Sub(s, ev) mostrarInfoAnimal(3)
        AddHandler panel4.Click, Sub(s, ev) mostrarInfoAnimal(3)


        ' Ingresar la lista al datagridview
        gridAnimales.DataSource = listaAnimales
        gridAnimales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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

        ' Agregar el ultimo elemento de la lista al flowlayout
        Dim index As Integer = listaAnimales.Count - 1
        Dim panel As New Panel()
        panel.Width = 400
        panel.Height = 500
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.BackColor = ColorTranslator.FromHtml("#3F4F44")
        flowPanel.Controls.Add(panel)
        Dim picAnimal As New PictureBox()
        picAnimal.Width = 400
        picAnimal.Height = 400
        picAnimal.SizeMode = PictureBoxSizeMode.StretchImage
        picAnimal.Load(listaAnimales(index).URL)
        panel.Controls.Add(picAnimal)
        Dim lblAnimal As New Label()
        lblAnimal.ForeColor = Color.White
        lblAnimal.Text = listaAnimales(index).Nombre & " - " & listaAnimales(index).Especie & " - " & listaAnimales(index).Edad & " años"
        lblAnimal.Top = picAnimal.Bottom + 10
        lblAnimal.Width = 400
        panel.Controls.Add(lblAnimal)
        AddHandler lblAnimal.Click, Sub(s, ev) mostrarInfoAnimal(index)

    End Sub

End Class
