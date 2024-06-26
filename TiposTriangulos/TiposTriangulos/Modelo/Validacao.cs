﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposTriangulos.Modelo
{
    internal sealed class Validacao : AbsPropriedades
    {
        public Validacao(string lado1, string lado2, string lado3) : base(lado1, lado2, lado3)
        {
        }

        public override void Executar()
        {
            this.mensagem = "";
            try
            {
                this.l1 = Convert.ToInt32(this.lado1);
                this.l2 = Convert.ToInt32(this.lado2);
                this.l3 = Convert.ToInt32(this.lado3);
                if (l1 + l2 < l3 ||
                    l1 + l3 < l2 ||
                    l2 + l3 < l1)
                {
                    this.mensagem = "Não é um triângulo";
                }
            }
            catch (Exception e)
            {
                this.mensagem = "Digite números válidos";
            }
        }
    }
}



