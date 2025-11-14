using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ejemplo de Menú", "Menú en C#", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
        }

        private void sumarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a, b, suma;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            suma = a + b;

            label3.Text = suma.ToString();
        }

        private void restarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a, b, resta;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            resta = a - b;

            label3.Text = resta.ToString();
        }

        private void dividirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a, b, dividir;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            dividir = a / b;

            label3.Text = dividir.ToString();
        }

        private void multiplicarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a, b, multiplicar;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            multiplicar = a * b;
            label3.Text = multiplicar.ToString();

            ventana.Visible = true;
        }
    }
}
