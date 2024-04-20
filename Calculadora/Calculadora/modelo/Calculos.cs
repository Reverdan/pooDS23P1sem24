using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Calculadora.modelo
{
    public class Calculos
    {
        #region Atributos
        private int n1;
        private int n2;
        private string op;
        private int resposta;
        #endregion

        #region Construtores
        public Calculos(int n1, int n2, string op)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.op = op;
            this.Calcular();
        }
        #endregion

        #region Métodos
        private void Calcular()
        {
            if (op.Equals("+")) resposta = n1 + n2;
            if (op.Equals("-")) resposta = n1 - n2;
            if (op.Equals("*")) resposta = n1 * n2;
            if (op.Equals("/")) resposta = n1 / n2;
        }
        #endregion

        #region Propriedades
        public int Resposta
        {
            get { return resposta; }
        }
        #endregion
    }
}
