namespace Exercicios_OO.Atividade04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("idade: "+ pessoa.Idade);
        }
    }
}