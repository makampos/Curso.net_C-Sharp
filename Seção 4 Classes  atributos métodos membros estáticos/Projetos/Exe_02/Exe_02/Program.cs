﻿using System;
using System.Globalization;

namespace Exe_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro Funcionario");
            Console.Write("Nome :");
            f1.Nome = (Console.ReadLine());
            Console.Write("Sálário: ");
            f1.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo Cliente");
            Console.Write("Nome: ");
            f2.Nome = (Console.ReadLine());
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double media = (f1.Salario + f2.Salario) / 2;

            Console.WriteLine("A média de salário é: " + media.ToString("F2",CultureInfo.InvariantCulture));

        } 
    
    }
}
