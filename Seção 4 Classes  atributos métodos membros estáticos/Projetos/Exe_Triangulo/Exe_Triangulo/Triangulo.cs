using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_Triangulo
{
    class Triangulo
    {
        public double A, B, C;

        public double Area()
        {
            double p = (A + B + C) / 2;
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }
    }
}
