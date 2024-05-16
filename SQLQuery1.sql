-- Crear la base de datos
create database DbInicioSesion;

-- Usar la base de datos recién creada
use DbInicioSesion;

-- Crear la tabla Usuarios
CREATE TABLE Usuarios
(
    NombreUsuario nvarchar(50) NOT NULL,
    Contrasena nvarchar(255) NOT NULL
)

-- Insertar datos de ejemplo
insert into Usuarios (NombreUsuario, Contrasena)
values ('Juan', 'diminombre'),
       ('Pablo', 'pablo321'),
       ('Samuel', 'samuel123')

-- Seleccionar todos los registros de la tabla Usuarios
select NombreUsuario, Contrasena
from Usuarios;