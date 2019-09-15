using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_membros_estáticos
{
    class ConversorMoeda
    {
        public static double Iof = 0.6;    
        public static double ValorPagoConvertido(double ValorCompra, double Cotacao)
        {
            double ValorIof = (ValorCompra * Iof) / 10 * Cotacao;
            return  (ValorCompra * Cotacao + ValorIof)  ;
        }      
    }
}
