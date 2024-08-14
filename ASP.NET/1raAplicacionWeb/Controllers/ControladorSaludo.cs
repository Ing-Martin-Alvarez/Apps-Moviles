using Microsoft.AspNetCore.Mvc;

namespace _1raAplicacionWeb.Controllers
{
    public class ControladorSaludo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
