﻿namespace atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5.Escreva um algoritmo que leia um vetor de
            //80 elementos inteiros.
            //Encontre e mostre o menor elemento e a sua posição.

            int[] vetor = new int[3];

            

            for (int i = 0; i < vetor.Length; i++) 
            {
                Console.WriteLine($"Digite o {i+1}° valor:");
                vetor[i] = int.Parse(Console.ReadLine());
                
            }


            int menor = vetor[0]; //define o primeiro elemento como valor de ref

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                {
                    menor = vetor[i]; //atualiza o menor valor
                }
            }
            Console.WriteLine($"O menor número é: {menor}");
        }
    }
}