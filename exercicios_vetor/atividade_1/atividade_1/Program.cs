namespace atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1.Escreva um algoritmo que leia os valores para um vetor de
            //10 elementos e então mostre na tela a quantidade de números pares e ímpares.

            int[] vetor = new int[10];
            int i, pares=0, impar=0;
            for (i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Informe o valor para a posição {i+1}:");
                vetor[i] = int.Parse( Console.ReadLine() );

            }
            for (i = 0; i < vetor.Length; i++)
            {
                if(vetor[i] % 2 ==0)
                {

                    pares++;
                }
                else
                {
                    impar++;
                }
            }

            Console.WriteLine($"A quantidade de valores pares dentro do vetor é: {pares}");
            Console.WriteLine($"A quantidade de valores impares dentro do vetor é: {impar}");




        }
    }
}