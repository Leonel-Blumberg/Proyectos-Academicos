using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_con_Archivos
{
    internal class GestorAlumnos
    {
        private const string rutaArchivo = "ListaAlumnos.txt";

        // Métodos del menú de opciones.

        public void CargarDatos()
        {
            Alumno nuevoAlumno = PedirDatos();

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                writer.WriteLine(nuevoAlumno.GenerarRegistro());
        }

        public void ModificarDatos()
        {
            Console.Write("Ingrese el código del alumno a modificar: ");
            string? codigo = Console.ReadLine();

            List<string> lineas = File.ReadAllLines(rutaArchivo).ToList();

            int indice = lineas.FindIndex(linea => OrdenarCodAlumno(linea) == codigo);

            if (indice == -1)
            {
                Console.WriteLine("\n| No se encontro el alumno. |");
                return;
            }

            Console.WriteLine();
            Alumno datoModificado = PedirDatos();

            lineas[indice] = datoModificado.GenerarRegistro();
            File.WriteAllLines(rutaArchivo, lineas);

            Console.WriteLine("\n| Dato modificado. |");
        }

        public void BuscarDatos()
        {
            Console.Write("Ingrese el dato a buscar: ");
            string? dato = Console.ReadLine();

            if (string.IsNullOrEmpty(dato))
            {
                Console.WriteLine("\n| Debe ingresar un dato. |");
                return;
            }

            List<string> encontradas = File.ReadAllLines(rutaArchivo).Where(linea => linea.Contains(dato)).ToList();

            if (encontradas.Count == 0)
            {
                Console.WriteLine("\n| No se encontraron datos. |");
                return;
            }

            for (int i = 0; i < encontradas.Count; i++)
                Console.WriteLine($"\n{i + 1}. {OrdenarDatos(encontradas[i])}");
        }

        public void BorrarDato()
        {
            Console.Write("Ingrese el código del alumno a eliminar: ");
            string? codigo = Console.ReadLine();

            List<string> lineas = File.ReadAllLines(rutaArchivo).ToList();

            int indice = lineas.FindIndex(linea => OrdenarCodAlumno(linea) == codigo);

            if (indice == -1)
            {
                Console.WriteLine("\n| No se encontro el alumno. |");
                return;
            }

            lineas.RemoveAt(indice);
            File.WriteAllLines(rutaArchivo, lineas);

            Console.WriteLine("\n| Dato eliminado. |");
        }

        public void ListadoApeYNom()
        {
            List<string> lineas = File.ReadAllLines(rutaArchivo).OrderBy(linea => OrdenarApeYNom(linea)).ToList();

            MostrarListado(lineas);
        }

        public void ListadoCodAlumno()
        {
            List<string> lineas = File.ReadAllLines(rutaArchivo).OrderBy(linea => int.TryParse(OrdenarCodAlumno(linea), out int c) ? c : int.MaxValue).ToList();

            MostrarListado(lineas);
        }

        private void MostrarListado(List<string> lineas)
        {
            for (int i = 0; i < lineas.Count; i++)
                Console.WriteLine($"\n{i + 1}. {OrdenarDatos(lineas[i])}");
        }

        // Método de petición de datos.

        private Alumno PedirDatos()
        {
            Alumno nuevoAlumno = new Alumno();

            int? codigoAlumno = null;
            string? apellidos = null;
            string? nombres = null;
            string? fechaNacimiento = null;
            long? telefono = null;
            string? mail = null;

            do
            {
                Console.Write("Ingrese el código del alumno: ");

                if (!int.TryParse(Console.ReadLine(), out int codigo))
                    Console.WriteLine("\n| Ingrese un código válido. |\n");

                else if (codigo < 1)
                    Console.WriteLine("\n| El código del alumno debe ser mayor o igual a 1. |\n");

                else
                    codigoAlumno = codigo;

            } while (codigoAlumno == null);

            do
            {
                Console.Write("Ingrese los apellidos del alumno: ");
                string? entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                    Console.WriteLine("\n| Los apellidos deben contener al menos un caracter. |\n");

                else if (!entrada.All(c => char.IsLetter(c) || c == ' '))
                    Console.WriteLine("\n| Los apellidos no pueden contener caracteres inválidos. |\n");

                else
                    apellidos = entrada;

            } while (apellidos == null);

            do
            {
                Console.Write("Ingrese los nombres del alumno: ");
                string? entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                    Console.WriteLine("\n| Los nombres deben contener al menos un caracter. |\n");

                else if (!entrada.All(c => char.IsLetter(c) || c == ' '))
                    Console.WriteLine("\n| Los nombres no pueden contener caracteres inválidos. |\n");

                else
                    nombres = entrada;

            } while (nombres == null);

            do
            {
                Console.Write("Ingrese la fecha de nacimiento del alumno: ");
                string? entrada = Console.ReadLine();

                if (entrada == null || entrada.Length < 7)
                    Console.WriteLine("\n| La fecha de nacimiento debe tener al menos 7 caracteres. |\n");

                else
                    fechaNacimiento = entrada;

            } while (fechaNacimiento == null);

            do
            {
                Console.Write("Ingrese el télefono del alumno: ");

                if (!long.TryParse(Console.ReadLine(), out long numero))
                    Console.WriteLine("\n| Ingrese un télefono válido. |\n");

                else if (numero.ToString().Length < 7)
                    Console.WriteLine("\n| El télefono debe tener al menos 7 caracteres. |\n");

                else
                    telefono = numero;

            } while (telefono == null);

            do
            {
                Console.Write("Ingrese el mail del alumno: ");
                string? entrada = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(entrada))
                    Console.WriteLine("\n| El mail debe contener al menos un caracter. |\n");
                else
                    mail = entrada;

            } while (mail == null);

            nuevoAlumno.CodigoAlumno = codigoAlumno;
            nuevoAlumno.Apellidos = apellidos;
            nuevoAlumno.Nombres = nombres;
            nuevoAlumno.FechaNacimiento = fechaNacimiento;
            nuevoAlumno.Telefono = telefono;
            nuevoAlumno.Mail = mail;

            return nuevoAlumno;
        }

        // Métodos de ordenamiento.

        private string OrdenarDatos(string linea)
        {
            string[] datos = linea.Split('|');

            return $"Código Alumno: {datos[0]}\n   Apellidos: {datos[1]}\n   Nombres: {datos[2]}\n   Fecha Nacimiento: {datos[3]}\n   Télefono: {datos[4]}\n   Mail: {datos[5]}";
        }

        private string OrdenarApeYNom(string linea)
        {
            string[] datos = linea.Split('|');

            return $"{datos[1]}|{datos[2]}";
        }

        private string OrdenarCodAlumno(string linea)
        {
            string[] datos = linea.Split('|');

            return $"{datos[0]}";
        }
    }
}