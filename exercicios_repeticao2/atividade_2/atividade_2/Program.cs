using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.


            //Exemplo:
            //Digite um número inteiro positivo: 8
            //Numero digitado: 8
            //Números inteiros pares entre 1 e 8: 2, 4, 6.


            //Deseja informar outro número(s/ n)? S

            //Digite um número inteiro positivo: 12
            //Numero digitado: 20
            //Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


            //Deseja informar outro número(s/ n)? N

            int i, num;
            bool continuar = true;
            do
            {
                for (; ; )
                {
                    Console.WriteLine("digite um número:");
                    if (int.TryParse(Console.ReadLine(), out num) && num > 0)
                    {

                        break;
                    }

                    Console.WriteLine("Entrada inválidade, digite novamente um número inteiro positivo");


                }
                Console.WriteLine("O número digitado é:" + num);
                Console.WriteLine($"Números pares entre 1 e {num}");

                for (i = 2; i <= num; i += 2)

                {
                    Console.WriteLine(i);
                    ;


                }

                string resposta;
                Console.WriteLine("\nDeseja inserir outro número? (s/n)");
                resposta = Console.ReadLine();

                continuar = (resposta == "s" || resposta == "S"); 

            } while (continuar);

            


        }
    }
}