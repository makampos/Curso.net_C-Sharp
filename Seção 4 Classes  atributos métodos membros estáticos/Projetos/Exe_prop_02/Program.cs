using System;
using System.Globalization;

namespace Exe_prop_02
{
    class Program
    {

        static void Main(String[] args)
        {
            Funcionario func = new Funcionario();

            Console.WriteLine("Entre com os dados o Funcíoanario");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("=====================");

            Console.WriteLine("Funcionaio: "+ func.Nome +", R$"+ func.SalarioLiquido().ToString("F2"));

            Console.WriteLine("=====================");

            Console.Write("Digite a porcetagem(%) para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            func.AumentarSalario(porcentagem);

            Console.WriteLine("=====================");
            Console.WriteLine("Dados atualizados: "+ func);


        }
        
    }
}