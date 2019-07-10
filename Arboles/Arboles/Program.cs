using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Árbol Genérico
            Arbol arbolito = new Arbol();
            NodoArbolG raiz = arbolito.Insertar("A", null);
            arbolito.Insertar("B", raiz);
            arbolito.Insertar("C", raiz);

            //arbolito.TransversaPre(raiz);

            NodoArbolG n = arbolito.Insertar("D", raiz);
            arbolito.Insertar("H", n);
            n = arbolito.Insertar("E", raiz);
            NodoArbolG i = arbolito.Insertar("I", n);
            arbolito.Insertar("J", i);
            NodoArbolG p = arbolito.Insertar("Q", n);
            arbolito.Insertar("P", p);

            n = arbolito.Insertar("F", raiz);
            arbolito.Insertar("k", n);
            arbolito.Insertar("L", n);
            arbolito.Insertar("M", n);
            n = arbolito.Insertar("G", raiz);
            arbolito.Insertar("N", n);          

            arbolito.TransversaPre(raiz);
            Console.WriteLine("-------");
        }
    }
}
