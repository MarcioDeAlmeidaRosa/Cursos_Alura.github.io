﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum.CaixaEletronico
{
    public class ValorNegativoException : Exception
    {
        public ValorNegativoException()
            : base("Valor é negativo")
        {

        }
    }
}