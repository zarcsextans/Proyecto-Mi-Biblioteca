using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Enums;
using MiBiblioteca.Domain.Interfaces;

namespace MiBiblioteca.Application.Services;

public class PrestamoService
{
    private readonly IPrestamoRepository repository;


    public PrestamoService(
        IPrestamoRepository repository)
    {
        this.repository = repository;
    }



    public IEnumerable<Prestamo> ObtenerPrestamos()
    {
        return repository.ObtenerTodos();
    }



    public Prestamo? ObtenerPrestamo(int id)
    {
        return repository.ObtenerPorId(id);
    }



    public void CrearPrestamo(
    Prestamo prestamo)
    {
        prestamo.FechaPrestamo = DateTime.UtcNow;

        prestamo.Estado = EstadoPrestamo.Activo;

        repository.Guardar(prestamo);
    }



    public void ActualizarPrestamo(
    Prestamo prestamo)
    {

        if (prestamo.FechaDevolucion.HasValue)
        {
            prestamo.FechaDevolucion =
                DateTime.SpecifyKind(
                    prestamo.FechaDevolucion.Value,
                    DateTimeKind.Utc
                );
        }


        prestamo.FechaPrestamo =
            DateTime.SpecifyKind(
                prestamo.FechaPrestamo,
                DateTimeKind.Utc
            );


        repository.Actualizar(prestamo);
    }
}