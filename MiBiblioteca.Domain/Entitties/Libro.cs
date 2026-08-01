namespace MiBiblioteca.Domain.Entities;

public class Libro
{
    public int Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public string Autor { get; set; } = string.Empty;

    public string ISBN { get; set; } = string.Empty;

    public int AnioPublicacion { get; set; }

    public bool Disponible { get; set; } = true;
}