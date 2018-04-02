using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOn.Repositorio;
using HandsOn.Dominio;

namespace HandsOn.Aplicacao
{
    public class SuspeitoAplicacaoConstrutor
    {
        public static SuspeitoAplicacao SuspeitoAplicacao()
        {
            return new SuspeitoAplicacao(new SuspeitoRepositorio());
        }
    }
}