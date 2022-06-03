using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pila_sin_libreria
{
    public partial class Form1 : Form
    {
        Pila pila = new Pila();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pila.Apilar(txtDato.Text);

            txtListado.Text = pila.Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

             string dato = pila.Desapilar();

            MessageBox.Show(dato);


            txtListado.Text = pila.Mostrar();

        }

        private void button2_Click(object sender, EventArgs e)
        {            string dato = pila.extraer();

            MessageBox.Show(dato);


            txtListado.Text = pila.Mostrar();
        }
    }
}
