using Microsoft.AspNetCore.Mvc;
using MiBiblioteca.Web.Models;
using MiBiblioteca.Web.Services;


namespace MiBiblioteca.Web.Controllers;


public class LibrosController : Controller
{

    private readonly ApiClient api;


    public LibrosController(ApiClient api)
    {
        this.api = api;
    }



    // LISTAR
    public async Task<IActionResult> Index()
    {

        var libros =
            await api.GetAsync<List<LibroViewModel>>(
                "Libros"
            );


        return View(
            libros ?? new List<LibroViewModel>()
        );

    }



    // MOSTRAR FORMULARIO CREAR
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }



    // CREAR
    [HttpPost]
    public async Task<IActionResult> Create(
        LibroViewModel libro)
    {

        await api.PostAsync(
            "Libros",
            libro
        );


        return RedirectToAction(
            nameof(Index)
        );

    }



    // MOSTRAR FORMULARIO EDITAR
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {

        var libro =
            await api.GetAsync<LibroViewModel>(
                $"Libros/{id}"
            );


        if (libro == null)
            return NotFound();


        return View(libro);

    }



    // GUARDAR CAMBIOS
    [HttpPost]
    public async Task<IActionResult> Edit(
        LibroViewModel libro)
    {

        await api.PutAsync(
            "Libros",
            libro
        );


        return RedirectToAction(
            nameof(Index)
        );

    }



    // ELIMINAR
    [HttpPost]
    public async Task<IActionResult> Delete(
        int id)
    {

        await api.DeleteAsync(
            $"Libros/{id}"
        );


        return RedirectToAction(
            nameof(Index)
        );

    }

}