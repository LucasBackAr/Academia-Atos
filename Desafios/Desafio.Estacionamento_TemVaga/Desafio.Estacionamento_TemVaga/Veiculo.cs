using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Estacionamento_TemVaga
{
    /// <summary>
    /// - ESCREVE ARQUIVO . dat
    /// CONTROLA ENTRADA E SAIDAS DE  VEICULOS
    /// - placa do carro, estadia na garagem, data e hora de entrada e de saida, e tempo
    /// de permanencia no estacionamento
    /// RETURN VALOR cobrado
    /// </summary>
    public class Veiculo : IVeiculo
    {

        private string nomeArquivo = @"D:\Academia Atos\exercicios\Desafios\Desafio.Estacionamento_TemVaga\dadosVeiculo.dat";
        private string nomeArquivoSaida = @"D:\Academia Atos\exercicios\Desafios\Desafio.Estacionamento_TemVaga\dadosVeiculoSaida.dat";
        
       
        public void EntraVeiculo (string placa, string modelo, string cor)
        {
            string conteudo = $"{DateTime.Now} - {placa} - {modelo} - {cor}";

            if (placa== "")
            {
                MessageBox.Show("Erro, placa não digitada");
            }
            
            SalvaRegistro(nomeArquivo, conteudo);
            
        }
        public void SaidaVeiculo(string placa)
        {
           string conteudoSaida = $"{DateTime.Now} - {placa}";
           SalvaRegistro(nomeArquivoSaida, conteudoSaida);                    
        }
        
        private void SalvaRegistro(string data, string conteudo)
        {
            using (StreamWriter escreve = new StreamWriter(data, true))
            {
                escreve.WriteLine(conteudo);
            }
        }

    }
}
