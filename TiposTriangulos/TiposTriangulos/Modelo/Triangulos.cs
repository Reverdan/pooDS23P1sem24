using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposTriangulos.Modelo
{
    internal sealed class Triangulos : AbsPropriedades
    {
        public Triangulos(int l1, int l2, int l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            this.Executar();
        }

        private void Executar()
        {

        }
    }
}
