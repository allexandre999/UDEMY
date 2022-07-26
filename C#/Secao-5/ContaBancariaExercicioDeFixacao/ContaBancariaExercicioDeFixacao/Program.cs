using System;
using System.Globalization;

namespace ContaBancariaExercicioDeFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta titularConta;
            Console.Write("Entre com o número da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            string op = Console.ReadLine().ToLower();
            double deposito = 0;
            if (op == "s")
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                titularConta = new Conta(numConta, nomeTitular, deposito);
            }
            else {
                titularConta = new Conta(numConta,nomeTitular);
            }
            deposito = 0;
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(titularConta.ToString());

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            deposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            titularConta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(titularConta.ToString());

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            titularConta.Saque(saque);
            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(titularConta.ToString());
            Console.WriteLine();


        }
    }
}
