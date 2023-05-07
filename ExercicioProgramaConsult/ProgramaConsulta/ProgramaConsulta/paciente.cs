using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgramaConsulta
{
    internal class Paciente
    {
        private string nome;
        private string email;
        private int cpf;
        DateTime data = new DateTime();

        public string Nome { get; set; }
        public string Email { get; set; }
        public int Cpf { get; set ; }
        public DateOnly Data { get; set ; }
        
        public Paciente()
        {

        }

        public Paciente(string nome, string email, int cpf, DateOnly data)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Data = data;
        }

        public Paciente(string nome, int cpf, DateOnly data)
        {
            Nome = nome;
            Cpf = cpf;
            Data = data;
        }
        
        public int idade()
        {

            return DateTime.Now.Year - Data.Year;
        }
    }
}
