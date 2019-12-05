using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEmpacotamento
{
    class ItemTabelaResultado
    {
        public string pacote { get; set; }

        public string produtos { get; set; }

        public ItemTabelaResultado(string pacote)
        {
            this.pacote = pacote;
        }
    }
}
