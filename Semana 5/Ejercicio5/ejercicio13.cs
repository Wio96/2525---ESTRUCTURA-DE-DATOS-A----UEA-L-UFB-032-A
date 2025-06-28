using System;
using System.Linq;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una muestra de números separados por comas:");
            string input = Console.ReadLine();

            // Separar y convertir a números enteros
            string[] parts = input.Split(',');
            int[] sample = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                // Quitar espacios y convertir a int
                sample[i] = int.Parse(parts[i].Trim());
            }

            int n = sample.Length;

            // Calcular la media
            double mean = sample.Average();

            // Calcular la suma de cuadrados
            double sumsq = sample.Select(x => x * x).Sum();

            // Calcular la desviación típica (desviación estándar poblacional)
            double stdev = Math.Sqrt(sumsq / n - mean * mean);

            Console.WriteLine($"La media es {mean:F2}, y la desviación típica es {stdev:F2}");
        }
    }
}
