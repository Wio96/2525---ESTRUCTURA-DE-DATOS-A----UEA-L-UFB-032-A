
class Biblioteca
{
    private HashSet<string> titulos;
    private Dictionary<int, string> catalogo;

    public Biblioteca()
    {
        titulos = new HashSet<string>();
        catalogo = new Dictionary<int, string>();
    }

    // Convierte título a formato "Título Capitalizado"
    private string NormalizarTitulo(string titulo)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase((titulo ?? "").ToLower());
    }

    public void AgregarLibro(int id, string titulo)
    {
        titulo = NormalizarTitulo(titulo);

        if (!titulos.Contains(titulo))
        {
            titulos.Add(titulo);
            catalogo[id] = titulo;
            Console.WriteLine($"Libro '{titulo}' agregado con ID {id}.");
        }
        else
        {
            Console.WriteLine("El libro ya existe en la biblioteca.");
        }
    }

    public void ConsultarLibro(int id)
    {
        if (catalogo.ContainsKey(id))
            Console.WriteLine($"ID {id}: {catalogo[id]}");
        else
            Console.WriteLine("El libro no existe en el catálogo.");
    }

    public void EliminarLibro(int id)
    {
        if (catalogo.ContainsKey(id))
        {
            string titulo = catalogo[id];
            catalogo.Remove(id);
            titulos.Remove(titulo);
            Console.WriteLine($"Libro '{titulo}' eliminado.");
        }
        else
        {
            Console.WriteLine("No se encontró el libro con ese ID.");
        }
    }

    public void MostrarLibros()
    {
        if (catalogo.Count == 0)
        {
            Console.WriteLine("No hay libros en la biblioteca.");
            return;
        }

        Console.WriteLine("\nListado de libros en la biblioteca:");
        foreach (var libro in catalogo)
            Console.WriteLine($"ID {libro.Key}: {libro.Value}");
    }
}

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        string opcion;

        do
        {
            Console.WriteLine("\n=== Menú Biblioteca ===");
            Console.WriteLine("1) Agregar libro");
            Console.WriteLine("2) Mostrar todos los libros");
            Console.WriteLine("3) Consultar libro por ID");
            Console.WriteLine("4) Eliminar libro por ID");
            Console.WriteLine("0) Salir");
            Console.Write("Seleccione una opción: ");
            opcion = (Console.ReadLine() ?? "").Trim();

            switch (opcion)
            {
                case "1":
                    if (LeerEntero("Ingrese ID del libro: ", out int idAgregar))
                    {
                        Console.Write("Ingrese título del libro: ");
                        string titulo = Console.ReadLine() ?? "";
                        biblioteca.AgregarLibro(idAgregar, titulo);
                    }
                    break;

                case "2":
                    biblioteca.MostrarLibros();
                    break;

                case "3":
                    if (LeerEntero("Ingrese ID a consultar: ", out int idConsultar))
                        biblioteca.ConsultarLibro(idConsultar);
                    break;

                case "4":
                    if (LeerEntero("Ingrese ID a eliminar: ", out int idEliminar))
                        biblioteca.EliminarLibro(idEliminar);
                    break;

                case "0":
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }

        } while (opcion != "0");
    }

    // Función para validar que el usuario ingrese un entero
    static bool LeerEntero(string mensaje, out int valor)
    {
        Console.Write(mensaje);
        string entrada = Console.ReadLine() ?? "";
        if (int.TryParse(entrada, out valor))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Error: ingrese un número entero válido.");
            valor = 0;
            return false;
        }
    }
}
