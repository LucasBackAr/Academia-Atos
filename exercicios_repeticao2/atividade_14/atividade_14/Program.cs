namespace atividade_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14. Mostrar as potências de 2 variando de 0 a 10.
           double resultado;
           for (int i = 1; i <= 10; i++)
            {
                resultado = (int)Math.Pow(2, i);
                Console.WriteLine($"{2}^{i} = {resultado}");
            }
        }
    }
}