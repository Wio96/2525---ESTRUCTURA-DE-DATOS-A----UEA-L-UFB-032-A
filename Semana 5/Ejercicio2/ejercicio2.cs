using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };

            foreach (string subject in subjects)
            {
                Console.WriteLine("Yo estudio " + subject);
            }
        }
    }
}
