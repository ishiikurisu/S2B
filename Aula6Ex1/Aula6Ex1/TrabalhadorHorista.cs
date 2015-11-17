using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Ex1
{
    class TrabalhadorHorista : Trabalhador
    {
        public double HorasTrabalhadas { get; set; }
        public double ValorHora { get; set; }
        public TrabalhadorHorista(string Nome,
                                  string Sobrenome,
                                  double Salario,
                                  double ValorHora,
                                  double HorasTrabalhadas) : base(Nome, Sobrenome)
        {
            this.Salario = Salario;
            this.ValorHora = ValorHora;
            this.HorasTrabalhadas = HorasTrabalhadas;
        }
        public override double CalcularSalario(double qtd)
        {
            this.HorasTrabalhadas = qtd;
            return GetSalario();
        }

        public override double GetSalario()
        {
            return this.Salario + HorasTrabalhadas * ValorHora;
        }
        public override string ToString()
        {
            return "Trabalhador Horista: " + base.ToString();
        }
    }
}
