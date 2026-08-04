using MiBiblioteca.Application.Services;
using MiBiblioteca.Domain.Entities;
using MiBiblioteca.Domain.Interfaces;
using Moq;
using System.Timers;
using Xunit;


namespace MiBiblioteca.Tests;


public class UsuarioServiceTests
{

    [Fact]
    public void CrearUsuario_DebeGuardarUsuario()
    {
        // Arrange
        var repository = new Mock<IUsuarioRepository>();

        var service = new UsuarioService(repository.Object);


        var usuario = new Usuario
        {
            Nombre = "Scarlet",
            Correo = "scarlet@test.com",
            Telefono = "9999999999"
        };


        // Act
        service.CrearUsuario(usuario);


        // Assert
        repository.Verify(
            x => x.Guardar(usuario),
            Times.Once
        );
    }


    [Fact]
    public void ObtenerUsuario_DebeRetornarUsuario()
    {
        // Arrange
        var repository = new Mock<IUsuarioRepository>();

        var usuario = new Usuario
        {
            Id = 1,
            Nombre = "Scarlet"
        };


        repository.Setup(
            x => x.ObtenerPorId(1)
        )
        .Returns(usuario);


        var service = new UsuarioService(repository.Object);


        // Act
        var resultado = service.ObtenerUsuario(1);


        // Assert
        Assert.NotNull(resultado);
        Assert.Equal("Scarlet", resultado.Nombre);
    }

}