using System;
using System.Globalization;

namespace Exe_membros_estáticos
{
    class Program
    {    
            static void Main(String [] args)
        {          
            Console.Write("Qual é a cotação do dólar? ");
            double Cotacao = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double ValorCompra = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais: ");

            double ValorPagarReal = ConversorMoeda.ValorPagoConvertido(ValorCompra, Cotacao);

            Console.WriteLine(ValorPagarReal.ToString("F2", CultureInfo.InvariantCulture));
        }
        
    }
}