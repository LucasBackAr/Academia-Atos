using System.Collections.Generic;

namespace Desafio_Lista_Csv
{
    internal class Program
    {
        static void Main(string[] args)
        { /* Menu
            1 - Cadastrar pessoa (controle de duplicidade: email)
            2 - Listar pessoa
            3 - Pesquisar pessoa (atributo nome)
            4 - Excluir pessoa
            5 - Sair*/

            Data arquivo = new Data();
            List<Pessoa> lista = new List<Pessoa>();
            Data.AddArquivo("D:\\Academia Atos\\exercicios\\Desafios\\Desafio_Lista_Csv", lista);
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Menu");
            int op;
            string pPesquisa;
            do
            {                
                Console.WriteLine("Digite:\n1 - Cadastrar Pessoa\n2 - Pesquisar pessoas\n3 - Listar Pessoas" +
                    "\n4 - Excluir pessoas\n0 - Sair da aplicação");
                Console.Write("Opção: ");
                op = int.Parse(Console.ReadLine());                
                Console.Clear();
                switch (op)
                {
                    case 0:
                        Console.WriteLine("Digite qualquer tecla para fechar o console!");
                        break;
                    case 1:
                                                                      
                            string nome;
                            string dataNascimento;   
                            

                            
                            Console.Write("Nome: ");
                            nome = Console.ReadLine().ToUpper();
                            
    
                            Console.Write("Data Nascimento: ");
                            dataNascimento = Console.ReadLine();
                            

                            pessoa = new Pessoa(nome, dataNascimento);

                            if (!lista.Contains(pessoa))
                            {
                                lista.Add(pessoa);
                                Data.AtualizaLista(pessoa, "dados.dat");
                                Console.WriteLine("Pessoa cadastrada na base de dados");
                            }
                            else
                            {
                                Console.WriteLine("Pessoa com este email já na base de dados");
                            }
                            break;
                    case 2:
                        Console.WriteLine("Digite o nome da pessoa a ser pesquisada");
                        pPesquisa = Console.ReadLine();
                        


                        break;
                    case 3:
                        Console.WriteLine("Listando pessoas");
                        foreach (var item in lista)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Excluir pessoa");
                        string nomeExclui;
                        nomeExclui = Console.ReadLine();
                        bool removeu = false;
                        foreach (var item in lista)
                        {
                            if (nomeExclui == item.Nome)
                            {
                                lista.Remove(item);
                                removeu = true;
                                System.Console.WriteLine("Pessoa excluida");
                                break;
                            }
                        }
                        if (removeu)
                        {
                            Data.gravarListaArquivo(lista, "dados.dat");
                        }
                        break;
                    default: Console.WriteLine("Opção inválida, digite novamente");
                        break;
                }
                Console.ReadKey();


            } while (op != 0);


        }
    }
}