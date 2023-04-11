namespace atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Le o número de eleitores, votos brancos, nulos e válidos
            Console.Write("Digite o número de eleitores: ");
            int numEleitores = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos brancos: ");
            int numBrancos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos nulos: ");
            int numNulos = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de votos válidos: ");
            int numValidos = int.Parse(Console.ReadLine());

            // Calcular percentuais
            double percBrancos = (double)numBrancos / numEleitores * 100.0;
            double percNulos = (double)numNulos / numEleitores * 100.0;
            double percValidos = (double)numValidos / numEleitores * 100.0;

            // Exibir resultados
            Console.WriteLine("Percentual de votos brancos: " + percBrancos.ToString("F2") + "%");
            Console.WriteLine("Percentual de votos nulos: " + percNulos.ToString("F2") + "%");
            Console.WriteLine("Percentual de votos válidos: " + percValidos.ToString("F2") + "%");
        }
    }
}