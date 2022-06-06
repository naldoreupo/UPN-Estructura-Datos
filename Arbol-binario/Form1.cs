using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol_binario
{
    public partial class Form1 : Form
    {
        ArbolBinarioBusqueda abb = new ArbolBinarioBusqueda();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
     
           

            abb.Agregar( int.Parse(txtValor.Text)  );

            abb.inorder = "";
            abb.RecorrerInOrder(abb.raiz);

            abb.preorder = "";
            abb.RecorrerPreOrder(abb.raiz);


            abb.postOrder = "";
            abb.RecorrerPostOrder(abb.raiz);

            abb.Formato = "";
            abb.RecorreFormato(abb.raiz);

            txtListado.Text = abb.inorder;
            txtPostOrder.Text = abb.postOrder;
            txtPreOrder.Text = abb.preorder;
            txtFormato.Text = abb.Formato;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var encontrado =   abb.Buscar(int.Parse(txtValoraBuscar.Text));

            if(encontrado)
            {
                MessageBox.Show("Valor encontrado");
            }
            else
            {
                MessageBox.Show("No encontrado");
            }



        }


    }
}
