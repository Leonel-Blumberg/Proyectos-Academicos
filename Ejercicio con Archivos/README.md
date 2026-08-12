*[Read this in English](README.en.md)*

# Ejercicio con Archivos

Aplicación de consola en C# que gestiona un registro de alumnos persistido en
un archivo de texto plano, sin base de datos. Permite cargar, buscar,
modificar y eliminar alumnos, y generar listados ordenados por dos criterios
distintos: apellido y nombre, o código de alumno.

Cada alumno se guarda como una línea del archivo con los campos separados por
`|`, y se reconstruye al leerlo. La entrada del usuario se valida campo por
campo antes de escribir, y las operaciones de modificación y borrado
identifican al alumno por su código para no afectar otros registros.

## Capturas

**Carga de alumnos**

![Carga de alumnos](docs/capturas/carga-datos.png)

**Listados ordenados y borrado**

![Listados ordenados y borrado](docs/capturas/listados.png)

**Listado luego de eliminar un alumno**

![Listado luego de eliminar](docs/capturas/listado-final.png)

## Requisitos Previos

Para abrir y ejecutar este proyecto en tu entorno local, necesitas tener instalado:

* .NET 8 SDK
* Visual Studio 2022

## Cómo ejecutar el proyecto

1. Clona o descarga este repositorio en tu computadora.
2. Abre el archivo `Ejercicio con Archivos.sln` en Visual Studio.
3. Presiona el botón **Iniciar** (o F5) para compilar y ejecutar la aplicación.

El archivo `ListaAlumnos.txt` se crea automáticamente la primera vez que se
carga un alumno.

---

## Autor

**Leonel Maximiliano Blumberg**
Desarrollador de Software | .NET · C# · ASP.NET · SQL | Estudiante de Ing. en Sistemas

[LinkedIn](https://www.linkedin.com/in/leonel-blumberg) · [GitHub](https://github.com/Leonel-Blumberg) · [Email](mailto:leonelblumberg.it@gmail.com)