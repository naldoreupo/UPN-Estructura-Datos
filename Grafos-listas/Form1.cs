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
            lblCantidadNodos.Text = grafo.CantidadNodos.ToString();
            lblAristas.Text = grafo.CantidadAristas.ToString();


          
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            var conectdo = grafo.Conectar(txtOrigen.Text, txtDestino.Text , int.Parse(txtPeso.Text) );

            if (conectdo)
            {
                MessageBox.Show("Nodos conectados");
            }
            else
            {
                MessageBox.Show("No se pudo conectar");
            }

            txtListaAdyacencias.Text = grafo.ObtenerListaAdyacencias();
            lblCantidadNodos.Text = grafo.CantidadNodos.ToString();
            lblAristas.Text = grafo.CantidadAristas.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {



            txtDFS.Text = grafo.RecorridoDFS(txtDatoABuscar.Text);
            txtBFS.Text = grafo.RecorridoBFS(txtDatoABuscar.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rutas = grafo.ObtenerRutasMinimas(txtDatoABuscar.Text);


            foreach (var item in rutas)
            {
                txtRutaMinima.Text += item.Key.dato + "(" + item.Value + ")";   
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grafo.Eliminar(txtDatoABuscar.Text);
            txtListaAdyacencias.Text = grafo.ObtenerListaAdyacencias();
            lblCantidadNodos.Text = grafo.CantidadNodos.ToString();
            lblAristas.Text = grafo.CantidadAristas.ToString();
        }
    }
}
