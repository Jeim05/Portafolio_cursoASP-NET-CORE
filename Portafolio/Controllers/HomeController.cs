using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using Portafolio.Servicios;

namespace Portafolio.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IRepositorioProyectos repositorioProyectos;
    private readonly ServicioDelimitado servicioDelimitado;
    private readonly ServicioTransitorio servicioTransitorio;
    private readonly ServicioUnico servicioUnico;

    public HomeController(ILogger<HomeController> logger, 
        IRepositorioProyectos repositorioProyectos,
        ServicioDelimitado servicioDelimitado,
        ServicioTransitorio servicioTransitorio,
        ServicioUnico servicioUnico)
    {
        _logger = logger;
        this.repositorioProyectos = repositorioProyectos;
        this.servicioDelimitado = servicioDelimitado;
        this.servicioTransitorio = servicioTransitorio;
        this.servicioUnico = servicioUnico;
    }

    public IActionResult Index()
    {
        var proyectos = repositorioProyectos.ObtenerProyectos().Take(3).ToList();
        var guidViewModel = new EjemploGUIDViewModel()
        {
            Delimitado = servicioUnico.ObtenerGuid,
            Transitorio = servicioTransitorio.ObtenerGuid,
            Unico = servicioTransitorio.ObtenerGuid
        };
        var modelo = new HomeIndexViewModel() { 
            Proyectos = proyectos,
            EjemploGUID_1 = guidViewModel
        };
        return View(modelo);
    }

    public IActionResult Proyectos()
    {
        var proyectos = repositorioProyectos.ObtenerProyectos();
        return View(proyectos);
    }

    public IActionResult Contacto()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
