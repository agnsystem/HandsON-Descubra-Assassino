using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOn.Dominio;
using HandsOn.Repositorio;

namespace HandsOn.Aplicacao
{
    public class ListaDadosAplicacao
    {
        public ListaDados obterListaObjetos()
        {
            return gerarObjetosModel();
        }

        private ListaDados gerarObjetosModel()
        {
            var SuspeitoApp = SuspeitoAplicacaoConstrutor.SuspeitoAplicacao();
            var LocalApp = LocalAplicacaoConstrutor.LocalAplicacao();
            var ArmaApp = ArmaAplicacaoConstrutor.ArmaAplicacao();

            var Lista = new ListaDados();

            Lista.Suspeitos = SuspeitoApp.listarTodos();
            Lista.Locais = LocalApp.listarTodos();
            Lista.Armas = ArmaApp.listarTodos();

            return Lista;

        }

    }
}