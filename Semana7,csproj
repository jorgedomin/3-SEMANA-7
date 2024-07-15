using System.Linq;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;

namespace Semana7
{
    internal class VerificacionBalanceo  // verificación de fórmula matemática  si esta o no balanceada, usando pilas
    {
        public static void Run()
        {
            Console.Write("Ingrese la fórmula matemática: ");
            string formula = Console.ReadLine();

            if (IsBalanced(formula))  // Verificar si balanceada o no la formula 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Fórmula balanceada.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Fórmula no balanceada.");
                Console.ResetColor();
            }
        }
        public static bool IsBalanced(string expression)    //  Esta función  verifica si  esta no  balanceada la fórmula
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in expression)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c); // Empuja los caracteres de apertura en la pila
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return false; // si esta balanceada  es que esta vacía
                    char open = stack.Pop(); // Sacar el último carácter de apertura
                    if ((c == ')' && open != '(') || // verifica los caracteres de cierre y de apertura 
                        (c == '}' && open != '{') ||
                        (c == ']' && open != '['))
                    {
                        return false; // No esta balanceada, no corresponde.
                    }
                }
            }

            return stack.Count == 0; // Esta balanceada, la pila esta vacía.
        }
    }

}
