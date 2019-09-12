using System;

namespace Exe_proposto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 2002;

            Console.Write("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != valor)
            {
                Console.WriteLine("Senha inválida\n");
                Console.Write("Digite uma senha: ");
                 senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido\n");
           
        }
    }
}
