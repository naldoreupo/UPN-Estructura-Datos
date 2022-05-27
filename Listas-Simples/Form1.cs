namespace Listas_Simples
{
    public partial class Form1 : Form
    {
        Lista lista = new Lista();
        List<int> listaConLibreria = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Sin libreria
            lista.Agregar(int.Parse(txtDato.Text));
            txtListado.Text = lista.Mostrar();


            //Con libreria
            listaConLibreria.Add(int.Parse(txtDato.Text));

            txtListadoConLibreria.Text = String.Empty;
            foreach (var item in listaConLibreria)
            {
                txtListadoConLibreria.Text += item + Environment.NewLine;
            }
        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}