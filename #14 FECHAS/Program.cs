DateTime fechaActual = DateTime.Now;

DateTime fechaNacimiento = new DateTime(2001, 6, 4, 0, 0, 0);

int edad = CalcularEdad(fechaNacimiento, fechaActual);

Console.WriteLine($"Fecha actual: {fechaActual}");
Console.WriteLine($"Fecha de nacimiento: {fechaNacimiento}");
Console.WriteLine($"Edad: {edad} años");

// Formato 1: Día, mes y año
Console.WriteLine("1. {0}", fechaNacimiento.ToString("dd/MM/yyyy"));

// Formato 2: Hora, minuto y segundo
Console.WriteLine("2. {0}", fechaNacimiento.ToString("HH:mm:ss"));

// Formato 3: Día de año
Console.WriteLine("3. {0}", fechaNacimiento.DayOfYear);

// Formato 4: Día de la semana
Console.WriteLine("4. {0}", fechaNacimiento.ToString("dddd"));

// Formato 5: Nombre del mes
Console.WriteLine("5. {0}", fechaNacimiento.ToString("MMMM"));

// Formato 6: Año completo
Console.WriteLine("6. {0}", fechaNacimiento.ToString("yyyy"));

// Formato 7: Mes y año
Console.WriteLine("7. {0}", fechaNacimiento.ToString("MM/yyyy"));

// Formato 8: Día y mes
Console.WriteLine("8. {0}", fechaNacimiento.ToString("dd/MM"));

// Formato 9: Año abreviado
Console.WriteLine("9. {0}", fechaNacimiento.ToString("yy"));

// Formato 10: Hora y AM/PM
Console.WriteLine("10. {0}", fechaNacimiento.ToString("hh:mm tt"));


int CalcularEdad(DateTime fechaNacimiento, DateTime fechaActual)
{
    int edad = fechaActual.Year - fechaNacimiento.Year;
    if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
    {
        edad--;
    }
    return edad;
}

//-Roberto Grijalva Sanchez