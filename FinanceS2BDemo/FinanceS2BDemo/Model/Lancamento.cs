using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceS2BDemo.Model
{
    [Table("Lancamento")]
    public class Lancamento
    {
        [AutoIncrement]
        [PrimaryKey]
        public int LancamentoId { get; set; }
        public int ContaId { get; set; }
        public int CategoriaId { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }
        public string Descricao { get; set; }

    }
}
