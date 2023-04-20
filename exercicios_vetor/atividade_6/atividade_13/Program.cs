namespace atividade_13
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;
            int[] vetor = new int[MAX];
            int i = 0;

            while (i < MAX)
            {
                Console.Write($"Digite o {i + 1}º número (-1 para sair): ");
                int valor = int.Parse(Console.ReadLine());

                if (valor == -1)
                {
                    break;
                }

                vetor[i] = valor;
                i++;
            }

            int cont2 = 0, cont4 = 0, cont8 = 0;
            for (int j = 0; j < i; j++)
            {
                if (vetor[j] == 2)
                {
                    cont2++;
                }
                else if (vetor[j] == 4)
                {
                    cont4++;
                }
                else if (vetor[j] == 8)
                {
                    cont8++;
                }
            }

            Console.WriteLine($"O número 2 aparece {cont2} vezes.");
            Console.WriteLine($"O número 4 aparece {cont4} vezes.");
            Console.WriteLine($"O número 8 aparece {cont8} vezes.");
        }
    }

}