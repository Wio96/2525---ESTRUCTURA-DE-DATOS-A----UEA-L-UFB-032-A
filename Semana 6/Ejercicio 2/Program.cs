using System;

class Nodo
{
    public int dato;
    public Nodo siguiente;

    public Nodo(int valor)
    {
        dato = valor;
        siguiente = null;
    }
}

class ListaEnlazada
{
    public Nodo cabeza = null;

    // Agrega nodo al final
    public void Agregar(int valor)
    {
        Nodo nuevo = new Nodo(valor);
        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Nodo actual = cabeza;
            while (actual.siguiente != null)
            {
                actual = actual.siguiente;
            }
            actual.siguiente = nuevo;
        }
    }

    // ✅ Método para invertir la lista enlazada
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.siguiente;
            actual.siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        cabeza = anterior;
    }

    // ✅ Método para buscar un valor y retornar su posición (empezando en 1)
    public int Buscar(int valor)
    {
        Nodo actual = cabeza;
        int posicion = 1;

        while (actual != null)
        {
            if (actual.dato == valor)
            {
                return posicion;
            }
            actual = actual.siguiente;
            posicion++;
        }

        return -1; // No encontrado
    }

    // Mostrar lista
    public void Mostrar()
    {
        Nodo actual = cabeza;
        while (actual != null)
        {
            Console.Write(actual.dato + " ");
            actual = actual.siguiente;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.Agregar(10);
        lista.Agregar(20);
        lista.Agregar(30);
        lista.Agregar(40);
        lista.Agregar(50);

        Console.WriteLine("Lista original:");
        lista.Mostrar();

        lista.Invertir();
        Console.WriteLine("Lista invertida:");
        lista.Mostrar();

        Console.Write("Ingrese un número a buscar: ");
        int valorBuscado = int.Parse(Console.ReadLine());

        int posicion = lista.Buscar(valorBuscado);

        if (posicion != -1)
        {
            Console.WriteLine($"El número {valorBuscado} está en la posición {posicion}.");
        }
        else
        {
            Console.WriteLine("El número no está en la lista.");
        }
    }
}
