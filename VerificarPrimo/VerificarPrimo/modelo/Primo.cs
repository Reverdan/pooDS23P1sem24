using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VerificarPrimo.modelo
{
    internal class Primo
    {
		private string mensagem;
		private int num;

        public Primo(int num)
        {
            this.num = num;
            this.Verificar();
        }

        private void Verificar()
        {
            this.mensagem = "É primo";
            if (num <= 1) 
                mensagem = "Não é primo";

            for (int i = 2; i < num / 2 + 1; i++)
            {
                if (num % i == 0)
                {
                    mensagem = "Não é primo";
                    break;
                }
            }
        }

        public string Mensagem
		{
			get { return mensagem; }
		}

	}
}
