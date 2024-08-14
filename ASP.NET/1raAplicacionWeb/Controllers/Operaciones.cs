using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace _1raAplicacionWeb.Controllers
{
    public class Operaciones : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Sumar(int floatingUno, int floatingDos, string operador)
        {
            int floatingResultado;
            
            if (operador == "suma")
            {
                floatingResultado = floatingUno + floatingDos;
                ViewBag.floatingResultado = "La suma es: " + floatingResultado.ToString();
                return View("Index");
            }
            else if (operador == "resta")
            {
                floatingResultado = floatingUno - floatingDos;
                ViewBag.floatingResultado = "La resta es: " + floatingResultado.ToString();
                return View("Index");
            }
            else if (operador == "multi")
            {
                floatingResultado = floatingUno * floatingDos;
                ViewBag.floatingResultado = "La multiplicacion es: " + floatingResultado.ToString();
                return View("Index");
            }
            else
            {
                floatingResultado = floatingUno / floatingDos;
                ViewBag.floatingResultado = "La division es: " + floatingResultado.ToString();
                return View("Index");
            }
        }
    }
}
