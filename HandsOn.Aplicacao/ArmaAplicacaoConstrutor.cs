using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOn.Repositorio;

namespace HandsOn.Aplicacao
{
    public class ArmaAplicacaoConstrutor
    {
        public static ArmaAplicacao ArmaAplicacao()
        {
            return new ArmaAplicacao(new ArmaRepositorio());
        }
    }
}