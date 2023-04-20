namespace atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11) Leia uma matriz A de tipo double de dimenção 3x3,
            //crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

           
            //Random random = new Random(); //não consegui fazer com random esse exercicio


            double[,] matrizA = new double[3, 3] { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 }, { 7.0, 8.0, 9.0 } };
            double[,] matrizResultado = new double[3, 3];

            double somaIndices = 0.0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    somaIndices = i + j + 2; // soma dos índices - + 2 pq começa em 0
                    matrizResultado[i, j] = matrizA[i, j] / somaIndices;
                }
            }

            // printa a matriz resultado
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrizResultado[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}