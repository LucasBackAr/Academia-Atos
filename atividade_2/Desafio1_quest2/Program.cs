using System.Net.Http.Headers;

namespace listaquestao2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

            double num1, num2, num3, num4;

            Console.WriteLine("Média entre 4 números quaisquer");

            Console.WriteLine("Digite o primeiro número");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro número");
            num3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ultimo número pessoa querida");
            num4 = double.Parse(Console.ReadLine());

            Console.WriteLine( "Mèdia:" + (num1 + num2 + num3 + num4)/2);


            

        }
    }
}