using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Lista_Csv
{
    internal class Pessoa
    {
        private string _nome;
        private string _dataNascimento;
        public string Email;
        
         
        public string Nome { get; set; }
        public string DataNascimento { get; set; }

        public void GeradorEmail()
        {
            try
            {
                string[] linha = Nome.Split();
                if (linha.Length == 1)
                {
                    Email = linha[0].ToLower() + "@backar.br";
                }
                else
                {
                    Email = linha[linha.Length - 1].ToLower() + "_" + linha[0].ToLower() + "@backar.br";
                }
            }
            catch (Exception) 
            {
                Email = "sem email";
            }
        }
        public override string ToString()
        {
            return Nome + " : " + Email;
        }
        public override bool Equals(object? obj)
        {
            return obj is Pessoa pessoa && Email == pessoa.Email;
        }

        public Pessoa(string Nome, string DataNascimento)
        {
            this._nome = Nome;
            this._dataNascimento = DataNascimento;
        }
        public Pessoa()
        {
            
        }
        
    }
}
