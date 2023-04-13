using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Drawing;
using System.ComponentModel.Design;

namespace atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1. Faça um programa em VS que solicite um número inteiro positivo ao usuário,
            //validando a entrada de dados 
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número
            //fornecido pelo usuário.

            //Exemplo:
            //Digite um número inteiro positivo: -8
            //Valor incorreto!
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.

            int i, n;

            for (; ; )
            {
                Console.WriteLine("digite um número:");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {

                    break;
                }

                else  { Console.WriteLine("O número digitado é" + n);
                    break;
                }

                Console.WriteLine("Entrada inválidade, digite novamente um número inteiro positivo");
                                                

            }
            Console.WriteLine($"Números pares entre 1 e {n}");  
            
            for (i = 2; i <= n; i+=2)

            {
                Console.WriteLine("Os números pares entre são:" + i);
            }
        
                

            


        }
    }
}