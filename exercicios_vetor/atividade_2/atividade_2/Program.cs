namespace atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Escreva um algoritmo que leia valores para dois vetores de
            //20 elementos e então realize a soma dos elementos da mesma posição,
            //armazenando o resultado em um outro vetor.

            int[] vetor = new int[20];
            int[] vetor2 = new int[20];
            int[] vetor3 = new int[20];
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Informe o valor para a posição {i+1}:");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine($"Informe o valor para a posição {i + 1}:");
                vetor2[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < vetor3.Length; i++) 
            {
                vetor3[i] = vetor[i] + vetor2[i];
            }

            for (i = 0; i < vetor2.Length; i++)
            {

                Console.WriteLine("O resultado da somas dos vetores é:" + vetor3[i]);
            }
            
            

        }
    }
}