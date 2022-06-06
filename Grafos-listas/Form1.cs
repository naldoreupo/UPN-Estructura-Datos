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
            var conectdo = grafo.Conectar(txtOrigen.Text, txtDestino.Text);

            if (conectdo)
            {
                MessageBox.Show("Nodos conectados");
            }
            else
            {
                MessageBox.Show("No se pudo conectar");
            }

            txtListaAdyacencias.Text = grafo.ObtenerListaAdyacencias();   
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtDFS.Text = grafo.RecorridoDFS(txtDatoABuscar.Text );
        }
    }
}
