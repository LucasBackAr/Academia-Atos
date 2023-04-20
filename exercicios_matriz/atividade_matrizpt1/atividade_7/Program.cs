namespace atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7) Leia duas matrizes A e B com 3x3 elementos.
            // Construir uma matriz C, onde cada elemento de C é a
            // subtração do elemento correspondente de A com B

            int[,] matrizA = new int[2, 3];
            int[,] matrizB = new int[2, 3];
            int[,] matrizC = new int[2, 3];


            //preenche a matrizA
            Console.WriteLine("Matriz A");
            Random random = new Random();//randomiza para facilitar na leitura
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    //Console.WriteLine("Digite os elementos da matriz");
                    //a[i,j] = int.Parse(Console.ReadLine());
                    matrizA[i, j] = random.Next(0, 100);
                }
            }
            //imprime a matrizA
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }




            Console.WriteLine("Matriz B");
            

            //preenche a matrizB

            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    //Console.WriteLine("Digite os elementos da matriz");
                    //a[i,j] = int.Parse(Console.ReadLine());
                    matrizB[i, j] = random.Next(0, 100);
                }
            }
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    Console.Write(matrizB[i, j] + "\t");
                }
                Console.WriteLine();
            }


            //subtração as matrizes

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            Console.WriteLine();
            //Imprime o resultado
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write(matrizC[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}