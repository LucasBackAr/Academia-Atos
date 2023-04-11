using System.Net;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System;

namespace Atividade_8
{
    internal class Program
    {
            // Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
            //            do que ou igual às prestações, que devem ser iguais, inteiras e as maiores possíveis.
            //            Por exemplo, se o valor da mercadoria for R$ 270, 00, a entrada e as duas prestações são iguais a R$ 90, 00;
            //            se o valor da mercadoria for R$ 302, 75 a entrada é de R$ 102, 75 e as duas prestações são iguais a R$ 100, 00.
            //            Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
            //            da entrada e das duas prestações, de acordo com as regras acima.
            //            Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o
            //            conseqüente pagamento dos boletos das duas prestações.

            static void Main(string[] args)
            {
                double valorMercadoria, valorEntrada, valorPrestacao;
                int quantidadePrestacoes;

                // Leitura do valor da mercadoria
                Console.Write("Digite o valor da mercadoria: R$ ");
                valorMercadoria = double.Parse(Console.ReadLine());

                // Cálculo da entrada e das prestações
                valorEntrada = Math.Ceiling(valorMercadoria * 0.5);
                quantidadePrestacoes = 2;
                valorPrestacao = Math.Ceiling((valorMercadoria - valorEntrada) / quantidadePrestacoes);

                // Exibição dos resultados
                Console.WriteLine($"Valor da entrada: R$ {valorEntrada:F2}");
                Console.WriteLine($"Valor das {quantidadePrestacoes} prestações: R$ {valorPrestacao:F2}");
            }
        
    }
}