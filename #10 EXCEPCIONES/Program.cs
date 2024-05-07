try
{
    int resultado = 10/0; 
}
catch (Exception ex)
{
    Console.WriteLine("Se produjo un error:");
    Console.WriteLine(ex.Message);
}

try
{
    var lista = new int[] { 1, 2, 3 };
    int valor = lista[10]; 
}
catch (Exception ex)
{
    Console.WriteLine("Se produjo un error:");
    Console.WriteLine(ex.Message);
}
//-------------------------------------------------------------------------------
static void ProcesarParametros(int parametro)
{
    try
    {
        if (parametro == 0)
        {
            throw new ArgumentException("El parámetro no puede ser cero.");
        }
        else if (parametro < 0)
        {
            throw new ArgumentOutOfRangeException("parametro", "El parámetro no puede ser negativo.");
        }
        else if (parametro > 100)
        {
            throw new ParametroFueraDeRangoException("El parámetro está fuera del rango permitido.");
        }
        else
        {
            Console.WriteLine("No se ha producido ningún error.");
        }
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Se produjo un error de tipo ArgumentException:");
        Console.WriteLine(ex.Message);
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("Se produjo un error de tipo ArgumentOutOfRangeException:");
        Console.WriteLine(ex.Message);
    }
    catch (ParametroFueraDeRangoException ex)
    {
        Console.WriteLine("Se produjo un error de tipo ParametroFueraDeRangoException:");
        Console.WriteLine(ex.Message);
    }
}
class ParametroFueraDeRangoException : Exception
{
    public ParametroFueraDeRangoException(string message) : base(message)
    {
    }
}
//-Roberto Grijalva Sanchez