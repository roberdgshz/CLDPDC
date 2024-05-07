string titulo = "roberdgshz.txt";

escribirArchivo(titulo);
mostrarContenido(titulo);
borrarArchivo(titulo);

void escribirArchivo(string titulo)
{
    try
    {
        using (StreamWriter sw = File.AppendText(titulo))
        {
            sw.WriteLine("Roberto Grijalva Sanchez");
            sw.WriteLine("22 años");
            sw.WriteLine("JavaScript");
        }
        Console.WriteLine("Archivo guardado exitosamente!");
    } catch (Exception ex)
    {
        Console.WriteLine("Ocurrió un error. "+ex.Message);
    }
}

void mostrarContenido(string titulo)
{
    try 
    {
        string contenido = File.ReadAllText(titulo);
        Console.WriteLine(contenido);
    } catch (Exception ex) 
    {
        Console.WriteLine("Ocurrió un error. "+ex.Message);
    }
}

void borrarArchivo(string titulo)
{
    try
    {
        File.Delete(titulo);
        Console.WriteLine("El archivo se borro correctamente!");
    } catch (Exception ex)
    {
        Console.WriteLine("Ocurrió un error. "+ex.Message);
    }
}

//-------------------------------------------------------------------------------

 string nombreArchivo = "textoProductos.txt";

Console.WriteLine("BIENVENIDO");

while (true)
{
    Console.WriteLine("Elige una opcion: ");
    Console.WriteLine("1.- Agregar.");
    Console.WriteLine("2.- Consultar.");
    Console.WriteLine("3.- Actualizar.");
    Console.WriteLine("4.- Eliminar.");
    Console.WriteLine("5.- Calcular total.");
    Console.WriteLine("6.- Calcular venta.");
    Console.WriteLine("7.-Salir. ");
    int opc = int.Parse(Console.ReadLine());
    switch (opc)
    {
        case 1: agregar(nombreArchivo);
            break;
        case 2: consultar(nombreArchivo);
            break;
        case 3: actualizar(nombreArchivo);
            break;
        case 4: eliminar(nombreArchivo);
            break;
        case 5: calcularTotal(nombreArchivo);
            break;
        case 6: calcularVenta(nombreArchivo);
            break;
        case 7: salir(nombreArchivo);
            break;
        default:
            Console.WriteLine("Esa opción no existe, intente otra.");
            break;
    }
}

static void agregar(string nombreArchivo)
{
    Console.WriteLine("\nAñadir producto:");
    Console.Write("Nombre del producto: ");
    string nombre = Console.ReadLine();
    Console.Write("Cantidad vendida: ");
    int cantidad = Convert.ToInt32(Console.ReadLine());
    Console.Write("Precio: ");
    double precio = Convert.ToDouble(Console.ReadLine());

    try
    {
        using (StreamWriter sw = File.AppendText(nombreArchivo))
        {
            sw.WriteLine($"{nombre}, {cantidad}, {precio}");
        }
        Console.WriteLine("Producto añadido correctamente.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al añadir el producto:");
        Console.WriteLine(ex.Message);
    }
}

static void consultar(string nombreArchivo)
{
    Console.WriteLine("\nProductos:");

    try
    {
        string[] lineas = File.ReadAllLines(nombreArchivo);
        foreach (var linea in lineas)
        {
            Console.WriteLine(linea);
        }
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("El archivo de ventas no existe o está vacío.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al consultar los productos:");
        Console.WriteLine(ex.Message);
    }
}

static void actualizar(string nombreArchivo)
{
    Console.WriteLine("\nActualizar producto:");
    consultar(nombreArchivo);
    Console.Write("Ingrese el nombre del producto a actualizar: ");
    string nombreProducto = Console.ReadLine();

    try
    {
        string[] lineas = File.ReadAllLines(nombreArchivo);
        List<string> nuevasLineas = new List<string>();

        foreach (var linea in lineas)
        {
            string[] campos = linea.Split(',');
            if (campos[0].Trim() == nombreProducto)
            {
                Console.Write("Nueva cantidad vendida: ");
                int nuevaCantidad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nuevo precio: ");
                double nuevoPrecio = Convert.ToDouble(Console.ReadLine());
                nuevasLineas.Add($"{nombreProducto}, {nuevaCantidad}, {nuevoPrecio}");
                Console.WriteLine("Producto actualizado correctamente.");
            }
            else
            {
                nuevasLineas.Add(linea);
            }
        }

        File.WriteAllLines(nombreArchivo, nuevasLineas);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al actualizar el producto:");
        Console.WriteLine(ex.Message);
    }
}

static void eliminar(string nombreArchivo)
{
    Console.WriteLine("\nEliminar producto:");
    consultar(nombreArchivo);
    Console.Write("Ingrese el nombre del producto a eliminar: ");
    string nombreProducto = Console.ReadLine();

    try
    {
        string[] lineas = File.ReadAllLines(nombreArchivo);
        List<string> nuevasLineas = new List<string>();

        foreach (var linea in lineas)
        {
            string[] campos = linea.Split(',');
            if (campos[0].Trim() != nombreProducto)
            {
                nuevasLineas.Add(linea);
            }
        }

        File.WriteAllLines(nombreArchivo, nuevasLineas);
        Console.WriteLine("Producto eliminado correctamente.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al eliminar el producto:");
        Console.WriteLine(ex.Message);
    }
}

static void calcularTotal(string nombreArchivo)
{
    try
    {
        string[] lineas = File.ReadAllLines(nombreArchivo);
        double ventaTotal = 0;

        foreach (var linea in lineas)
        {
            string[] campos = linea.Split(',');
            double precio = Convert.ToDouble(campos[2].Trim());
            int cantidad = Convert.ToInt32(campos[1].Trim());
            ventaTotal += precio * cantidad;
        }

        Console.WriteLine($"\nVenta total: {ventaTotal}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al calcular la venta total:");
        Console.WriteLine(ex.Message);
    }
}

static void calcularVenta(string nombreArchivo)
{
    Console.WriteLine("\nCalcular venta por producto:");
    consultar(nombreArchivo);
    Console.Write("Ingrese el nombre del producto para calcular la venta: ");
    string nombreProducto = Console.ReadLine();

    try
    {
        string[] lineas = File.ReadAllLines(nombreArchivo);
        double ventaProducto = 0;

        foreach (var linea in lineas)
        {
            string[] campos = linea.Split(',');
            if (campos[0].Trim() == nombreProducto)
            {
                double precio = Convert.ToDouble(campos[2].Trim());
                int cantidad = Convert.ToInt32(campos[1].Trim());
                ventaProducto = precio * cantidad;
                break;
            }
        }

        Console.WriteLine($"Venta total de {nombreProducto}: {ventaProducto}");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al calcular la venta por producto:");
        Console.WriteLine(ex.Message);
    }
}

static void salir(string nombreArchivo)
{
    Console.WriteLine("Borrando archivo...");
    try
    {
        File.Delete(nombreArchivo);
        Console.WriteLine("Archivo borrado correctamente.");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error al borrar el archivo:");
        Console.WriteLine(ex.Message);
    }

    Environment.Exit(0);
}

//-Roberto Grijalva Sanchez