namespace Desafio2_ativ7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
           // O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por
           // exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.


            
            string texto, palavra;

            //recebendo o texto ou frase
            Console.WriteLine("Digite o texto ou frase desejada");
            texto = Console.ReadLine();

            //recebendo a palavra indicada pelo usuario do programa
            Console.WriteLine("Qual palavra você deseja localizar no texto");
            palavra = Console.ReadLine();
            
            //se contem a palavra
            if (texto.Contains(palavra))
            {
                Console.WriteLine("Está palavra está presente no texto");
            }
            else //não contem a palavra
            {
                Console.WriteLine("A palavra não aparece no texto");
            }

        }
    }
}