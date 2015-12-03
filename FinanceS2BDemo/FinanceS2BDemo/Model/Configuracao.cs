using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceS2BDemo.Model
{
    public class Configuracao
    {
        public Configuracao()
        {

        }

        [PrimaryKey]
        public string Chave { get; set; }
        public string Valor { get; set; }
    }
}
