# 📘 Asociar subrutinas y funciones con parámetros personalizados a controles dinámicos en VB.NET Windows Forms

---

## 🔹 1. Crear un control en tiempo de ejecución

Para crear un botón desde código:

```vbnet
Dim boton As New Button()
boton.Text = "Saludar"
boton.Location = New Point(50, 50)
Controls.Add(boton)
```

Con esto ya tienes un botón dentro del formulario.

---

## 🔹 2. Asociar una **subrutina** al evento

Los eventos en Windows Forms esperan siempre una subrutina con la forma:

```vbnet
Sub NombreDelEvento(sender As Object, e As EventArgs)
```

Ejemplo con un botón:

```vbnet
AddHandler boton.Click, AddressOf Boton_Click

Private Sub Boton_Click(sender As Object, e As EventArgs)
    MessageBox.Show("Presionaste el botón")
End Sub
```

---

## 🔹 3. Subrutina con **parámetros propios**

Si quieres que tu subrutina tenga parámetros diferentes, se hace un "puente":

```vbnet
AddHandler boton.Click, Sub(s, ev) MiSubrutinaConParametros("Josue", 27)

Private Sub MiSubrutinaConParametros(nombre As String, edad As Integer)
    MessageBox.Show($"Nombre: {nombre}, Edad: {edad}")
End Sub
```

👉 Aquí el evento `Click` llama a `MiSubrutinaConParametros` con los parámetros que tú quieras.

---

## 🔹 4. Asociar una **función** que devuelve valores

También puedes llamar funciones personalizadas desde un evento:

```vbnet
AddHandler boton.Click, Sub(s, ev)
                            Dim resultado As String = MiFuncionConParametros("Apellido", 2021)
                            MessageBox.Show("Resultado: " & resultado)
                        End Sub

Private Function MiFuncionConParametros(apellido As String, anio As Integer) As String
    Return $"{apellido} - Edad aprox: {Now.Year - anio}"
End Function
```

👉 Cuando haces clic, la función se ejecuta y su resultado se muestra en pantalla.

---

## 🔹 5. Usar la propiedad **Tag** para guardar un valor

Cada control tiene una propiedad llamada **Tag**, que puedes usar para guardar un dato que luego recuperarás en la subrutina.

```vbnet
Dim boton2 As New Button()
boton2.Text = "Botón con Tag"
boton2.Tag = "Dato guardado"
boton2.Location = New Point(50, 120)
Controls.Add(boton2)

AddHandler boton2.Click, AddressOf BotonConTag_Click

Private Sub BotonConTag_Click(sender As Object, e As EventArgs)
    Dim btn As Button = DirectCast(sender, Button)
    Dim dato As String = DirectCast(btn.Tag, String)
    MessageBox.Show("El dato del botón es: " & dato)
End Sub
```