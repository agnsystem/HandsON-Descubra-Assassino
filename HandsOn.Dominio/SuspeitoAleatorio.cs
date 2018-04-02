using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HandsOn.Dominio
{
    public class SuspeitoAleatorio
    {
        public int IdSuspeito { get; set; }
        public int IdLocal { get; set; }
        public int IdArma { get; set; }

        public int obterSuspeitoAleatorio(List<Suspeito> oSuspeitos)
        {
            Random suspeitoAleatorio = new Random();
            int idSuspeito = suspeitoAleatorio.Next(1, oSuspeitos.Count + 1);
           
            return idSuspeito;
        }

        public int obterLocalAleatorio(List<Local> oLocal)
        {
            Random localAleatorio = new Random();
            int idLocal = localAleatorio.Next(1, oLocal.Count + 1);

            return idLocal;
        }

        public int obterArmaAleatorio(List<Arma> oArma)
        {
            Random ArmaAleatorio = new Random();
            int idArma = ArmaAleatorio.Next(1, oArma.Count + 1);

            return idArma;
        }

        public Retorno verificarSuspeito(SuspeitoAleatorio oSuspeitoSelecionado, SuspeitoAleatorio oSuspeitoAleatorio)
        {
            Random numAleatorio = new Random();
            int[] idErro = {0, 0, 0};
            Retorno oRetorno = new Retorno();
           
            // Verificar Suspeito selecionado com suspeito aleatorio
            if (oSuspeitoSelecionado.IdSuspeito != oSuspeitoAleatorio.IdSuspeito)
            {
                idErro[0] = 1;
            }

            if (oSuspeitoSelecionado.IdLocal != oSuspeitoAleatorio.IdLocal)
            {
                idErro[1] = 2;
            }

            if (oSuspeitoSelecionado.IdArma != oSuspeitoAleatorio.IdArma)
            {
                idErro[2] = 3;
            }

            // verificar tipo do erro
            if (idErro[0] == 0 && idErro[1] == 0 && idErro[2] == 0)
            {
                oRetorno.Codigo = 0;
                oRetorno.Descricao = "Parabéns, você solucionou o caso!" + "\n" + "Deseja iniciar o questionamento novamente?";
            }
            else if (idErro[0] == 0 && idErro[1] == 0 && idErro[2] == 3)
            {
                oRetorno.Codigo = 3;
                oRetorno.Descricao = "A arma selecionada está incorreto!";
            }
            else if (idErro[0] == 0 && idErro[1] == 2 && idErro[2] == 0)
            {
                oRetorno.Codigo = 2;
                oRetorno.Descricao = "O local selecionado está incorreto!";
            }
            else if (idErro[0] == 0 && idErro[1] == 2 && idErro[2] == 3)
            {
                oRetorno.Codigo = numAleatorio.Next(2, 4);
                oRetorno.Descricao = "Somente o suspeitto selecionado está correto!";
            }
            else if (idErro[0] == 1 && idErro[1] == 0 && idErro[2] == 0)
            {
                oRetorno.Codigo = 1;
                oRetorno.Descricao = "O suspeito selecionado está incorreto!";
            }
            else if (idErro[0] == 1 && idErro[1] == 0 && idErro[2] == 3)
            {
                oRetorno.Codigo = 1;
                oRetorno.Descricao = "Somente o local selecionado está correto!";
            }
            else if (idErro[0] == 1 && idErro[1] == 2 && idErro[2] == 0)
            {
                oRetorno.Codigo = numAleatorio.Next(1, 3);
                oRetorno.Descricao = "Somente a arma selecionada está correto!";
            }
            else // (idErro[0] == 1 && idErro[1] == 2 && idErro[2] == 3)
            {
                oRetorno.Codigo = numAleatorio.Next(1, 4);
                oRetorno.Descricao = "Todas as opções selecionadas estão incorretas!";
            }

            return oRetorno;

            //// Serializando suspeito aleatorio
            //var retorno_serializado = JsonConvert.SerializeObject(oRetorno);
            //System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Retorno.json", retorno_serializado);
        }
    }
}
