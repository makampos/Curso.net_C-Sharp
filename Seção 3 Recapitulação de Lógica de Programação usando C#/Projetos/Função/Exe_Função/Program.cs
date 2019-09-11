using System;

namespace Função
{
    class Program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Digite três valores: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior: " + resultado);
        }

        static int Maior(int a, int b, int c) // Função
        {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }
    }

}
