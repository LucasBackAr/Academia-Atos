using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace atividade9
{
    internal class ContaBancaria
    {
        private string _numConta;
        private string _titular;
        private double _saldo;
        private double _limite;

        public string NumConta 
        { 
            get { return _numConta; } 
            set { _numConta = value; } 
        }
        public string Titular
        {
            get { return _titular; }
            set {
                if (!string.IsNullOrWhiteSpace(value)) 
                { _titular = value.ToUpper(); 
                }
            }
        }

        public double Saldo 
        { 
            get { return _saldo; } 
        }
        public double Limite {
            get { return _limite; }
            set 
            {
                if (value <+ 0)
                {
                    _limite = value;
                }
            } 
        }

        public void Depositar(double vaiDeposito)
        {
            if (vaiDeposito > 0)
            {
                _saldo += vaiDeposito;
                
            }
            else
            {
                Console.WriteLine("Deposito não efetuado!");
            }
        }
        public bool Sacar(double valSaque)
        {
            if(valSaque > (_saldo + _limite))
            {
                _saldo -= valSaque;
                return true;
            }
            else
            {
                return false;
            }
        }
    }   
}
