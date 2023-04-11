namespace atividade_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13-  Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
            //preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas
            //vendidas pelo vendedor, calcule e mostre: o salário do empregado
            double salarioMinimo, precoCusto, comissao, valorVenda, salario;
            int numBicicletas;

            Console.Write("Digite o valor do salário mínimo: ");
            salarioMinimo = double.Parse(Console.ReadLine());

            Console.Write("Digite o preço de custo de cada bicicleta: ");
            precoCusto = double.Parse(Console.ReadLine());

            Console.Write("Digite o número de bicicletas vendidas pelo vendedor: ");
            numBicicletas = int.Parse(Console.ReadLine());

            valorVenda = precoCusto * 1.5; // Preço de venda = preço de custo + 50%
            comissao = precoCusto * 0.15; // Comissão = 15% do preço de custo

            salario = 2 * salarioMinimo + comissao * numBicicletas; // Salário = 2 salários mínimos + comissão * número de bicicletas vendidas

            Console.WriteLine($"O salário do empregado é: R$ {salario}");
        }
    }
}