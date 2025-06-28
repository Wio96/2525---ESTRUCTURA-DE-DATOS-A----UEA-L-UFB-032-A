using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1: Mostrar lista de asignaturas");

            string[] subjects = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            Console.WriteLine("Asignaturas:");
            Console.WriteLine("[{0}]", string.Join(", ", subjects));
        }
    }
}
