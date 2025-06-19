using System;

public class Estudiante
{
    private int id;
    private string nombres;
    private string apellidos;
    private string direccion;
    private string[] telefonos;

    public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
    {
        this.id = id;
        this.nombres = nombres;
        this.apellidos = apellidos;
        this.direccion = direccion;
        this.telefonos = telefonos;
    }

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

class Program
{
    static void Main()
    {
        string[] telefonos = { "0987654321", "0991234567", "0976543210" };

        Estudiante estudiante1 = new Estudiante(
            1,
            "Ana María",
            "Pérez Gómez",
            "Av. Amazonas N34-56",
            telefonos
        );

        estudiante1.MostrarInformacion();
    }
}
