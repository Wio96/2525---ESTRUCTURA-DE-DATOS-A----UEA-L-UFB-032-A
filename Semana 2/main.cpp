// Nombre: Wio Gualinga
// Fecha: 6 de junio de 2025
// Página: 1

using System;

namespace FigurasGeometricas
{
    // Clase que representa un círculo
    public class Circulo
    {
        // Radio del círculo, dato privado para encapsulación
        private double radio;

        // Constructor que inicializa el radio del círculo
        public Circulo(double radio)
        {
            this.radio = radio;
        }

        // Método para calcular el área del círculo
        // Área = π * radio^2
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        // Método para calcular el perímetro (circunferencia) del círculo
        // Perímetro = 2 * π * radio
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
    }

    // Clase que representa un cuadrado
    public class Cuadrado
    {
        // Lado del cuadrado, dato privado para encapsulación
        private double lado;

        // Constructor que inicializa el lado del cuadrado
        public Cuadrado(double lado)
        {
            this.lado = lado;
        }

        // Método para calcular el área del cuadrado
        // Área = lado * lado
        public double CalcularArea()
        {
            return lado * lado;
        }

        // Método para calcular el perímetro del cuadrado
        // Perímetro = 4 * lado
        public double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }

    // Clase para probar las figuras geométricas
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo(5); // Círculo con radio 5
            Console.WriteLine("Área del círculo: " + c.CalcularArea());
            Console.WriteLine("Perímetro del círculo: " + c.CalcularPerimetro());

            Cuadrado q = new Cuadrado(4); // Cuadrado con lado 4
            Console.WriteLine("Área del cuadrado: " + q.CalcularArea());
            Console.WriteLine("Perímetro del cuadrado: " + q.CalcularPerimetro());
        }
    }
}
