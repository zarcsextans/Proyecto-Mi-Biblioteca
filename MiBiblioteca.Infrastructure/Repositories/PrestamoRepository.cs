using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Interfaces;
using MiBiblioteca.Infrastructure.Data;


namespace MiBiblioteca.Infrastructure.Repositories;


public class PrestamoRepository : IPrestamoRepository
{

    private readonly BibliotecaDbContext context;



    public PrestamoRepository(
        BibliotecaDbContext context)
    {
        this.context = context;
    }



    public IEnumerable<Prestamo> ObtenerTodos()
    {
        return context.Prestamos.ToList();
    }



    public Prestamo? ObtenerPorId(int id)
    {
        return context.Prestamos.Find(id);
    }



    public void Guardar(
        Prestamo prestamo)
    {
        context.Prestamos.Add(prestamo);
        context.SaveChanges();
    }



    public void Actualizar(
        Prestamo prestamo)
    {
        context.Prestamos.Update(prestamo);
        context.SaveChanges();
    }

}