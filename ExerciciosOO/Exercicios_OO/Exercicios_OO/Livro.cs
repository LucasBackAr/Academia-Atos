using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO
{
    
    internal class Livro
    {
        private Titulo _titulo;
        private Autor _autor;

        public Autor Autor { 

            get { return _autor; } 
            set {
                if (value == null)
                {
                    throw new ArgumentException("o titulo não deve ser vazio.");
                }
                _autor = value; 
                } 
        }
        public Titulo Titulo { 
            get { return _titulo; } 
            set {
                if(Titulo != null) { _titulo = value; }
                } 
        }
    }
}
