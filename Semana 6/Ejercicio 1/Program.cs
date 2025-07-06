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

    // Agregar un nodo al final de la lista
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

    // ✅ Función que calcula el número de elementos de la lista
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = cabeza;

        while (actual != null)
        {
            contador++;          // Contamos cada nodo
            actual = actual.siguiente; // Saltamos al siguiente nodo
        }

        return contador;
    }

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

        Console.WriteLine("Elementos en la lista:");
        lista.Mostrar();

        Console.WriteLine("Cantidad total de elementos: " + lista.ContarElementos());
    }
}
