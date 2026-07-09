using MiBiblioteca.Application.Factories;
using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Interfaces;

namespace MiBiblioteca.Application.Services;


public class PagoService
{

    private readonly PagoFactory factory;
    private readonly IPagoRepository repository;


    public PagoService(
        PagoFactory factory,
        IPagoRepository repository)
    {
        this.factory = factory;
        this.repository = repository;
    }


    public string RealizarPago(
        decimal monto,
        string metodo)
    {

        var estrategia =
            factory.Crear(metodo);


        var resultado =
            estrategia.Ejecutar(monto);


        repository.Guardar(
            new Pago
            {
                Monto = monto,
                Metodo = metodo,
                Fecha = DateTime.Now
            });


        return resultado;

    }


    public IEnumerable<Pago> ObtenerPagos()
    {
        return repository.ObtenerTodos();
    }

}