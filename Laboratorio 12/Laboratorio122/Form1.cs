using System;
using System.Windows.Forms;

namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            if (float.TryParse(tbvelocidad.Text, out float velocidad) &&
                float.TryParse(tbtiempo.Text, out float tiempo))
            {
                Movimiento m = new Movimiento
                {
                    Velocidad = velocidad,
                    Tiempo = tiempo
                };

                tbDistancia.Text = m.CalcularDistancia().ToString("0.00");
            }
            else
            {
                MessageBox.Show("Ingrese valores válidos para velocidad y tiempo.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbvelocidad.Text = "";
            tbtiempo.Text = "";
            tbDistancia.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }

    public class Movimiento
    {
        public float Velocidad { get; set; }
        public float Tiempo { get; set; }

        public float CalcularDistancia()
        {
            return Velocidad * Tiempo;
        }
    }
}
