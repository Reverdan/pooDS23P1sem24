
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
            Controle controle = new Controle(txbPrimeiroNumero.Text, txbSegundoNumero.Text, op);
            if (controle.Mensagem.Equals(""))
                lblResultado.Text = controle.Resultado;
            else
                lblResultado.Text = controle.Mensagem;
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