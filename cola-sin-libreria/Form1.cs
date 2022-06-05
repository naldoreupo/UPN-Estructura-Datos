using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cola_sin_libreria
{
    public partial class Form1 : Form
    {
        Cola cola = new Cola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cola.Encolar(int.Parse(txtDato.Text));

            txtListado.Text = cola.Mostrar();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string inicio =    cola.Desencolar();

            MessageBox.Show(inicio);

            txtListado.Text = cola.Mostrar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inicio = cola.Extraer();

            MessageBox.Show(inicio);

            txtListado.Text = cola.Mostrar();
        }
    }
}
