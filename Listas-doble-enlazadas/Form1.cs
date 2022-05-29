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
            lblCantidad.Text = datos.cantidad.ToString();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var Encontrado = datos.Buscar(int.Parse(txtDato.Text));

            if (Encontrado)
            {
                MessageBox.Show("Cadena encontrada");
            }
            else
            {
                MessageBox.Show("Cadena NO encontrada");

            }


        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            datos.EliminarUltimo();

            txtListado.Text = datos.Mostrar();
            txtListadoReverso.Text = datos.MostrarInversa();
            lblCantidad.Text = datos.cantidad.ToString();
        }
    }
}