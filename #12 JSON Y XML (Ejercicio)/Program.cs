
using System.Text.Json;
using System.Xml.Serialization;

string archivoXML = "datosprogramador.xml";
DatosProgramador programadorDesdeXML = LeerArchivoXML(archivoXML);
Console.WriteLine("Datos del programador desde XML:");
Console.WriteLine(programadorDesdeXML);

string archivoJSON = "datosprogramador.json";
DatosProgramador programadorDesdeJSON = LeerArchivoJSON(archivoJSON);
Console.WriteLine("\nDatos del programador desde JSON:");
Console.WriteLine(programadorDesdeJSON);

BorrarArchivo(archivoXML);
BorrarArchivo(archivoJSON);


static DatosProgramador LeerArchivoXML(string nombreArchivo)
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(DatosProgramador));
    using (FileStream fs = new FileStream(nombreArchivo, FileMode.Open))
    {
        return (DatosProgramador)xmlSerializer.Deserialize(fs);
    }
}

static DatosProgramador LeerArchivoJSON(string nombreArchivo)
{
    string jsonString = File.ReadAllText(nombreArchivo);
    return JsonSerializer.Deserialize<DatosProgramador>(jsonString);
}

static void BorrarArchivo(string nombreArchivo)
{
    try
    {
        File.Delete(nombreArchivo);
        Console.WriteLine($"Archivo '{nombreArchivo}' borrado correctamente.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error al borrar el archivo '{nombreArchivo}':");
        Console.WriteLine(ex.Message);
    }
}

public class DatosProgramador
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public List<string> LenguajesProgramacion { get; set; }

    public DatosProgramador()
    {
        LenguajesProgramacion = new List<string>();
    }

    public override string ToString()
    {
        return $"Nombre: {Nombre}\nEdad: {Edad}\nFecha de nacimiento: {FechaNacimiento}\nLenguajes de programación: {string.Join(", ", LenguajesProgramacion)}";
    }
}

//-Roberto Grijalva Sanchez