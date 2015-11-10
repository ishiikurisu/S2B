using System;

namespace Aula1
{
    class Program
    {
        static int input()
        {
            return int.Parse(Console.ReadLine());
        }

        static int min(int x, int y, int z)
        {
            return (x <= y && x <= z) ? x : (y <= x && y <= z) ? y : z;
        }

        static int max(int x, int y, int z)
        {
            return (x >= y && x >= z)? x : (y >= x && y >= z)? y : z;
        }

        static void ex1()
        {
            int n, s;

            Console.WriteLine("# Ex 1");
            for (n = int.Parse(Console.ReadLine()), s = 0;
                 n > 0;
                 s += int.Parse(Console.ReadLine()), --n);
            Console.WriteLine(s);
        }

        static void ex2()
        {
            Console.WriteLine("# Ex 2");
            int i = input();
            int a = input();
            int b = input();
            int c = input();
            int x = min(a, b, c);
            int z = max(a, b, c);
            int y = (a != z && a != x)? a : (b != z && b != x)? b : c;

            switch (i)
            {
                case 1:
                    Console.WriteLine(x + " " + y + " " + z);
                    break;

                case 2:
                    Console.WriteLine(z + " " + y + " " + x);
                    break;

                case 3:
                    if (z == a) { x = b; y = c; }
                    else if (z == b) { x = a; y = c; }
                    else { x = a; y = b; }
                    Console.WriteLine(x + " " + z + " " + y);
                    break;
            }
        }

        static void ex3()
        {
            Console.WriteLine("# Ex 3");
            double m = 0;

            for (int i = 0; i < 3;
                 m += double.Parse(Console.ReadLine()) / 3, ++i);
            if (m >= 10)
                Console.WriteLine("Passado com louvor! :D");
            else if (m >= 7 && m < 10)
                Console.WriteLine("Aprovado :)");
            else
                Console.WriteLine("Reprovado :(");
        }

        static void Main(string[] args)
        {
            
            ex1();
            ex2();
            ex3();
            Console.ReadKey();

        }
    }
}
