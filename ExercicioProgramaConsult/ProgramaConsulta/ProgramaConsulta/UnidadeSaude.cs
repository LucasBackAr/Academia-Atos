using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaConsulta
{
    internal class UnidadeSaude
    {
        private string nome;
        private string sigla;
        private string endereco;

        public string Nome { get; set; }
        public string Sigla { get; set; }
        public string Endereco { get; set; }

        public ProfissionalSaude Responsavel { get; set; }

        
        public UnidadeSaude() 
        { 
            Responsavel = new ProfissionalSaude();  
        }

        public UnidadeSaude(int ID, string nome, string sigla, string endereco)
        {
            Nome = nome.ToUpper();
            Sigla = sigla.ToUpper();
            Endereco = endereco.ToUpper();

            Responsavel = new ProfissionalSaude();
        }

        public UnidadeSaude(string nome)
        {
            Nome = nome;
            Responsavel = new ProfissionalSaude(); 
        }


    }
}
