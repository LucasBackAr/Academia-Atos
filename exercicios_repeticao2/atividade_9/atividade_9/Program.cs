using System.Security.Cryptography;
using System;

namespace atividade_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
            // o zoológico num determinado dia, imprimindo:
            //Quantas pessoas tem entre 1 e 3 filhos.
            //Quantas pessoas tem entre 4 e 7 filhos.
            //Quantas pessoas tem mais de 8 filhos.
            //Quantas pessoas não tem filhos.

            int umA3Filho = 0, quatroa7filho = 0, maisFilho = 0, semfilho = 0, i;
            
            for (i = 1; i <=30; i++)
            {
                int quantiFilhos = 0;
                Console.WriteLine($"Digite o número de filhos da pessoa {i}:");
                quantiFilhos = int.Parse( Console.ReadLine() );

                if ((quantiFilhos >= 1) && (quantiFilhos <=3) ) 
                {
                    umA3Filho++;
                }
                else if ((quantiFilhos >= 4) && (quantiFilhos <=7))
                {
                    quatroa7filho++;
                }
                else if (quantiFilhos >= 8)
                {
                    maisFilho++;
                }
                else
                {
                    semfilho++; 
                }

                
            }

            Console.WriteLine($"Número de pessoas com 1 a 3 filhos: {umA3Filho}");

            Console.WriteLine($"Número de pessoas com 4 a 7 filhos: {quatroa7filho}");

            Console.WriteLine($"Número de pessoas com mais de 8: {maisFilho}");

            Console.WriteLine($"Número de pessoas com sem filhos: {semfilho}");
        }
    }
}