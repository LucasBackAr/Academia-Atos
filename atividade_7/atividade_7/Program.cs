namespace atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
            //Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.

            int numVendedor;
            double salarioFixo, totalVendas, percentualComissao, salarioTotal;

            Console.WriteLine("Informe o número do vendedor:");
            numVendedor = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o salário fixo do vendedor:");
            salarioFixo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o total de vendas do vendedor:");
            totalVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o percentual de comissão do vendedor:");
            percentualComissao = double.Parse(Console.ReadLine());

            salarioTotal = salarioFixo + (totalVendas * percentualComissao / 100);

            Console.WriteLine("O salário total do vendedor {0} é de R$ {1:F2}", numVendedor, salarioTotal);
        }
    }
}