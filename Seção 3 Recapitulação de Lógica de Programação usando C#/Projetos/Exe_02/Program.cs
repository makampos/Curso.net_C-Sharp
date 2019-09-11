using System;
using System.Globalization;

namespace Exe_02
{
    class Program
    {
        static void Main(String [] args)
        {
            Console.WriteLine("Insira as informações conforme o fluxo");
            Console.WriteLine("========================================");

            Console.Write("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            

            Console.Write("Quantos quartos tem na sua casa: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.Write("Entre com o preço de um produto: ");
            double valor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Entre seu último nome, idade e altura(Na mesma linha)");
            string[] vetor = Console.ReadLine().Split(' ');
            string sobrenome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2]);

            Console.WriteLine();


            Console.WriteLine("Sua ficha");
            Console.WriteLine(nome);
            Console.WriteLine(quantidade);
            Console.WriteLine(valor.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("=================");
            Array.ForEach(vetor, Console.WriteLine); // Imprimi conteudo do vetor

        }
    }
}