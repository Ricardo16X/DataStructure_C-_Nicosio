using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            //pila.Push(1);
            //pila.Push(2);
            //pila.Push(3);
            //pila.Push(4);
            pila.Transversa();

            Console.WriteLine(pila.Pop());
            pila.Transversa();

            Console.WriteLine(pila.Peek());
            pila.Transversa();
        }
    }
}
