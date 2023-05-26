using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade14
{
    internal class Agenda
    {
        
        private List<Pessoa> pessoas = new List<Pessoa>();

        public void ArmazenaPessoas(string nome, int idade, float altura)
        {
            pessoas.Add(new Pessoa { Nome = nome, Idade = idade, Altura = altura });
        }
        public void AddPessoas (string nome, int idade, float altura)
        {
            pessoas.Add (new Pessoa { Nome = nome, Idade= idade, Altura = altura });
            Console.WriteLine("Pessoa adicionada" + nome);
        }
        public void RemovePessoas(string nome)
        {
            int remove = pessoas.RemoveAll(p => p.Nome == nome);
            if(remove > 0)
            {
                Console.WriteLine("Pessoa removidada:" + nome);
            }
            else 
                Console.WriteLine("pessoa não encontrada");

        }
        public Pessoa BuscaPessoa(string nome)
        {
            return pessoas.Find(p => p.Nome == nome);


        }
        public void ImprimePessoas()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}.\nIdade: {pessoa.Idade}\nAltura: {pessoa.Altura}");
            }
        }
        public Agenda() 
        {
        } 

        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Altura { get; set; }


    }
}
