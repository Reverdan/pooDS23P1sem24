using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposTriangulos.Modelo
{
    internal sealed class Controle : AbsPropriedades
    {
        public Controle(string lado1, string lado2, string lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.Executar();
        }

        private void Executar()
        {

        }
    }
}
