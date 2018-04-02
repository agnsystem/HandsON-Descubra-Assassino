using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOn.Repositorio;

namespace HandsOn.Aplicacao
{
    public class LocalAplicacaoConstrutor
    {
        public static LocalAplicacao LocalAplicacao()
        {
            return new LocalAplicacao(new LocalRepositorio());
        }
    }
}