using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exe_prop_03
{
    class Aluno
    {
        public string Nome;
        public double NotaA, NotaB, NotaC, NotaFinal, Media;


        
        public double CalcularNotaFinal()
        {
            NotaFinal = NotaA + NotaB + NotaC;
            return NotaFinal;
        }

        public bool Aprovado()
        {
            if (CalcularNotaFinal() >= 60.0)
            {
                return true;
                    
            } else
            return false;
        }

        public double Restante()
        {
            if(Aprovado())
            {
                return 0.0;
            }
            else
            return 60.0 - CalcularNotaFinal();
        }
       
    }
}
