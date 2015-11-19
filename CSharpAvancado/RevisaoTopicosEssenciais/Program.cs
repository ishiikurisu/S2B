using System;

namespace RevisaoTopicosEssenciais
{
    class Program
    {
        static ManipuladorFTP<string> Manipulador = new ManipuladorFTP<string>();
        static void Main(string[] args)
        {
            while (MainMenu());
        }

        static bool MainMenu()
        {
            bool key = true;

            Console.WriteLine("--- # store your stuff");
            Console.WriteLine("E. exit");
            Console.WriteLine("A. store something");
            Console.WriteLine("R. get something");

            switch (Console.ReadLine().ToUpper())
            {
                case "E":
                    key = false;
                    Console.WriteLine("see ya :)");
                    break;

                case "A":
                    Add();
                    break;

                case "R":
                    Get();
                    break;

                default:
                    Console.WriteLine("there's no such option");
                    break;
            }

            Console.WriteLine("...");
            return key;
        }

        private static void Add()
        {
            Console.WriteLine("- what do you want to add?");
            Manipulador.Armazenar(Console.ReadLine());
        }

        private static void Get()
        {
            Console.WriteLine("- what is the item's code you want to get?");
            try {
                Console.WriteLine(Manipulador.Recuperar(int.Parse(Console.ReadLine()) - 1));
            }
            catch (Exception any)
            {
                Console.WriteLine("! there is no such item");
            }
        }
    }
}
