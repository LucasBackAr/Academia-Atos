namespace atividade_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
            //a média aritmética da turma e a quantidade de alunos da turma.Usar - 1 para encerrar a leitura.

            double nota, notaAlta = int.MinValue, notaBaixa = int.MaxValue, media, soma=0;
            int alunos=0, i =0;

            while (true)
            {
                   Console.WriteLine("Digite a nota do aluno");
                nota = double.Parse(Console.ReadLine());

                if (nota == -1)
                {
                    break;

                }
                if (nota > notaAlta)
                {
                    notaAlta = nota;

                }
                if (nota < notaBaixa)
                {
                    notaBaixa = nota;
                }

                soma += nota;
                alunos++;

                if (alunos == 0)
                {
                    Console.WriteLine("Nenhuma nota foi digitada.");

                }
                else
                {
                    media = (double)soma / alunos;


                    Console.WriteLine($"A nota mais baixa dos aluno é: {notaBaixa}");
                    Console.WriteLine($"A nota mais alta dos aluno é: {notaAlta}");
                    Console.WriteLine($"A media de nota entre os alunos é de: {media.ToString ("N2")}");
                    Console.WriteLine($"A sala possui {alunos} alunos;");
                }
            }

        }
    }
}