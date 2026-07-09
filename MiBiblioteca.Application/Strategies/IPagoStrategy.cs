namespace MiBiblioteca.Application.Strategies;

public interface IPagoStrategy
{
    string Ejecutar(decimal monto);
}