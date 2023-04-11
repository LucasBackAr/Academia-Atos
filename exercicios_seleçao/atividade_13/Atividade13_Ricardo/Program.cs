namespace Atividade13_Ricardo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
            //seu peso ideal, utilizando as seguintes fórmulas:
            //Para homens: (72.7 * h) - 58
            //Para mulheres: (62.1 * h) - 44.7

            //Recebe os dados da pessoa
            double altura, peso;
            char M, F, opcao;
            Console.WriteLine("Digite a ALTURA de uma pessoa (em metros):");
            altura = double.Parse(Console.ReadLine());

            //Solicita do usuario uma das opções de Sexo
            Console.WriteLine("Selecione uma das opções:");
            Console.WriteLine("M - Para o sexo Masculino");            
            Console.WriteLine("F - Para o sexo Feminino");
            opcao = char.Parse(Console.ReadLine());
            

            //Realiza a operação selecionada

            double resultado = 0.0;
            
            switch (opcao)
            {
                case 'm': //caso seja masc
                    resultado = (altura * 72.7) - 58;
                    Console.WriteLine($"Seu peso ideal é: {resultado} kg");
                    break;
                case 'f': //caso seja feminino
                    resultado = (altura * 62.1) - 44.7;
                    Console.WriteLine($"Seu peso ideal é:{resultado} kg");
                    break;

            }

            Console.WriteLine("Digite o Peso desta pessoa");
            peso = double.Parse(Console.ReadLine());   

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($" O peso atual é de: {peso}");//retorna peso atual
            Console.WriteLine($"Você está {peso - resultado}kg, acima do peso"); //retorna a diferença

        }
    }
}