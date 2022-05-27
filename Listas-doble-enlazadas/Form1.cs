namespace Listas_doble_enlazadas
{
    public partial class Form1 : Form
    {
        Lista datos = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            datos.Agregar(int.Parse(txtDato.Text));
            txtDato.Clear();

            txtListado.Text = datos.Mostrar();
            txtListadoReverso.Text = datos.MostrarInversa();
        }
    }
}