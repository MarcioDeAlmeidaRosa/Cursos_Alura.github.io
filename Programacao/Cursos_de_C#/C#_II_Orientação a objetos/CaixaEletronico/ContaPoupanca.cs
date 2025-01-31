﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class ContaPoupanca : Conta, ITributavel
    {
        public override bool Saca(double valorASerSacado)
        {
            if (this.Saldo >= valorASerSacado && valorASerSacado >= 0)
            {
                this.Saldo -= valorASerSacado + 0.10;
                return true;
            }
            return false;
        }

        public override void Atualiza(double taxa)
        {
            base.Atualiza(3 * taxa);
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
