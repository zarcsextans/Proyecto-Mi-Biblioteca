using MiBiblioteca.Application.Services;
using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Enums;
using MiBiblioteca.Domain.Interfaces;
using Moq;
using System.Timers;
using Xunit;


namespace MiBiblioteca.Tests;


public class PrestamoServiceTests
{

    [Fact]
    public void CrearPrestamo_DebeAsignarFechaYEstadoActivo()
    {

        // Arrange
        var repository = new Mock<IPrestamoRepository>();

        var service = new PrestamoService(repository.Object);


        var prestamo = new Prestamo
        {
            UsuarioId = 1,
            LibroId = 1
        };


        // Act
        service.CrearPrestamo(prestamo);


        // Assert

        Assert.NotEqual(
            default,
            prestamo.FechaPrestamo
        );


        Assert.Equal(
            EstadoPrestamo.Activo,
            prestamo.Estado
        );


        repository.Verify(
            x => x.Guardar(prestamo),
            Times.Once
        );

    }

}