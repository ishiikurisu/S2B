namespace Aula4Ex1
{
    public class Calc
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public double Somar()
        {
            return this.Numero1 + Numero2;
        }

        public double Subtrair()
        {
            return this.Numero1 - Numero2;
        }

        public double Dividir()
        {
            if (Numero2 != 0)
                return this.Numero1 / Numero2;
            else
                return 0;
        }
    }
}
