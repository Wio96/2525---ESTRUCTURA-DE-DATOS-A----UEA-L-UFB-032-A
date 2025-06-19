using System;

// Clase que representa un círculo
public class Circulo
{
    // Radio del círculo (dato privado para encapsulación)
    private double radio;

    // Constructor para inicializar el radio
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

    // Método para calcular el perímetro del círculo
    // Perímetro = 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase que representa un rectángulo
public class Rectangulo
{
    // Base y altura (datos privados para encapsulación)
    private double baseRectangulo;
    private double altura;

    // Constructor para inicializar base y altura
    public Rectangulo(double baseRectangulo, double altura)
    {
        this.baseRectangulo = baseRectangulo;
        this.altura = altura;
    }

    // Método para calcular el área del rectángulo
    // Área = base * altura
    public double CalcularArea()
    {
        return baseRectangulo * altura;
    }

    // Método para calcular el perímetro del rectángulo
    // Perímetro = 2 * (base + altura)
    public double CalcularPerimetro()
    {
        return 2 * (baseRectangulo + altura);
    }
}

// Clase principal para ejecutar el programa
class Programa
{
    static void Main()
    {
        // Crear un círculo con radio 5
        Circulo circulo = new Circulo(5);

        // Crear un rectángulo con base 4 y altura 6
        Rectangulo rectangulo = new Rectangulo(4, 6);

        // Mostrar resultados para el círculo
        Console.WriteLine("Círculo:");
        Console.WriteLine("Área: " + circulo.CalcularArea());
        Console.WriteLine("Perímetro: " + circulo.CalcularPerimetro());

        Console.WriteLine(); // línea en blanco para separación

        // Mostrar resultados para el rectángulo
        Console.WriteLine("Rectángulo:");
        Console.WriteLine("Área: " + rectangulo.CalcularArea());
        Console.WriteLine("Perímetro: " + rectangulo.CalcularPerimetro());
    }
}
