Public Class Form4
    ' Declaración del Panel y los 12 botones
    Private WithEvents Panel1 As New Panel()
    Private WithEvents btn1 As New Button()
    Private WithEvents btn2 As New Button()
    Private WithEvents btn3 As New Button()
    Private WithEvents btn4 As New Button()
    Private WithEvents btn5 As New Button()
    Private WithEvents btn6 As New Button()
    Private WithEvents btn7 As New Button()
    Private WithEvents btn8 As New Button()
    Private WithEvents btn9 As New Button()
    Private WithEvents btn10 As New Button()
    Private WithEvents btn11 As New Button()
    Private WithEvents btn12 As New Button()

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración del formulario
        Text = "Panel con Botones Grandes"
        ClientSize = New Size(600, 500)
        StartPosition = FormStartPosition.CenterScreen

        ' Configuración del Panel con AutoScroll
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Size = New Size(550, 400) ' Tamaño visible del panel
        Panel1.Location = New Point(20, 20)
        Panel1.AutoScroll = True ' Activar el scroll automático
        Panel1.AutoScrollMinSize = New Size(500, 1200) ' Tamaño total del área desplazable

        ' ===== CREACIÓN MANUAL DE LOS 12 BOTONES GRANDES =====

        ' Fila 1 de botones
        btn1.Text = "Botón 1"
        btn1.Size = New Size(180, 80) ' Botones más grandes
        btn1.Location = New Point(30, 30) ' Más espacio entre botones
        btn1.Font = New Font("Arial", 12, FontStyle.Bold) ' Texto más grande
        btn1.BackColor = Color.LightBlue
        Panel1.Controls.Add(btn1)

        btn2.Text = "Botón 2"
        btn2.Size = New Size(180, 80)
        btn2.Location = New Point(250, 30)
        btn2.Font = New Font("Arial", 12, FontStyle.Bold)
        btn2.BackColor = Color.LightGreen
        Panel1.Controls.Add(btn2)

        ' Fila 2 de botones
        btn3.Text = "Botón 3"
        btn3.Size = New Size(180, 80)
        btn3.Location = New Point(30, 150) ' Más espacio vertical
        btn3.Font = New Font("Arial", 12, FontStyle.Bold)
        btn3.BackColor = Color.LightPink
        Panel1.Controls.Add(btn3)

        btn4.Text = "Botón 4"
        btn4.Size = New Size(180, 80)
        btn4.Location = New Point(250, 150)
        btn4.Font = New Font("Arial", 12, FontStyle.Bold)
        btn4.BackColor = Color.LightYellow
        Panel1.Controls.Add(btn4)

        ' Fila 3 de botones
        btn5.Text = "Botón 5"
        btn5.Size = New Size(180, 80)
        btn5.Location = New Point(30, 270)
        btn5.Font = New Font("Arial", 12, FontStyle.Bold)
        btn5.BackColor = Color.LightSalmon
        Panel1.Controls.Add(btn5)

        btn6.Text = "Botón 6"
        btn6.Size = New Size(180, 80)
        btn6.Location = New Point(250, 270)
        btn6.Font = New Font("Arial", 12, FontStyle.Bold)
        btn6.BackColor = Color.LightSeaGreen
        Panel1.Controls.Add(btn6)

        ' Fila 4 de botones
        btn7.Text = "Botón 7"
        btn7.Size = New Size(180, 80)
        btn7.Location = New Point(30, 390)
        btn7.Font = New Font("Arial", 12, FontStyle.Bold)
        btn7.BackColor = Color.LightSkyBlue
        Panel1.Controls.Add(btn7)

        btn8.Text = "Botón 8"
        btn8.Size = New Size(180, 80)
        btn8.Location = New Point(250, 390)
        btn8.Font = New Font("Arial", 12, FontStyle.Bold)
        btn8.BackColor = Color.LightGoldenrodYellow
        Panel1.Controls.Add(btn8)

        ' Fila 5 de botones
        btn9.Text = "Botón 9"
        btn9.Size = New Size(180, 80)
        btn9.Location = New Point(30, 510)
        btn9.Font = New Font("Arial", 12, FontStyle.Bold)
        btn9.BackColor = Color.LightCoral
        Panel1.Controls.Add(btn9)

        btn10.Text = "Botón 10"
        btn10.Size = New Size(180, 80)
        btn10.Location = New Point(250, 510)
        btn10.Font = New Font("Arial", 12, FontStyle.Bold)
        btn10.BackColor = Color.LightCyan
        Panel1.Controls.Add(btn10)

        ' Fila 6 de botones
        btn11.Text = "Botón 11"
        btn11.Size = New Size(180, 80)
        btn11.Location = New Point(30, 630)
        btn11.Font = New Font("Arial", 12, FontStyle.Bold)
        btn11.BackColor = Color.LightSteelBlue
        Panel1.Controls.Add(btn11)

        btn12.Text = "Botón 12"
        btn12.Size = New Size(180, 80)
        btn12.Location = New Point(250, 630)
        btn12.Font = New Font("Arial", 12, FontStyle.Bold)
        btn12.BackColor = Color.LightGray
        Panel1.Controls.Add(btn12)



        ' Agregar el Panel al formulario
        Controls.Add(Panel1)

        ' Asignar el mismo evento a todos los botones
        AddHandler btn1.Click, AddressOf BotonClickeado
        AddHandler btn2.Click, AddressOf BotonClickeado
        AddHandler btn3.Click, AddressOf BotonClickeado
        AddHandler btn4.Click, AddressOf BotonClickeado
        AddHandler btn5.Click, AddressOf BotonClickeado
        AddHandler btn6.Click, AddressOf BotonClickeado
        AddHandler btn7.Click, AddressOf BotonClickeado
        AddHandler btn8.Click, AddressOf BotonClickeado
        AddHandler btn9.Click, AddressOf BotonClickeado
        AddHandler btn10.Click, AddressOf BotonClickeado
        AddHandler btn11.Click, AddressOf BotonClickeado
        AddHandler btn12.Click, AddressOf BotonClickeado
    End Sub



    Private Sub BotonClickeado(sender As Object, e As EventArgs)
        MsgBox(sender.Text)
    End Sub
End Class