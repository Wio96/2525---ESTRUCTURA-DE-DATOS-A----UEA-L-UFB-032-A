using System;
using System.Collections.Generic;

class Contacto
{
    public string? Nombre { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }

    public void Mostrar()
    {
        Console.WriteLine($"Nombre: {Nombre}, Teléfono: {Telefono}, Correo: {Correo}");
    }
}

class Program
{
    static List<Contacto> agenda = new List<Contacto>();

    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("\n--- AGENDA TELEFÓNICA ---");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar todos los contactos");
            Console.WriteLine("3. Buscar contacto");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out opcion))
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
                continue;
            }

            switch (opcion)
            {
                case 1:
                    AgregarContacto();
                    break;
                case 2:
                    MostrarContactos();
                    break;
                case 3:
                    BuscarContacto();
                    break;
                case 4:
                    Console.WriteLine("Gracias por usar la agenda.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }

        } while (opcion != 4);
    }

    static void AgregarContacto()
    {
        Contacto nuevo = new Contacto();

        Console.Write("Ingrese el nombre: ");
        nuevo.Nombre = Console.ReadLine();

        Console.Write("Ingrese el teléfono: ");
        nuevo.Telefono = Console.ReadLine();

        Console.Write("Ingrese el correo electrónico: ");
        nuevo.Correo = Console.ReadLine();

        agenda.Add(nuevo);
        Console.WriteLine("Contacto agregado con éxito.");
    }

        }
    }

    static void BuscarContacto()
    {
        Console.Write("Ingrese el nombre a buscar: ");
        string? nombreBuscado = Console.ReadLine()?.ToLower();
        bool encontrado = false;

        foreach (Contacto c in agenda)
        {
            if (c.Nombre?.ToLower() == nombreBuscado)
            {
                Console.WriteLine("Contacto encontrado:");
                c.Mostrar();
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("No se encontró el contacto.");
        }
    }
}
