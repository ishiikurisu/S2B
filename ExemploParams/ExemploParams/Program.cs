using System;

namespace ExemploParams
{
    class Program
    {
        static void Main(string[] args)
        {
            ExemploParams ep = new ExemploParams();
            Console.WriteLine("Dois parâmetros: " + ep.Somar(10, 15));
            Console.WriteLine("Três parâmetros: " + ep.Somar(10, 12, 3));
        }
    }
}
