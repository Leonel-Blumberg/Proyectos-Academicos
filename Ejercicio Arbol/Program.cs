using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Arbol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arbol arbol = new Arbol();
            Nodo raiz = null;

            ProgramaPrincipal(arbol, ref raiz);

            MostrarRecorridoPreorder(arbol, raiz);
            Console.WriteLine("");
            MostrarRecorridoPostOrder(arbol, raiz);

            Console.WriteLine("\n------------------------------------------\n");
            Console.ReadKey();
        }

        static void ProgramaPrincipal(Arbol arbol, ref Nodo raiz)
        {
            Nodo encontrado = null;
            string nuevoNodo, ubiNuevoNodo, respuesta;

            Console.WriteLine("##########################################");
            Console.WriteLine("###### PROGRAMA PARA ARMAR UN ÁRBOL ######");
            Console.WriteLine("##########################################\n");

            Console.Write("Ingrese el nombre del nodo raiz: ");
            nuevoNodo = Console.ReadLine();
            raiz = arbol.Insertar(nuevoNodo, null);
            Console.WriteLine("");

            do
            {
                Console.Write("Ingrese el nombre del nodo a insertar: ");
                nuevoNodo = Console.ReadLine();

                do
                {
                    Console.Write("Ingrese la ubicación del nodo a insertar (nombre del nodo): ");
                    ubiNuevoNodo = Console.ReadLine();

                    encontrado = arbol.Buscar(ubiNuevoNodo, raiz);

                    if (encontrado != null)
                    {
                        arbol.Insertar(nuevoNodo, encontrado);
                        Console.WriteLine("\n| SE HA INSERTADO EL NODO |\n");
                    }
                    else
                        Console.WriteLine($"\n| NO SE ENCONTRO EL NODO \"{ubiNuevoNodo}\" |\n");

                } while (encontrado == null);

                do
                {
                    Console.Write("¿Desea continuar? (SI/NO): ");
                    respuesta = Console.ReadLine();

                    if (respuesta.ToUpper() != "SI" && respuesta.ToUpper() != "NO")
                        Console.WriteLine("\n| LA RESPUESTA DEBE SER \"SI\" o \"NO\". |\n");

                } while (respuesta.ToUpper() != "SI" && respuesta.ToUpper() != "NO");

                Console.WriteLine("");

            } while (respuesta.ToUpper() == "SI");
        }

        static void MostrarRecorridoPreorder(Arbol arbol, Nodo raiz)
        {
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("##########################################");
            Console.WriteLine("########### RECORRIDO PREORDER ###########");
            Console.WriteLine("##########################################\n");
            arbol.RecorridoPreOrder(raiz);
        }

        static void MostrarRecorridoPostOrder(Arbol arbol, Nodo raiz)
        {
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("##########################################");
            Console.WriteLine("########### RECORRIDO POSTORDER ###########");
            Console.WriteLine("##########################################\n");
            arbol.RecorridoPostOrder(raiz);
        }
    }
}