namespace ExemploParams
{
    class ExemploParams
    {
        public int Somar(params int[] list)
        {
            int soma = 0;

            foreach (int x in list)
            {
                soma += x;
            }

            return soma;
        }
    }
}
