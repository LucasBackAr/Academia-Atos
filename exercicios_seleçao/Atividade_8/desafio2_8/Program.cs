namespace desafio2_8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
            //Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5 % do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7 % do total de vendas.
            //E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10 % do
            //total de vendas.


            string f, fmais;
            double salario, vendas;
            int cd;
            

            //recebendo o codigo do funcionario
            Console.WriteLine("Insira o código do Funcionário");
            try 
            { 
                cd = int.Parse(Console.ReadLine());
            }
            catch 
            {

                Console.WriteLine("Insira somente numeros");

                Console.WriteLine("insira o código do Funcionário");
                cd = int.Parse((string)Console.ReadLine());

            }
              
            
            
            //recebe o Nome
            Console.WriteLine("Indique o nome do funcionario");
            f = Console.ReadLine();
            fmais = f.ToUpper();
            fmais = f;

            //recebe o salario
           
            Console.WriteLine("Informe o salário base do funcionário");
            salario = double.Parse(Console.ReadLine());
            
            //recebe as vendas
            Console.WriteLine("Informe o numero de vendas do funcionário (em reais)");
            vendas = double.Parse(Console.ReadLine());
            
            
            double comissao = 0;


            if(vendas > 500 && vendas <= 1000)
            {
                comissao = vendas * 0.05; 
            }
                      
            else if(vendas >= 1000 && vendas < 5000) {
                comissao = vendas * 0.07; ;
            }
            else 
            {
                comissao = vendas * 0.1;
                    }

            //Tabela final
            double salariocomi;
            salariocomi = salario + comissao;

            Console.WriteLine("Código:" + cd);

            Console.WriteLine("Funcionário:" + f);

            Console.WriteLine("Base salárial:" + salario);

            Console.WriteLine("Total de vendas:" + vendas);

            Console.WriteLine("Comissão:" + comissao);

            Console.WriteLine("Salário final:" + salariocomi);






        }
    }
}