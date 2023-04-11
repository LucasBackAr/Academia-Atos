namespace atividade_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precoCombustivel = 6.90;
            double marcacaoInicio, marcacaoFim, numLitros, valorTotal, mediaConsumo, lucroLiquido;
            // recebe dados do usuario
            Console.Write("Digite a marcação do odômetro (início do dia): ");
            marcacaoInicio = double.Parse(Console.ReadLine());

            Console.Write("Digite a marcação do odômetro (final do dia): ");
            marcacaoFim = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de litros de combustível gasto: ");
            numLitros = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor total recebido dos passageiros: ");
            valorTotal = double.Parse(Console.ReadLine());

            // Cálculo da média de consumo em Km/l
            double distanciaPercorrida = marcacaoFim - marcacaoInicio;
            mediaConsumo = distanciaPercorrida / numLitros;

            // Cálculo do lucro líquido do dia
            double custoCombustivel = numLitros * precoCombustivel;
            lucroLiquido = valorTotal - custoCombustivel;

            Console.WriteLine("Média de consumo: " + mediaConsumo + " Km/l");
            Console.WriteLine("Lucro líquido: R$ " + lucroLiquido);
        }
    }
}