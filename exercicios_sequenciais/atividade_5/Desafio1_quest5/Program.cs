namespace desafio1_quest5
{
    internal class Question5
    {
        static void Main(string[] args)
        {
            //5)Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            //(medido em Km/ l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            //consumido para percorrê-la(medido em l).

            double num1, num2;

            Console.WriteLine("Consumo médio de um veiculo em km/l:");

            Console.WriteLine("Indique a distancia que será percorrida em quilometros (apesar os números):");
            num1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Indique a quantidade de combustivel consumido para percorrer o percurso:");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine((num1 + num2) / 2 + "km/l");
        }
    }
}
