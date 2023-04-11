namespace Desafio2_atividade10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
            

            

            string nome1, nome2;
            double nIdade1, nAltura1, nIdade2, nAltura2;

            ////DADOS DO PRIMEIRO ATLETA
            //Recebe os nomes dos atletas
            Console.WriteLine("Qual o nome do atleta?");
            nome1 = Console.ReadLine();

            //RECEBE A IDADE DO ATLETA1
            Console.WriteLine("Qual a IDADE deste atleta?");
            nIdade1 = double.Parse(Console.ReadLine());

            //RECEBE A ALTURA
            Console.WriteLine("Qual a ALTURA deste atleta?");
            nAltura1 = double.Parse(Console.ReadLine());


            ////DADOS DO SEGUNDO ATLETA
            //RECEBE O NOME DO SEGUNDO ATLETA
            Console.WriteLine("Indique o nome de outro atleta:");
            nome2 = Console.ReadLine();

            //RECEBE A IDADE DO SEGUNDO ATLETA
            Console.WriteLine("Qual a IDADE deste atleta?");
            nIdade2 = double.Parse(Console.ReadLine());

            //RECEBE A ALTURA DO SEGUNDO ATLETA
            Console.WriteLine("Qual a ALTURA deste atleta?");
            nAltura2 = double.Parse(Console.ReadLine());


            ////O programa deve mostrar os dados do atleta mais novo E mais alto.
            ///IRA INDICAR O ATLETA QUE É MAIS NOVO E É MAIS ALTO. DUPLO SIM!

            if (nIdade1 < nIdade2 && nAltura1 > nAltura2)
            {
                Console.WriteLine($"O {nome1} tem idade de: {nIdade1}  anos! e altura de: {nAltura1}!");
            }

            // se não for o atleta um, tem que ser o atleta 2, já que é uma dupla positiva.
            else
            {
                Console.WriteLine($"O {nome2} tem idade de: {nIdade2}  anos! e altura de: {nAltura2}!");
            } 

        }
    }
}