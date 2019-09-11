using System;

namespace Exe_EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite três palavras: ");
            string s = Console.ReadLine(); // lê o conteudo da linha e add dentro da variavel correspondente.
            string[] vetor = s.Split(' '); // variavel correspondente chama o método Split que separada as variaveis entre os espaços em branco.
            string palavra1 = vetor[0]; // add o conteudo nas posições especificas dentro do vetor.
            string palavra2 = vetor[1];
            string palavra3 = vetor[2];

            Console.WriteLine("Você inseriu as seguintes palavra: " + s);
        }
    }
}

