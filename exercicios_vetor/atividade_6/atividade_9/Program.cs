namespace atividade_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9.Escreva um algoritmo que leia os valores para um vetor de 10 elementos,
            //e em seguida ordene em ordem crescente os valores desse vetor,
            //utilizando um vetor auxiliar.

            int[] vetor = new int[10];
           
            
            //preenchimento do usuario
            for (int i = 0; i < vetor.Length; i++) 
            {
                Console.WriteLine($"Digite o {i+1}º número do vetor:");
                vetor[i] = int.Parse( Console.ReadLine() );

                
            }

            //ordenamento do vetor

            for (int i = 0; i < vetor.Length - 1; i++)
            {
                for (int j = 0; j < vetor.Length - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        int temp = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Valores da posição {i}: {vetor[i]}");
            }

        }
    }
}