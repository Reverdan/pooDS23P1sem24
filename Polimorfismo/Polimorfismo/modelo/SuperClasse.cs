using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.modelo
{
    internal class SuperClasse
    {

        public virtual void Calcular()
        {
            Estaticos.VALOR = Estaticos.VALOR * 0.05;
        }
    }
}
