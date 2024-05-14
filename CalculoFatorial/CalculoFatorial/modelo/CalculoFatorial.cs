using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoFatorial.modelo
{
    internal class CalculoFatorial : AbsPropriedades
    {
        public CalculoFatorial(Int64 num) : base(num)
        {
        }

        public override void Executar()
        {
            Int64 valor = num;
            for(int i = 1; i < valor; i++)
            {
                num *= i; // num = num * i
            }
            this.numero = num.ToString();
        }
    }
}
