using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7_contaBancaria_classeAbstrata
{
    internal class ContaPoupanca : ContaBancaria
    {
        
        public ContaPoupanca(string titular, double taxaJuros, double saldoPoupanca)
        {
            Titular = titular;
            TxadeJuros = taxaJuros;
            Saldo = saldoPoupanca;
        }
    }
}
