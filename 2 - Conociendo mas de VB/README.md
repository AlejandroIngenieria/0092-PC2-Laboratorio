## 🔐 MODIFICADORES DE ACCESO

| Modificador        | Accesibilidad                                                                 |
| ------------------ | ----------------------------------------------------------------------------- |
| `Public`           | Accesible desde cualquier parte del proyecto o incluso otros ensamblados      |
| `Private`          | Solo dentro del mismo bloque, clase o módulo                                  |
| `Friend`           | Solo dentro del mismo ensamblado o proyecto                                   |
| `Protected`        | Dentro de la misma clase o clases derivadas                                   |
| `Protected Friend` | En el mismo proyecto y subclases heredadas, incluso si están en otro proyecto |

---

## 🔁 SUBRUTINAS Y FUNCIONES

### 🔹 SUBRUTINA (Sub)

* Bloque de código que **no retorna valor**.
* Se usa para realizar acciones (mostrar, guardar, procesar, etc.).

**Sintaxis básica:**

```vb
Sub NombreSub()
   ' Código
End Sub
```

**Ejemplo de uso:**

```vb
Call NombreSub()
```

---

### 🔹 FUNCIÓN (Function)

* Bloque de código que **retorna un valor**.
* Facilita reutilización, segmentación y claridad del código.

**Sintaxis básica:**

```vb
Function NombreFuncion(parametros) As Tipo
   ' Código
   Return resultado
End Function
```

**Ejemplo de uso:**

```vb
Dim resultado As Integer = NombreFuncion(argumentos)
```

---

### 📌 ¿Dónde SÍ se pueden declarar funciones o subrutinas?

| Lugar       | Descripción                                                    |
| ----------- | -------------------------------------------------------------- |
| `Class`     | Métodos públicos, privados, protegidos, útil en POO            |
| `Module`    | Funciones globales sin necesidad de instancia                  |
| `Structure` | Funciones que operan sobre sus propios datos                   |
| `Interface` | Solo se declara la firma (sin cuerpo), se implementa en clases |

### 🚫 ¿Dónde NO se pueden declarar?

* Dentro de otra función o subrutina (no se permiten funciones anidadas)
* Fuera de clase/módulo/estructura
* Dentro de un procedimiento de evento (como `Button1_Click`)

---

## 📦 MÓDULOS

* Son **contenedores** de funciones, subrutinas y variables globales.
* Se declaran con `Module`.
* Solo existe **una instancia** por aplicación.

### 🧠 ¿Para qué sirven?

* Agrupar funciones compartidas
* Declarar constantes/configuraciones
* Subrutinas generales no asociadas a clases
* Reutilización de código

**Ejemplo de declaración:**

```vb
Module Utilidades
   ' funciones y subrutinas aquí
End Module
```

---

## ❗ MANEJO DE ERRORES: `Try ... Catch ... Finally`

### 🛠 TRY ... CATCH

Permite capturar errores sin detener la ejecución.

**Estructura:**

```vb
Try
   ' Código potencialmente riesgoso
Catch ex As Exception
   ' Manejo del error
End Try
```

### 🧹 TRY ... CATCH ... FINALLY

El bloque `Finally` **siempre se ejecuta**, ocurra o no un error.

**Estructura completa:**

```vb
Try
   ' Código principal
Catch ex As Exception
   ' Código para manejar la excepción
Finally
   ' Código que siempre se ejecuta (limpieza)
End Try
```

📎 Más info:
[Documentación oficial Microsoft - Try...Catch...Finally](https://learn.microsoft.com/es-es/dotnet/visual-basic/language-reference/statements/try-catch-finally-statement)
