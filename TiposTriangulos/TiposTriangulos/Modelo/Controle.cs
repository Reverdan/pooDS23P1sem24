using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposTriangulos.Modelo
{
    internal sealed class Controle : AbsPropriedades
    {
        public Controle(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            Validacao validacao = new Validacao(
                this.lado1, this.lado2, this.lado3);
            if (validacao.mensagem.Equals(""))
            {
                Triangulos triangulos = new Triangulos(
                    validacao.l1, validacao.l2, validacao.l3);
                this.mensagem = triangulos.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}

