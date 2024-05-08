static async Task Main(string[] args)
{
    Console.WriteLine("Iniciando programa principal...");

    await EjecutarFuncionAsync("Función 1", 3);
    await EjecutarFuncionAsync("Función 2", 5);

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