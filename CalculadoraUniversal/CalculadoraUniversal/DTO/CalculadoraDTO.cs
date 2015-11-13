namespace CalculadoraUniversal.DTO
{
    public class CalculadoraDTO
    {
        public double Entrada1 { get; set; }
        public double Entrada2 { get; set; }

        public double Somar()
        {
            return this.Entrada1 + this.Entrada2;
        }
    }
}
