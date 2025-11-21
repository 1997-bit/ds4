using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Laboratorio192.Controllers
{
    public class ValuesController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<ActionResult> GetAllValues()
        {
            try
            {
                // Cambia el puerto por el que usa tu API del Laboratorio 19-1
                string apiUrl = "https://localhost:44360/api/values";

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    ViewBag.Values = responseBody;
                    ViewBag.Message = "Datos obtenidos correctamente";
                }
                else
                {
                    ViewBag.Message = "Error al obtener datos: " + response.StatusCode;
                }
            }
            catch (Exception ex)
            {
                ViewBag.Message = "Error: " + ex.Message;
            }

            return View();
        }
    }
}