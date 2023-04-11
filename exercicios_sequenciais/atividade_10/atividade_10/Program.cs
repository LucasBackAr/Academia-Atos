namespace atividade_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorPedido, auxValor, notas50, notas20, notas10, notas5, notas1;

            Console.Write("Informe o valor da quantia solicitada: R$ ");
            valorPedido = int.Parse(Console.ReadLine());

            auxValor = valorPedido;
            notas50 = auxValor / 50;
            auxValor %= 50;
            notas20 = auxValor / 20;
            auxValor %= 20;
            notas10 = auxValor / 10;
            auxValor %= 10;
            notas5 = auxValor / 5;
            auxValor %= 5;
            notas1 = auxValor;

            Console.WriteLine("\nDistribuição das notas para R$" + valorPedido);
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");
            Console.WriteLine(notas1 + " nota(s) de R$ 1,00");
        }
    }
}