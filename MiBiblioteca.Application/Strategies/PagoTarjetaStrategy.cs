namespace MiBiblioteca.Application.Strategies;

public class PagoTarjetaStrategy : IPagoStrategy
{
    public string Ejecutar(decimal monto)
    {
        return $"Pago con tarjeta realizado por ${monto}";
    }
}