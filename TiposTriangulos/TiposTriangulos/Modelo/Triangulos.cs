using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposTriangulos.Modelo
{
    internal sealed class Triangulos : AbsPropriedades
    {
        public Triangulos(int l1, int l2, int l3) : base(l1, l2, l3)
        {
        }

        public override void Executar()
        {
            if (l1 == l2 && l2 == l3)
                this.mensagem = "Triângulo Equilátero";
            else
            {
                if (l1 != l2 && l1 != l3 && l2 != l3)
                    this.mensagem = "Triângulo Escaleno";
                else
                    this.mensagem = "Triângulo Isosceles";
            }
        }
    }
}



