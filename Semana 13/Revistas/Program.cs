

class Program
{
    static List<string> catalogo = new List<string>
    {
        "National Geographic",
        "Time",
        "Forbes",
        "Nature",
        "Science",
        "Sports Illustrated",
        "Vogue",
        "The Economist",
        "Popular Mechanics",
        "Reader's Digest"
    };

    static void Main()
    {
        int opcion = -1;
        while (opcion != 0)
        {
            Console.WriteLine("\n=== CATALOGO DE REVISTAS ===");
            Console.WriteLine("1. Buscar revista");
            Console.WriteLine("2. Mostrar catalogo");
            Console.WriteLine("0. Salir");
            Console.Write("Opcion: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                Console.Write("Ingrese el titulo a buscar: ");
                string titulo = Console.ReadLine();

                bool encontrado = BuscarRecursivo(catalogo, titulo, 0);

                if (encontrado)
                    Console.WriteLine("Encontrado");
                else
                    Console.WriteLine("No encontrado");
            }
            else if (opcion == 2)
            {
                foreach (var revista in catalogo)
                {
                    Console.WriteLine("- " + revista);
                }
            }
            else if (opcion == 0)
            {
                Console.WriteLine("Adios...");
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }
        }
    }

    static bool BuscarRecursivo(List<string> lista, string titulo, int i)
    {
        if (i >= lista.Count) return false;
        if (lista[i].Equals(titulo, StringComparison.OrdinalIgnoreCase)) return true;
        return BuscarRecursivo(lista, titulo, i + 1);
    }
}
