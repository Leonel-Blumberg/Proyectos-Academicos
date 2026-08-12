using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Arbol
{
    internal class Arbol
    {
        private Nodo raiz;

        public Nodo Insertar(string pDato, Nodo pNodo)
        {
            if (pNodo == null)
            {
                raiz = new Nodo();
                raiz.Nombre = pDato;
                raiz.Hijo = null;
                raiz.Hermano = null;

                return raiz;
            }

            if (pNodo.Hijo == null)
            {
                Nodo temp = new Nodo();
                temp.Nombre = pDato;
                pNodo.Hijo = temp;

                return temp;
            }
            else
            {
                Nodo trabajo = pNodo.Hijo;

                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }

                Nodo temp = new Nodo();

                temp.Nombre = pDato;

                trabajo.Hermano = temp;

                return temp;
            }
        }

        public void RecorridoPreOrder(Nodo pNodo, int nivel = 0)
        {
            if (pNodo == null)
                return;

            for (int n = 0; n < nivel; n++)
                Console.Write("  ");

            Console.WriteLine(pNodo.Nombre);

            if (pNodo.Hijo != null)
                RecorridoPreOrder(pNodo.Hijo, nivel + 1);

            if (pNodo.Hermano != null)
                RecorridoPreOrder(pNodo.Hermano, nivel);
        }

        public void RecorridoPostOrder(Nodo pNodo, int nivel = 0)
        {
            if (pNodo == null)
                return;

            if (pNodo.Hijo != null)
                RecorridoPostOrder(pNodo.Hijo, nivel + 1);

            for (int n = 0; n < nivel; n++)
                Console.Write("  ");

            Console.WriteLine(pNodo.Nombre);

            if (pNodo.Hermano != null)
                RecorridoPostOrder(pNodo.Hermano, nivel);
        }

        public Nodo Buscar(string pDato, Nodo pNodo)
        {
            Nodo encontrado = null;

            if (pNodo == null)
                return encontrado;

            if (pNodo.Nombre.CompareTo(pDato) == 0)
            {
                encontrado = pNodo;
                return encontrado;
            }

            if (pNodo.Hijo != null)
            {
                encontrado = Buscar(pDato, pNodo.Hijo);

                if (encontrado != null)
                    return encontrado;
            }

            if (pNodo.Hermano != null)
            {
                encontrado = Buscar(pDato, pNodo.Hermano);

                if (encontrado != null)
                    return encontrado;
            }

            return encontrado;
        }
    }
}
