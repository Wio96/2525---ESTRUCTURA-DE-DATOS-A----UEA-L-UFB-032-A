using System;

// Clase que representa un estudiante
public class Estudiante
{
    // Atributos privados para encapsular los datos
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos; // Array para almacenar los 3 teléfonos

    // Constructor de la clase Estudiante
    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        this.id = id;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.direccion = direccion;
        this.telefonos = telefonos;
    }

    // Método para mostrar la información del estudiante
    public void MostrarInformacion()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Nombres: " + nombres);
        Console.WriteLine("Apellidos: " + apellidos);
        Console.WriteLine("Dirección: " + direccion);
        Console.WriteLine("Teléfonos:");
        for (int i = 0; i < telefonos.Length; i++)
        {
            Console.WriteLine("- " + telefonos[i]);
        }
    }
}

// Clase principal que ejecuta el programa
class Programa
{
    static void Main()
    {
        // Se crea un array con tres teléfonos
        string[] telefonos = new string[3] { "0987654321", "0991234567", "0976543210" };

        // Se instancia un estudiante con sus datos
        Estudiante estudiante1 = new Estudiante(
            1,
            "Ana María",
            "Pérez Gómez",
            "Av. Amazonas N34-56",
            telefonos
        );

        // Se muestra la información del estudiante
        estudiante1.MostrarInformacion();
    }
}
