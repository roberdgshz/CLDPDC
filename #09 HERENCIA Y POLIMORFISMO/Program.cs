Perro perro1 = new Perro();
Gato gato1 = new Gato();

perro1.caminar();
perro1.ladrar();

gato1.caminar();
gato1.maullido();



Gerente gerente = new Gerente(1, "Juan");
GerenteProyecto gerenteProyecto = new GerenteProyecto(2, "María");
Programador programador = new Programador(3, "Carlos");

gerente.AsignarTarea(programador, "Desarrollar módulo de autenticación");
gerenteProyecto.CoordinarProyecto();
programador.Trabajar();


class Animal
{
    public void caminar()
    {
        Console.WriteLine("El animal camina...");
    }
}

class Perro : Animal
{ 
    public void ladrar()
    {
        Console.WriteLine("*Ladrido*");
    }
}

class Gato : Animal
{
    public void maullido()
    {
        Console.WriteLine("*Maullido*");
    }
}
//------------------------------------------------------------------------------

class Empleado
{
    public int Identificador { get; set; }
    public string Nombre { get; set; }

    public Empleado(int id, string nombre)
    {
        Identificador = id;
        Nombre = nombre;
    }

    public virtual void Trabajar()
    {
        Console.WriteLine(Nombre+" está trabajando como empleado.");
    }
}

class Gerente : Empleado
{
    public List<Empleado> EmpleadosACargo { get; set; }

    public Gerente(int id, string nombre) : base(id, nombre)
    {
        EmpleadosACargo = new List<Empleado>();
    }

    public void AsignarTarea(Empleado empleado, string tarea)
    {
        Console.WriteLine("El gerente "+Nombre+" asigna la tarea "+tarea+" a "+empleado.Nombre);
    }
}

class GerenteProyecto : Gerente
{
    public GerenteProyecto(int id, string nombre) : base(id, nombre)
    {
    }

    public void CoordinarProyecto()
    {
        Console.WriteLine("El gerente de proyecto "+Nombre+" está coordinando el proyecto.");
    }
}

class Programador : Empleado
{
    public Programador(int id, string nombre) : base(id, nombre)
    {
    }

    public override void Trabajar()
    {
        Console.WriteLine(Nombre+" está programando.");
    }
}
//-Roberto Grijalva Sanchez