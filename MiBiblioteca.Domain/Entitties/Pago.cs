namespace MiBiblioteca.Domain.Entities;

public class Pago
{
    public int Id { get; set; }

    public decimal Monto { get; set; }

    public string Metodo { get; set; } = "";

    public DateTime Fecha { get; set; }
}