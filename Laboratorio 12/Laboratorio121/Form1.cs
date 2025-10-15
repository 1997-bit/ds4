using System;
using System.Windows.Forms;

namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        private Movimiento movimiento = new Movimiento();

        public Form1()
        {
            InitializeComponent();
        }

        private void tbVelocidad_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbVelocidad.Text, out float valor);
            movimiento.Velocidad = valor;
        }

        private void tbTiempo_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbTiempo.Text, out float valor);
            movimiento.Tiempo = valor;
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            tbDistancia.Text = movimiento.CalcularDistancia().ToString("0.##");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbVelocidad.Text = "";
            tbTiempo.Text = "";
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
