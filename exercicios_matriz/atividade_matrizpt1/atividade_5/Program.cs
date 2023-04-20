namespace atividade_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Leia duas matrizes 2x3 de números double. 
            //Imprima a soma destas duas matrizes.

            double[,] matrizA = new double[2,3];
            double[,] resultado = new double[2, 3];


            //preenche a matrizA
            Console.WriteLine("Matriz A");
            Random random = new Random();//randomiza para facilitar na leitura
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.WriteLine("Digite os elementos da matriz");
                    //a[i,j] = int.Parse(Console.ReadLine());
                    matrizA[i, j] = random.NextDouble() * 10.0;
                }                
            }
            //imprime a matrizA
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for(int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write(matrizA[i,j] + "\t");
                }
                Console.WriteLine();
            }

            


            Console.WriteLine("Matriz B");
            double[,] matrizB = new double[2, 3];

            //preenche a matrizB
            
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    //Console.WriteLine("Digite os elementos da matriz");
                    //a[i,j] = int.Parse(Console.ReadLine());
                    matrizB[i, j] = random.NextDouble() * 10.0;
                }
            }            
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write(matrizB[i, j] + " ");
                }
                Console.WriteLine();
            }
            

            //soma as matrizes
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for(int j = 0; j < matrizA.GetLength (1); j++)
                {
                    resultado[i,j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine();
            //Imprime o resultado
            for (int i = 0; i < resultado.GetLength(0); i++)
            {
                for (int j = 0; j < resultado.GetLength(1); j++)
                {
                    Console.Write(resultado[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}