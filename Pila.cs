using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace Semana7
{
   
    internal class Pila  // Clase para la demostración de operaciones básicas con pilas
    {
        public static void Run()
        {
            Stack<int> pilaEnteros = new Stack<int>();  // Definición de una pila para enteros

            // Agregar elementos a la pila
            pilaEnteros.Push(1);
            pilaEnteros.Push(2);
            pilaEnteros.Push(20);
            pilaEnteros.Push(4);
          
            ImprimirPila(pilaEnteros);  // Imprimir los elementos en la pila
          
            int ElementoSuperior = pilaEnteros.Peek(); // Mostrar el elemento en la parte superior sin sacarlo de la pila
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Elemento en la cima (Peek): {0}", ElementoSuperior);
            Console.ResetColor();
            int ElementoSacado = pilaEnteros.Pop();  // Sacar el elemento de la cima de la pila
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se ha sacado el elemento {0}", ElementoSacado);
            Console.ResetColor();
            ImprimirPila(pilaEnteros);

            while (pilaEnteros.Count > 0)   // Vaciar la pila
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Se saca el elemento {0}", pilaEnteros.Pop());
                Console.ResetColor();
            }
        }
        static void ImprimirPila(Stack<int> pila)  //mostra el contenido de una pila en pantalla
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Elementos de la pila: ");
            foreach (var item in pila) // Recorrer elementos de la pila
            {
                Console.WriteLine(item); // Muestra el item en pantalla
            }
            Console.ResetColor();
        }
    }
}
