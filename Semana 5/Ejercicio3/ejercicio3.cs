using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] subjects = { "Matemáticas", "Física", "Química", "Historia", "Lengua" };
            string[] scores = new string[subjects.Length];

            // Pedir notas al usuario
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.Write($"¿Qué nota has sacado en {subjects[i]}? ");
                scores[i] = Console.ReadLine();
            }

            // Mostrar las notas
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"En {subjects[i]} has sacado {scores[i]}");
            }
        }
    }
}
