# Base de datos del ejemplo
```sql
-- Crear base de datos y usarla
CREATE DATABASE clientes;
USE clientes;

-- Crear tabla
CREATE TABLE usuarios (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    correo VARCHAR(100)
);
```
