using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Interfaces;
using MiBiblioteca.Infrastructure.Data;

namespace MiBiblioteca.Infrastructure.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly BibliotecaDbContext context;


    public UsuarioRepository(
        BibliotecaDbContext context)
    {
        this.context = context;
    }



    public IEnumerable<Usuario> ObtenerTodos()
    {
        return context.Usuarios.ToList();
    }



    public Usuario? ObtenerPorId(int id)
    {
        return context.Usuarios.Find(id);
    }



    public void Guardar(Usuario usuario)
    {
        context.Usuarios.Add(usuario);
        context.SaveChanges();
    }



    public void Actualizar(Usuario usuario)
    {
        context.Usuarios.Update(usuario);
        context.SaveChanges();
    }



    public void Eliminar(int id)
    {
        var usuario = ObtenerPorId(id);


        if (usuario != null)
        {
            context.Usuarios.Remove(usuario);
            context.SaveChanges();
        }
    }
}