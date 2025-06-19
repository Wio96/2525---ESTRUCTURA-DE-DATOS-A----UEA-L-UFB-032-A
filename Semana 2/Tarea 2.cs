using System;

// Clase para representar un círculo
public class Circulo
{
    // Atributo privado para almacenar el radio
    private double radio;

    // Constructor para inicializar el radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Método para calcular el área de un círculo
    // Usa la fórmula: área = PI * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Método para calcular el perímetro (circunferencia) de un círculo
    // Usa la fórmula: perímetro = 2 * PI * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase para representar un rectángulo
public class Rectangulo
{
    // Atributos privados para la base y la altura
    private double baseRect;
    private double altura;

    // Constructor para inicializar la base y la altura
    public Rectangulo(double baseRect, double altura)
    {
        this.baseRect = baseRect;
        this.altura = altura;
    }

    // Método para calcular el área de un rectángulo
    // Usa la fórmula: área = base * altura
    public double CalcularArea()
    {
        return baseRect * altura;
    }

    // Método para calcular el perímetro del rectángulo
    // Usa la fórmula: perímetro = 2 * (base + altura)
    public double CalcularPerimetro()
    {
        return 2 * (baseRect + altura);
    }
}

// Clase principal para ejecutar los cálculos
class Programa
{
    static void Main()
    {
        Circulo miCirculo = new Circulo(5);
        Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

        Rectangulo miRectangulo = new Rectangulo(4, 6);
        Console.WriteLine("Área del rectángulo: " + miRectangulo.CalcularArea());
        Console.WriteLine("Perímetro del rectángulo: " + miRectangulo.CalcularPerimetro());
    }
}
