using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFatorial.modelo
{
    internal class Validacao : AbsPropriedades
    {
        public Validacao(string numero) : base(numero)
        {
        }

        public override void Executar()
        {
            Estaticos.MENSAGEM = "";
            try
            {
                this.num = Convert.ToInt64(this.numero);
            }
            catch (Exception)
            {
                Estaticos.MENSAGEM = "Digite valores válidos";
            }
        }
    }
}
