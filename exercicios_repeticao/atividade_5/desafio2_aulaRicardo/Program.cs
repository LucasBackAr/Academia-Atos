namespace desafio2_aulaRicardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5-Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
            //se a média das duas notas for maior ou igual a 7, 0.
              
            double num1, num2, m;
            
            string ok;
            Console.WriteLine("Escreva a primeira nota do discente");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a segunda nota do discente");
            num2 = double.Parse(Console.ReadLine());

            m = (num1 + num2) / 2;

            Console.WriteLine("A Media do discente é:" + m);

            if (m > 7)
            {
                Console.WriteLine("O discente foi APROVADO com nota!!!");
            }
            else
            {
                Console.WriteLine("Discente REPROVADO por nota!");
            }
            
        }
    }
}