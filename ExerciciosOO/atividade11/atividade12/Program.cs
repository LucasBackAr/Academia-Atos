namespace atividade12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*12 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro
            (aumentando a velocidade em 10) e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a 
            velocidade negativa).*/
            Carro carro = new Carro();
            Console.WriteLine("Digite o modelo do carro:");
            carro.Model = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro");
            carro.Ano = int.Parse(Console.ReadLine());

            int op;
            Console.WriteLine("Digite 1 para ligar o carro!");
            op = int.Parse(Console.ReadLine());
            carro.Acelera();
            if(op == 1)
            {
                Console.WriteLine("Carro ligado!");
                carro.Acelera();
                Console.WriteLine("Carro começou a se movimentar" + carro.Vel);


                do
                {

                    Console.WriteLine("Digite:\n [A] - para acelerar \n[F] - para Freiar");
                    char acelera = char.Parse(Console.ReadLine());

                    if (acelera == 'A')
                    {
                        carro.Acelera();

                        Console.WriteLine("Velocidade atual: " + carro.Vel);
                        
                        
                    }
                    else if(acelera == 'F')
                    {
                        carro.Freio();
                        Console.WriteLine("Velocidade atual: " + carro.Vel);
                        
                    }
                    if (carro.Vel == 0)
                    {
                        Console.WriteLine("Digite: \n2 -  Para desligar o Carro");
                        int desliga = int.Parse(Console.ReadLine());
                        if (desliga == 2)
                        {
                            Console.WriteLine("Carro Desligado!");
                            break;

                        }
                    }


                } while(carro.Vel != 200);
               
            }
            
            else { Console.WriteLine("Atribuição inválida!"); }
            


        }
    }
}