using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas_1;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista_Ligada lista = new Lista_Ligada();
            lista.Agregar(77);
            lista.Agregar(34);
            lista.Agregar(68);
            lista.Agregar(24);
            lista.Agregar(75);

            // Selection Sort
            int cantidad = lista.getSize();
            for (int i = 0; i < cantidad; i++)
            {

            }
        }
    }
}
