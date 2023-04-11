namespace desafio1
{

    internal class Program
    {

        static void Main(string[] args)
        {
            //questão 1) media entre 2 números quaisquer

            //ju deu certo

            double num1;
            double num2;
            
            
            Console.WriteLine("Digite o primeiro número:");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = double.Parse(Console.ReadLine());


            double media = (num1 + num2) / 2;
            Console.WriteLine("A média é: " + media);
        }

       
    }

    
}

