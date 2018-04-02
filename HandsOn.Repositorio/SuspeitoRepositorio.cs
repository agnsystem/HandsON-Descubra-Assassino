using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HandsOn.Dominio;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Threading;

namespace HandsOn.Repositorio
{
    public class SuspeitoRepositorio : IRepositorio<Suspeito>
    {
        private Contexto oContexto;

        public IEnumerable<Suspeito> ListarTodos()
        {
            using (oContexto = new Contexto())
            {
                var strQuery = " SELECT * from Suspeito ";
                var RetornoDataReader = oContexto.gerarDataHeader(strQuery);
                return gerarListaDeObjetos(RetornoDataReader);
            }
        }

        private List<Suspeito> gerarListaDeObjetos(SqlDataReader reader)
        {
                var oSuspeitos = new List<Suspeito>();
                while (reader.Read())
                {
                    var tempObjeto = new Suspeito()
                    {
                        IdSuspeito = int.Parse(reader["IdSuspeito"].ToString()),
                        Nome = reader["Nome"].ToString(),
                    };
                    oSuspeitos.Add(tempObjeto);
                }
                reader.Close();
                return oSuspeitos;
        }
    }
}
