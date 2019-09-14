using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_prop_01
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            double area = Largura * Altura;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2*(Largura + Altura);
            return perimetro;
        }

        public double CalcularDiagonal()
        {
            double diagonal = (Largura * Largura + Altura * Altura);
            diagonal = Math.Sqrt(diagonal);
            return diagonal;
        }
    }
}
