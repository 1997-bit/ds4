using System.Configuration;
using System.Data;
using System.Data.SqlClient;

protected void Page_Load(object sender, EventArgs e)
{
    ConnectionStringSettings conString = ConfigurationManager.ConnectionStrings["db.Name"];
    SqlConnection conexion = new SqlConnection(conString.ConnectionString);

    using (SqlCommand cmd = new SqlCommand("SalesByCategory", conexion))
    {
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = "Seafood";
        conexion.Open();

        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            GridV.DataSource = reader;
            GridV.DataBind();
        }
    }
}