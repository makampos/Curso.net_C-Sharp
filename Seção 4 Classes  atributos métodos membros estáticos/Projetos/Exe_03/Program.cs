using System;
using System.Globalization;

namespace Exe_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do Produto");
            Console.Write("Nome: ");
             p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
             p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(p);
            Console.WriteLine("==============");


            Console.Write("Adicionar mais produtos: ");
            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AdicionarProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine("==============");

            Console.WriteLine("Digite a quantidade de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados Atualizados: " + p);
        }
    }
}
