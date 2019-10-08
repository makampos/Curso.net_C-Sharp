using System;
using System.Collections.Generic;
using System.Text;

namespace Exe_fixação2
{
    class Funcionario
    {
        public string Nome { get; set; }
        private double Salario { get; set; }
        public int  Id { get; set; }

        public Funcionario(string _nome, double _salario, int _id)
        {
            Nome = _nome;
            Salario = _salario;
            Id = _id;
        }

        public void AumentaSalario(double salario)
        {
            salario = (salario * 10) / 100;
        }
    }
}
