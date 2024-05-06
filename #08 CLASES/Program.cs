Persona persona1 = new Persona("Juan", 30);

Console.WriteLine("Atributos originales:");
persona1.Imprimir();

persona1.Nombre = "María";
persona1.Edad = 25;

Console.WriteLine("\nAtributos modificados:");
persona1.Imprimir();

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void Imprimir()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
    }
}


//------------------------------------------------------------------------------

class Pila<T>
{
    private Stack<T> elementos = new Stack<T>();

    public void Push(T elemento)
    {
        elementos.Push(elemento);
    }

    public T Pop()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("La pila está vacía");
        }

        return elementos.Pop();
    }

    public int ContarElementos()
    {
        return elementos.Count;
    }

    public void Imprimir()
    {
        Console.WriteLine("Contenido de la pila:");
        foreach (var elemento in elementos)
        {
            Console.WriteLine(elemento);
        }
    }
}



class Cola<T>
{
    private Queue<T> elementos = new Queue<T>();

    public void Enqueue(T elemento)
    {
        elementos.Enqueue(elemento);
    }

    public T Dequeue()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("La cola está vacía");
        }

        return elementos.Dequeue();
    }

    public int ContarElementos()
    {
        return elementos.Count;
    }

    public void Imprimir()
    {
        Console.WriteLine("Contenido de la cola:");
        foreach (var elemento in elementos)
        {
            Console.WriteLine(elemento);
        }
    }
}

//-Roberto Grijalva Sanchez