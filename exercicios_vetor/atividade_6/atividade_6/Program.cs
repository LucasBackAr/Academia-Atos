namespace atividade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
            //a.lê: 		| 7 | 40 | 3 | 9 | 21 | 0 | 63 | 31 | 7 | 22 |
            //b.escreve: 	| 22 | 7 | 31 | 63 | 0 | 21 | 9 | 3 | 40 | 7 |

            int[] vetor = new int[10];
            int[] vetor2 = new int[10];
            
            //recebe o vetor
            for (int i = 0; i < vetor.Length; i++) 
            {
                Console.WriteLine($"Digite o valor de {i +1}º número:");
                vetor[i] = int.Parse(Console.ReadLine());                            


            }
            // inverte o vetor
            for (int i = 0; i < vetor2.Length; i++)
            {

                vetor2[i] = vetor[vetor.Length - 1 - i];

            }
            //imprime o resultado
            for (int i = 0;i < vetor.Length; i++)
            {
                Console.WriteLine($"Resultado do {i +1}° valor: {vetor2[i]}");
            }


        }
    }
}