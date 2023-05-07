using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaConsulta
{
    internal class ProfissionalSaude
    {
        
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Matricula { get; set; }
        public string Conselho { get; set; }
      

        public ProfissionalSaude() { }
        public ProfissionalSaude(string nome, string sobrenome, string matricula, string conselho, string tipo)
        {
            Nome = nome.ToUpper();
            Matricula = matricula.ToUpper();
            Conselho = conselho.ToUpper();
            Tipo = tipo.ToUpper();
            
        }

        public string SobreNome()
        {
            string[] lista = Nome.Split(',');
            return lista[lista.Length - 1] + " " + Conselho;
        }
    }
}
