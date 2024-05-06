Pila pila = new Pila();

pila.Push(1);
pila.Push(2);
pila.Push(3);

while (!pila.EstaVacia())
{
    Console.WriteLine("Pop: " + pila.Pop());
}

Cola cola = new Cola();

cola.Enqueue(1);
cola.Enqueue(2);
cola.Enqueue(3);

while (!cola.EstaVacia())
{
    Console.WriteLine("Dequeue: " + cola.Dequeue());
}

NavegadorWeb navegador = new NavegadorWeb();

while (true)
{
    Console.Write("Ingrese una acción (adelante, atrás, viajar a una página o salir): ");
    string entrada = Console.ReadLine().ToLower();

    if (entrada == "adelante")
    {
        navegador.Avanzar();
    }
    else if (entrada == "atrás")
    {
        navegador.Retroceder();
    }
    else if(entrada == "salir")
    {
        break;
    }
    else
    {
        navegador.IrA(entrada);
    }
}

ImpresoraCompartida impresora = new ImpresoraCompartida();

while (true)
{
    Console.Write("Ingrese un comando (imprimir o nombre de documento): ");
    string entrada = Console.ReadLine().ToLower();

    if (entrada == "imprimir")
    {
        impresora.Imprimir();
    }
    else if(entrada == "salir")
    {
        break;
    }
    else
    {
        impresora.AgregarDocumento(entrada);
    }
}

class Cola
{
    private List<int> elementos = new List<int>();

    public void Enqueue(int elemento)
    {
        elementos.Add(elemento);
    }

    public int Dequeue()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("La cola está vacía");
        }

        int elemento = elementos[0];
        elementos.RemoveAt(0);
        return elemento;
    }

    public int Peek()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("La cola está vacía");
        }

        return elementos[0];
    }

    public bool EstaVacia()
    {
        return elementos.Count == 0;
    }
}

class Pila
{
    private List<int> elementos = new List<int>();

    public void Push(int elemento)
    {
        elementos.Add(elemento);
    }

    public int Pop()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("La pila está vacía");
        }

        int elemento = elementos[elementos.Count - 1];
        elementos.RemoveAt(elementos.Count - 1);
        return elemento;
    }

    public int Peek()
    {
        if (elementos.Count == 0)
        {
            throw new InvalidOperationException("La pila está vacía");
        }

        return elementos[elementos.Count - 1];
    }

    public bool EstaVacia()
    {
        return elementos.Count == 0;
    }
}

//-------------------------------------------------------------------------------------------



class NavegadorWeb
{
    private Stack<string> historial = new Stack<string>();
    private string paginaActual = "Inicio", paginaSiguiente = "";

    public void IrA(string pagina)
    {
        historial.Push(paginaActual);
        paginaActual = pagina;
        Console.WriteLine($"Navegando a: {paginaActual}");
    }

    public void Retroceder()
    {
        if (historial.Count == 0)
        {
            Console.WriteLine("No hay páginas para retroceder");
            return;
        }
        paginaSiguiente = paginaActual;
        string paginaAnterior = historial.Pop();
        Console.WriteLine($"Retrocediendo a: {paginaAnterior}");
        paginaActual = paginaAnterior;
    }

    public void Avanzar()
    {
        historial.Push(paginaSiguiente);
        paginaActual = paginaSiguiente;
        Console.WriteLine($"Navegando a: {paginaActual}");
    }
}

class ImpresoraCompartida
{
    private Queue<string> colaDocumentos = new Queue<string>();

    public void AgregarDocumento(string documento)
    {
        colaDocumentos.Enqueue(documento);
        Console.WriteLine($"Documento '{documento}' agregado a la cola de impresión");
    }

    public void Imprimir()
    {
        if (colaDocumentos.Count == 0)
        {
            Console.WriteLine("No hay documentos en la cola para imprimir");
            return;
        }

        string documento = colaDocumentos.Dequeue();
        Console.WriteLine($"Imprimiendo documento: {documento}");
    }
}



//-Roberto Grijalva Sanchez