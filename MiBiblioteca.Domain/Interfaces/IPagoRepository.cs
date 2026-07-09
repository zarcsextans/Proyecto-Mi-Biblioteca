using MiBiblioteca.Domain.Entities;

namespace MiBiblioteca.Domain.Interfaces;

public interface IPagoRepository
{
    void Guardar(Pago pago);

    IEnumerable<Pago> ObtenerTodos();
}