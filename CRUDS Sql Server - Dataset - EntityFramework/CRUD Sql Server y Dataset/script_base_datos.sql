-- Crear la base de datos | Create the database
CREATE DATABASE CRUDconDataset;
GO

-- Usar la base de datos recién creada | Use the newly created database
USE CRUDconDataset;
GO

-- Crear la tabla Personas2 | Create the People2 table
CREATE TABLE Personas2 (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Edad INT NOT NULL,
    Sexo NVARCHAR(20) NOT NULL
);
GO