using Microsoft.AspNetCore.Mvc;
using MiBiblioteca.Web.Models;
using MiBiblioteca.Web.Services;


namespace MiBiblioteca.Web.Controllers;


public class PrestamosController : Controller
{

    private readonly ApiClient api;


    public PrestamosController(ApiClient api)
    {
        this.api = api;
    }



    // LISTAR
    public async Task<IActionResult> Index()
    {

        var prestamos =
            await api.GetAsync<List<PrestamoViewModel>>(
                "Prestamos"
            );


        return View(
            prestamos ?? new List<PrestamoViewModel>()
        );

    }



    // CREAR FORMULARIO
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }



    // CREAR
    [HttpPost]
    public async Task<IActionResult> Create(
        PrestamoViewModel prestamo)
    {

        await api.PostAsync(
            "Prestamos",
            prestamo
        );


        return RedirectToAction(
            nameof(Index)
        );

    }



    // EDITAR FORMULARIO
    [HttpGet]
    public async Task<IActionResult> Edit(
        int id)
    {

        var prestamo =
            await api.GetAsync<PrestamoViewModel>(
                $"Prestamos/{id}"
            );


        if (prestamo == null)
            return NotFound();


        return View(prestamo);

    }



    // ACTUALIZAR
    [HttpPost]
    public async Task<IActionResult> Edit(
        PrestamoViewModel prestamo)
    {

        await api.PutAsync(
            $"Prestamos/{prestamo.Id}",
            prestamo
        );


        return RedirectToAction(
            nameof(Index)
        );

    }

}