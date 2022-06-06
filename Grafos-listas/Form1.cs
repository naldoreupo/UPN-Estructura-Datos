using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafos_listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Grafo grafo = new Grafo();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            grafo.Agregar(txtDato.Text);
            txtListaAdyacencias.Text = grafo.ObtenerListaAdyacencias();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            grafo.Conectar(txtOrigen.Text, txtDestino.Text);
            txtListaAdyacencias.Text = grafo.ObtenerListaAdyacencias();
        }
    }
}
