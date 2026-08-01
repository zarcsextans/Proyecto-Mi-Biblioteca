using Microsoft.AspNetCore.Mvc;
using MiBiblioteca.Application.Services;
using MiBiblioteca.Domain.Entities;


namespace MiBiblioteca.Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class LibrosController : ControllerBase
{
    private readonly LibroService service;


    public LibrosController(LibroService service)
    {
        this.service = service;
    }


    [HttpGet]
    public IActionResult Get()
    {
        return Ok(service.ObtenerLibros());
    }


    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var libro = service.ObtenerLibro(id);

        if (libro == null)
            return NotFound();

        return Ok(libro);
    }


    [HttpPost]
    public IActionResult Post(Libro libro)
    {
        service.CrearLibro(libro);

        return Ok(libro);
    }


    [HttpPut]
    public IActionResult Put(Libro libro)
    {
        service.ActualizarLibro(libro);

        return Ok(libro);
    }


    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        service.EliminarLibro(id);

        return NoContent();
    }
}