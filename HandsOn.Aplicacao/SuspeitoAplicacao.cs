using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOn.Dominio;
using HandsOn.Repositorio;

namespace HandsOn.Aplicacao
{
    public class SuspeitoAplicacao
    {

        private readonly IRepositorio<Suspeito> oRepositorio;

        public SuspeitoAplicacao(IRepositorio<Suspeito> oRepo)
        {
            oRepositorio = oRepo;
        }

        public IEnumerable<Suspeito> listarTodos()
        {
            return oRepositorio.ListarTodos();
        }

    }
}