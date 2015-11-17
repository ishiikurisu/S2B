using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Ex1
{
    public abstract class Trabalhador
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; set; }
        public double Salario { get; set; }

        public Trabalhador()
        {
            this.Salario = 500;
        }

        public Trabalhador(string Nome, string Sobrenome)
        {
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Salario = 500;
        }

        public override string ToString()
        {
            return this.Nome + " " + this.Sobrenome;
        }

        public abstract double GetSalario();
        public abstract double CalcularSalario(double quantidade);
    }
}
