using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn.Dominio
{
    public class ListaDados
    {
        public IEnumerable<Suspeito> Suspeitos { get; set; }
        public IEnumerable<Local> Locais { get; set; }
        public IEnumerable<Arma> Armas { get; set; }
    }
}
