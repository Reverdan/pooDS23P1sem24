using CalculoFatorial.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFatorial.modelo
{
    internal class Controle : AbsPropriedades
    {
        public Controle(long num) : base(num)
        {
        }

        public override void Executar()
        {
            AbsPropriedades validacao = new Validacao(this.numero);
            if (Estaticos.MENSAGEM.Equals(""))
            {
                AbsPropriedades fatorial = new CalculoFatorial(validacao.num);
                this.numero = fatorial.ToString();
            }
        }
    }
}

