using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Laboratorio193.Controllers
{
    public class ValuesController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> GetValueById(int id = 2)
        {
            try
            {
                // Cambia el puerto por el que usa tu API del Laboratorio 19-1
                string apiUrl = $"https://localhost:44360/api/values/{id}";

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ViewBag.Value = responseBody;
                    ViewBag.Message = $"Dato con ID {id} obtenido correctamente";
                    ViewBag.Id = id;
                }
                else
                {
                    ViewBag.Message = "Error al obtener dato: " + response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: " + ex.Message;
            }

            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(int id)
        {
            return RedirectToAction("GetValueById", new { id = id });
        }
    }
}