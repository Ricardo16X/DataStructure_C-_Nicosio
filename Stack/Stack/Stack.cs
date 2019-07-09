﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack
    {
        // Es el ancla o encabezado del stack
        private Nodo ancla;
        // Esta variable de referencia nos ayuda a trabajar con el stack
        private Nodo trabajo;

        public Stack()
        {
            // Instanciamos el ancla
            ancla = new Nodo();
            // Como es un stack vacio, su siguiente es null
            ancla.Sig = null;
        }

        // Push
        public void Push(int valor)
        {
            // Creamos el nodo temporal
            Nodo temp = new Nodo();
            temp.Dato = valor;
            // Conectamos el temporal a la lista
            temp.Sig = ancla.Sig;
            // Conectamos el ancla al temporal
            ancla.Sig = temp;
        }

        // Pop
        public int Pop()
        {
            // Esta version no contiene código de seguridad
            // Colocar una excepcion cuando se intente hacer un pop a un stack vacio
            int valor = 0;
            // Llevamos a cabo el trabajo solo si hay elementos en el stack
            if (ancla.Sig != null)
            {
                // Obtenemos el dato correspondiente
                trabajo = ancla.Sig;
                valor = trabajo.Dato;
                // Lo sacamos del stack
                ancla.Sig = trabajo.Sig;
                trabajo.Sig = null;
            }
            return valor;
        }

        // Peek
        public int Peek()
        {
            // Esta version no contiene código de seguridad
            // Colocar una excepcion cuando se intente hacer un peek a un stack vacio

            int valor = 0;
            // Llevamos a cabo el trabajo solamente si hay elementos en el stack
            if (ancla.Sig != null)
            {
                // Obtenemos el dato correspondiente
                trabajo = ancla.Sig;
                valor = trabajo.Dato;
            }
            return valor;
        }

        // Transversa
        public void Transversa()
        {
            // Trabajo al inicio
            trabajo = ancla;
            // Recorremos hasta encontrar el final
            while (trabajo.Sig != null)
            {
                // Avanzamos trabajo
                trabajo = trabajo.Sig;
                // Obtenemos el dato y lo mostramos
                Console.Write("[{0}] <== ", trabajo.Dato);
            }
            Console.WriteLine();
        }
    }
}
