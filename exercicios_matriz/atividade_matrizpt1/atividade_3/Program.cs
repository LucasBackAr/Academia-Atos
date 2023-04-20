using System.Globalization;

namespace atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!
            /*
             * ****
             * ****
             * ****
             * ****
            */
            int[,] a = new int[4, 4];
            int i = 0;

            for (i = 0; i < a.GetLength(0); i++)
            {
                
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine($"Digite o elemento {i} e {j} da matriz:");
                    a[i,j] = int.Parse(Console.ReadLine());
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

            //print da diagonal principal 

            for (i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if(i== j)
                    {
                        Console.Write("elementos da diagonal da matriz:");
                        Console.Write(a[i,j] + " ");
                    }
                    
                    
                    

                }

                Console.WriteLine();
            }



        }
    }
}