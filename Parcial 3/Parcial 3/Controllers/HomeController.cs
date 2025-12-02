using System.Web.Mvc;
using Parcial_3.Models;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace Parcial_3.Controllers
{
    public class HomeController : Controller
    {
        private string Conn => ConfigurationManager.ConnectionStrings["JuanConn"].ConnectionString;

        public ActionResult Index()
        {
            var casos = GetAllCasos();
            ViewBag.Casos = casos;

            return View();
        }

        [HttpPost]
        public ActionResult Index(Caso model)
        {
            using (SqlConnection cn = new SqlConnection(Conn))
            {
                cn.Open();
                string sql = @"
INSERT INTO JG_Casos
(NumeroCaso, ClienteNombre, Descripcion, AbogadoAsignado, FechaInicio, FechaVencimiento, Estado, Observaciones)
VALUES (@NumeroCaso, @ClienteNombre, @Descripcion, @AbogadoAsignado, @FechaInicio, @FechaVencimiento, @Estado, @Observaciones)";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@NumeroCaso", model.NumeroCaso);
                    cmd.Parameters.AddWithValue("@ClienteNombre", model.ClienteNombre);
                    cmd.Parameters.AddWithValue("@Descripcion", model.Descripcion ?? "");
                    cmd.Parameters.AddWithValue("@AbogadoAsignado", model.AbogadoAsignado ?? "");
                    cmd.Parameters.AddWithValue("@FechaInicio", model.FechaInicio);
                    cmd.Parameters.AddWithValue("@FechaVencimiento", (object)model.FechaVencimiento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Estado", model.Estado);
                    cmd.Parameters.AddWithValue("@Observaciones", model.Observaciones ?? "");

                    cmd.ExecuteNonQuery();
                }
            }

            return RedirectToAction("Index");
        }

        private List<Caso> GetAllCasos()
        {
            List<Caso> casos = new List<Caso>();

            using (SqlConnection cn = new SqlConnection(Conn))
            {
                cn.Open();
                string sql = @"SELECT Id, NumeroCaso, ClienteNombre, Descripcion, AbogadoAsignado,
                                      FechaInicio, FechaVencimiento, Estado, Observaciones
                               FROM JG_Casos";

                using (SqlCommand cmd = new SqlCommand(sql, cn))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        casos.Add(new Caso
                        {
                            Id = dr.GetInt32(0),
                            NumeroCaso = dr.GetString(1),
                            ClienteNombre = dr.GetString(2),
                            Descripcion = dr.IsDBNull(3) ? "" : dr.GetString(3),
                            AbogadoAsignado = dr.IsDBNull(4) ? "" : dr.GetString(4),
                            FechaInicio = dr.GetDateTime(5),
                            FechaVencimiento = dr.IsDBNull(6) ? (DateTime?)null : dr.GetDateTime(6),
                            Estado = dr.GetString(7),
                            Observaciones = dr.IsDBNull(8) ? "" : dr.GetString(8)
                        });
                    }
                }
            }

            return casos;
        }
    }
}
