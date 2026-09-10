*[Read this in English](README.en.md)*

# Práctica de Colas

Aplicación de escritorio en C# con Windows Forms que gestiona una cola de
pedidos. La cola y el nodo están implementados a mano, sin usar las colecciones
de la biblioteca estándar, y el recorrido para mostrar el contenido se resuelve
con métodos recursivos.

Los pedidos se atienden en el orden en que entran, que es lo propio de una cola.
Cada uno lleva su número, el producto comprado, el precio y la fecha de entrega
estimada.

A medida que se van despachando pedidos, la aplicación calcula sobre los ya
atendidos el precio máximo, el mínimo, el promedio y el total acumulado.

## Capturas

**Cinco pedidos en cola, todavía sin despachar**

![Pedidos en cola](docs/capturas/captura-1.png)

**Después de despachar los tres primeros, con las estadísticas calculadas**

![Pedidos despachados](docs/capturas/captura-2.png)

## Requisitos Previos

Para abrir y ejecutar este proyecto en tu entorno local, necesitas tener instalado:

* .NET Framework 4.8
* Visual Studio 2022

## Cómo ejecutar el proyecto

1. Clona o descarga este repositorio en tu computadora.
2. Abre el archivo `Practica de Colas.sln` en Visual Studio.
3. Presiona el botón **Iniciar** (o F5) para compilar y ejecutar la aplicación.

---

## Autor

**Leonel Maximiliano Blumberg**<br>
Desarrollador de Software | .NET · C# · ASP.NET · SQL | Estudiante de Ing. en Sistemas

[LinkedIn](https://www.linkedin.com/in/leonel-blumberg) · [GitHub](https://github.com/Leonel-Blumberg) · [Email](mailto:leonelblumberg.it@gmail.com)
