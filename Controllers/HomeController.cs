using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
[HttpGet]
[Route("")]
public IActionResult Index()
{
    string titulo = "Bienvenidos al formulario";
    ViewBag.Titulo = titulo;
    return View("Index");
}


[HttpPost]
[Route("datosFormulario")]
public IActionResult DatosFormulario(string name, string DojoLocation, string FavoriteLanguage, string description)
{
    ViewBag.Name = name;
    ViewBag.DojoLocation = DojoLocation;
    ViewBag.FavoriteLanguage = FavoriteLanguage;
    ViewBag.Description = description;

    return View("DatosFormulario");
}

}





