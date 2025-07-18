using System;
using System.Collections.Generic;

class ProgramaBalanceo
{
    /// <summary>
    /// Verifica si los paréntesis, llaves y corchetes en una expresión matemática están balanceados.
    /// </summary>
    /// <param name="expresion">Cadena con la expresión matemática a evaluar</param>
    /// <returns>true si los símbolos están balanceados; false en caso contrario</returns>
    static bool EstaBalanceado(string expresion)
    {
        // Se utiliza una pila para almacenar los símbolos de apertura encontrados
        Stack<char> pila = new Stack<char>();

        // Recorremos cada carácter de la expresión
        foreach (char c in expresion)
        {
            // Si el carácter es un símbolo de apertura, lo apilamos
            if (c == '(' || c == '{' || c == '[')
            {
                pila.Push(c);
            }
            // Si el carácter es un símbolo de cierre, verificamos si hay coincidencia
            else if (c == ')' || c == '}' || c == ']')
            {
                // Si la pila está vacía, no hay símbolo de apertura para hacer match
                if (pila.Count == 0)
                    return false;

                // Extraemos el último símbolo de apertura ingresado
                char tope = pila.Pop();

                // Verificamos si el símbolo de cierre corresponde al último de apertura
                if ((c == ')' && tope != '(') ||
                    (c == '}' && tope != '{') ||
                    (c == ']' && tope != '['))
                {
                    return false; // No hay coincidencia, está mal balanceado
                }
            }
        }

        // Si la pila está vacía, todos los símbolos tuvieron su pareja correcta
        return pila.Count == 0;
    }

    /// <summary>
    /// Punto de entrada principal del programa.
    /// Permite al usuario ingresar una expresión y muestra si está balanceada.
    /// </summary>
    static void Main()
    {
        Console.WriteLine("Ingrese la expresión matemática:");
        string expresion = Console.ReadLine();

        // Llamada a la función que verifica si la expresión está balanceada
        if (EstaBalanceado(expresion))
        {
            Console.WriteLine("Fórmula balanceada.");
        }
        else
        {
            Console.WriteLine("Fórmula no balanceada.");
        }
    }
}
