using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade05
{
    internal class Conta
    { //Número, Saldo  e Limite.
        private string numeroConta;
        private double saldo;
        private double limiteConta;
        public Conta(string numeroConta, double saldo, double limite) 
        {
            this.numeroConta = numeroConta;
            Saldo = saldo;
            Limite = limite;
        }
        public int NumeroConta { get; private set; }
        public double Saldo 
        {
            get { return saldo; }
            set { if (value <= 0)
                {

                }
                saldo = value; }
        }

        public double Limite { 
            get { return limiteConta; }
            set { if (value <= 0)
                {

                } 
                limiteConta = value;
            }
        }
    }
}
