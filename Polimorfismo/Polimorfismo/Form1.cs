using Polimorfismo.modelo;

namespace Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            SuperClasse calcular = new SuperClasse();
            Estaticos.VALOR = Convert.ToDouble(txbValor.Text);
            calcular.Calcular();
            lblResposta.Text = Estaticos.VALOR.ToString();
        }
    }
}
