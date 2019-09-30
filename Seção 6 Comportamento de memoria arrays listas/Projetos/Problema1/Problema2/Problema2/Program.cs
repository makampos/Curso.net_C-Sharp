using System;
using System.Globalization;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vetores de tipo referência

            Console.WriteLine("Qual a quantidade de produtos ?");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product [n];

            for ( int i = 0; i < n; i++)
            {
                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double price = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;

            for(int i = 0;i <n; i++)
            {
                sum += vect[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("O preço médio é igual a: "+ avg.ToString("F2", CultureInfo.InvariantCulture));
           
        }
    }
}
