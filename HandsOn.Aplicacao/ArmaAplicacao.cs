using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOn.Dominio;
using HandsOn.Repositorio;

namespace HandsOn.Aplicacao
{
    public class ArmaAplicacao
    {
        private readonly IRepositorio<Arma> oRepositorio;

        public ArmaAplicacao(IRepositorio<Arma> oRepo)
        {
            oRepositorio = oRepo;
        }

        public IEnumerable<Arma> listarTodos()
        {
            return oRepositorio.ListarTodos();
        }
    }
}