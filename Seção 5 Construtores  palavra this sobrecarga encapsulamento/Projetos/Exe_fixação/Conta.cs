using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exe_fixação
{
    class Conta
    {
        public string _nome;
        private int _numeroConta;
        private double _valorDeposito;
        public double _taxaSaque = 5.00;

        //Construtor
        public Conta(string nome, int numeroConta, double valorDeposito)
        {
            _nome = nome;
            _numeroConta = numeroConta;
            _valorDeposito = valorDeposito;
        }

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1){
                    _nome = value;
                }
            }
        } 
    }
}
