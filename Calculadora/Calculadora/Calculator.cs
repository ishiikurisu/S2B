using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    

    class Calculator
    {
        private double Accumulator { get; set; }

        public Calculator()
        {
            ResetAccumulator();
        }

        public double Add(double value)
        {
            this.Accumulator += value;
            return this.Accumulator;
        }

        public double Subtract(double value)
        {
            this.Accumulator -= value;
            return this.Accumulator;
        }

        public double Multiply(double value)
        {
            this.Accumulator *= value;
            return this.Accumulator;
        }

        public double Divide(double value)
        {
            this.Accumulator /= value;
            return this.Accumulator;
        }

        public double GetAccumulator()
        {
            return this.Accumulator;
        }

        public void ResetAccumulator()
        {
            this.Accumulator = 0;
        }
    }

}
