using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }



    public class RepositorioProyectos:IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
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
    }
}
