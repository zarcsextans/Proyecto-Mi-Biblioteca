using MiBiblioteca.Domain.Entities;

namespace MiBiblioteca.Domain.Interfaces;

public interface IUsuarioRepository
{
    IEnumerable<Usuario> ObtenerTodos();

    Usuario? ObtenerPorId(int id);

    void Guardar(Usuario usuario);

    void Actualizar(Usuario usuario);

    void Eliminar(int id);
}