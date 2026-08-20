using Ejercicio_con_Archivos;

internal class Program
{
    static void Main()
    {
        GestorAlumnos gestorAlumnos = new();

        string? opcion;

        do
        {
            Console.WriteLine("---------- Menú Programa Alumnos ----------\n");
            Console.WriteLine("             1. Cargar Datos");
            Console.WriteLine("             2. Modificar");
            Console.WriteLine("             3. Buscar");
            Console.WriteLine("             4. Borrar");
            Console.WriteLine("             5. Hacer Listado");
            Console.WriteLine("             0. Salir");

            Console.Write("\nSeleccione una opción: ");

            opcion = Console.ReadLine();

            if (opcion == null)
            {
                AvisarFinDeEntrada();
                return;
            }

            Console.WriteLine();

            // Las opciones 0 y 1 no necesitan que el archivo tenga datos.
            // Una opción inválida tampoco: se responde con el mensaje de error.
            bool esOpcionValida = opcion == "0" || opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4" || opcion == "5";

            bool necesitaArchivo = esOpcionValida && opcion != "0" && opcion != "1";

            bool archivoConDatos = gestorAlumnos.ArchivoConDatos();

            if (!necesitaArchivo || archivoConDatos)
            {
                switch (opcion)
                {
                    case "1":
                        gestorAlumnos.CargarDatos();
                        break;

                    case "2":
                        gestorAlumnos.ModificarDatos();
                        break;

                    case "3":
                        gestorAlumnos.BuscarDatos();
                        break;

                    case "4":
                        gestorAlumnos.BorrarDato();
                        break;

                    case "5":
                        string? opcionListado;

                        do
                        {
                            Console.Write("¿Desea hacer un listado ordenado por apellidos y nombres (1) o un listado ordenado por código de alumno (2)?: ");
                            opcionListado = Console.ReadLine();

                            if (opcionListado == null)
                            {
                                AvisarFinDeEntrada();
                                return;
                            }

                            switch (opcionListado)
                            {
                                case "1":
                                    gestorAlumnos.ListadoApeYNom();
                                    break;
                                case "2":
                                    gestorAlumnos.ListadoCodAlumno();
                                    break;
                                default:
                                    Console.WriteLine("\n| Opción inválida, por favor intente de nuevo. |\n");
                                    break;
                            }
                        } while (opcionListado != "1" && opcionListado != "2");
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("| Opción inválida, por favor intente de nuevo. |");
                        break;
                }
            }
            else if (gestorAlumnos.ExisteArchivo())
                Console.WriteLine("| El archivo está vacío, pruebe a cargar un dato. |");
            else
                Console.WriteLine("| El archivo no existe, pruebe a cargar un dato. |");

            Console.WriteLine();
        } while (true);
    }

    static void AvisarFinDeEntrada()
    {
        Console.WriteLine("\n| SE TERMINÓ LA ENTRADA DE DATOS |\n");
    }
}