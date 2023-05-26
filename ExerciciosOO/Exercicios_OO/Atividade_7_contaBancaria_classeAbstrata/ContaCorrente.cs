using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_7_contaBancaria_classeAbstrata
{
    internal class ContaCorrente : ContaBancaria
    {
        public ContaCorrente(string titular, double taxaJuros, double saldo)
        {
            Titular = titular;
            TxadeJuros = taxaJuros;
            Saldo = saldo;
        }
    }
}
