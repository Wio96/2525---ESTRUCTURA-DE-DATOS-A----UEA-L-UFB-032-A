class Nodo
{
    public string Nombre;
    public List<Nodo> Hijos = new List<Nodo>();

    public Nodo(string nombre)
    {
        Nombre = nombre;
    }

    public void AgregarHijo(Nodo hijo)
    {
        Hijos.Add(hijo);
    }

    public void Imprimir(string espacio = "")
    {
        Console.WriteLine(espacio + Nombre);
        foreach (var hijo in Hijos)
            hijo.Imprimir(espacio + "  ");
    }
}

// Leer archivo notas.txt
string[] lineas = File.ReadAllLines("notas.txt");

// Listas para estudiantes y materias
List<Nodo> estudiantes = new List<Nodo>();
List<Nodo> materias = new List<Nodo>();

foreach (string linea in lineas)
{
    string[] partes = linea.Split(',');
    if (partes.Length != 3) continue;

    string nombre = partes[0];
    string materia = partes[1];
    string nota = partes[2];

    // Buscar si ya existe el estudiante
    Nodo est = estudiantes.Find(e => e.Nombre == nombre);
    if (est == null)
    {
        est = new Nodo(nombre);
        estudiantes.Add(est);
    }
    est.AgregarHijo(new Nodo(materia + ": " + nota));

    // Buscar si ya existe la materia
    Nodo mat = materias.Find(m => m.Nombre == materia);
    if (mat == null)
    {
        mat = new Nodo(materia);
        materias.Add(mat);
    }
    mat.AgregarHijo(new Nodo(nombre + ": " + nota));
}

// Imprimir árbol por estudiante
Console.WriteLine("Árbol de notas por estudiante:\n");
foreach (var est in estudiantes)
    est.Imprimir();

Console.WriteLine("\n-----------------------------\n");

// Imprimir árbol por materia
Console.WriteLine("Árbol de notas por materia:\n");
foreach (var mat in materias)
    mat.Imprimir();
