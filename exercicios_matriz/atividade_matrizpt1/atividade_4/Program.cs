using System.Reflection;

namespace atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4) Popule uma matriz 5x5 e informe:
            -Quantos números são pares
            - Quantos números são impares
            - Quantos números são positivos
            - Quantos números são negativos
            - Quantos zeros existem!*/

            Console.WriteLine("Matriz 5x5");
            int i;
            int[,] a = new int[5, 5];
            Random random = new Random();

            //preenche a matriz com num aleatorios, para facilitar
            for (i = 0; i< a.GetLength(0); i++)
            {
                for(int j = 0; j< a.GetLength(1); j++)
                {
                    //Console.WriteLine($"Digite o elemento {i} e o {j} da Matriz");
                    //a[i,j] = int.Parse(Console.ReadLine());
                    a[i, j] = random.Next(1, 101);
                }
            }
            //print matriz
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine();

            }

            int par = 0, impar = 0, zero = 0, posit = 0, negat = 0; 
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        impar++;
                    }
                    if ((a[i,j] < 0))
                    {
                        negat++;
                    }
                    else if ((a[i, j] > 0))
                    {
                        posit++;
                    }
                    if (a[i,j] == 0)
                    {
                        zero++;
                    }

                }
            }

            Console.WriteLine("Quantidade de números pares:" + par);
            Console.WriteLine("Quantidade de números impares:" + impar);
            Console.WriteLine("Quantidade de números positivos:" + posit);
            Console.WriteLine("Quantidade de números negativos:" + negat);
            Console.WriteLine("Quantidade de números zeros:" + zero);

        }
    }
}