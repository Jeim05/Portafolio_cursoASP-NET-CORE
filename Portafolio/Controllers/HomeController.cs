using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var proyectos = ObtenerProyectos().Take(3).ToList();
        var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
        return View(modelo);
    }

    private List<Proyecto> ObtenerProyectos()
    {
        return new List<Proyecto>() { new Proyecto
        {
            Titulo = "Amazon",
            Descripcion = "E-Commerce realizado en ASP .NET Core",
            Link = "",
            ImgURL = "/img/steam.PNG"
        },
        new Proyecto
        {
            Titulo = "Proyecto 2",
            Descripcion = "E-Commerce realizado en ASP .NET Core",
            Link = "",
            ImgURL = "/img/reddit.PNG"
        },
        new Proyecto
        {
            Titulo = "Proyecto 3",
            Descripcion = "Sistema de facturación",
            Link = "",
            ImgURL = "/img/nyt.PNG"
        },
        new Proyecto
        {
            Titulo = "Proyecto 4",
            Descripcion = "Tienda en linea",
            Link = "",
            ImgURL = "/img/nyt.PNG"
        },
        };
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
