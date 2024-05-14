using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFatorial.modelo
{
    internal abstract class AbsPropriedades : IMetodos
    {
        public string numero;
        public Int64 num;

        protected AbsPropriedades(string numero)
        {
            this.numero = numero;
            this.Executar();
        }

        protected AbsPropriedades(Int64 num)
        {
            this.num = num;
            this.Executar();
        }

        public abstract void Executar();

        public override string? ToString()
        {
            return numero;
        }
    }
}
