
using System.Text.Json;
using System.Xml.Serialization;





Programador programador1 = new Programador
{
    Nombre = "Roberto Grijalva",
    Edad = 22,
    FechaNac = new DateTime(2001, 6, 4),
    ListaLenguajes = new List<string> { "C#", "C++", "Java", "Python", "Javascript", "Objective C", "Swift" }
};

string archivoXML = "datosProgramador.xml";
crearArchivoXML(programador1, archivoXML);

mostrarContenidoArchivo(archivoXML);

string archivoJSON = "datosProgramador.json";
crearArchivoJSON(programador1, archivoJSON);

mostrarContenidoArchivo(archivoJSON);

//borrarArchivo(archivoJSON);
//borrarArchivo(archivoXML);

static void crearArchivoXML(Programador programador, string nombreArchivo)
{
    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Programador));
    using (FileStream fs = new FileStream(nombreArchivo, FileMode.Create))
    {
        xmlSerializer.Serialize(fs, programador);
    }
    Console.WriteLine($"Archivo XML '{nombreArchivo}' creado correctamente.");
}

static void crearArchivoJSON(Programador programador, string nombreArchivo)
{
    string jsonString = JsonSerializer.Serialize(programador);
    File.WriteAllText(nombreArchivo, jsonString);
    Console.WriteLine($"Archivo JSON '{nombreArchivo}' creado correctamente.");
}

static void mostrarContenidoArchivo(string nombreArchivo)
{
    try
    {
        string contenido = File.ReadAllText(nombreArchivo);
        Console.WriteLine(contenido);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error al leer el archivo '{nombreArchivo}':");
        Console.WriteLine(ex.Message);
    }
}

static void borrarArchivo(string nombreArchivo)
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

public class Programador
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public DateTime FechaNac { get; set; }
    public List<string> ListaLenguajes { get; set; }

    public Programador()
    {
       ListaLenguajes = new List<string>();
    }
}

//----------------------------------------------------------------------------------------------
//-Roberto Grijalva Sanchez