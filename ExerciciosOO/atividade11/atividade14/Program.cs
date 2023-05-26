using System.Runtime.CompilerServices;

namespace atividade14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
                void armazenaPessoa(String nome, int idade, float altura);
                void removePessoa(String nome);
                Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
                void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda*/
            
            Agenda agenda = new Agenda();
            Pessoa pessoa = new Pessoa();
            Agenda imprime = new Agenda();
            
            agenda.ArmazenaPessoas("Lucas Back Araujo", 29, 1.69F);
            agenda.ArmazenaPessoas("Manoela L. Carngelutti", 22, 1.70F);
            agenda.ArmazenaPessoas("Marcelo Back Araujo", 27, 1.72F);
            agenda.ArmazenaPessoas("Juh Adamns", 31, 1.71F);
            agenda.ArmazenaPessoas("Hericles Farias", 27, 1.75F);
            agenda.ArmazenaPessoas("Gabriel Machado", 27, 1.62F);
           
            bool continuar = true;
            while (continuar)
            { 
            Console.WriteLine("Agenda:");
            Console.WriteLine("Ações da Agenda:\n1 - Você deseja toda visualizar a agenda?" +
                "\n2 - Para buscar pessoa\n3 -  Para remover pessoa\n0 - Fechar programa");
            
            int op = int.Parse(Console.ReadLine());
            if (op == 1)
            {
                agenda.ImprimePessoas();
            }
            else if (op == 2)
            {


                Console.Write("Digite o nome da pessoa que deseja buscar: ");
                string nome = Console.ReadLine();

                Pessoa pessoaBusca = agenda.BuscaPessoa(nome);

                if (pessoaBusca != null) 
                {
                    Console.WriteLine($"Pessoa encontrada: {pessoaBusca.Nome}");
                }
                else 
                    Console.WriteLine("Pessoa não encontrada!");

            }
            else if (op == 3)
                {
                    Console.WriteLine("Digite o nome da pessoa a ser adicionada:");
                    string nomeAdiciona = Console.ReadLine();
                    Console.WriteLine("Digite a Idade:");
                    int idadeAdiciona = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a altura:");
                    float alturaAdiciona = float.Parse(Console.ReadLine());
                    agenda.AddPessoas(nomeAdiciona, idadeAdiciona, alturaAdiciona);
                }
            else if (op == 4)
            {
                Console.WriteLine("Digite o nome da pessoa que deve ser removido");
                string nomeRemove = Console.ReadLine() ;
                agenda.RemovePessoas(nomeRemove);
            }
            else if (op == 0) { continuar = false; }
            else
                {
                    Console.WriteLine("opção inválida!");
                }


            }

        }
    }
}