saludo();
int a = 10, b = 5;
mayor(b,a);
Console.WriteLine("La suma de los numeros es: "+suma(a,b));
Console.WriteLine("La cantidad de ocurrencias es: "+multiplos("str1", "str2"));
void saludo()
{
    Console.WriteLine("Este es un saludo genérico.");
}

void mayor(int numero1, int numero2)
{
    if (numero1 > numero2)
    {
        Console.WriteLine("El numero 1 -> "+numero1+ ", es el mayor!");
    } else if (numero1 < numero2)
    {
        Console.WriteLine("El numero 2 -> "+numero2+", es el mayor!");
    } else
    {
        Console.WriteLine("Ninguno es mayor que el otro");
    }
}

int suma(int numero1, int numero2)
{
    return numero1 + numero2;
}

void mayor2(int numero1, int numero2)
{
    void mensajeMayor(int n)
    {
        Console.WriteLine("El numero: " + n + ", es el mayor!");
    }

    if (numero1 > numero2)
    {
        mensajeMayor(numero1);
        
    }
    else if (numero1 < numero2)
    {
        mensajeMayor(numero2);
    }
    else
    {
        Console.WriteLine("Ninguno es mayor que el otro");
    }
}

int multiplos(String str1, String str2)
{
    int contador = 0;
    for (int i = 0; i < 101;i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine(str1);
            contador++;
        }else if (i % 5 == 0)
        {
            Console.WriteLine(str2);
            contador++;
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine(str1+str2);
            contador++;
        }
    }
    return contador;
}
//-Roberto Grijalva Sanchez