using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_03
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque(double preco, int quantidade)
        {
            return quantidade * preco;
        }

        public void ValorTotalEmEstoque()
        {
            Preco = Quantidade * Preco;
        }

        public void RemoverProdtos(int quantity)
        {
           
        }
    }
}
