using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exe_fixação
{
    class Conta
    {
        public string _nome;
        private double _numeroConta;
        private double _valorDeposito;
        public double _taxaSaque = 5.00;
        private double _saldo;
        private double _valorSaque;

        //Construtor

            public Conta()
        {

        }

        public Conta(string nome, double numeroConta, double valorDeposito )
        {
            _nome = nome;
            _numeroConta = numeroConta;
            _valorDeposito = valorDeposito;
            Depositar(valorDeposito);
        }

        public string Nome
        {
            get { return _nome; }
            set { if (value != null && value.Length > 1){
                    _nome = value;
                }
            }
        } 

        public double NumeroConta
        {
            get { return _numeroConta; }
            set { _numeroConta = value; }
        }

        public void Depositar(double valorDeposito)
        {
            _saldo += valorDeposito;
        }

        public double Saldo
        {
            get { return _saldo; }
        }

        public void Sacar (double valorSaque)
        {
            _saldo = _saldo - _taxaSaque - valorSaque  ;
        }

        public override string ToString()
        {
            return "Conta: "
                +
                _numeroConta
                + " , "
                + "Títular: "
                + _nome
                + ", "
                + "Saldo:R$ "
                + _saldo.ToString("F2", CultureInfo.InvariantCulture);       
        }
    }
}
