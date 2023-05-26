using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO
{
    internal class Autor
    {
        private string _nome;
        private string _email;
        private string _estilo;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Email { get { return _email; } set { _email = value; } }

        public Autor() { }

    }
}
