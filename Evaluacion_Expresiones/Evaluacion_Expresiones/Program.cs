using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack;

namespace Evaluacion_Expresiones
{
    class Program
    {
        static void Main(string[] args)
        {
            // Evaluación de Postfix
            Stack.Stack pila = new Stack.Stack();
            int n = 0;
            int a = 0;
            int b = 0;
            int r = 0;
            // -+3*52*73
            // 352*+73*-
            string expresion = "352*+73*-";
            // Para Prefix solamente agregar .Reverse() al final de expresion
            // Para Postfix solamente quitar .Reverse() al final de expresion y cambiar el orden de a y b en la asignación de POP
            foreach (char item in expresion)
            {
                if (char.IsDigit(item))
                {
                    pila.Push(Convert.ToInt32(char.GetNumericValue(item)));
                }
                else if (item == '*' || item == '/' || item == '+' || item == '-')
                {
                    b = pila.Pop();
                    a = pila.Pop();
                    switch (item)
	                {
                        case '+':
                            n = a + b;
                            break;
                        case '-':
                            n = a - b;
                            break;
                        case '*':
                            n = a * b;
                            break;
                        case '/':
                            n = a / b;
                            break;
		                default:
                        break;
	                }
                    pila.Push(Convert.ToInt32(n));
                }
            }
            Console.Write("Resultado de la Expresión {0} es = ", expresion);
            pila.Transversa();
            Console.WriteLine();
        }
    }
}
