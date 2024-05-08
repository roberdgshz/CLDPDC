static async Task Main(string[] args)
{
    Console.WriteLine("Iniciando programa principal...");

    Task tareaC = EjecutarFuncionAsync("Función C", 3);
    Task tareaB = EjecutarFuncionAsync("Función B", 2);
    Task tareaA = EjecutarFuncionAsync("Función A", 1);

    await Task.WhenAll(tareaC, tareaB, tareaA);

    await EjecutarFuncionAsync("Función D", 1);

    Console.WriteLine("Programa principal finalizado.");
}

static async Task EjecutarFuncionAsync(string nombre, int segundos)
{
    Console.WriteLine($"{nombre} empezará a ejecutarse.");
    DateTime inicio = DateTime.Now;

    await Task.Delay(segundos * 1000);

    DateTime fin = DateTime.Now;
    TimeSpan duracion = fin - inicio;
    Console.WriteLine($"{nombre} ha finalizado. Duración: {duracion.TotalSeconds} segundos.");
}

//-Roberto Grijalva Sanchez