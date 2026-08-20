namespace Ejercicio_con_Archivos
{
    internal class GestorAlumnos
    {
        private const string rutaArchivo = "ListaAlumnos.txt";

        // Cantidad de campos que tiene cada línea del archivo, separados por |.
        private const int cantidadCampos = 6;

        // Métodos del menú de opciones.
        public void CargarDatos()
        {
            Alumno? nuevoAlumno = PedirDatos(null);

            if (nuevoAlumno == null)
                return;

            AgregarLinea(nuevoAlumno.GenerarRegistro());
        }

        public void ModificarDatos()
        {
            Console.Write("Ingrese el código del alumno a modificar: ");
            string? codigo = Console.ReadLine();

            if (codigo == null)
            {
                AvisarFinDeEntrada();
                return;
            }

            List<string>? lineas = LeerLineas();

            if (lineas == null)
                return;

            int indice = lineas.FindIndex(linea => OrdenarCodAlumno(linea) == codigo);

            if (indice == -1)
            {
                Console.WriteLine("\n| No se encontró el alumno. |");
                return;
            }

            Console.WriteLine();
            Alumno? datoModificado = PedirDatos(codigo);

            if (datoModificado == null)
                return;

            lineas[indice] = datoModificado.GenerarRegistro();

            if (!GuardarLineas(lineas))
                return;

            Console.WriteLine("\n| Dato modificado. |");
        }

        public void BuscarDatos()
        {
            Console.Write("Ingrese el dato a buscar: ");
            string? dato = Console.ReadLine();

            if (dato == null)
            {
                AvisarFinDeEntrada();
                return;
            }

            if (string.IsNullOrEmpty(dato))
            {
                Console.WriteLine("\n| Debe ingresar un dato. |");
                return;
            }

            List<string>? lineas = LeerLineas();

            if (lineas == null)
                return;

            List<string> encontradas = lineas.Where(linea => linea.Contains(dato)).ToList();

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

            if (codigo == null)
            {
                AvisarFinDeEntrada();
                return;
            }

            List<string>? lineas = LeerLineas();

            if (lineas == null)
                return;

            int indice = lineas.FindIndex(linea => OrdenarCodAlumno(linea) == codigo);

            if (indice == -1)
            {
                Console.WriteLine("\n| No se encontró el alumno. |");
                return;
            }

            lineas.RemoveAt(indice);

            if (!GuardarLineas(lineas))
                return;

            Console.WriteLine("\n| Dato eliminado. |");
        }

        public void ListadoApeYNom()
        {
            List<string>? lineas = LeerLineas();

            if (lineas == null)
                return;

            MostrarListado(lineas.OrderBy(linea => OrdenarApeYNom(linea)).ToList());
        }

        public void ListadoCodAlumno()
        {
            List<string>? lineas = LeerLineas();

            if (lineas == null)
                return;

            MostrarListado(lineas.OrderBy(linea => int.TryParse(OrdenarCodAlumno(linea), out int c) ? c : int.MaxValue).ToList());
        }

        private void MostrarListado(List<string> lineas)
        {
            for (int i = 0; i < lineas.Count; i++)
                Console.WriteLine($"\n{i + 1}. {OrdenarDatos(lineas[i])}");
        }

        // Método de petición de datos.

        // codigoActual es el código del alumno que se está modificando, o null
        // cuando se carga un alumno nuevo. Sirve para no rechazar como duplicado
        // el código que el alumno ya tenía.
        private Alumno? PedirDatos(string? codigoActual)
        {
            Alumno nuevoAlumno = new();

            int? codigoAlumno = null;
            string? apellidos = null;
            string? nombres = null;
            string? fechaNacimiento = null;
            long? telefono = null;
            string? mail = null;

            do
            {
                Console.Write("Ingrese el código del alumno: ");
                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    AvisarFinDeEntrada();
                    return null;
                }

                if (!int.TryParse(entrada, out int codigo))
                    Console.WriteLine("\n| Ingrese un código válido. |\n");

                else if (codigo < 1)
                    Console.WriteLine("\n| El código del alumno debe ser mayor o igual a 1. |\n");

                else if (codigo.ToString() != codigoActual && ExisteCodigo(codigo))
                    Console.WriteLine("\n| Ya existe un alumno con ese código. |\n");

                else
                    codigoAlumno = codigo;

            } while (codigoAlumno == null);

            do
            {
                Console.Write("Ingrese los apellidos del alumno: ");
                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    AvisarFinDeEntrada();
                    return null;
                }

                if (string.IsNullOrWhiteSpace(entrada))
                    Console.WriteLine("\n| Los apellidos deben contener al menos un carácter. |\n");

                else if (!entrada.All(c => char.IsLetter(c) || c == ' '))
                    Console.WriteLine("\n| Los apellidos no pueden contener caracteres inválidos. |\n");

                else
                    apellidos = entrada;

            } while (apellidos == null);

            do
            {
                Console.Write("Ingrese los nombres del alumno: ");
                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    AvisarFinDeEntrada();
                    return null;
                }

                if (string.IsNullOrWhiteSpace(entrada))
                    Console.WriteLine("\n| Los nombres deben contener al menos un carácter. |\n");

                else if (!entrada.All(c => char.IsLetter(c) || c == ' '))
                    Console.WriteLine("\n| Los nombres no pueden contener caracteres inválidos. |\n");

                else
                    nombres = entrada;

            } while (nombres == null);

            do
            {
                Console.Write("Ingrese la fecha de nacimiento del alumno: ");
                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    AvisarFinDeEntrada();
                    return null;
                }

                if (entrada.Length < 7)
                    Console.WriteLine("\n| La fecha de nacimiento debe tener al menos 7 caracteres. |\n");

                else if (entrada.Contains('|'))
                    Console.WriteLine("\n| La fecha de nacimiento no puede contener una barra vertical. |\n");

                else
                    fechaNacimiento = entrada;

            } while (fechaNacimiento == null);

            do
            {
                Console.Write("Ingrese el teléfono del alumno: ");
                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    AvisarFinDeEntrada();
                    return null;
                }

                if (!long.TryParse(entrada, out long numero))
                    Console.WriteLine("\n| Ingrese un teléfono válido. |\n");

                else if (numero < 0)
                    Console.WriteLine("\n| El teléfono no puede ser negativo. |\n");

                else if (numero.ToString().Length < 7)
                    Console.WriteLine("\n| El teléfono debe tener al menos 7 caracteres. |\n");

                else
                    telefono = numero;

            } while (telefono == null);

            do
            {
                Console.Write("Ingrese el mail del alumno: ");
                string? entrada = Console.ReadLine();

                if (entrada == null)
                {
                    AvisarFinDeEntrada();
                    return null;
                }

                if (string.IsNullOrWhiteSpace(entrada))
                    Console.WriteLine("\n| El mail debe contener al menos un carácter. |\n");

                else if (entrada.Contains('|'))
                    Console.WriteLine("\n| El mail no puede contener una barra vertical. |\n");

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

        // Si la entrada se termina en medio de una operación no queda nada que
        // preguntar, así que se corta el programa igual que con la opción Salir.
        private void AvisarFinDeEntrada()
        {
            Console.WriteLine("\n| SE TERMINÓ LA ENTRADA DE DATOS |\n");
            Environment.Exit(0);
        }

        // Métodos de acceso al archivo.
        public bool ExisteArchivo()
        {
            return File.Exists(rutaArchivo);
        }

        public bool ArchivoConDatos()
        {
            return ExisteArchivo() && new FileInfo(rutaArchivo).Length > 0;
        }

        // Se corta la operación si alguna línea no tiene los campos esperados,
        // porque el archivo se puede editar a mano por fuera del programa y al
        // separarla quedarían campos sin leer.
        private List<string>? LeerLineas()
        {
            try
            {
                List<string> lineas = File.ReadAllLines(rutaArchivo).ToList();

                int invalida = lineas.FindIndex(linea => linea.Split('|').Length != cantidadCampos);

                if (invalida != -1)
                {
                    Console.WriteLine($"\n| La línea {invalida + 1} del archivo no tiene los {cantidadCampos} campos esperados. |");
                    return null;
                }

                return lineas;
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                Console.WriteLine($"\n| No se pudo leer el archivo: {ex.Message} |");
                return null;
            }
        }

        private bool GuardarLineas(List<string> lineas)
        {
            try
            {
                File.WriteAllLines(rutaArchivo, lineas);
                return true;
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                Console.WriteLine($"\n| No se pudo escribir el archivo: {ex.Message} |");
                return false;
            }
        }

        private void AgregarLinea(string linea)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    writer.WriteLine(linea);
            }
            catch (Exception ex) when (ex is IOException || ex is UnauthorizedAccessException)
            {
                Console.WriteLine($"\n| No se pudo escribir el archivo: {ex.Message} |");
            }
        }

        private bool ExisteCodigo(int codigo)
        {
            if (!File.Exists(rutaArchivo))
                return false;

            List<string>? lineas = LeerLineas();

            if (lineas == null)
                return false;

            return lineas.Any(linea => OrdenarCodAlumno(linea) == codigo.ToString());
        }

        // Métodos de ordenamiento.
        private string OrdenarDatos(string linea)
        {
            string[] datos = linea.Split('|');

            return $"Código Alumno: {datos[0]}\n   Apellidos: {datos[1]}\n   Nombres: {datos[2]}\n   Fecha Nacimiento: {datos[3]}\n   Teléfono: {datos[4]}\n   Mail: {datos[5]}";
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