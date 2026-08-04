using MiBiblioteca.Application.Services;
using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Interfaces;
using Moq;
using System.Timers;
using Xunit;


namespace MiBiblioteca.Tests;


public class LibroServiceTests
{

    [Fact]
    public void CrearLibro_DebeGuardarLibro()
    {

        // Arrange
        var repository = new Mock<ILibroRepository>();

        var service = new LibroService(repository.Object);


        var libro = new Libro
        {
            Titulo = "Clean Code",
            Autor = "Robert C. Martin",
            ISBN = "123456"
        };


        // Act
        service.CrearLibro(libro);


        // Assert
        repository.Verify(
            x => x.Guardar(libro),
            Times.Once
        );

    }


    [Fact]
    public void EliminarLibro_DebeLlamarRepositorio()
    {

        var repository = new Mock<ILibroRepository>();

        var service = new LibroService(repository.Object);


        service.EliminarLibro(1);


        repository.Verify(
            x => x.Eliminar(1),
            Times.Once
        );

    }

}