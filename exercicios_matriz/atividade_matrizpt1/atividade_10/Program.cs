using System.Globalization;
using System.Net;

namespace atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) Leia duas matrizes A e B de 4x4 elementos, calcule a
            //média dos mesmos, em seguida, diga quantos dos elementos lidos
            //estão abaixo, acima e na média.

            int i;
            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            Random random = new Random();

            //preenche a matriz com num aleatorios, para facilitar
            for (i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {

                    matrizA[i, j] = random.Next(1, 101);
                }
            }

            //PRINT MATRIZ

            Console.WriteLine("Matriz A");
            Console.WriteLine();
            for (i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write(matrizA[i, j] + " ");
                }

                Console.WriteLine();

            }


            //MATRIZ B
            
            for (i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    //Console.WriteLine($"Digite o elemento {i} e o {j} da Matriz");
                    //a[i,j] = int.Parse(Console.ReadLine());
                    matrizB[i, j] = random.Next(1, 101);
                }
            }
            //print matriz
            Console.WriteLine();
            Console.WriteLine("Matriz B");
            for (i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write(matrizB[i, j] + " ");
                }

                Console.WriteLine();

            }
            double soma = 0;
            int[,] somaB = new int[4, 4];
            int quantidade=0;
            for (i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    soma += matrizB[i, j];
                    soma += matrizA[i, j];
                    quantidade++;

                }
            }
            Console.WriteLine("A soma das duas matrizes é:" + soma);
            Console.WriteLine("A média das matrizes é:" + (double)soma/quantidade);

        }
    }
}