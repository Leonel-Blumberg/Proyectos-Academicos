-- Crear la base de datos | Create the database
CREATE DATABASE CRUDconADONET;
GO

-- Usar la base de datos recién creada | Use the newly created database
USE CRUDconADONET;
GO

-- Crear la tabla Personas | Create the People table
CREATE TABLE Personas (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Edad INT NOT NULL
);
GO