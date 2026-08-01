using MiBiblioteca.Domain.Entities;

namespace MiBiblioteca.Domain.Interfaces;

public interface ILibroRepository
{
    IEnumerable<Libro> ObtenerTodos();

    Libro? ObtenerPorId(int id);

    void Guardar(Libro libro);

    void Actualizar(Libro libro);

    void Eliminar(int id);
}