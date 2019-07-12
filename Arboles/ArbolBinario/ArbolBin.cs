﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class ArbolBin
    {
        private Nodo raiz;
        private Nodo trabajo;

        private int i = 0;

        public ArbolBin()
        {
            this.raiz = null;
        }
        internal Nodo Raiz { get; set; }

        // Insertar
        public Nodo Insertar(int dato, Nodo nodo)
        {
            Nodo temp = null;
            // Si no hay a quién insertar entonces creamos el nodo
            if (nodo == null)
            {
                temp = new Nodo();
                temp.Dato = dato;
                return temp;
            }
            // Si el dato es menor
            if (dato < nodo.Dato) { nodo.Izq = Insertar(dato, nodo.Izq); }
            // Si el dato es mayor
            if (dato > nodo.Dato) { nodo.Der = Insertar(dato, nodo.Der); }

            return nodo;
        }

        public void Transversa(Nodo nodo)
        {
            if (nodo == null) { return; }
            // Me proceso primero a mí
            for (int n = 0; n < i; n++) { Console.Write(" "); }
            Console.WriteLine(nodo.Dato);
            // Si tengo izquierda, proceso a la izquierda
            if (nodo.Izq != null)
            {
                i++;
                Console.Write("I ");
                Transversa(nodo.Izq);
                i--;
            }
            // Si tengo a la derecha, proceso a la derecha
            if (nodo.Der != null)
            {
                i++;
                Console.Write("D ");
                Transversa(nodo.Der);
                i--;
            }
        }    
    }
}