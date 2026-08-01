using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Interfaces;

namespace MiBiblioteca.Application.Services;


public class UsuarioService
{

    private readonly IUsuarioRepository repository;


    public UsuarioService(
        IUsuarioRepository repository)
    {
        this.repository = repository;
    }



    public IEnumerable<Usuario> ObtenerUsuarios()
    {
        return repository.ObtenerTodos();
    }



    public Usuario? ObtenerUsuario(int id)
    {
        return repository.ObtenerPorId(id);
    }



    public void CrearUsuario(
        Usuario usuario)
    {
        repository.Guardar(usuario);
    }



    public void ActualizarUsuario(
        Usuario usuario)
    {
        repository.Actualizar(usuario);
    }



    public void EliminarUsuario(
        int id)
    {
        repository.Eliminar(id);
    }
}