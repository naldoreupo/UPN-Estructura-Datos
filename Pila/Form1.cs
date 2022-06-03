using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pila
{
    public partial class Form1 : Form
    {
        Stack<int> pila = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            pila.Push(int.Parse(txtDato.Text));

            txtListado.Clear();
            foreach (var item in pila)
            {
                txtListado.Text += item.ToString() + Environment.NewLine;
            }       
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ultimo =  pila.Pop();

            MessageBox.Show(ultimo.ToString());


            txtListado.Clear();
            foreach (var item in pila)
            {
                txtListado.Text += item.ToString() + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ultimo = pila.Peek();

            MessageBox.Show(ultimo.ToString());


            txtListado.Clear();
            foreach (var item in pila)
            {
                txtListado.Text += item.ToString() + Environment.NewLine;
            }
        }
    }
}
