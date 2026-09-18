*[Read this in English](README.en.md)*

# Sistema de Gestión de Biblioteca

Aplicación de escritorio en C# con Windows Forms para administrar una
biblioteca: el catálogo de libros, los socios y los préstamos. Los datos se
guardan en SQL Server con Entity Framework Core, usando el enfoque Code-First.

La solución está separada en cuatro proyectos, uno por capa:

* **Vista**: el formulario. Valida lo que se carga y le pide todo a la controladora.
* **Controladora**: las reglas de negocio, como que un libro prestado no se puede
  volver a prestar o que la devolución tiene que ser posterior al préstamo.
* **Modelo**: el contexto de Entity Framework, la migración y un repositorio por
  entidad.
* **Entidades**: las clases Libro, Socio y Prestamo.

El estado de cada libro lo maneja la aplicación. Pasa a "Prestado" al registrar
un préstamo y vuelve a "Disponible" cuando se devuelve, cuando el préstamo se
cambia a otro libro o cuando se elimina al socio que lo tenía.

## Capturas

**Libros, socios y préstamos cargados, con dos libros prestados**

![Sistema de Gestión de Biblioteca](docs/capturas/captura-1.png)

## Requisitos Previos

Para abrir y ejecutar este proyecto en tu entorno local, necesitas tener instalado:

* .NET 8 SDK
* Visual Studio 2022
* SQL Server (Express o Developer)

## Configuración de la Base de Datos

La base se llama `SistemaGestionBibliotecaDB` y se crea a partir de la migración
incluida en el proyecto Modelo. La cadena de conexión usa autenticación de
Windows (`Integrated Security=True`).

1. Clona o descarga este repositorio en tu computadora.
2. Abre el archivo `Sistema de Gestion de Biblioteca.sln` en Visual Studio.
3. Si tu servidor no se llama `.\SQLEXPRESS`, abre la clase `Context` del
   proyecto **Modelo** y cambia el `Data Source` de la cadena de conexión.
4. Establece **Vista** como proyecto de inicio.
5. Abre la **Consola del Administrador de paquetes**, elige **Modelo** como
   proyecto predeterminado y ejecuta:
   ```powershell
   Update-Database
   ```
6. Presiona el botón **Iniciar** (o F5) para compilar y ejecutar la aplicación.

---

## Autor

**Leonel Maximiliano Blumberg**<br>
Desarrollador de Software | .NET · C# · ASP.NET · SQL | Estudiante de Ing. en Sistemas

[LinkedIn](https://www.linkedin.com/in/leonel-blumberg) · [GitHub](https://github.com/Leonel-Blumberg) · [Email](mailto:leonelblumberg.it@gmail.com)
