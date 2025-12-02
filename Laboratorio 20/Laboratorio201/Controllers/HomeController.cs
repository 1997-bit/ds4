using System.Web.Mvc;

namespace TablaMultiplicarApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // POST: Home/CalcularTabla
        [HttpPost]
        public ActionResult CalcularTabla(int numero)
        {
            if (numero < 1 || numero > 1000)
            {
                ViewBag.Error = "El número debe estar entre 1 y 1000";
                return View("Index");
            }

            ViewBag.Numero = numero;
            ViewBag.MostrarTabla = true;
            
            return View("Index");
        }
    }
}