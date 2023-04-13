namespace atividade_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
            //Se o usuário digitar 0 o programa em VS deve parar. 
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

            int i, n, divisores = 0;
            
            for (; ; ) 
            {
                Console.WriteLine("digite um número");
                n = int.Parse(Console.ReadLine());
                
                if (n == 0) 
                {
                    break;
                }

                Console.WriteLine("o número digitado foi: " + n);
                if (n % 2 == 0)
                {
                    Console.WriteLine("O número digitado é par");
                }
                else if (n % 2 == 1)
                {
                    Console.WriteLine("O número digitado é impar");
                }

                bool eprimo = true;

                for(i = 2; i < n; i++) 
                { 
                    if (n % i == 0)
                    {
                        eprimo = false;
                        break;
                    }
                }

                if (n == 1 || eprimo) 
                {
                    Console.WriteLine($"{n} é um número primo");
                }
                else
                {
                    Console.WriteLine($"{n} não é um número primo");
                }


            }

          

          

        }
    }
}