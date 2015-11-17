using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Ex1
{
    public class TrabalhadorChefe : Trabalhador
    {
        public TrabalhadorChefe()
        {

        }
        public TrabalhadorChefe(string nome, string sobrenome, double salario) : base(nome, sobrenome)
        {
            this.Salario = salario;
        }

        public double SetSalarioSemanal(double salario)
        {
            return this.Salario = salario;
        }

        public override double GetSalario()
        {
            return this.Salario;
        }

        public override string ToString()
        {
            return "Chefe: " + base.ToString();
        }

        public override double CalcularSalario(double salario)
        {
            return this.SetSalarioSemanal(salario);
        }
    }
}
