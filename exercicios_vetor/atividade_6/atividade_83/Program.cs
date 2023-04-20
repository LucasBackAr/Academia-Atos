using System.Runtime.Intrinsics.X86;

namespace atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8.Fazer um algoritmo que leia trinta números reais
            //armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor.
            //Exemplo:
            //a.lê:          	| 5.1 | 0 | -3.6 | 4.1 | -2.5 | -1.3 | -4 | 1.39 | -128 | -6.9 | 8.2 | 9 | 154 | -88 | 6.4 | 7.1 | ...|
            //b.escreve: 	| 3 | 5 | 6 | 7 | 9 | 10 | 14 |. . .

            double[] vetor = new double[10];
            int  i;
            for (i = 0; i < vetor.Length; i++) 
            {
                Console.WriteLine($"Digite o {i}° número:");
                vetor[i] = double.Parse(Console.ReadLine());
                if (vetor[i] < 0)
                {
                    vetor[i]++;
                }

                
            }
            for (i = 0; i < vetor.Length; i++) 
            { 
                Console.WriteLine($"O número {vetor[i]} está na posição {i}"); 
            }
                    
        }
    }
}