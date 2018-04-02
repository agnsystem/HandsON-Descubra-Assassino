using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandsOn.Dominio;
using System.Data.SqlClient;

namespace HandsOn.Repositorio
{
    public class ArmaRepositorio : IRepositorio<Arma>
    {
        private Contexto oContexto;

        public IEnumerable<Arma> ListarTodos()
        {
            using (oContexto = new Contexto())
            {
                var strQuery = " SELECT * from Arma ";
                var RetornoDataReader = oContexto.gerarDataHeader(strQuery);
                return gerarListaDeObjetos(RetornoDataReader);
            }
        }

        private List<Arma> gerarListaDeObjetos(SqlDataReader reader)
        {
            var oSuspeitos = new List<Arma>();
            while (reader.Read())
            {
                var tempObjeto = new Arma()
                {
                    IdArma = int.Parse(reader["IdArma"].ToString()),
                    Descricao = reader["Descricao"].ToString(),
                };
                oSuspeitos.Add(tempObjeto);
            }
            reader.Close();
            return oSuspeitos;
        }
    }
}
