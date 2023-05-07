using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaConsulta
{
    internal class Triagem
    {
        public double peso, altura, pressao, temp;

        public ProfissionalSaude Responsavel { get; set; }
        public Paciente Paciente { get; set; }
        public string Urgencia { get; set; }
        public double Peso { set; get; }
        public double Altura { set; get; }
        public double Temp { set; get; }
        public double Pressao { set; get; }
        
        public Triagem() { }

        public Triagem(double peso, double altura, double pressao, double temp, string urgencia, ProfissionalSaude responsavel, Paciente paciente)
        {
            Peso = peso;
            Altura = altura;
            Pressao = pressao;
            Temp = temp;
            Urgencia = urgencia;
            Responsavel = responsavel;
            Paciente = paciente

            
        }


    }
}
