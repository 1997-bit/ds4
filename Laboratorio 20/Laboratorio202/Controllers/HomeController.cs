using System.Web.Mvc;
using Laboratorio202.Models;

namespace Laboratorio202.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home/Index
        public ActionResult Index()
        {
            return View();
        }

        // POST: Home/GenerarMatriz
        [HttpPost]
        public ActionResult GenerarMatriz(MatrizModel model)
        {
            if (ModelState.IsValid)
            {
                model.Matriz = GenerarMatrizDiagonalInversa(model.Dimension);
            }
            return View("Index", model);
        }

        private int[,] GenerarMatrizDiagonalInversa(int dimension)
        {
            int[,] matriz = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    // Diagonal inversa: i + j = dimension - 1
                    if (i + j == dimension - 1)
                    {
                        matriz[i, j] = 1;
                    }
                    else
                    {
                        matriz[i, j] = 0;
                    }
                }
            }

            return matriz;
        }
    }
}