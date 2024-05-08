

using NUnit.Framework;
using NUnit.Framework.Legacy;

int a = 10, b = 6;
int resultado1 = suma(a,b);
pruebaSuma(a,b);

int suma(int num1, int num2)
{
    return num1 + num2;
}

void pruebaSuma(int num1,  int num2)
{
    int resultado = suma(num1, num2);
    int num3 = num1 + num2;
    Assert.AreEqual(num3, resultado);
}

//----------------------------------------------------------------------------
[TestFixture]
public class DatosPersonalesTests
{
    [Test]
    public void ExistenTodosLosCampos()
    {
        Dictionary<string, object> datosPersonales = CrearDatosPersonales();

        Assert.IsTrue(datosPersonales.ContainsKey("name"));
        Assert.IsTrue(datosPersonales.ContainsKey("age"));
        Assert.IsTrue(datosPersonales.ContainsKey("birth_date"));
        Assert.IsTrue(datosPersonales.ContainsKey("programming_languages"));
    }

    [Test]
    public void DatosCorrectos()
    {
        Dictionary<string, object> datosPersonales = CrearDatosPersonales();

        Assert.AreEqual("Tu nombre", datosPersonales["name"]);
        Assert.AreEqual("Tu edad", datosPersonales["age"]);
        Assert.AreEqual("Tu fecha de nacimiento", datosPersonales["birth_date"]);

        List<string> lenguajes = datosPersonales["programming_languages"] as List<string>;
        Assert.IsNotNull(lenguajes);
        CollectionAssert.Contains(lenguajes, "Listado de lenguajes de programación");
    }

    private Dictionary<string, object> CrearDatosPersonales()
    {
        Dictionary<string, object> datosPersonales = new Dictionary<string, object>
        {
            { "name", "Tu nombre" },
            { "age", "Tu edad" },
            { "birth_date", "Tu fecha de nacimiento" },
            { "programming_languages", new List<string> { "Listado de lenguajes de programación" } }
        };
        return datosPersonales;
    }
}
//-Roberto Grijalva Sanchez