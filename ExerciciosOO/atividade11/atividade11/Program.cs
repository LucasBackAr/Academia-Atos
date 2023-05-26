namespace atividade11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /*11 - Crie uma classe "Aluno" com os atributos "nome", "nota1", "nota2" e "nota3". Os atributos devem ser privados e
           acessados através de propriedades. Em seguida, crie um método para calcular a média e verificar se o aluno está aprovado 
           ou reprovado (se a nota for maior ou igual a 6, está aprovado, senão está reprovado).*/

            Aluno aluno = new Aluno();

            Console.WriteLine("Qual o nome do Aluno?");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a primeira nota de: " + aluno.Nome);
            aluno.Nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota de: " + aluno.Nome);
            aluno.Nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota de: " + aluno.Nome);
            aluno.Nota3 = int.Parse(Console.ReadLine());


            double media = (aluno.Nota1 + aluno.Nota2 + aluno.Nota3) / 3;
            
            if(media > 6)
            {
                Console.WriteLine("O aluno está aprovado com nota");
                Console.WriteLine("Media do Aluno:" + media);
            }
            else 
            { Console.WriteLine("O aluno foi reprovado!");
                Console.WriteLine("Media do Aluno:" + media);
            }

        }
    }
}