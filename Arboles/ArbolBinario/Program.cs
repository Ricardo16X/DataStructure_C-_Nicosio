using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arbol Completo refiriendome a que esta es la estructura de arbol
            ArbolBin arbol = new ArbolBin();
            // Declarando la raíz del árbol
            Nodo raiz = arbol.Insertar(6, null);
            // Cuerpo de la raiz del árbol binario
            arbol.Insertar(2, raiz);
            arbol.Insertar(8, raiz);
            arbol.Insertar(1, raiz);
            arbol.Insertar(4, raiz);
            arbol.Insertar(3, raiz);
            arbol.Insertar(5, raiz);
            arbol.Insertar(7, raiz);
            arbol.Insertar(11, raiz);
            arbol.Insertar(9, raiz);
            arbol.Insertar(10, raiz);
            arbol.Insertar(0, raiz);
            arbol.Insertar(-1, raiz);
            arbol.Insertar(12, raiz);
            // Mostrando el contenido del árbol
            arbol.Transversa(raiz);
        }
    }
}
