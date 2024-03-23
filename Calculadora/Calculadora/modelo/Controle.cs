using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.modelo
{
    public class Controle
    {
        public string mensagem;
        public string resultado;

        public void Executar(string num1, string num2, string op)
        {
            mensagem = "";
            Validacao validacao = new Validacao();
            validacao.Validar(num1, num2, op);
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                resultado = calculos.Calcular(validacao.n1, validacao.n2, op).ToString();
            }
            else
                mensagem = validacao.mensagem;
        }
    }
}
