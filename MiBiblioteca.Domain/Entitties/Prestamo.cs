using MiBiblioteca.Domain.Enums;

namespace MiBiblioteca.Domain.Entities;

public class Prestamo
{
    public int Id { get; set; }

    public int UsuarioId { get; set; }

    public int LibroId { get; set; }

    public DateTime FechaPrestamo { get; set; }

    public DateTime? FechaDevolucion { get; set; }

    public EstadoPrestamo Estado { get; set; }
}