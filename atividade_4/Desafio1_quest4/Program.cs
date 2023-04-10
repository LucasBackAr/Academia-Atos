using System.Runtime.Intrinsics.X86;

namespace quest4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

            //usei as strings separadas para utilizar o substring, já que não tinha total certeza se serviria usando o comando na mesma linha
            string dia;
            string mes;
            string ano;

            Console.WriteLine("Digite o dia");
            dia = Console.ReadLine();
            Console.WriteLine("Digite o Mês");
            mes = Console.ReadLine();
            Console.WriteLine("Digite o Ano");
            ano = Console.ReadLine();

            Console.WriteLine("Data:" + ano + "/" + mes + "/" + dia);
            Console.WriteLine("Data:" + ano.Substring(2) + "/" + mes + "/" + dia);
            
            //np substring para subtrair parte de uma linha dentro do codigo.
        }
    }
}
