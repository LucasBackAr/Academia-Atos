using System.Runtime.ConstrainedExecution;

namespace atividade_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
            //ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente.
            //Considerar nota 7,0 como mínima para aprovação.

            double nota1 = 0, nota2 = 0, nota3 = 0, nota4 = 0; //as variaveis ultilizadas pelas notas
            bool notasValidas = false; // o booleano mostrando que as notas são validas, serve para o retorno o loop

            while (!notasValidas) // !notasvalidas, caso a nota não seja valida, o loop tem que retornar
            {
                Console.WriteLine("Digite a primeira nota:"); //nota 1
                if (!double.TryParse(Console.ReadLine(), out nota1)) // o uf dentro do console, é usar o tryparse,que serve para voltar caso a nota esteja errada
                {                                          // o out indica o paremetro de saida para a nota1
                    Console.WriteLine("Digite um valor número. NOTA INVÁLIDA!!");
                    continue;
                }

                Console.WriteLine("Digite a segunda nota:");
                if (!double.TryParse(Console.ReadLine(), out nota2))
                {
                    Console.WriteLine("Digite um valor número. NOTA INVÁLIDA!!");
                    continue;
                }

                Console.WriteLine("Digite a terceira nota:");
                if (!double.TryParse(Console.ReadLine(), out nota3))
                {
                    Console.WriteLine("Digite um valor número. NOTA INVÁLIDA!!");
                    continue;
                }

                Console.WriteLine("Digite a quarta nota:");
                if (!double.TryParse(Console.ReadLine(), out nota4))
                {
                    Console.WriteLine("Digite um valor número. NOTA INVÁLIDA!!");
                    continue;
                }

                notasValidas = true;

            }

            double media = (((nota1 * 2) + (nota2 * 1) + (nota3 * 2) + (nota4 * 4)) / 9);

            Console.WriteLine($"A media é:{media}");

            if (media >= 7) 
            {
                Console.WriteLine($"O Aluno está aprovado com média {media:f2}.");


            }
            else
            {
                Console.WriteLine($"Foi de lojas americanas. \nAluno reprovado com média {media:f2}.");
            }
        }
    }
}