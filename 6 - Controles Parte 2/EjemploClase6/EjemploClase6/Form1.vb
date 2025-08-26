Public Class Form1

    'Crear la subrutina al dar click al a cada panel y controles dentro del panel dentro del flowlayout
    Public Sub panel_Click(sender As Object, e As EventArgs)
        ' Obtener el panel que se ha clickeado
        Dim panelClickeado As Panel = Nothing
        If TypeOf sender Is Panel Then
            panelClickeado = CType(sender, Panel)
        ElseIf TypeOf sender Is PictureBox Or TypeOf sender Is Label Then
            panelClickeado = CType(CType(sender, Control).Parent, Panel)
        End If
        If panelClickeado IsNot Nothing Then
            ' Obtener el indice del panel clickeado en el flowlayout
            Dim indice As Integer = flowPanel.Controls.IndexOf(panelClickeado)
            ' Mostrar un mensaje con la informacion del animal correspondiente al indice
            Dim animal As Animal = listaAnimales(indice)
            MessageBox.Show("Nombre: " & animal.Nombre & vbCrLf & "Especie: " & animal.Especie & vbCrLf & "Edad: " & animal.Edad & " años", "Información del Animal")
        End If
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
        ' Agregar el evento click al panel1
        AddHandler panel1.Click, AddressOf panel_Click
        ' Agregar el evento click al picturebox y label del panel1 para que tambien respondan al click
        AddHandler picAnimal1.Click, AddressOf panel_Click
        AddHandler lblAnimal1.Click, AddressOf panel_Click

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
        ' Agregar el evento click al panel2
        AddHandler panel2.Click, AddressOf panel_Click
        ' Agregar el evento click al picturebox y label del panel2 para que tambien respondan al click
        AddHandler picAnimal2.Click, AddressOf panel_Click
        AddHandler lblAnimal2.Click, AddressOf panel_Click

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
        ' Agregar el evento click al panel3
        AddHandler panel3.Click, AddressOf panel_Click
        ' Agregar el evento click al picturebox y label del panel3 para que tambien respondan al click
        AddHandler picAnimal3.Click, AddressOf panel_Click
        AddHandler lblAnimal3.Click, AddressOf panel_Click

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
        ' Agregar el evento click al panel4
        AddHandler panel4.Click, AddressOf panel_Click
        ' Agregar el evento click al picturebox y label del panel4 para que tambien respondan al click
        AddHandler picAnimal4.Click, AddressOf panel_Click
        AddHandler lblAnimal4.Click, AddressOf panel_Click


        ' Ingresar la lista al datagridview
        gridAnimales.DataSource = listaAnimales
        gridAnimales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Agregar la imagen al picturebox piclogo
        piclogo.Load("https://i.pinimg.com/736x/0d/d3/cf/0dd3cfaf001a903e769bdf263dc885af.jpg")
        piclogo.SizeMode = PictureBoxSizeMode.StretchImage


    End Sub
End Class
