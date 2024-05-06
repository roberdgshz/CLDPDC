string cadena = "Hola Mundo";
char primerCaracter = cadena[0]; 
char tercerCaracter = cadena[2]; 

string subcadena1 = cadena.Substring(0, 4); 
string subcadena2 = cadena.Substring(5);     

int longitud = cadena.Length; 

string nuevaCadena = cadena + " - ¡Adiós Mundo!"; 

string repetida = new string('X', 3); 

foreach (char c in cadena)
{
    Console.WriteLine(c); 
}

string enMayusculas = cadena.ToUpper();   
string enMinusculas = cadena.ToLower();   

string reemplazada = cadena.Replace("Mundo", "Amigo"); 

string[] palabras = cadena.Split(' '); 

string[] partes = { "Hola", "Mundo" };
string unida = string.Join(" ", partes); 

string nombre = "Juan";
int edad = 30;
string mensaje = $"Hola, me llamo {nombre} y tengo {edad} años."; 

bool contieneHola = cadena.Contains("Hola");
bool comienzaConHola = cadena.StartsWith("Hola");
bool terminaConMundo = cadena.EndsWith("Mundo");

//-----------------------------------------------------------------------------------------

Console.Write("Ingrese la primera palabra: ");
string palabra1 = Console.ReadLine().ToLower();

Console.Write("Ingrese la segunda palabra: ");
string palabra2 = Console.ReadLine().ToLower();

bool palindromo1 = EsPalindromo(palabra1);
bool palindromo2 = EsPalindromo(palabra2);

Console.WriteLine("Palíndromo:");
Console.WriteLine("La primera palabra es palíndromo: " + palindromo1);
Console.WriteLine("La segunda palabra es palíndromo: " + palindromo2);

bool anagrama = SonAnagramas(palabra1, palabra2);
Console.WriteLine("\nAnagrama:");
Console.WriteLine("Las dos palabras son anagramas: " + anagrama);

bool isograma1 = EsIsograma(palabra1);
bool isograma2 = EsIsograma(palabra2);
Console.WriteLine("\nIsograma:");
Console.WriteLine("La primera palabra es isograma: " + isograma1);
Console.WriteLine("La segunda palabra es isograma: " + isograma2);

bool EsPalindromo(string palabra)
{
    string reverso = new string(palabra.Reverse().ToArray());
    return palabra == reverso;
}

bool SonAnagramas(string palabra1, string palabra2)
{
    if (palabra1.Length != palabra2.Length)
        return false;

    char[] caracteres1 = palabra1.ToCharArray();
    char[] caracteres2 = palabra2.ToCharArray();

    Array.Sort(caracteres1);
    Array.Sort(caracteres2);

    return new string(caracteres1) == new string(caracteres2);
}

bool EsIsograma(string palabra)
{
    return palabra.Distinct().Count() == palabra.Length;
}

//-Roberto Grijalva Sanchez