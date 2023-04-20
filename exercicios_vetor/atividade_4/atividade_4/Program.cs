namespace atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Escreva um algoritmo que leia dois vetores de 10 posições e faça a
            //multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor.
            //Mostre o vetor resultante.


            int[] vetor1 = new int[3];
            int[] vetor2 = new int[3];
            int[] vetorResultado = new int[3];

           for (int i = 0; i < vetor1.Length; i++) 
            {
                Console.WriteLine($"Informe o valor da {i+1}ª posição:");
                vetor1[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine($"Informe o valor da {i + 1}ª posição:");
                vetor2[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetorResultado[i] = vetor1[i] * vetor2[i];

                Console.WriteLine($"O Vetor resultante, posição {i+1}: {vetorResultado[i]}");

            }


        }
    }
}