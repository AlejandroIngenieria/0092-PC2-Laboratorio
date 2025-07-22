# Introducción a la programación en Visual Basic

## 🎯 Índice

1. [Controles](#-controles-en-visual-basic)
2. [Eventos](#-eventos-en-visual-basic)
3. [Variables y operadores](#-variables-y--operadores)
4. [Sentencias condicionales](#-sentencias-condicionales)

---

## 🎛 CONTROLES EN VISUAL BASIC

### ➤ ¿Qué son?

Son elementos visuales (botones, cajas de texto, etiquetas, etc.) que permiten al usuario interactuar con la aplicación.

### 📋 Tabla de controles

| Control            | Descripción                                |
| ------------------ | ------------------------------------------ |
| **Label**          | Muestra texto estático al usuario.         |
| **TextBox**        | Permite ingresar o editar texto.           |
| **Button**         | Ejecuta una acción al hacer clic.          |
| **CheckBox**       | Selección independiente.                   |
| **RadioButton**    | Selección única dentro de un grupo.        |
| **ComboBox**       | Lista desplegable de opciones.             |
| **ListBox**        | Lista con selección de uno o varios ítems. |
| **PictureBox**     | Muestra imágenes (JPG, PNG, BMP).          |
| **GroupBox**       | Agrupa controles relacionados.             |
| **Panel**          | Contenedor flexible.                       |
| **Timer**          | Ejecuta eventos a intervalos de tiempo.    |
| **ProgressBar**    | Muestra progreso de una tarea.             |
| **DateTimePicker** | Selector de fecha/hora.                    |
| **DataGridView**   | Muestra y organiza datos tabulares.        |
| **TrackBar**       | Selección dentro de un rango.              |
| **TabControl**     | Contiene pestañas para distintas vistas.   |

---

## ⚙️ PROPIEDADES MÁS COMUNES

| Propiedad        | Descripción                                     |
| ---------------- | ----------------------------------------------- |
| **Name**         | Nombre interno del control.                     |
| **Text**         | Texto visible del control.                      |
| **Enabled**      | Control habilitado o deshabilitado.             |
| **Visible**      | Control visible o no.                           |
| **BackColor**    | Color de fondo.                                 |
| **ForeColor**    | Color del texto.                                |
| **Font**         | Tipo, tamaño y estilo de fuente.                |
| **Size**         | Tamaño del control.                             |
| **Location**     | Posición dentro del formulario.                 |
| **TabIndex**     | Orden al navegar con TAB.                       |
| **TabStop**      | Recibe foco con TAB.                            |
| **Items**        | Lista de elementos (ComboBox, ListBox).         |
| **SelectedItem** | Ítem seleccionado.                              |
| **Checked**      | Define si está marcado (CheckBox, RadioButton). |
| **ReadOnly**     | Solo lectura en TextBox.                        |
| **MaxLength**    | Máximo de caracteres en TextBox.                |
| **Multiline**    | Permite múltiples líneas en TextBox.            |
| **Anchor**       | Comportamiento al redimensionar formulario.     |

---

## ⚡ EVENTOS EN VISUAL BASIC

### ➤ ¿Qué son?

Acciones del usuario o sistema (clics, escritura, carga de formulario, etc.) que desencadenan código.

### 📋 Tabla de eventos comunes

| Control      | Evento                 | Descripción                        |
| ------------ | ---------------------- | ---------------------------------- |
| **Button**   | `Click`                | Clic del usuario en el botón.      |
| **TextBox**  | `TextChanged`          | Cambia el texto.                   |
| **Form**     | `Load`                 | Al abrir el formulario.            |
| **Timer**    | `Tick`                 | En intervalos de tiempo definidos. |
| **ComboBox** | `SelectedIndexChanged` | Al seleccionar una nueva opción.   |

---

## 📦 VARIABLES Y ➕ OPERADORES

### ➤ Variables

Se usan para almacenar datos temporales como texto, números, fechas o valores lógicos.

### 📋 Tipos de variables

| Tipo    | Descripción                          |
| ------- | ------------------------------------ |
| Integer | Números enteros.                     |
| Double  | Números con decimales.               |
| String  | Cadenas de texto.                    |
| Boolean | Valores `True` o `False`.            |
| Date    | Fechas y horas.                      |
| Char    | Un solo carácter.                    |
| Decimal | Números decimales de alta precisión. |
| Byte    | Enteros entre 0 y 255.               |

---

### ➕ Operadores Aritméticos

| Operador | Descripción      |
| -------- | ---------------- |
| `+`      | Suma             |
| `-`      | Resta            |
| `*`      | Multiplicación   |
| `/`      | División decimal |
| `\`      | División entera  |
| `Mod`    | Residuo (módulo) |
| `^`      | Potencia         |

---

### 🔍 Operadores Relacionales

| Operador | Significado   |
| -------- | ------------- |
| `=`      | Igual a       |
| `<>`     | Diferente     |
| `>`      | Mayor que     |
| `<`      | Menor que     |
| `>=`     | Mayor o igual |
| `<=`     | Menor o igual |

---

### 🔗 Operadores Lógicos

| Operador  | Descripción                      |
| --------- | -------------------------------- |
| `And`     | Ambas condiciones verdaderas     |
| `Or`      | Al menos una condición verdadera |
| `Not`     | Invierte el valor lógico         |
| `AndAlso` | Igual a And, más eficiente       |
| `OrElse`  | Igual a Or, más eficiente        |
| `Xor`     | Solo una condición verdadera     |

---

### 🔢 Precedencia de Operadores

| Prioridad | Operador(es)                   | Descripción                      |
| --------- | ------------------------------ | -------------------------------- |
| 1         | `^`                            | Potencia                         |
| 2         | `-` (unario)                   | Negación de valor numérico       |
| 3         | `*`, `/`, `\`, `Mod`           | Multiplicación, división, módulo |
| 4         | `+`, `-`                       | Suma y resta                     |
| 5         | Relacionales (`=`, `<>`, etc.) | Comparaciones                    |
| 6         | `Not`                          | Negación lógica                  |
| 7         | `And`, `AndAlso`               | Conjunción lógica                |
| 8         | `Or`, `OrElse`, `Xor`          | Disyunción / exclusión lógica    |

---

## 🧠 SENTENCIAS CONDICIONALES

### ➤ ¿Qué son?

Permiten tomar decisiones según condiciones y ejecutar diferentes bloques de código.

### 📋 Tabla de estructuras condicionales

| Sentencia               | Descripción                                          |
| ----------------------- | ---------------------------------------------------- |
| `If...Then`             | Ejecuta si la condición es verdadera.                |
| `If...Then...Else`      | Ejecuta un bloque si es verdadera, otro si es falsa. |
| `If...Then...ElseIf`    | Evalúa múltiples condiciones.                        |
| `Select Case`           | Evalúa una expresión contra varios valores.          |
| `IIf(cond, val1, val2)` | Devuelve un valor según la condición.                |

---

### 🧪 Ejemplos

| Sentencia     | Ejemplo                                     |
| ------------- | ------------------------------------------- |
| `If...Then`   | `If x > 0 Then MsgBox("Positivo")`          |
| `If...Else`   | `If x > 0 Then ... Else ... End If`         |
| `ElseIf`      | `If x > 0 Then ... ElseIf x < 0 Then ...`   |
| `Select Case` | `Select Case x ... Case 1: ... Case 2: ...` |
| `IIf`         | `IIf(x > 0, "Sí", "No")`                    |

---

## 🧪 EJERCICIOS PRÁCTICOS

| Ejercicio | Enunciado                  | Controles Sugeridos                   | Sentencia                     |
| --------- | -------------------------- | ------------------------------------- | ----------------------------- |
| 1         | Edad mínima para votar     | TextBox, Button, Label                | `If edad >= 18 Then`          |
| 2         | Número positivo o negativo | TextBox, Button, Label                | `If numero > 0 Then`          |
| 3         | Verificación de contraseña | TextBox (PasswordChar), Button, Label | `If contrasena = "1234" Then` |
| 4         | Verificación de número par | TextBox, Button, Label                | `If numero Mod 2 = 0 Then`    |
| 5         | Calificación aprobatoria   | TextBox, Button, Label                | `If nota > 60 Then`           |

