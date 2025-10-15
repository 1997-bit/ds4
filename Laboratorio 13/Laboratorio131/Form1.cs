using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio131
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"Server=localhost;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;");
            conexion.Open();

            SqlCommand comando = new SqlCommand("SELECT ProductName FROM [dbo].[Products]", conexion);
            SqlDataReader reader = comando.ExecuteReader();


            while (reader.Read())
            {
                listBox1.Items.Add(reader["ProductName"].ToString());
            }

            reader.Close();
            conexion.Close();
        }


    }
}
