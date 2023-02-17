using Microsoft.AspNetCore.Mvc;
namespace AspNetCore.Models;

public class Asignaturacontroller : Controller
{
    public IActionResult Index()
    {
            return View
            (
                new Asignatura{Nombre="Programación",
                UniqueId = Guid.NewGuid().ToString()}
            );
    }
    public IActionResult MultiAsignatura()
    {
        var listaAsignaturas = new List<Asignatura>()
        {
            new Asignatura{Nombre="Matemáticas",
            UniqueId = Guid.NewGuid().ToString()},

            new Asignatura{Nombre="Educación Física",
            UniqueId = Guid.NewGuid().ToString()},

            new Asignatura{Nombre="Castellano",
            UniqueId = Guid.NewGuid().ToString()},

            new Asignatura{Nombre="Ciencias Naturales",
            UniqueId = Guid.NewGuid().ToString()},

            new Asignatura{Nombre="Programación",
            UniqueId = Guid.NewGuid().ToString()}
        };

        ViewBag.CosaDimanica = "La monja";
        ViewBag.Fecha = DateTime.Now;

        return View("MultiAsignatura",listaAsignaturas);
    }
}