using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP3_MusicStore_new_.Models;

namespace TP3_MusicStore_new_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Catalogo.InicializarCatalogo();
        ViewBag.catalogo = Catalogo.catalogo;

        return View();
    }
    public IActionResult SelectDisco(string Id)
    {
        if(Catalogo.catalogo.ContainsKey(Id))
        {
            ViewBag.Disco = Catalogo.catalogo[Id];
            ViewBag.Id = Id;
        }
        
        return View("infoDisco");
    }
}
