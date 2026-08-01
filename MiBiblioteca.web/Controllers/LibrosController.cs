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



    public async Task<IActionResult> Index()
    {

        var libros =
            await api.GetAsync<List<LibroViewModel>>(
                "Libros"
            );


        return View(libros ?? new List<LibroViewModel>());

    }

}