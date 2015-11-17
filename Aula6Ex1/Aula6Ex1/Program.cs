using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Trabalhador chefe = new TrabalhadorChefe("Joe", "Frank", 500);
            Trabalhador comissionado = new TrabalhadorComissao("Igor", "Mota", 250, 20, 8);
            Trabalhador produtor = new TrabalhadorProducao("Tia", "Almendra", 100, 25, 7);
            Trabalhador horista = new TrabalhadorHorista("Carol", "Haine", 300, 15, 12);

            double[] salarios = new double[4];
            salarios[0] = chefe.GetSalario();
            salarios[1] = comissionado.GetSalario();
            salarios[2] = produtor.GetSalario();
            salarios[3] = horista.GetSalario();

            Console.WriteLine(chefe.ToString() + " ganhou " + salarios[0] + "$");
            Console.WriteLine(comissionado.ToString() + " ganhou " + salarios[1] + "$");
            Console.WriteLine(produtor.ToString() + " ganhou " + salarios[2] + "$");
            Console.WriteLine(horista.ToString() + " ganhou " + salarios[3] + "$");
            Console.ReadKey();
        }
    }
}
