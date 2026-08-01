using Microsoft.AspNetCore.Mvc;
using MiBiblioteca.Application.Services;
using MiBiblioteca.Domain.Entities;


namespace MiBiblioteca.Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UsuariosController : ControllerBase
{

    private readonly UsuarioService service;


    public UsuariosController(
        UsuarioService service)
    {
        this.service = service;
    }



    [HttpGet]
    public IActionResult Get()
    {
        return Ok(
            service.ObtenerUsuarios()
        );
    }



    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {

        var usuario =
            service.ObtenerUsuario(id);


        if (usuario == null)
            return NotFound();


        return Ok(usuario);
    }



    [HttpPost]
    public IActionResult Post(
        Usuario usuario)
    {

        service.CrearUsuario(usuario);


        return CreatedAtAction(
            nameof(Get),
            new { id = usuario.Id },
            usuario
        );
    }



    [HttpPut("{id}")]
    public IActionResult Put(
        int id,
        Usuario usuario)
    {

        if (id != usuario.Id)
            return BadRequest();



        service.ActualizarUsuario(usuario);


        return Ok(usuario);
    }



    [HttpDelete("{id}")]
    public IActionResult Delete(
        int id)
    {

        service.EliminarUsuario(id);


        return NoContent();
    }

}