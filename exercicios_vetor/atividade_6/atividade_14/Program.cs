using System.Runtime.Intrinsics.Arm;

namespace atividade_14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //14.Escreva um algoritmo que leia um código numérico inteiro e
            //um vetor de 50 posições de números.Se o código for zero, termine o algoritmo.
            //Se o código for 1, mostre o vetor na ordem em que foi lido.Se o código for 2,
            //mostre o vetor na ordem inversa, do último elemento até o primeiro. 

            int max = 50;
            int[] vetor = new int[max];
            int codigo = -1;
            int qtd = 0;

            while (codigo != 0)            
            {
                Console.WriteLine("Digite o código (0 para sair, 1 para mostrar na ordem e 2 para invertida");
                codigo = int.Parse( Console.ReadLine() );

                switch (codigo) 
                {
                    case 0: Console.WriteLine("Encerrando o programa...");
                        break;
                        
                    case 1: Console.WriteLine("Mostrando os valores do vetor");
                        for (int i = 0; i < qtd; i++) 
                        {
                            Console.WriteLine(vetor[i] + "");
                        }
                        Console.WriteLine();
                        break;
                    
                    case 2:
                        Console.WriteLine("Mostrando os valores do vetor");
                        for (int i = qtd - 1; i >= 0; i--)
                        {
                            Console.WriteLine(vetor[i] + "");
                        }
                        Console.WriteLine();
                        break;


                    default:
                        Console.WriteLine("Código inválido");
                        break;
                }

                if (codigo != 0 && qtd < max) 
                {
                    Console.WriteLine("Digite um número:");
                    vetor[qtd] = int.Parse(Console.ReadLine());
                    qtd++;
                }

                

            }


           
        }
    }
}