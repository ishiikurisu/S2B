using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Ex1
{
    class TrabalhadorProducao : Trabalhador
    {
        public double ItensProduzidos { get; set; }
        public double ValorItem { get; set; }
        public TrabalhadorProducao(string Nome,
                                   string Sobrenome,
                                   double Salario,
                                   double ValorItem,
                                   double ItensProduzidos) : base(Nome, Sobrenome)
        {
            this.Salario = Salario;
            this.ValorItem = ValorItem;
            this.ItensProduzidos = ItensProduzidos;
        }
        public override double CalcularSalario(double qtd)
        {
            this.ItensProduzidos = qtd;
            return GetSalario();
        }

        public override double GetSalario()
        {
            return this.Salario + ItensProduzidos * ValorItem;
        }
        public override string ToString()
        {
            return "Trabalhador por produção: " + base.ToString();
        }
    }
}
