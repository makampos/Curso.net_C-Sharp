using System;
using System.Globalization;

namespace Exe_fixação
{
    class Program
    {
        static void Main (String[] args)
        {
            // exe.
                Conta c = new Conta();

                Console.WriteLine("Entre com o número da conta:");
                c.NumeroConta = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Entre com o títular da conta:");
                c._nome = Console.ReadLine();

                Console.WriteLine("Havera depósito inicial?");
                string resposta = Console.ReadLine();
            if (resposta == "sim")
            {
                Console.Write("Qual o valor do depósito inicial? ");
                c.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));               
            }
                Console.WriteLine("Dados da conta: " + c);

                Console.WriteLine("Entre com um valor para depósito :");
                c.Depositar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine("Dados da conta atualizados: " + c);
                Console.WriteLine("Gostaria de realizar uma operação de saque ?");
                 resposta = Console.ReadLine();
            if(resposta == "sim")
            {
                Console.WriteLine("Digite o valor para saque: ");
                c.Sacar(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));               
            }
                Console.WriteLine("Dados da conta atualizados: " + c);
        }
    }
}