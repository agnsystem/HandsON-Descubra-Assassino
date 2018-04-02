using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HandsOn.Dominio
{
    public interface IRepositorio<T> where T : class
    {
        IEnumerable<T> ListarTodos();
    }
}
