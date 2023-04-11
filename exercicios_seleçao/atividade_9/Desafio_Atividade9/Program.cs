using System.Drawing;
using System.Net;

namespace Desafio_Atividade9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
            //diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
            //Se o valor diário for menor que 65, avisá - lo que corre risco de hipoglicemia
            //Se o valor diário for maior que 250, avisá - lo que corre risco de hiperglicemia.


            //Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados.E se a média for
            //menor que 80, avisá - lo que é preciso diminuir 2 unidades de insulina.Se a média for maior que
            //150, avisá - lo que será necessário adicionar 2 unidades de insulina.

            double vGlicemia1, vGlicemia2, vGlicemia3;
            string nomePaciente;


            //TITULO DO PROGRAMA
            Console.WriteLine("Calcúlo para glicemia em jejum:");

            //recebe o nome do paciente

            Console.WriteLine("Informe o NOME do paciente:");
            nomePaciente = Console.ReadLine();

            //recebe o primeiro valor de glicemia indicado pelo usuario.
            Console.WriteLine("Informe o PRIMEIRO valor de glicemia (em jejum):");
            vGlicemia1 = double.Parse(Console.ReadLine());

            //INFORMA SE OS VALORES DO PACIENTE RECORREM A RISCO DE HIPO OU HIPERGLICEMIA

            if (vGlicemia1 < 65)
            {
                Console.WriteLine("O paciente corre risco de HIPOGLICEMIA!!");
            }
            else if (vGlicemia1 >= 65 && vGlicemia1 <= 250)
            {
                Console.WriteLine("O paciente está dentro da NORMALIDADE!");

            }

            else
            {
                Console.WriteLine("O paciente corre risco de HIPERGLICEMIA!!");
            }



            //Recebe o segundo valor de glicemia indicado pelo usuario.
            Console.WriteLine("Informe o SEGUNDO valor de glicemia medido em jejum:");
            vGlicemia2 = double.Parse(Console.ReadLine());

            //INFORMA SE OS VALORES DO PACIENTE RECORREM A RISCO DE HIPO OU HIPERGLICEMIA

            if (vGlicemia2 < 65)
            {
                Console.WriteLine("O paciente corre risco de HIPOGLICEMIA!!");
            }

            else if (vGlicemia2 >= 65 && vGlicemia2 <= 250)
            {
                Console.WriteLine("O paciente está dentro da NORMALIDADE!");

            }

            else
            {
                Console.WriteLine("O paciente corre risco de HIPERGLICEMIA!!");
            }


            //Recebo o terceiro valor de glicemia
            Console.WriteLine("Informe o TERCEIRO valor de glicemia:");
            vGlicemia3 = double.Parse(Console.ReadLine());

            //INFORMA SE OS VALORES DO PACIENTE RECORREM A RISCO DE HIPO OU HIPERGLICEMIA

            if (vGlicemia3 < 65)
            {
                Console.WriteLine("O paciente corre risco de HIPOGLICEMIA");
            }
            else if (vGlicemia3 >= 65 && vGlicemia3 <= 250)
            {
                Console.WriteLine("O paciente está dentro da NORMALIDADE!");

            }

            else
            {
                Console.WriteLine("O paciente corre risco de HIPERGLICEMIA!!");



                //Media dos valores glicemicos

                double media;
                media = (vGlicemia1 + vGlicemia2 + vGlicemia3) / 3;

                Console.WriteLine($"O valor GLICEMICO médio diário é: {media}");

                //OS INFORMES DO PACIENTE DENTRE AS MEDIAS RECEBIDAS

                if (media < 80)
                {
                    Console.WriteLine("O paciente deve diminuir 2 doses de insulina para normalizar o indice glicemico!");

                }
                else if (media >= 150)
                {
                    Console.WriteLine("O paciente deve adicionar 2 doses de insulina para normalizar o indice glicemico!");
                }
                else
                {
                    Console.WriteLine("O paciente está dentro da NORMALIDADE!");
                }

;



            }
        }

    }
}