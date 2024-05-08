using System.Text.RegularExpressions;

string texto = "Este es un texto con números como 123 y 4567, y también decimales como 3.14 y 2.71828.";
string patron = @"\d+(\.\d+)?";
Regex regex = new Regex(patron);
MatchCollection coincidencias = regex.Matches(texto);

Console.WriteLine("Números encontrados:");

foreach (Match coincidencia in coincidencias)
{
    Console.WriteLine(coincidencia.Value);
}
//--------------------------------------------------------------------------------------
string texto1 = "roberd.999117@gmail.com";
string patronEmail = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
Regex regex1 = new Regex(patronEmail);
MatchCollection coincidencias1 = regex.Matches(texto1);
foreach (Match coincidencia in coincidencias1)
{
    Console.WriteLine(coincidencia.Value);
}

string texto2 = "1234567890";
string patronTelefono = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";
Regex regex2 = new Regex(patronTelefono);
MatchCollection coincidencias2 = regex.Matches(texto2);
foreach (Match coincidencia in coincidencias2)
{
    Console.WriteLine(coincidencia.Value);
}

string texto3 = "https://www.example.com";
string patronURL = @"^(https?://)?(www\.)?([a-zA-Z0-9-]+\.){1,2}[a-zA-Z]{2,}(/\S*)?$";
Regex regex3 = new Regex(patronURL);
MatchCollection coincidencias3 = regex.Matches(texto3);
foreach (Match coincidencia in coincidencias3)
{
    Console.WriteLine(coincidencia.Value);
}
//-Roberto Grijalva Sanchez