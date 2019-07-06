using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Listas_1;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista_Ligada lista = new Lista_Ligada();
            lista.Agregar(81);
            lista.Agregar(12);
            lista.Agregar(65);
            lista.Agregar(76);
            lista.Agregar(12);
            lista.Agregar(27);
            lista.Agregar(78);
            lista.Agregar(38);
            lista.Agregar(58);
            lista.Agregar(10);
            lista.Transversa();

            //Insertion Sort
            int cantidad = lista.getSize() + 1;
            int indexAgujero = 0;
            int dato = 0;

            //Recorremos los elementos
            for (int i = 1; i < cantidad; i++)
            {
                //Obtenemos el dato
                dato = (int)lista[i];
                //Indicamos la posición del agujero
                indexAgujero = i;
                //Recorremos los elementos hacia el agujero
                while (indexAgujero > 0 && lista[indexAgujero - 1] > dato)
                {
                    lista[indexAgujero] = lista[indexAgujero - 1];
                    indexAgujero -= 1;
                }
                //Le colocamos al agujero el dato correspondiente
                lista[indexAgujero] = dato;
                lista.Transversa();
            }
            //Mostrar lista ordenada
            Console.WriteLine("Lista Ordenada");
            lista.Transversa();
        }
    }
}
