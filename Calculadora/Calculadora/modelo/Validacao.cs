using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Validacao
    {
        public int n1;
        public int n2;
        public string mensagem;

        public void Validar(string num1, string num2, string op)
        {
            mensagem = "";
            try
            {
                n1 = Convert.ToInt32(num1);
                n2 = Convert.ToInt32(num2);
                if (op.Equals("/") && n2.Equals(0))
                    mensagem = "Divisão por zero";
            }
            catch (Exception erro)
            {
                mensagem = "Digite números válidos";
            }
        }

    }
}
