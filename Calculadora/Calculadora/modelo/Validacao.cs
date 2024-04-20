using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Validacao
    {
        private string num1;
        private string num2;
        private string op;
        
        private int n1;
        private int n2;
        private string mensagem;

        /// Comunicação por método construtor
        /// Poderia ter sido feito a sobrecarga para valores diferentes

        public Validacao(string num1, string num2, string op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
            this.Validar();
        }

        private void Validar()
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

        public string Mensagem
        {
            get { return mensagem; }
        }

        public int N1
        {
            get => n1;
        }

        public int N2
        {
            get => n2;
        }

    }
}
