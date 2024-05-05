int suma = 10 + 5;
int resta = 10 - 5;
int multiplicacion = 10 * 5;
int division = 10 / 5;
int modulo = 10 % 5;

Console.WriteLine(suma);
Console.WriteLine(resta);
Console.WriteLine(multiplicacion);
Console.WriteLine(division);
Console.WriteLine(modulo);
Console.WriteLine();

bool and = true && false;
bool or = true || false;
bool not = !true;

Console.WriteLine(and);
Console.WriteLine(or);
Console.WriteLine(not);
Console.WriteLine();

bool igual = 10 == 5;
bool noIgual = 10 != 5;
bool mayorQue = 10 > 5;
bool menorQue = 10 < 5;
bool mayorIgual = 10 >= 5;
bool menorIgual = 10 <= 5;

Console.WriteLine(igual);
Console.WriteLine(noIgual);
Console.WriteLine(mayorQue);
Console.WriteLine(menorQue);
Console.WriteLine(mayorIgual);
Console.WriteLine(menorIgual);
Console.WriteLine();

int a = 10, b = 5;
a += b;
Console.WriteLine(a);
a -= b;
Console.WriteLine(a);
a *= b;
Console.WriteLine(a);
a /= b;
Console.WriteLine(a);
a %= b;
Console.WriteLine(a);
Console.WriteLine();

string[] nombres = { "Juan", "María", "Pedro" };
string nombre = "Juan";
bool esIgual = (object)nombres == (object)nombre;
bool contiene = nombres.Contains(nombre);
Console.WriteLine(esIgual);
Console.WriteLine(contiene);
Console.WriteLine();

int x = 60;       
int y = 13;       
int resultado = 0;
resultado = x & y;
Console.WriteLine(resultado);
resultado = x | y;
Console.WriteLine(resultado);
resultado = x ^ y;
Console.WriteLine(resultado);
resultado = ~x;
Console.WriteLine(resultado);
resultado = x << 2;
Console.WriteLine(resultado);
resultado = x >> 2;
Console.WriteLine(resultado);
Console.WriteLine();

int edad = 18;
if (edad >= 18)
{
    Console.WriteLine("Eres mayor de edad");
}
else
{
    Console.WriteLine("Eres menor de edad");
}


int contador = 0;
while (contador < 5)
{
    Console.WriteLine("Contador: " + contador);
    contador++;
}

contador = 0;
do
{
    Console.WriteLine("Contador: " + contador);
    contador++;
} while (contador < 5);

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Índice: " + i);
}

string[] nombres2 = { "Juan", "María", "Pedro" };
foreach (string nombre2 in nombres2)
{
    Console.WriteLine("Nombre: " + nombre2);
}

try
{
    int divisor = 0;
    int resultado2 = 10 / divisor;
    Console.WriteLine("Resultado: " + resultado2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: División por cero, error "+ex);
}
finally
{
    Console.WriteLine("Esto se ejecuta siempre");
}

//-Roberto Grijalva Sanchez