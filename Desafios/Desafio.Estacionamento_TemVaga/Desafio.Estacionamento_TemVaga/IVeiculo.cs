using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Estacionamento_TemVaga
{
    public interface IVeiculo
    {
        void EntraVeiculo(string placa, string modelo, string cor);
        void SaidaVeiculo(string placa);
      
    }
}
