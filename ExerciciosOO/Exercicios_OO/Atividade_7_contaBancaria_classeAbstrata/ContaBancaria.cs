using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7_contaBancaria_classeAbstrata
{
    public abstract class ContaBancaria
    {

        private string _titular;
        private double _saldo;
        private double _taxadeJuros;

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }
        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        public double TxadeJuros
        {
            get { return _taxadeJuros; }
            set { _taxadeJuros = value;  }
        }


    }
}
