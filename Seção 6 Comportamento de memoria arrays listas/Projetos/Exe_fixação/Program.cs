using System;

namespace Exe_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados ?");
            int n = int.Parse(Console.ReadLine());

            Cliente[] vect = new Cliente[10];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Entre com o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Entre o email:");
                string email = Console.ReadLine();
                Console.Write("Qual o quarto:");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Cliente(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }

        }
    }
}
