namespace atividade9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta = new ContaBancaria();
            Console.WriteLine("Sem vindo ao caixa eletronico:");

            Console.WriteLine("Digite o número da conta:");
            conta.NumConta = Console.ReadLine();
            Console.WriteLine("Digite o nome do Titular:");
            conta.Titular = Console.ReadLine();
            Console.WriteLine("Digite o lumite da conta:");
            conta.Limite = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine("Número: " + conta.NumConta);
            Console.WriteLine("Titular:" + conta.Titular);
            Console.WriteLine("Limite: " + conta.Limite);
            Console.WriteLine("Saldo: " + conta.Saldo);

            while(true)
            {
                int op;
                double valor;
                Console.WriteLine("Digite \n 1 - para Saque: \n2 - Deposito \n3 - Saldo da Conta \n 0 - Para sair  ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    Console.WriteLine("\n Informe o valor a ser Sacado:");
                    valor = double.Parse(Console.ReadLine());
                    if (conta.Sacar(valor))
                    {
                        Console.WriteLine("Saque efetuado. Saldo atual:" + conta.Saldo);
                    }
                    else
                    { Console.WriteLine("Saldo insuficiente!"); }
                    
                }
               else if (op == 2)
                {
                    Console.WriteLine("\n Informe o valor a ser Depositado:");
                    valor = double.Parse(Console.ReadLine());
                    conta.Depositar(valor);
                }
                else if(op == 3)
                {
                    Console.WriteLine("Dados da conta:");
                    Console.WriteLine("Número: " + conta.NumConta);
                    Console.WriteLine("Titular:" + conta.Titular);
                    Console.WriteLine("Limite: " + conta.Limite);
                    Console.WriteLine("Saldo: " + conta.Saldo);
                }
                else if(op == 0) { break; }

                else { Console.WriteLine("Valor indisponivel"); }

            }

        }
    }
}