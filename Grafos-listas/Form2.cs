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
    public partial class Form2 : Form
    {
        Grafo grafo = new Grafo();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grafo.Agregar("casa");
            grafo.Agregar("trabajo");
            grafo.Agregar("Oficina");

            //..
            //.

            grafo.Conectar("casa", "trabajo", 2);
            grafo.Conectar("casa", "Oficina", 5);         
            grafo.Conectar("Oficina", "trabajo", 8);



            List<int> listaA = new List<int>();
            List<int> listaB = new List<int>();

            List<int> listaBConsolidado= new List<int>();

            ///Unir listas
            foreach (var item in listaA)
            {
                listaBConsolidado.Add(item);
            }
            foreach (var item in listaB)
            {
                listaBConsolidado.Add(item);
            }


            listaBConsolidado.AddRange(listaA);
            listaBConsolidado.AddRange(listaB);




        }

        private void button2_Click(object sender, EventArgs e)
        {

            var rutas = grafo.ObtenerRutasMinimas("casa");


            foreach (var item in rutas)
            {
                txtRutas2.Text += item.Key.dato + "(" + item.Value + ")";
            }

        }
    }
}
