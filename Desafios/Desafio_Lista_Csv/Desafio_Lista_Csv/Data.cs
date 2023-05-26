using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Lista_Csv
{
    internal class Data
    {
        ///<summary>
        /// Responsavel por escrever e pesquisar e listar Pessoas. Arquivos em CSV
        /// </summary>
        
        public Data() { }
        Pessoa Pessoa { get; set; }
        public static void AddArquivo(string nomeArquivo, List<Pessoa> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                do
                {
                    linha = leitor.ReadLine(); //adiciona leitor na linha. Lucas Sobrenome, Datanascimento
                    vetorLinha = linha.Split(";"); //Separa os termos do vetor
                    
                    lista.Add(new Pessoa(vetorLinha[0], vetorLinha[1]));

                }while(!leitor.EndOfStream);
                leitor.Close();
            }
            catch 
            {
                Console.WriteLine("Inválido!");
            }

        }
        /// <summary>
        /// Grava os nomes na lista
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="nomeArquivo"></param>
        public static void gravarListaArquivo(List<Pessoa> lista, string nomeArquivo)
        {
            try
            {
                StreamWriter escrito = new StreamWriter(nomeArquivo);
                foreach (var item in lista)
                {
                    escrito.WriteLine($"{item.Nome};{item.DataNascimento}");
                    escrito.Flush();
                }
                escrito.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Inválido!");
            }
        }
        public static void AtualizaLista(Pessoa pessoa, string nomeArquivo)
        {
            try
            {
                StreamWriter escrito = new StreamWriter(nomeArquivo, append: true);
                escrito.WriteLine($"{pessoa.Nome}; {pessoa.DataNascimento}");
                escrito.Flush();
            }
            catch (Exception)
            {
                Console.WriteLine("Inválido");
            }
            
        }

        /// <summary>
        /// Le o arquivo na tela
        /// </summary>
        /// <param name="nomeArquivo"></param>
        public static void LerArquivoTela(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    Console.WriteLine(leitor.ReadLine());
                }while(!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Arquivo com problemas.");
            }
        }
        public static void LerArquivoNome(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha;
                string linha;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    Console.WriteLine(vetorLinha[0]);
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception) { Console.WriteLine("Inválido"); }
        }

        /// <summary>
        /// Validações
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        public static bool validaNome(string nome)
        {
            string[] vetor = nome.Split();
            if (vetor.Length < 2)
            {
                return false;
            }
            return true;
        }

        public static bool validaData(string data)
        {
            //   dd/mm/aaaa --- exemplo de 'preocupacao'
            string[] vetor = data.Split('/');

            if (vetor.Length != 3 || vetor[0].Length > 2 || vetor[1].Length > 2 || vetor[2].Length != 4)
            {
                return false;
            }
            return true;
        }
    }
}
