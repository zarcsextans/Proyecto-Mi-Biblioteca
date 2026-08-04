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



    // GET: Usuarios
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



    // GET: Usuarios/Create
    public IActionResult Create()
    {
        return View();
    }



    // POST: Usuarios/Create
    [HttpPost]
    public async Task<IActionResult> Create(
        UsuarioViewModel usuario)
    {

        if (!ModelState.IsValid)
        {
            return View(usuario);
        }


        await api.PostAsync(
            "Usuarios",
            usuario
        );


        return RedirectToAction(
            nameof(Index)
        );

    }
    // GET: Usuarios/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        var usuario =
            await api.GetAsync<UsuarioViewModel>(
                $"Usuarios/{id}"
            );


        if (usuario == null)
        {
            return NotFound();
        }


        return View(usuario);
    }



    // POST: Usuarios/Edit/5
    [HttpPost]
    public async Task<IActionResult> Edit(
        int id,
        UsuarioViewModel usuario)
    {

        if (!ModelState.IsValid)
        {
            return View(usuario);
        }


        await api.PutAsync(
            $"Usuarios/{id}",
            usuario
        );


        return RedirectToAction(
            nameof(Index)
        );

    }
    // POST: Usuarios/Delete/5
    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        await api.DeleteAsync(
            $"Usuarios/{id}"
        );


        return RedirectToAction(
            nameof(Index)
        );
    }

}