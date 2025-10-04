
class Nodo
{
    public string Nombre;              // Nombre del nodo (estudiante o materia)
    public List<Nodo> Hijos = new List<Nodo>(); // Lista de hijos (notas o estudiantes)

    public Nodo(string nombre)
    {
        Nombre = nombre;
    }

    // Agregar un hijo al nodo
    public void AgregarHijo(Nodo hijo)
    {
        Hijos.Add(hijo);
    }

    // Imprimir árbol recursivamente
    public void Imprimir(string espacio = "")
    {
        Console.WriteLine(espacio + Nombre);
        foreach (var hijo in Hijos)
            hijo.Imprimir(espacio + "  ");
    }
}

class Programa
{
    static void Main()
    {
        // Construir la ruta correcta del archivo notas.txt en la carpeta raíz del proyecto
        string rutaArchivo = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "notas.txt");

        if (!File.Exists(rutaArchivo))
        {
            Console.WriteLine("Archivo notas.txt no encontrado en la carpeta del proyecto.");
            return;
        }

        // Leer todas las líneas del archivo
        string[] lineas = File.ReadAllLines(rutaArchivo);

        // Diccionarios para organizar los datos
        Dictionary<string, Nodo> estudiantes = new Dictionary<string, Nodo>();
        Dictionary<string, Nodo> materias = new Dictionary<string, Nodo>();

        // Procesar cada línea del archivo
        foreach (string linea in lineas)
        {
            // Formato esperado: Nombre, Materia, Nota
            string[] partes = linea.Split(',');
            if (partes.Length != 3) continue; // Ignorar líneas mal formateadas

            string nombre = partes[0].Trim();
            string materia = partes[1].Trim();
            string nota = partes[2].Trim();

            // Árbol por estudiante
            if (!estudiantes.ContainsKey(nombre))
                estudiantes[nombre] = new Nodo(nombre);
            estudiantes[nombre].AgregarHijo(new Nodo($"{materia}: {nota}"));

            // Árbol por materia
            if (!materias.ContainsKey(materia))
                materias[materia] = new Nodo(materia);
            materias[materia].AgregarHijo(new Nodo($"{nombre}: {nota}"));
        }

        // Imprimir árbol por estudiante
        Console.WriteLine("Árbol de notas por estudiante:\n");
        foreach (var est in estudiantes.Values)
            est.Imprimir();

        // Separador
        Console.WriteLine("\n-----------------------------\n");

        // Imprimir árbol por materia
        Console.WriteLine("Árbol de notas por materia:\n");
        foreach (var mat in materias.Values)
            mat.Imprimir();
    }
}
