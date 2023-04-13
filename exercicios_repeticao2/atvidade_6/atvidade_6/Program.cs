namespace atvidade_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
            //ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
            //Ao final, mostre a idade digitada.

            int idade;
            

                for (; ; )
                {
                    Console.Write("Digite sua idade: ");
                    if (int.TryParse(Console.ReadLine(), out idade) && idade > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Entrada inválida. Digite uma idade maior que zero.");
                }

            Console.WriteLine($"Idade digitada: {idade}");




        }
    }
}