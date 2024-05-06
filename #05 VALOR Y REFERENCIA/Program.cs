int a = 10;
int b = a;
Console.WriteLine("Valor de a -> "+a+", Valor de B -> "+b);

int[] arreglo1 = { 1, 2, 3 };
int[] arreglo2 = arreglo1;

Console.WriteLine($"arreglo1[0]: {arreglo1[0]}, arreglo2[0]: {arreglo2[0]}"); 

arreglo2[0] = 10;

Console.WriteLine($"arreglo1[0]: {arreglo1[0]}, arreglo2[0]: {arreglo2[0]}"); 

int c = 20;
Console.WriteLine("Valor de c: " + c);
cambioDeValor(c);
Console.WriteLine("Valor nuevo de c: "+c);

cambioDeValorConReferencia(ref c);
Console.WriteLine("Valor nuevo de c con referencia: " + c);
void cambioDeValor(int numero)
{
    numero = 15;
}


void cambioDeValorConReferencia(ref int numero)
{
    numero = 50;
}

//-------------------------------------------------------------------------------------------
int originalA = 10;
int originalB = 20;

int nuevoA, nuevoB;
IntercambiarValoresPorValor(originalA, originalB, out nuevoA, out nuevoB);

Console.WriteLine("Valores originales:");
Console.WriteLine($"originalA: {originalA}, originalB: {originalB}");
Console.WriteLine("Valores intercambiados:");
Console.WriteLine($"nuevoA: {nuevoA}, nuevoB: {nuevoB}");

void IntercambiarValoresPorValor(int a, int b, out int nuevoA, out int nuevoB)
{
    nuevoA = b;
    nuevoB = a;
}

//--------------------------------------------------------------------------------------------
int originalA2 = 10;
int originalB2 = 20;

IntercambiarValoresPorReferencia(ref originalA2, ref originalB2);

Console.WriteLine("Valores originales:");
Console.WriteLine($"originalA2: {originalA2}, originalB2: {originalB2}");
Console.WriteLine("Valores intercambiados:");
Console.WriteLine($"originalA2: {originalA2}, originalB2: {originalB2}");
void IntercambiarValoresPorReferencia(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

//-Roberto Grijalva Sanchez