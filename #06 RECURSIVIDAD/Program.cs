int a = 100;
imprimirCienNumerosRecursivo(a);

void imprimirCienNumerosRecursivo(int n)
{
    if (n != -1)
    {
        Console.WriteLine(n);
        n--;
        imprimirCienNumerosRecursivo(n);
    }
}

//----------------------------------------------------------------------------------------
int factorial = 5;
Console.WriteLine("El factorial de "+factorial+" es: "+Factorial(factorial));

int fibonacci = 6;
Console.WriteLine("El valor de la posicion "+fibonacci+" es: "+Factorial(fibonacci));
int Factorial(int numero)
{
    if (numero == 0)
        return 1;

    int resultado = 1;
    for (int i = 1; i <= numero; i++)
    {
        resultado *= i;
    }
    return resultado;
}

int Fibonacci(int posicion)
{
    if (posicion <= 1)
        return posicion;

    int a = 0;
    int b = 1;
    for (int i = 2; i <= posicion; i++)
    {
        int temp = a + b;
        a = b;
        b = temp;
    }
    return b;
}

//-Roberto Grijalva Sanchez