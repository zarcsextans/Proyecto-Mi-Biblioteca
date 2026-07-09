using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Interfaces;

namespace MiBiblioteca.Infrastructure.Repositories;

public class PagoRepository : IPagoRepository
{
    private readonly List<Pago> pagos = new();


    public void Guardar(Pago pago)
    {
        pago.Id = pagos.Count + 1;
        pagos.Add(pago);
    }


    public IEnumerable<Pago> ObtenerTodos()
    {
        return pagos;
    }
}