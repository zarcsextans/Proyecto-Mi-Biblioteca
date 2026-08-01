using Microsoft.AspNetCore.Mvc;
using MiBiblioteca.Application.Services;
using MiBiblioteca.Domain.Entities;


namespace MiBiblioteca.Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class PrestamosController : ControllerBase
{

    private readonly PrestamoService service;



    public PrestamosController(
        PrestamoService service)
    {
        this.service = service;
    }



    [HttpGet]
    public IActionResult Get()
    {
        return Ok(
            service.ObtenerPrestamos()
        );
    }



    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {

        var prestamo =
            service.ObtenerPrestamo(id);


        if (prestamo == null)
            return NotFound();


        return Ok(prestamo);
    }



    [HttpPost]
    public IActionResult Post(
        Prestamo prestamo)
    {

        service.CrearPrestamo(prestamo);


        return Ok(prestamo);
    }



    [HttpPut("{id}")]
    public IActionResult Put(
        int id,
        Prestamo prestamo)
    {

        if (id != prestamo.Id)
            return BadRequest();



        service.ActualizarPrestamo(prestamo);


        return Ok(prestamo);
    }

}