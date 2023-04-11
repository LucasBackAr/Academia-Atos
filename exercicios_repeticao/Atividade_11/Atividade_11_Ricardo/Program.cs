namespace Atividade_11_Ricardo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
            //O programa deve exibir se a hora digitada está ou não válida. 
            //Lembre que usaremos o padrão de hora com 24h, de 0 a 23.
           
            double Hora, Minutos;
            //Recebe a hora
           
            Console.WriteLine("Digite uma hora (entre 00 e 23h)");
            Hora = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite os minutos (entre 00 e 60 min)");
            Minutos = double.Parse(Console.ReadLine());

            if (Hora < 23 || Minutos < 59) 
            { 
                Console.WriteLine("São:" + Hora + ":" + Minutos);

            }
            else
            {
                Console.WriteLine("A hora digitada é invalida!");
            }
        }
    }
}