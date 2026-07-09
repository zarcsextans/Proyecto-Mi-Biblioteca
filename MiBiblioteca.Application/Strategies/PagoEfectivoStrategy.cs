using MiBiblioteca.Application.Strategies;

public class PagoEfectivoStrategy : IPagoStrategy
{
    public string Ejecutar(decimal monto)
    {
        return "Pago";
    }
}