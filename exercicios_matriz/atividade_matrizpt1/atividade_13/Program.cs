namespace atividade_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e 
             * verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
               diagonal secundária.*/

            int[,] matriz = new int[5, 5];
            int diagonalPrincipal = 0;
            int diagonalSegundaria = 0;
            Random random = new Random();
            
            //matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                    
                }
                Console.WriteLine();
            }
            //print matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //Números da primeira diagonal
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                   
                    if (i == j)
                    {

                        diagonalPrincipal += matriz[i, j];
                        Console.WriteLine(diagonalPrincipal);
                        Console.WriteLine();


                    }
                    else
                    {
                        for (i = matriz.GetLength(0) - 1, j = 0; i >= 0; i--, j++)
                        {
                            diagonalSegundaria += matriz[i, j];
                            
                        }
                    }
                }
            }



        }
    }
}