using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace HandsOn.Repositorio
{
    public class Contexto : IDisposable
    {
        private readonly SqlConnection dbConexao;

        // Conexão com banco de dados
        public Contexto()
        {
            dbConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["dbHandsOn"].ConnectionString);
            dbConexao.Open();
        }

        /// <summary>
        /// Este metodo preenche um DataHeader conforme instrução SQL enviada por paramentro
        /// </summary>
        /// <param name="strQuery"></param>
        /// <returns>SqlDataHeader</returns>
        public SqlDataReader gerarDataHeader(string strQuery)
        {
                var cmdComando = new SqlCommand(strQuery, dbConexao);
                return cmdComando.ExecuteReader();
        }

        public void Dispose()
        {
            if (dbConexao.State == ConnectionState.Open)
            {
                dbConexao.Close();
            }
        }
    }
}
