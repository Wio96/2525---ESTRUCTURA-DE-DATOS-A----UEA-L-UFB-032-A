using System;
using System.Collections.Generic;

class Program
{
    static void MoverDiscos(int n, Stack<int> origen, Stack<int> auxiliar, Stack<int> destino,
                            string nombreOrigen, string nombreAuxiliar, string nombreDestino)
    {
        if (n == 1)
        {
            int disco = origen.Pop();
            destino.Push(disco);
            Console.WriteLine($"Mover disco {disco} de {nombreOrigen} a {nombreDestino}");
            MostrarTorres(origen, auxiliar, destino);
        }
        else
        {
            MoverDiscos(n - 1, origen, destino, auxiliar, nombreOrigen, nombreDestino, nombreAuxiliar);
            MoverDiscos(1, origen, auxiliar, destino, nombreOrigen, nombreAuxiliar, nombreDestino);
            MoverDiscos(n - 1, auxiliar, origen, destino, nombreAuxiliar, nombreOrigen, nombreDestino);
        }
    }

    static void MostrarTorres(Stack<int> A, Stack<int> B, Stack<int> C)
    {
        Console.WriteLine($"Torre A: [{string.Join(", ", A)}]");
        Console.WriteLine($"Torre B: [{string.Join(", ", B)}]");
        Console.WriteLine($"Torre C: [{string.Join(", ", C)}]");
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Número de discos: ");
        int numDiscos = int.Parse(Console.ReadLine());

        Stack<int> torreA = new Stack<int>();
        Stack<int> torreB = new Stack<int>();
        Stack<int> torreC = new Stack<int>();

        for (int i = numDiscos; i >= 1; i--)
        {
            torreA.Push(i);
        }

        Console.WriteLine("Estado inicial:");
        MostrarTorres(torreA, torreB, torreC);

        MoverDiscos(numDiscos, torreA, torreB, torreC, "A", "B", "C");
    }
}
