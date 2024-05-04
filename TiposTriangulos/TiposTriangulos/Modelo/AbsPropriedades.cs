using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposTriangulos.Modelo
{
    internal abstract class AbsPropriedades : IMetodos
    {
        public int l1;
        public int l2;
        public int l3;
        public string lado1;
        public string lado2;
        public string lado3;
        public string mensagem;

        protected AbsPropriedades(string lado1, string lado2, string lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
            this.Executar();
        }

        protected AbsPropriedades(int l1, int l2, int l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
            this.Executar();
        }

        public abstract void Executar();
    }
}
