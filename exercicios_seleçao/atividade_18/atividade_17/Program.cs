namespace atividade_18
{
    internal class Program
    {
        static void Main(string[] args)
        { //atividade 18 Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            int n1, n2, n3;
            Console.WriteLine("Digite a N1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a N2");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a N3");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("N1 Maoir" + n1);

            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("N3 Maior" + n3);
            }

            else if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("N3 Maior" + n3);
            }
            else { Console.WriteLine("Algum dos valores são iguais"); }
        }
    }
}