using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HandsOn.Dominio;
using HandsOn.Repositorio;
using System.Threading.Tasks;
using System.Threading;

namespace HandsOn.Aplicacao
{
    public class SuspeitoAleatorioAplicacao
    {
        public SuspeitoAleatorio ObterSuspeitoAleatorio(ListaDados oLista)
        {
            var oSuspeitoAleatorio = new SuspeitoAleatorio();

            oSuspeitoAleatorio.IdSuspeito = oSuspeitoAleatorio.obterSuspeitoAleatorio(oLista.Suspeitos.ToList());
            oSuspeitoAleatorio.IdLocal = oSuspeitoAleatorio.obterLocalAleatorio(oLista.Locais.ToList());
            oSuspeitoAleatorio.IdArma = oSuspeitoAleatorio.obterArmaAleatorio(oLista.Armas.ToList());

            return oSuspeitoAleatorio;

        }

        public Retorno VerificarSuspeito(SuspeitoAleatorio oSuspeitoSelecionado, SuspeitoAleatorio oSuspeitoAleatorio)
        {
            return oSuspeitoAleatorio.verificarSuspeito(oSuspeitoSelecionado, oSuspeitoAleatorio);
        }
    }
}