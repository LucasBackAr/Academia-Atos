namespace atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. 
            Após isso determine o maior número da matriz.
            Random random = new Random();
            int randomNumber = random.Next(0, 100);*/

            int[,] a = new int[4, 4];
            Random random = new Random(); //randomiza para facilitar na leitura
            int valorMax = int.MinValue;

            //preenche a matrizA        
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    //Console.WriteLine("Digite os elementos da matriz");
                    //a[i,j] = int.Parse(Console.ReadLine());
                    a[i, j] = random.Next(0,9);

                    if (a[i, j] > valorMax)
                    {
                        valorMax = a[i, j];
                    }
                }
            }
            //imprime a matriz

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("O maior valor na matriz é:" + valorMax);

        }
    }
}