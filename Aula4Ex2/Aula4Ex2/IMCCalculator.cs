namespace Aula4Ex2
{
    class IMCCalculator
    {
        public double Altura { get; set; }
        public double Peso { get; set; }

        public IMCCalculator()
        {
        }

        public double Calcular()
        {
            return Peso / Altura / Altura;
        }

        public string Avaliar()
        {
            double imc = this.Calcular();
            string resultado = "Magro";

            if (imc > 18.5 && imc < 25)
                resultado = "Normal";
            else if (imc > 25)
                resultado = "Obeso";

            return resultado;
        }
    }
}