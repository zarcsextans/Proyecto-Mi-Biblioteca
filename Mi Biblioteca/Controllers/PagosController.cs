using Microsoft.AspNetCore.Mvc;
using MiBiblioteca.Application.Services;


namespace MiBiblioteca.Api.Controllers;


[ApiController]
[Route("api/pagos")]
public class PagosController : ControllerBase
{

    private readonly PagoService service;


    public PagosController(
        PagoService service)
    {
        this.service = service;
    }



    [HttpPost]
    public IActionResult CrearPago(
        decimal monto,
        string metodo)
    {

        var respuesta =
            service.RealizarPago(
                monto,
                metodo);


        return Ok(new
        {
            mensaje = respuesta
        });

    }



    [HttpGet]
    public IActionResult ObtenerPagos()
    {

        return Ok(
            service.ObtenerPagos()
        );

    }

}