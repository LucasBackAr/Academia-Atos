using System.Runtime.Intrinsics.X86;

namespace atividade_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da
            //multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
            //(N * 3; N * 3 * 3; N * 3 * 3 * 3; etc)

            int n, i;

            do
            {
                Console.WriteLine("Digite um número entre 1 e 50");

            } while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 50);

            int produto = n;
            while (produto < 250){
                Console.WriteLine(produto + "");
                produto *= 3;
            }

            Console.WriteLine("\nPressione Enter para sair");
        }
    }
}