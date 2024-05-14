

using CalculoFatorial.modelo;

namespace CalculoFatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle(txbNumero.Text);
            if(Estaticos.MENSAGEM.Equals(""))
            {
                lblResposta.Text = controle.ToString();
            }
            else
            {
                MessageBox.Show(Estaticos.MENSAGEM);
            }
        }
    }
}
