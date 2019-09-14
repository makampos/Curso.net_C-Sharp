using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exe_prop_02
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        
        public double SalarioLiquido()
        {
            double Salario = SalarioBruto - Imposto;
            return Salario;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.00);
        }

        public override string ToString()
        {
            return Nome
                + ", R$"
                + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
