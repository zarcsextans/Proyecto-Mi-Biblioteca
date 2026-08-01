using MiBiblioteca.Domain.Entities;


namespace MiBiblioteca.Domain.Interfaces;


public interface IPrestamoRepository
{

    IEnumerable<Prestamo> ObtenerTodos();


    Prestamo? ObtenerPorId(int id);


    void Guardar(Prestamo prestamo);


    void Actualizar(Prestamo prestamo);

}