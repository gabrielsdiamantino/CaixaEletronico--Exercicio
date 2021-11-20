using System;
using System.Globalization;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            ContaBancaria saldo;
           

            Console.WriteLine("========= Banco Diamantino =========");
            Console.WriteLine("-------- Seja bem vindo(a) ---------");
            Console.Write("Digite o número da conta:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("====================================");

            Console.Write("Digite o nome do Titular:");
            string titular = Console.ReadLine();

            Console.WriteLine("====================================");

            Console.WriteLine("Deseja fazer um deposito inicial?");
            Console.WriteLine("S- Sim");
            Console.WriteLine("N - NÃO");
            
            char resposta = char.Parse(Console.ReadLine());

            
            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o valor que deseja depositar:");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
                Console.WriteLine("Dados da conta");
                Console.Write($"Titular: {titular}.");
                Console.Write($"Nº da Conta: {conta}");
                Console.Write($"Saldo: R${depositoInicial}");
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta");
            Console.Write($"Titular: {titular}.");
            Console.Write($"Nº da Conta: {conta}");

            Console.WriteLine("====================================");
            Console.Write("Digite um Valor para deposito:");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.Write("Dados Atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine("====================================");
            Console.Write("Digite um Valor para saque:");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.Write("Dados Atualizados:");
            Console.WriteLine(conta);
            Console.Write("Lem-se a taxa de saque é de R$5.00.");

        }
    }
}
