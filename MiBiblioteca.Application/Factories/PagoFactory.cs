using MiBiblioteca.Application.Strategies;

namespace MiBiblioteca.Application.Factories;

public class PagoFactory
{

    public IPagoStrategy Crear(string metodo)
    {

        return metodo.ToLower() switch
        {
            "efectivo" => new PagoEfectivoStrategy(),

            "tarjeta" => new PagoTarjetaStrategy(),

            _ => throw new Exception("Método de pago no disponible")
        };

    }

}