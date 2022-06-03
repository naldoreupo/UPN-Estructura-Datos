namespace Pilas
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
            datos.Apilar(int.Parse(txtDatos.Text));

            txtListado.Text = datos.mostrar();
            
        }
    }
}