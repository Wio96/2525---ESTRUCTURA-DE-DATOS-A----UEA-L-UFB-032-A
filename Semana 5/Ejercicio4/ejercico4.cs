using System;
using System.Collections.Generic;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> awarded = new List<int>();

            Console.WriteLine("Introduce los 6 números ganadores de la lotería:");

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Número {i + 1}: ");
                bool validInput = int.TryParse(Console.ReadLine(), out int number);
                while (!validInput)
                {
                    Console.WriteLine("Entrada inválida. Por favor ingresa un número entero.");
                    Console.Write($"Número {i + 1}: ");
                    validInput = int.TryParse(Console.ReadLine(), out number);
                }
                awarded.Add(number);
            }

            awarded.Sort();

            Console.WriteLine("Los números ganadores son: " + string.Join(", ", awarded));
        }
    }
}

