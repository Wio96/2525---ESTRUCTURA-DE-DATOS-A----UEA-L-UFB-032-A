List<int> ids = new List<int>();
List<string> titulos = new List<string>();
int opcion = -1;

while (opcion != 0)
{
    Console.WriteLine("1) Agregar libro");
    Console.WriteLine("2) Mostrar libros");
    Console.WriteLine("3) Consultar por ID");
    Console.WriteLine("4) Eliminar por ID");
    Console.WriteLine("0) Salir");
    Console.Write("Opcion: ");
    opcion = int.Parse(Console.ReadLine());

    if (opcion == 1)
    {
        Console.Write("ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Titulo: ");
        string titulo = Console.ReadLine();
        ids.Add(id);
        titulos.Add(titulo);
        Console.WriteLine("Libro agregado.");
    }
    else if (opcion == 2)
    {
        for (int i = 0; i < ids.Count; i++)
            Console.WriteLine(ids[i] + ": " + titulos[i]);
    }
    else if (opcion == 3)
    {
        Console.Write("ID a consultar: ");
        int id = int.Parse(Console.ReadLine());
        int index = ids.IndexOf(id);
        if (index >= 0) Console.WriteLine(ids[index] + ": " + titulos[index]);
        else Console.WriteLine("No existe.");
    }
    else if (opcion == 4)
    {
        Console.Write("ID a eliminar: ");
        int id = int.Parse(Console.ReadLine());
        int index = ids.IndexOf(id);
        if (index >= 0)
        {
            Console.WriteLine("Libro " + titulos[index] + " eliminado.");
            ids.RemoveAt(index);
            titulos.RemoveAt(index);
        }
        else Console.WriteLine("No se encontro.");
    }
    else if (opcion == 0)
        Console.WriteLine("Saliendo...");
    else
        Console.WriteLine("Opcion invalida");
}
