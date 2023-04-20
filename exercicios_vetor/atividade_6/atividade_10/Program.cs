namespace atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.Escreva um algoritmo que leia um vetor inteiro de 20 posições.
            //Crie um segundo vetor, substituindo os valores nulos por 2.
            //Mostre os vetores lidos e o vetor resultado.

            int[] vetor = new int[3];
            int valorSubs = 2;
            int i;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite os valor do vetor");
                vetor[i] = int.Parse(Console.ReadLine());

                if (vetor[i] == 0)
                {
                    vetor[i] = valorSubs;
                }
                
                
            }

            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine(vetor[i]);
            }


        }
    }
}