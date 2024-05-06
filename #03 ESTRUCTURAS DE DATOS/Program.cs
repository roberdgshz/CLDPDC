int[] arreglo1 = new int[] { 4,1,235,7,95,3};
arreglo1[1] = 5; //<-- Cambiar valor
Array.Sort(arreglo1); //<-- Para ordenar

List<string> nombres = new List<string> { "Roberto", "Victor", "Fernando" };
nombres.Add("Lamia");
nombres.Remove("Fernando");
nombres[1] = "Victoria";
nombres.Sort();

Dictionary<int, string> diccionario = new Dictionary<int, string>();
diccionario.Add(1,"valor 1");
diccionario.Add(2,"valor 2");
diccionario.Add(3,"valor 3");
diccionario.Remove(3);
diccionario[1] = "Valor Uno";

HashSet<int> conjunto = new HashSet<int> { 3,6,9,12 };
conjunto.Add(1);
conjunto.Remove(6);
//------------------------------------------------------------------------------------------
Dictionary<string, long> contactos = new Dictionary<string, long>();
contactos.Add("Roberto", 11111111111);
contactos.Add("Ivan", 22222222222);
contactos.Add("Aracely", 33333333333);
contactos.Add("Lamia", 44444444444);
contactos.Add("Sam", 55555555555);

bool servicio = true;

do {
    Console.WriteLine("BIENVENIDO");
    Console.WriteLine("Seleccione el número de una opción:");
    Console.WriteLine("1.- Consulta.");
    Console.WriteLine("2.- Búsqueda.");
    Console.WriteLine("3.- Inserción.");
    Console.WriteLine("4.- Actualización.");
    Console.WriteLine("5.- Eliminación.");
    Console.WriteLine("6.- Salir.");
    int opc = int.Parse(Console.ReadLine());

    bool repetir = true;
    string nombre = "";
    string respuesta = "";
    string numero = "";
    switch (opc)
    {
        case 1:
            foreach (var contacto in contactos)
            {
                Console.WriteLine("Nombre: "+contacto.Key+"\n Número: "+contacto.Value);
            }
            Console.WriteLine();
            break;
        case 2:
            do
            {
                Console.WriteLine("Escriba el nombre que desee buscar: ");
                nombre = Console.ReadLine();

                busqueda(nombre);
                
                Console.WriteLine("¿Desea buscar otro? (si/no)");
                respuesta = Console.ReadLine();
                
                if (respuesta.ToLower() == "si") { repetir = true; } else { repetir = false; }
            
            } while (repetir);
            Console.WriteLine();
            break;
        case 3:
            do
            {
                Console.WriteLine("Escriba el nombre del contacto: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Escriba el número del contacto: ");
                numero = Console.ReadLine();

                if (numero.Length > 11)
                {
                    Console.WriteLine("Número demasiado largo, intente otro");
                }
                else
                {
                    insercion(nombre, long.Parse(numero));
                }

                Console.WriteLine("¿Desea agregar otro? (si/no)");
                respuesta = Console.ReadLine();

                if (respuesta.ToLower() == "si") { repetir = true; } else { repetir = false; }
            } while (repetir);
            Console.WriteLine();
            break;
        case 4:
            do
            {
                Console.WriteLine("Escribe el nombre del contacto que desea actualizar: ");
                nombre = Console.ReadLine();

                Console.WriteLine("Escribe el nuevo número: ");
                numero = Console.ReadLine();

                actualizacion(nombre, long.Parse(numero));

                Console.WriteLine("¿Desea buscar otro? (si/no)");
                respuesta = Console.ReadLine();

                if (respuesta.ToLower() == "si") { repetir = true; } else { repetir = false; }
            } while (repetir);
            Console.WriteLine();
            break;
        case 5:
            do
            {
                Console.WriteLine("Escriba el contacto desea eliminar: ");
                nombre = Console.ReadLine();

                eliminacion(nombre);

                Console.WriteLine("¿Desea buscar otro? (si/no)");
                respuesta = Console.ReadLine();

                if (respuesta.ToLower() == "si") { repetir = true; } else { repetir = false; }
            } while (repetir);
            Console.WriteLine();
            break;
        case 6:
            Console.WriteLine("Hasta la próxima!");
            servicio = false;
            break;
        default: Console.WriteLine("Escoja otra opción.");
            break;
    }

} while (servicio);

void busqueda(string nombre)
{
    bool match = false;
    foreach (var contacto in contactos)
    {
        if(contacto.Key == nombre)
        {
            Console.WriteLine("Nombre: " + contacto.Key + "\n Número: " + contacto.Value);
            match = true;
        }
    }
    if (!match) { Console.WriteLine("No se encontró ese contacto."); }
}

void insercion(string nombre, long numero)
{
    contactos.Add(nombre,numero);
    Console.WriteLine("Contacto agregado exitosamente!");
}

void actualizacion(string nombre, long numero)
{
    contactos[nombre] = numero;
    Console.WriteLine("Contacto actualizado exitosamente!");
}

void eliminacion(string nombre)
{
    contactos.Remove(nombre);
}
//-Roberto Grijalva Sanchez