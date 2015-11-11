using System;

namespace Banco
{
    class UI
    {
        private bool Permaneca { get; set; }
        private ContaBancaria Conta;

        public UI()
        {
            this.Permaneca = true;
            this.Conta = new ContaBancaria(100);
        }

        public void Setup()
        {
            int numeroTentativas = 3;
            bool chave = false;

            while (numeroTentativas > 0 && !chave)
            {
                Console.WriteLine("Digite o usuário");
                string usuario = Console.ReadLine();
                Console.WriteLine("Digite a senha");
                string senha = Console.ReadLine();

                if (usuario.Equals("AlunoS2B") && senha.Equals("123456"))
                    chave = true;
                else
                {
                    Console.WriteLine("Senha inválida");
                    numeroTentativas--;
                }
                    
            }

            if (numeroTentativas == 0)
            {
                this.Permaneca = false;
                Console.WriteLine("Sua conta foi bloqueada. Contate seu gerente.");
                Console.ReadKey();
            }
        }

        public bool Loop()
        {
            if (!this.Permaneca) return this.Permaneca;

            Console.WriteLine("# Aplicação Bancária");
            Console.WriteLine("1. Saque");
            Console.WriteLine("2. Depósito");
            Console.WriteLine("3. Saldo");
            Console.WriteLine("4. Sair");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Valor para saque:");
                    Conta.Sacar(double.Parse(Console.ReadLine()));
                    break;

                case 2:
                    Console.WriteLine("Valor para depósito:");
                    Conta.Depositar(double.Parse(Console.ReadLine()));
                    break;

                case 3:
                    Console.WriteLine("Seu saldo é de " + Conta.Saldo + "$");
                    break;

                case 4:
                    Console.WriteLine("Obrigado por usar a aplicação :)");
                    Console.ReadKey();
                    this.Permaneca = false;
                    break;
            }

            Console.WriteLine("---");
            return this.Permaneca;
        }
    }
}
