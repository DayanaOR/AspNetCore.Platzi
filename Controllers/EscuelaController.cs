using Microsoft.AspNetCore.Mvc;
namespace AspNetCore.Models;

public class Escuelacontroller: Controller
{
    public IActionResult Index()
    {
        var escuela = new Escuela();
        escuela.AñoDeCreación = 2005;
        escuela.UniqueId = Guid.NewGuid().ToString();
        escuela.Nombre = "Platzi School";
        escuela.Dirección = "kr. 14B # 25-52 sur, barrio Madelena";
        escuela.Pais = "Colombia";
        escuela.Ciudad = "Bogotá";
        escuela.TipoEscuela = TiposEscuela.Secundaria;

        ViewBag.CosaDimanica = "La monja"; 

        return View(escuela); 
    }
}