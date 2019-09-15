using System;
using System.Globalization;

namespace Exe_prop_03
{
    class Program
    {
        static void Main(String [] args)
        {
            // Executa o programa!

            Aluno aln = new Aluno();

            Console.WriteLine("Entre os dados do aluno:");

            Console.Write("Nome do aluno: ");
            aln.Nome = Console.ReadLine();

            Console.WriteLine("Entre com as três notas do aluno: ");
            aln.NotaA = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aln.NotaB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aln.NotaC = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("NOTA FINAL: " + aln.CalcularNotaFinal().ToString(), ("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" PONTOS");
            if (aln.Aprovado())
            {
                Console.Write("=== APROVADO ===\n");                                        
            }
            else
            {
                Console.Write("=== REPROVADO ===\n");
                Console.Write("FALTARAM: " + aln.Restante().ToString(), ("F2", CultureInfo.InvariantCulture));
                Console.WriteLine(" PONTOS");
            }
            
        }
    }
}