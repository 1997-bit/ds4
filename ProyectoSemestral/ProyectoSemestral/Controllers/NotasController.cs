using ProyectoSemestral.Models;
using ProyectoSemestral.Models.WS;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Http;

namespace ProyectoSemestral.Controllers
{
    [RoutePrefix("api/Notas")]
    public class NotasController : ApiController
    {
        private SqlConnection con;

        public NotasController()
        {
            var connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConexionNotas"];

            if (connectionString == null)
            {
                throw new InvalidOperationException("No se encontró la cadena de conexión 'ConexionNotas' en Web.config");
            }

            con = new SqlConnection(connectionString.ConnectionString);
        }

        // GET: api/Notas
        [HttpGet]
        [Route("")]
        public Reply ObtenerNotas()
        {
            Reply oR = new Reply();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Notas ORDER BY UltimaModificacion DESC", con))
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    var lista = new System.Collections.Generic.List<Nota>();

                    while (reader.Read())
                    {
                        lista.Add(new Nota
                        {
                            Id = reader.GetInt32(0),
                            Titulo = reader.GetString(1),
                            Contenido = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            FechaCreacion = reader.GetDateTime(3),
                            UltimaModificacion = reader.GetDateTime(4)
                        });
                    }
                    con.Close();

                    oR.Result = 1;
                    oR.Data = lista;
                    oR.Message = "Notas obtenidas correctamente";
                }
            }
            catch (Exception ex)
            {
                oR.Result = 0;
                oR.Message = "Error: " + ex.Message;
            }
            return oR;
        }

        // GET: api/Notas/5
        [HttpGet]
        [Route("{id}")]
        public Reply ObtenerNota(int id)
        {
            Reply oR = new Reply();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Notas WHERE Id = @Id", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Nota nota = new Nota
                        {
                            Id = reader.GetInt32(0),
                            Titulo = reader.GetString(1),
                            Contenido = reader.IsDBNull(2) ? "" : reader.GetString(2),
                            FechaCreacion = reader.GetDateTime(3),
                            UltimaModificacion = reader.GetDateTime(4)
                        };
                        oR.Result = 1;
                        oR.Data = nota;
                        oR.Message = "Nota encontrada";
                    }
                    else
                    {
                        oR.Result = 0;
                        oR.Message = "Nota no encontrada";
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                oR.Result = 0;
                oR.Message = "Error: " + ex.Message;
            }
            return oR;
        }

        // POST: api/Notas
        [HttpPost]
        [Route("")]
        public Reply CrearNota([FromBody] Nota nota)
        {
            Reply oR = new Reply();
            try
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Notas (Titulo, Contenido) VALUES (@Titulo, @Contenido); SELECT SCOPE_IDENTITY();", con))
                {
                    cmd.Parameters.AddWithValue("@Titulo", nota.Titulo);
                    cmd.Parameters.AddWithValue("@Contenido", nota.Contenido ?? "");
                    con.Open();
                    int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();

                    oR.Result = 1;
                    oR.Data = nuevoId;
                    oR.Message = "Nota creada con éxito";
                }
            }
            catch (Exception ex)
            {
                oR.Result = 0;
                oR.Message = "Error al crear nota: " + ex.Message;
            }
            return oR;
        }

        // PUT: api/Notas/5
        [HttpPut]
        [Route("ActualizarNota/{id}")]
        public Reply ActualizarNota(int id, [FromBody] Nota nota)
        {
            Reply oR = new Reply();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Notas SET Titulo = @Titulo, Contenido = @Contenido, " +
                    "UltimaModificacion = GETDATE() WHERE Id = @Id", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Titulo", nota.Titulo);
                    cmd.Parameters.AddWithValue("@Contenido", nota.Contenido ?? "");
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    oR.Result = rows > 0 ? 1 : 0;
                    oR.Message = rows > 0 ? "Nota actualizada" : "Nota no encontrada";
                }
            }
            catch (Exception ex)
            {
                oR.Result = 0;
                oR.Message = "Error: " + ex.Message;
            }
            return oR;
        }

        // DELETE: api/Notas/5
        [HttpDelete]
        [Route("EliminarNota/{id}")]
        public Reply EliminarNota(int id)
        {
            Reply oR = new Reply();
            try
            {
                using (SqlCommand cmd = new SqlCommand(
                    "DELETE FROM Notas WHERE Id = @Id", con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    oR.Result = rows > 0 ? 1 : 0;
                    oR.Message = rows > 0 ? "Nota eliminada" : "Nota no encontrada";
                }
            }
            catch (Exception ex)
            {
                oR.Result = 0;
                oR.Message = "Error: " + ex.Message;
            }
            return oR;
        }
    }
}