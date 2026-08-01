using Microsoft.EntityFrameworkCore;
using MiBiblioteca.Domain.Entities;

namespace MiBiblioteca.Infrastructure.Data;

public class BibliotecaDbContext : DbContext
{
    public BibliotecaDbContext(
        DbContextOptions<BibliotecaDbContext> options)
        : base(options)
    {

    }


    public DbSet<Libro> Libros { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<Prestamo> Prestamos { get; set; }
}