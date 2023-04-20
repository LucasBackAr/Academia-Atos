namespace atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //11.Escreva um programa que leia valores em um vetor de 5 posições.
            //Escrever os elementos do vetor e após escrever os elementos na ordem inversa.


            int tamanho=5;
            int[] vetor = new int[tamanho];
            
            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o valor do elemento {i}: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0, j = tamanho - 1; i < j; i++, j--)
            {
                int temp = vetor[i];
                vetor[i] = vetor[j];
                vetor[j] = temp;
            }

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(vetor[i]);
            }


        }
    }
}