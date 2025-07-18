using System;

class Program
{
    static void Main(string[] args)
    {
        Atraccion atraccion = new Atraccion(30);
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
    }
}
