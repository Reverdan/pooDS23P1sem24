using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposTriangulos.Modelo
{
    internal sealed class Validacao : AbsPropriedades
    {
        public Validacao(string lado1, string lado2, string lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.Executar();
        }

        private void Executar()
        {
            this.mensagem = "";
            try
            {
                this.l1 = Convert.ToInt32(this.lado1);
                this.l2 = Convert.ToInt32(this.lado2);
                this.l3 = Convert.ToInt32(this.lado3);
            }
            catch (Exception e)
            {
                this.mensagem = "Digite números válidos";
            }
        }
    }
}
