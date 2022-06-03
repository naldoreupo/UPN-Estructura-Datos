using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cola
{
    public partial class Form1 : Form
    {
        Queue<int> cola = new Queue<int>(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            cola.Enqueue(int.Parse(txtDato.Text));

            txtListado.Clear();
            foreach (var item in cola)
            {
                txtListado.Text += item + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ultimo = cola.Dequeue();

            MessageBox.Show(ultimo.ToString());

            txtListado.Clear();
            foreach (var item in cola)
            {
                txtListado.Text += item + Environment.NewLine;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ultimo = cola.Peek();

            MessageBox.Show(ultimo.ToString());

            txtListado.Clear();
            foreach (var item in cola)
            {
                txtListado.Text += item + Environment.NewLine;
            }

            //objetos
            /// Grupo 1 ,2 3 -> Pilas Practica 04
            /// Grupos 3,4,5 -> Cola Practica 05

        }
    }
}
