using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Controle
    {
        private string num1;
        private string num2;
        private string op;

        private string mensagem;
        private string resultado;

        public Controle(string num1, string num2, string op)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.op = op;
            this.Executar();
        }

        private void Executar()
        {
            mensagem = "";
            Validacao validacao = new Validacao(num1, num2, op);
            if (validacao.Mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.N1, validacao.N2, op);
                resultado = calculos.Resposta.ToString();
            }
            else
                mensagem = validacao.Mensagem;
        }

        public string Mensagem { get => mensagem; }
        public string Resultado { get => resultado; }
    }
}
