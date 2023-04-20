using System;

namespace atividade_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //) Ler uma matriz com 4x4 de inteiros e mostrar os
            //números na ordem direta e inversa a que foram lidos.
            int i;
            int[,] a = new int[,] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 }, { 5, 2, 3, 4 }, { 1, 2, 6, 4 } } ;
            Random random = new Random();

            //for (i = 0; i < a.GetLength(0); i++)
            //{
            //    for (int j = 0; j < a.GetLength(1); j++)
            //    {
            //        //Console.WriteLine($"Digite o elemento {i} e o {j} da Matriz");
            //        //a[i,j] = int.Parse(Console.ReadLine());

            //    }
            //}
            //print matriz
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (int j = a.GetLength(1) - 1; j >= 0; j--)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}