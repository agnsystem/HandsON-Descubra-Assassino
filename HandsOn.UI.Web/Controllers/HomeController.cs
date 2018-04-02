using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOn.Aplicacao;
using HandsOn.Dominio;
using HandsOn.UI.Web.Models;
using Newtonsoft.Json;
using System.IO;

namespace HandsOn.UI.Web.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var ListaDadosApp = new ListaDadosAplicacao();
            var SuspeitoAleatorioApp = new SuspeitoAleatorioAplicacao();

            ViewBag.Mensagem = ""; 

            var Model = new ListaDados();
            Model = ListaDadosApp.obterListaObjetos();

            ViewBag.IdSuspeito = new SelectList(Model.Suspeitos, "IdSuspeito", "Nome");
            ViewBag.IdLocal = new SelectList(Model.Locais, "IdLocal", "Descricao");
            ViewBag.IdArma = new SelectList(Model.Armas, "IdArma", "Descricao");

            var oSuspeitoAleatorio = SuspeitoAleatorioApp.ObterSuspeitoAleatorio(Model);

            // Serializando suspeito aleatorio
            var suspeitoAleatorio_serializado = JsonConvert.SerializeObject(oSuspeitoAleatorio);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\suspeitoAleatorio.json", suspeitoAleatorio_serializado);

            return View();
        }

        [HttpPost]
        public ActionResult Index(string idSuspeito, string idLocal, string idArma)
        {
            var oSuspeitoSelecionado = new SuspeitoAleatorio();
            var oRetorno = new Retorno();
            var oMensagem = new Mensagem();
            if (idSuspeito == "" || idLocal == "" || idArma == "" || idSuspeito == null || idLocal == null || idArma == null)
            {
                // todas as opçoes devem ser selecionadas
                ViewBag.Mensagem = "Um suspeito, um local e uma arma devem ser selecionado!";
                return View();
            }

            int idSuspeitoSelecionado = int.Parse(idSuspeito);
            int idLocalSelecionado = int.Parse(idLocal);
            int idArmaSelecionado = int.Parse(idArma);

            oSuspeitoSelecionado.IdSuspeito = idSuspeitoSelecionado;
            oSuspeitoSelecionado.IdLocal = idLocalSelecionado;
            oSuspeitoSelecionado.IdArma = idArmaSelecionado;

            // Desserializando Lista de Suspeitos, Locais e armar
            var suspeitoAleatorio_json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\suspeitoAleatorio.json");
            var oSuspeitoAleatorio = JsonConvert.DeserializeObject<SuspeitoAleatorio>(suspeitoAleatorio_json);

            oRetorno = oSuspeitoAleatorio.verificarSuspeito(oSuspeitoSelecionado, oSuspeitoAleatorio);

            ViewBag.Mensagem = oRetorno.Descricao;

            //// Desserializando retorno da verificação
            //var retorno_json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Retorno.json");
            //var oRetorno = JsonConvert.DeserializeObject<Retorno>(retorno_json);

            return View();
        }
    }
}
