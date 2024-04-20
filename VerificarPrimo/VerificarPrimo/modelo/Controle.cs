using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarPrimo.modelo
{
    internal class Controle
    {
		private string mensagem;
		private string numero;

        public Controle(string numero)
        {
            this.numero = numero;
            this.Executar();
        }

        private void Executar()
        {
            Validacao validacao = new Validacao(numero);
            if (validacao.Mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.N1);
                this.mensagem = primo.Mensagem;
            }
            else
            {
                this.mensagem = validacao.Mensagem;
            }
        }

        public string Mensagem
		{
			get { return mensagem; }
		}

	}
}
