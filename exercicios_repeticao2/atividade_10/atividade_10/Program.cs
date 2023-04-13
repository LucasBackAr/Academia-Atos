namespace atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
            //Número de pessoas do sexo masculino.
            //Número de pessoas do sexo feminino.
            //Número de pessoas com idade inferior a 30 anos.
            //Número de pessoas com idade superior a 60 anos.
            //Média de idade das mulheres.

            int masc = 0, fem = 0, idadeTrinta = 0, idadeSessent = 0, idadeMulher = 0, qtdMulher = 0;
            int i = 1;
            int masculino = 0, feminino = 0;
            while (i <= 2)
            {
                Console.WriteLine($"Pessoa {i}");
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Sexo (M/F): ");
                string sexo = Console.ReadLine();
                Console.WriteLine("Idade da pessoa");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine();

               

                if (sexo.ToUpper() == "M")
                {
                    masculino++;
                }
                else if (sexo.ToUpper() == "F")
                {
                    feminino++;

                    idadeMulher += idade;

                    qtdMulher++;
                }
                else { Console.WriteLine("Sexo inválido. Tente Novamente");
                     continue;
                }

                if (idade < 30)
                {
                    idadeTrinta++;
                }
                if (idade > 60)
                {
                    idadeSessent++;
                }

                i++;                       

            }
            Console.WriteLine($"Número de pessoas do sexo masculino: {masculino}");
            Console.WriteLine($"Número de pessoas do sexo feminino: {feminino}");
            Console.WriteLine($"Número de pessoas com menos de 30 anos: {idadeTrinta}");
            Console.WriteLine($"Número de pessoas com mais de 60 anos: {idadeSessent}");

            double mediaMulher;
            if (qtdMulher > 0)
            {
                mediaMulher = (double)idadeMulher / qtdMulher;

                Console.WriteLine($"A média de idade entre as mulheres é: {mediaMulher:F2}");
            }
            else
            {
                Console.WriteLine("Não há mulheres registradas");
            }
        }



    }
}