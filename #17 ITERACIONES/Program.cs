Console.WriteLine("Utilizando bucle for:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("Utilizando bucle while:");
int j = 1;
while (j <= 10)
{
    Console.WriteLine(j);
    j++;
}

Console.WriteLine("Utilizando bucle foreach:");
int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
foreach (int num in numeros)
{
    Console.WriteLine(num);
}

//-------------------------------------------------------------------------------
// Bucle do-while
Console.WriteLine("\nBucle do-while:");
int k = 1;
do
{
    Console.WriteLine(k);
    k++;
} while (k <= 5);

// Método ForEach() de la clase List<T>
Console.WriteLine("\nMétodo ForEach() de la clase List<T>:");
List<int> listaNumeros = new List<int> { 1, 2, 3, 4, 5 };
listaNumeros.ForEach(num => Console.WriteLine(num));

// Método Select() de LINQ
Console.WriteLine("\nMétodo Select() de LINQ:");
var resultadoSelect = Enumerable.Range(1, 5).Select(num => num);
foreach (var num in resultadoSelect)
{
    Console.WriteLine(num);
}

// Método ForEach() de LINQ
Console.WriteLine("\nMétodo ForEach() de LINQ:");
var resultadoForEach = Enumerable.Range(1, 5);
resultadoForEach.ToList().ForEach(num => Console.WriteLine(num));

// Método Aggregate() de LINQ
Console.WriteLine("\nMétodo Aggregate() de LINQ:");
var resultadoAggregate = Enumerable.Range(1, 5).Aggregate((acc, num) => acc + num);
Console.WriteLine(resultadoAggregate);

// Método Zip() de LINQ
Console.WriteLine("\nMétodo Zip() de LINQ:");
var resultadoZip = Enumerable.Range(1, 5).Zip(Enumerable.Range(6, 5), (x, y) => x + y);
foreach (var num in resultadoZip)
{
    Console.WriteLine(num);
}

// Método Skip() y Take() de LINQ combinados
Console.WriteLine("\nMétodo Skip() y Take() de LINQ combinados:");
var resultadoSkipTake = Enumerable.Range(1, 10).Skip(5).Take(5);
foreach (var num in resultadoSkipTake)
{
    Console.WriteLine(num);
}

//-Roberto Grijalva Sanchez