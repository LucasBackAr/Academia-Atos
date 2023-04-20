namespace atividade_matrizpt1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha.
            //A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna,
            //armazene o dobro dos elementos da 1ª coluna.


            int[,] matrizI = new int[5, 3];
            for (int i = 0; i < 5; i++) // para linhas
            {

                Console.WriteLine("Digite um valor para a primeira coluna");
                matrizI[i, 0] = int.Parse(Console.ReadLine());
                matrizI[i, 1] = matrizI[i, 0] + 10;
                matrizI[i, 2] = matrizI[i, 0] * 2;

            }

            for (int i = 0; i < 5; i++) //saida
            {
                for (int j = 0; j < 3; j++) 
                { 
                    Console.Write(matrizI[i, j] + "\t"); 
                }

                Console.WriteLine();

            }
        }
    }
}