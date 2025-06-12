using System;

namespace RegistroEstudiantes
{
    // Definición de la clase Estudiante
    public class Estudiante
    {
        // Atributos de la clase
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string[] Telefonos { get; set; }  // Array para almacenar tres teléfonos

        // Constructor
        public Estudiante(int id, string nombres, string apellidos, string direccion, string[] telefonos)
        {
            Id = id;
            Nombres = nombres;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefonos = telefonos;
        }

        // Método para mostrar los datos del estudiante
        public void MostrarInformacion()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Nombres: " + Nombres);
            Console.WriteLine("Apellidos: " + Apellidos);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfonos:");
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"Teléfono {i + 1}: {Telefonos[i]}");
            }
        }
    }

    // Clase principal
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un array con 3 teléfonos
            string[] telefonos = { "0987654321", "0991234567", "0976543210" };

            // Instanciar un objeto Estudiante
            Estudiante estudiante = new Estudiante(1, "Juan", "Pérez", "Av. Siempre Viva 123", telefonos);

            // Mostrar información del estudiante
            estudiante.MostrarInformacion();
        }
    }
}
