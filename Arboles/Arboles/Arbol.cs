using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles
{
    class Arbol
    {
        private NodoArbolG raiz;
        private NodoArbolG trabajo;
        private int i = 0;

        // constructor de nuevo árbol
        public Arbol()
        {
            raiz = new NodoArbolG();
        }

        public NodoArbolG Insertar(string cadena, NodoArbolG nodo)
        {
            // Si no hay nodo donde insertar, tomamos como si fuera en la raiz
            if (nodo == null)
            {
                raiz = new NodoArbolG();
                raiz.Dato = cadena;
                // No hay hijo
                raiz.Hijo = null;
                // No hay hermano
                raiz.Hermano = null;
                return raiz;
            }
            // Verificamos si no tiene hijo
            if (nodo.Hijo == null)
            {
                NodoArbolG temp = new NodoArbolG();
                temp.Dato = cadena;
                // Conectamos el nuevo nodo como hijo
                nodo.Hijo = temp;
                return temp;
            }
            else // Ya tiene un hijo, tenemos que insertarlo como hermano.
            {
                trabajo = nodo.Hijo;
                // Avanzamos hasta el ultimo hermano
                while (trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }
                // Creamos nodo temporal
                NodoArbolG temp = new NodoArbolG();
                temp.Dato = cadena;
                // Unimos el temp al último hermano
                trabajo.Hermano = temp;
                return temp;
            }
        }
    }
}
