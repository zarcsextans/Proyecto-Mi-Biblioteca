namespace MiBiblioteca.Web.Models;


public class PrestamoViewModel
{
    public int Id { get; set; }


    public int UsuarioId { get; set; }


    public int LibroId { get; set; }


    public DateTime FechaPrestamo { get; set; }


    public DateTime? FechaDevolucion { get; set; }


    public int Estado { get; set; }
}