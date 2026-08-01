namespace MiBiblioteca.Web.Models;


public class LibroViewModel
{
    public int Id { get; set; }


    public string Titulo { get; set; } = "";


    public string Autor { get; set; } = "";


    public string ISBN { get; set; } = "";


    public int AnioPublicacion { get; set; }


    public bool Disponible { get; set; }
}