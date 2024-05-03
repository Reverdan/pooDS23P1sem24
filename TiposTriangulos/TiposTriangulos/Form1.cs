using TiposTriangulos.Modelo;

namespace TiposTriangulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbLado1.Text,
                txbLado2.Text, txbLado3.Text);
            lblResultado.Text = controle.mensagem;
        }
    }
}
