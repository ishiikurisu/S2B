using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceS2BDemo.Model
{
    [Table("Categoria")]
    public class Categoria
    {
        [AutoIncrement]
        [PrimaryKey]
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }

    }
}
