-- Crear la base de datos | Create the database
CREATE DATABASE CRUDconEntityFramework;
GO

-- Usar la base de datos recién creada | Use the newly created database
USE CRUDconEntityFramework;
GO

-- Crear la tabla Personas3 | Create the People3 table
CREATE TABLE Personas3 (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(120) NOT NULL,
    Correo VARCHAR(120) NOT NULL,
    [Fecha de Nacimiento] DATE NOT NULL
);
GO