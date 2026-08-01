using Microsoft.AspNetCore.Mvc;
using MiBiblioteca.Web.Models;
using MiBiblioteca.Web.Services;


namespace MiBiblioteca.Web.Controllers;


public class UsuariosController : Controller
{

    private readonly ApiClient api;


    public UsuariosController(ApiClient api)
    {
        this.api = api;
    }



    public async Task<IActionResult> Index()
    {

        var usuarios =
            await api.GetAsync<List<UsuarioViewModel>>(
                "Usuarios"
            );


        return View(
            usuarios ?? new List<UsuarioViewModel>()
        );
    }
}