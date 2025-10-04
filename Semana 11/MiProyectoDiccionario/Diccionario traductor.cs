// Diccionario inicial Español -> Inglés
var diccionario = new Dictionary<string, string>()
{
    {"tiempo","time"},
    {"persona","person"},
    {"año","year"},
    {"camino","way"},
    {"día","day"},
    {"cosa","thing"},
    {"hombre","man"},
    {"mundo","world"},
    {"vida","life"},
    {"mano","hand"},
    {"parte","part"},
    {"niño","child"},
    {"ojo","eye"},
    {"mujer","woman"},
    {"lugar","place"},
    {"trabajo","work"},
    {"semana","week"},
    {"caso","case"},
    {"punto","point"},
    {"gobierno","government"}
};

int opcion;
do
{
    Console.WriteLine("\n===== MENÚ =====");
    Console.WriteLine("1. Traducir una frase");
    Console.WriteLine("2. Agregar palabras al diccionario");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");
    int.TryParse(Console.ReadLine(), out opcion);

    if (opcion == 1)
    {
        Console.Write("Frase: ");
        string frase = Console.ReadLine() ?? "";
        string[] palabras = frase.Split(' ');

        for (int i = 0; i < palabras.Length; i++)
        {
            string token = palabras[i];
            string palabra = token.ToLower(); // Sin Trim si tu profe no lo pidió

            if (diccionario.ContainsKey(palabra))
            {
                string tradu = diccionario[palabra];
                if (char.IsUpper(token[0]))
                    tradu = char.ToUpper(tradu[0]) + tradu.Substring(1);
                palabras[i] = tradu;
            }
        }

        Console.WriteLine("Traducción (parcial): " + string.Join(" ", palabras));
    }
    else if (opcion == 2)
    {
        Console.Write("Palabra en español: ");
        string esp = Console.ReadLine() ?? "";
        Console.Write("Traducción en inglés: ");
        string ing = Console.ReadLine() ?? "";

        if (!diccionario.ContainsKey(esp))
        {
            diccionario.Add(esp, ing);
            Console.WriteLine("Palabra agregada correctamente.");
        }
        else
            Console.WriteLine("La palabra ya existe en el diccionario.");
    }

} while (opcion != 0);

Console.WriteLine("¡Hasta luego!");
