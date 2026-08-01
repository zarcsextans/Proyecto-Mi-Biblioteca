using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Interfaces;

namespace MiBiblioteca.Application.Services;

public class LibroService
{
    private readonly ILibroRepository repository;


    public LibroService(ILibroRepository repository)
    {
        this.repository = repository;
    }


    public IEnumerable<Libro> ObtenerLibros()
    {
        return repository.ObtenerTodos();
    }


    public Libro? ObtenerLibro(int id)
    {
        return repository.ObtenerPorId(id);
    }


    public void CrearLibro(Libro libro)
    {
        repository.Guardar(libro);
    }


    public void ActualizarLibro(Libro libro)
    {
        repository.Actualizar(libro);
    }


    public void EliminarLibro(int id)
    {
        repository.Eliminar(id);
    }
}