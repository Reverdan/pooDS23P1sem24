using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Controle
    {
        public string num1;
        public string num2;
        public string mensagem;
        public string resultado;

        public void executar()
        {
            mensagem = "";
            Validacao validacao = new Validacao();
            validacao.num1 = num1;
            validacao.num2 = num2;
            validacao.validar();
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                calculos.n1 = validacao.n1;
                calculos.n2 = validacao.n2;
                calculos.calcular();
                resultado = calculos.resposta.ToString();
            }
            else
            {
                mensagem = validacao.mensagem;
            }
        }
    }
}
