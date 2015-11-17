using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Ex1
{
    class TrabalhadorComissao : Trabalhador
    {
        public double ItensVendidos { get; set; }
        public double Comissao { get; set; }

        public TrabalhadorComissao(string nome,
                                   string sobrenome,
                                   double salario,
                                   double comissao,
                                   double qtd) : base(nome, sobrenome)
        {
            this.Salario = salario;
            this.Comissao = comissao;
            this.ItensVendidos = qtd;
        }

        public double SetComissao(double comissao)
        {
            this.Comissao = comissao;
            return this.Comissao;
        }
        public double SetQuantidade(double qtd)
        {
            this.ItensVendidos = qtd;
            return qtd;
        }

        public override double CalcularSalario(double qtd)
        {
            this.SetQuantidade(qtd);
            return this.Salario + 
                this.ItensVendidos*this.Comissao;
        }
        public override string ToString()
        {
            return "Trabalhador por comissão: " 
                + base.ToString();
        }

        public override double GetSalario()
        {
            return this.CalcularSalario(this.ItensVendidos);
        }
    }
}
