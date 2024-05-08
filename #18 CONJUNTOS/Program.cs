List<int> conjuntoDatos = new List<int>();

conjuntoDatos.Add(10);

conjuntoDatos.Insert(0, 5);

conjuntoDatos.AddRange(new int[] { 20, 30, 40 });

conjuntoDatos.InsertRange(2, new int[] { 15, 25 });

conjuntoDatos.RemoveAt(3);

conjuntoDatos[1] = 7;

int elementoBuscado = 30;
bool estaEnConjunto = conjuntoDatos.Contains(elementoBuscado);
Console.WriteLine($"El elemento {elementoBuscado} {(estaEnConjunto ? "sí" : "no")} está en el conjunto.");

conjuntoDatos.Clear();

Console.WriteLine("\nContenido del conjunto después de limpiarlo:");
foreach (var elemento in conjuntoDatos)
{
    Console.WriteLine(elemento);
}

//------------------------------------------------------------------------------------------------------

// Conjunto 1
HashSet<int> conjunto1 = new HashSet<int> { 1, 2, 3, 4, 5 };
// Conjunto 2
HashSet<int> conjunto2 = new HashSet<int> { 4, 5, 6, 7, 8 };

// Unión
HashSet<int> union = new HashSet<int>(conjunto1);
union.UnionWith(conjunto2);
Console.WriteLine("Unión:");
foreach (var num in union)
{
    Console.WriteLine(num);
}

// Intersección
HashSet<int> interseccion = new HashSet<int>(conjunto1);
interseccion.IntersectWith(conjunto2);
Console.WriteLine("\nIntersección:");
foreach (var num in interseccion)
{
    Console.WriteLine(num);
}

// Diferencia
HashSet<int> diferencia = new HashSet<int>(conjunto1);
diferencia.ExceptWith(conjunto2);
Console.WriteLine("\nDiferencia (conjunto1 - conjunto2):");
foreach (var num in diferencia)
{
    Console.WriteLine(num);
}

// Diferencia simétrica
HashSet<int> diferenciaSimetrica = new HashSet<int>(conjunto1);
diferenciaSimetrica.SymmetricExceptWith(conjunto2);
Console.WriteLine("\nDiferencia simétrica:");
foreach (var num in diferenciaSimetrica)
{
    Console.WriteLine(num);
}
//-Roberto Grijalva Sanchez