using System;
using System.Collections.Generic;

public class Atraccion
{
    private Queue<Persona> cola = new Queue<Persona>();
    private List<Persona> asientos = new List<Persona>();
    private int capacidadMaxima;

    public Atraccion(int capacidad)
    {
        capacidadMaxima = capacidad;
    }

    public void IngresarPersona(string nombre)
    {
        if (asientos.Count >= capacidadMaxima)
        {
            Console.WriteLine("Todos los asientos están ocupados.");
            return;
        }

        Persona nuevaPersona = new Persona(nombre);
        cola.Enqueue(nuevaPersona);
        Console.WriteLine($"{nombre} ha ingresado a la cola.");
    }

    public void AsignarAsientos()
    {
        while (cola.Count > 0 && asientos.Count < capacidadMaxima)
        {
            Persona persona = cola.Dequeue();
            asientos.Add(persona);
            Console.WriteLine($"Asiento asignado a {persona.Nombre}.");
        }

        if (asientos.Count == capacidadMaxima)
        {
            Console.WriteLine("Todos los asientos han sido asignados.");
        }
    }

    public void MostrarAsientos()
    {
        Console.WriteLine("\n🪑 Asientos asignados:");
        for (int i = 0; i < asientos.Count; i++)
        {
            Console.WriteLine($"Asiento {i + 1}: {asientos[i].Nombre}");
        }
    }

    public void MostrarCola()
    {
        Console.WriteLine("\n🎟 Personas en la cola:");
        if (cola.Count == 0)
        {
            Console.WriteLine("La cola está vacía.");
            return;
        }
        foreach (var persona in cola)
        {
            Console.WriteLine($"- {persona.Nombre}");
        }
    }
}
