using System;
using System.Windows.Forms;

namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        Triangulo triangulo = new Triangulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void tbLadoA_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbLadoA.Text, out var valor);
            triangulo.A = valor;
        }

        private void tbLadoB_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbLadoB.Text, out var valor);
            triangulo.B = valor;
        }

        private void tbLadoC_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(tbLadoC.Text, out var valor);
            triangulo.C = valor;
        }

        private void btnSemiperimetro_Click(object sender, EventArgs e)
        {
            tbSemiperimetro.Text = triangulo.CalcularSemiperimetro().ToString();
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            tbAeraTriangulo.Text = triangulo.CalcularArea().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbLadoA.Text = tbLadoB.Text = tbLadoC.Text = tbSemiperimetro.Text = tbAeraTriangulo.Text = "";
            triangulo.A = triangulo.B = triangulo.C = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
