using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;

namespace atividade_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4.Em uma cidadezinha do interior há dois candidatos para prefeito(JOAO e ZECA).
            //Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            //de votos em branco. 



            int joao = 0, zeca = 0, branco = 0 ;
            string voto;

            for (; ; )
            {

                Console.WriteLine("Digite seu voto. \n:JOAO \n: ZECA \n:BRANCO \n:FIM");
                voto = Console.ReadLine().ToUpper();

                if (voto == "FIM")

                {
                    break; //encerra
                }
                else if (voto == "JOAO")
                {
                    joao++; //votos para joao
                }
                else if (voto == "ZECA")
                {
                    zeca++; //votos zeca

                }

                else if (voto == "BRANCO")
                {
                    branco++; // brancos pq sim
                }
                else
                {
                    Console.WriteLine("Voto inválido");
                }
            }

            Console.WriteLine("Resultado da eleição:");
            
            Console.WriteLine($"Votos para JOAO: {joao}");

            Console.WriteLine($"Votos para ZECA: {zeca}");

            Console.WriteLine($"Votos para BRANCO: {branco}");
            Console.WriteLine();
            Console.WriteLine("OBRIGADO POR VOTAR!!");


        }


    }
}