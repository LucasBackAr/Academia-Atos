namespace atividade_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12.Faça um algoritmo que leia um vetor V de 10 posições e, após,
            //verifica se um número N, fornecido pelo usuário, existe no vetor.
            //Se existir, indicar a(s) posição(ões), senão escrever a mensagem
            //"O número fornecido não existe no vetor!".

            int[] v = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º valor: ");
                v[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Digite um número a ser buscado: ");
            int n = int.Parse(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < 10; i++)
            {
                if (v[i] == n)
                {
                    Console.WriteLine($"O número {n} foi encontrado na posição {i}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("O número fornecido não existe no vetor!");
            }
        }
    }
}