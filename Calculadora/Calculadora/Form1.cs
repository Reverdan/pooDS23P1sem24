
using Calculadora.modelo;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular(string op)
        {
            Controle controle = new Controle();
            controle.Executar(txbPrimeiroNumero.Text, txbSegundoNumero.Text, op);
            if (controle.mensagem.Equals(""))
                lblResultado.Text = controle.resultado;
            else
                lblResultado.Text = controle.mensagem;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calcular("+");
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calcular("-");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calcular("*");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calcular("/");
        }
    }
}