using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class ContaBancaria
    {
        public double Saldo { get; private set; }

        public ContaBancaria()
        {
            this.Saldo = 0;
        }

        public ContaBancaria(double Saldo)
        {
            this.Saldo = Saldo;
        }

        public double Sacar(double valor)
        {
            this.Saldo -= valor;
            return this.Saldo;
        }

        public double Depositar(double valor)
        {
            this.Saldo += valor;
            return this.Saldo;
        }
    }
}
