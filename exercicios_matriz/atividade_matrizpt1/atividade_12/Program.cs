using System.Runtime.Intrinsics.X86;

namespace atividade_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12) Escreva um programa que leia os valores de uma matriz 4x3,
            // e em seguida mostre na tela apenas os valores cuja soma dos índices(i + j) seja um número par.

           
            
            int[,] a = new int[4,3];
            Random random = new Random();
            
            
            
            //preenche a matriz com num aleatorios, para facilitar
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    //Console.WriteLine($"Digite o elemento {i} e o {j} da Matriz");
                    //a[i,j] = int.Parse(Console.ReadLine());
                    a[i, j] = random.Next(1, 101);
                }
            }

            //print matriz com resultado
            Console.WriteLine("Valores cuja soma dos indices que resultam números pares");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    int somaIndice = i + j;
                    if (somaIndice % 2 == 0)
                    { Console.Write(a[i,j]); }
                }               

                Console.WriteLine();

            }
        }
    }
}