namespace Atividade_9
{
    internal class Program
    {

        // Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
        //A fórmula da conversão é F = (9 * C + 160) / 5.
        static void Main(string[] args)
        {
            double grauCelcius, fahrenh;
            Console.WriteLine("Digite a temperatura em graus Celcius");
            grauCelcius = double.Parse(Console.ReadLine());

            fahrenh = (9 * grauCelcius + 160) / 5;

            Console.WriteLine("A temperatude em Fahrenheit é:" +  fahrenh.ToString("F2"));

        }
    }
}