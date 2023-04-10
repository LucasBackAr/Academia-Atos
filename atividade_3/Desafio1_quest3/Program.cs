namespace desafio1_quest3
{

    internal class Program
    {

        static void Main(string[] args)
        {
            //3) Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre
            //si os valores de duas variáveis A e B.


            Console.WriteLine("Questão 3) troca de valores entre 2 variaveis distintas");

            double a, b, ag;
            a = 1;
            b = 2;
            ag = 2;

            Console.WriteLine("Valor de A:" + a);
            Console.WriteLine("Valor de B:" + b);

            Console.WriteLine("Troca de Valores entre A e B");
            b = a; 
            a = ag;
            Console.WriteLine("Valor de A:" + a);
            Console.WriteLine("Valor de B:" + b);
        }

    }
}