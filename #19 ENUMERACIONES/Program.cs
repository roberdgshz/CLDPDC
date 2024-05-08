
for (int i = 1; i <= 7; i++)
{
    Console.WriteLine($"Número: {i}, Día: {NombreDiaSemana(i)}");
}


Pedido pedido1 = new Pedido(1);
Pedido pedido2 = new Pedido(2);

pedido1.MostrarEstado();
pedido2.MostrarEstado();

pedido1.MarcarEnviado();
pedido1.MostrarEstado();

pedido2.MarcarEntregado();

pedido1.MarcarEntregado();
pedido1.MostrarEstado();

pedido2.CancelarPedido();
pedido2.MostrarEstado();

pedido2.MarcarEnviado();
string NombreDiaSemana(int numero)
{
    if (numero < 1 || numero > 7)
    {
        return "Número inválido";
    }

    DiaSemana dia = (DiaSemana)numero;

    return dia.ToString();
}
enum DiaSemana
{
    Lunes = 1,
    Martes,
    Miércoles,
    Jueves,
    Viernes,
    Sábado,
    Domingo
}


//------------------------------------------------------------------------------

enum EstadoPedido
{
    PENDIENTE,
    ENVIADO,
    ENTREGADO,
    CANCELADO
}

class Pedido
{
    public int Id { get; }
    public EstadoPedido Estado { get; private set; }

    public Pedido(int id)
    {
        Id = id;
        Estado = EstadoPedido.PENDIENTE;
    }

    public void MarcarEnviado()
    {
        if (Estado == EstadoPedido.PENDIENTE)
        {
            Estado = EstadoPedido.ENVIADO;
            Console.WriteLine($"Pedido {Id} enviado.");
        }
        else
        {
            Console.WriteLine($"No se puede marcar como enviado. Estado actual: {Estado}");
        }
    }

    public void MarcarEntregado()
    {
        if (Estado == EstadoPedido.ENVIADO)
        {
            Estado = EstadoPedido.ENTREGADO;
            Console.WriteLine($"Pedido {Id} entregado.");
        }
        else
        {
            Console.WriteLine($"No se puede marcar como entregado. Estado actual: {Estado}");
        }
    }

    public void CancelarPedido()
    {
        if (Estado != EstadoPedido.ENTREGADO && Estado != EstadoPedido.CANCELADO)
        {
            Estado = EstadoPedido.CANCELADO;
            Console.WriteLine($"Pedido {Id} cancelado.");
        }
        else
        {
            Console.WriteLine($"No se puede cancelar el pedido. Estado actual: {Estado}");
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Estado del pedido {Id}: {Estado}");
    }
}

//-Roberto Grijalva Sanchez
