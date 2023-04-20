using System.Net;

namespace atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3.Escreva um algoritmo que leia os valores para um vetor de
            //20 elementos e então mostre na tela o índice da posição dos valores
            //correspondentes a números primos.

            int[] vetor = new int[3];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write($"Digite o valor do {i + 1}º elemento: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Índices dos valores primos: ");

            for (int i = 0; i < vetor.Length; i++)
            {
                bool primo = true;
                for (int j = 2; j < vetor[i]; j++)
                {
                    if (vetor[i] % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }
                if (primo && vetor[i] > 1)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}