﻿using CaelumEstoque.Filtros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CaelumEstoque.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFlter(GlobalFilterCollection filter)
        {
            //Adiciona nosso filter de login
            //filter.Add(new AltorizacaoFilterAttribute());
        }
    }
}