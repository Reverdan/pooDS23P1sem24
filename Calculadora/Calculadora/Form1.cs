
using Calculadora.modelo;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.num1 = txbPrimeiroNumero.Text;
            controle.num2 = txbSegundoNumero.Text;
            controle.executar();
            if (controle.mensagem.Equals(""))
            {
                lblResultado.Text = controle.resultado;
            }
            else
            {
                lblResultado.Text = controle.mensagem;
            }
        }
    }
}