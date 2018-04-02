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
    public class LocalRepositorio : IRepositorio<Local>
    {
        private Contexto oContexto;

        public IEnumerable<Local> ListarTodos()
        {
            using (oContexto = new Contexto())
            {
                var strQuery = " SELECT * from Local ";
                var RetornoDataReader = oContexto.gerarDataHeader(strQuery);
                return gerarListaDeObjetos(RetornoDataReader);
            }
        }

        private List<Local> gerarListaDeObjetos(SqlDataReader reader)
        {
            var oSuspeitos = new List<Local>();
            while (reader.Read())
            {
                var tempObjeto = new Local()
                {
                    IdLocal = int.Parse(reader["IdLocal"].ToString()),
                    Descricao = reader["Descricao"].ToString(),
                };
                oSuspeitos.Add(tempObjeto);
            }
            reader.Close();
            return oSuspeitos;
        }
    }
}
