using System;
using System.Globalization;

namespace Exe_prop_01
{
    class Programa
    {
        static void Main(String[] args)
        {
            Retangulo rtg = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo :");
            Console.Write("Lagura:");
            rtg.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Altura:");
            rtg.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("============================");

            Console.Write("AREA:");
            Console.WriteLine(rtg.CalcularArea().ToString("F2",CultureInfo.InvariantCulture));
            Console.Write("PERÍMETRO:");
            Console.WriteLine(rtg.CalcularPerimetro().ToString("F2",CultureInfo.InvariantCulture));
            Console.Write("DIAGONAL:");
            Console.WriteLine(rtg.CalcularDiagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
    
