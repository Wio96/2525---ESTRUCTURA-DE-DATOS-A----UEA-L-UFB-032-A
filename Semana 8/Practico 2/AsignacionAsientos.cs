public class Persona
{
    public string Nombre { get; }
    public Persona(string nombre) => Nombre = nombre;
}

public class Atraccion
{
    private Queue<Persona> cola = new();
    private List<Persona> asientos = new();
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
        foreach (Persona persona in cola)
        {
            Console.WriteLine($"- {persona.Nombre}");
        }
    }
}

Atraccion atraccion = new Atraccion(3);
bool salir = false;

while (!salir)
{
    Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
    Console.WriteLine("1. Ingresar persona a la cola");
    Console.WriteLine("2. Asignar asientos");
    Console.WriteLine("3. Mostrar asientos asignados");
    Console.WriteLine("4. Mostrar personas en la cola");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");
    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.Write("Ingrese nombre de la persona: ");
            string nombre = Console.ReadLine();
            atraccion.IngresarPersona(nombre);
            break;
        case "2":
            atraccion.AsignarAsientos();
            break;
        case "3":
            atraccion.MostrarAsientos();
            break;
        case "4":
            atraccion.MostrarCola();
            break;
        case "5":
            salir = true;
            break;
        default:
            Console.WriteLine("Opción no válida.");
            break;
    }
}

Console.WriteLine("Programa finalizado.");
