using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOn.Dominio;
using HandsOn.Repositorio;

namespace HandsOn.Aplicacao
{
    public class LocalAplicacao
    {            
        private readonly IRepositorio<Local> oRepositorio;

        public LocalAplicacao(IRepositorio<Local> oRepo)
            {
                oRepositorio = oRepo;
            }

            public IEnumerable<Local> listarTodos()
            {
                return oRepositorio.ListarTodos();
            }

    }
}