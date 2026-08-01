using Microsoft.EntityFrameworkCore;
using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Interfaces;
using MiBiblioteca.Infrastructure.Data;

namespace MiBiblioteca.Infrastructure.Repositories;

public class LibroRepository : ILibroRepository
{
    private readonly BibliotecaDbContext context;


    public LibroRepository(BibliotecaDbContext context)
    {
        this.context = context;
    }


    public IEnumerable<Libro> ObtenerTodos()
    {
        return context.Libros.ToList();
    }


    public Libro? ObtenerPorId(int id)
    {
        return context.Libros
            .FirstOrDefault(l => l.Id == id);
    }


    public void Guardar(Libro libro)
    {
        context.Libros.Add(libro);
        context.SaveChanges();
    }


    public void Actualizar(Libro libro)
    {
        context.Libros.Update(libro);
        context.SaveChanges();
    }


    public void Eliminar(int id)
    {
        var libro = ObtenerPorId(id);

        if (libro != null)
        {
            context.Libros.Remove(libro);
            context.SaveChanges();
        }
    }
}