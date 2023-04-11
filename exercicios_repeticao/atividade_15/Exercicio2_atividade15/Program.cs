using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Exercicio2_atividade15
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados
         //da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
         //e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
         //Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.
            
            Console.WriteLine("Loja de Tintas");
            
            // Definindo as variaveis
            double precoTinta, metroQuadrados;
            int lataTinta;
            precoTinta = 80.00;
            lataTinta = 18;
             //define o tamanho a ser pintada
            Console.WriteLine("Qual o tamanho da área a ser pintada (em metros quadrados)?");
            metroQuadrados = double.Parse(Console.ReadLine());

            //calcula a quantidade de litros
            double litrosNecessario = metroQuadrados / 3;

            int latasNecessarias = 0;
            switch (litrosNecessario % lataTinta) 
            { 
                case 0:
                    latasNecessarias = (int) (litrosNecessario / lataTinta); 
                    break;

                    // o default vai retornar aqui, caso exista a possibildade te exister parte de uma lata, como não se pode
                    // comprar meia lata, ele arredondara para cima
                
                default:
                    latasNecessarias = (int)(litrosNecessario / lataTinta) + 1;
                    break;
            }

            //calculando o preço total

            double precototal = latasNecessarias * precoTinta;

            Console.WriteLine("Você precisará de:" + latasNecessarias + " latas de tinta, ao preço total de R$" + precototal.ToString("F2"));



            /// usando o math.CELLING - que é uma operação matematica para arrendondar para cima.
        }
    }
}