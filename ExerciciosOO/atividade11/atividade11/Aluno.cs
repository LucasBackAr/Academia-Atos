using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade11
{
    internal class Aluno
    {
        private string _nome;
        private int _nota1;
        private int _nota2;
        private int _nota3;

        public string Nome { get { return _nome; } set { _nome = value; } }
        public int Nota1 
        { 
            get { return _nota1; } 
            set
            { if (_nota1 >= 0) 
                {
                    _nota1 = value; 
                }
                else {Console.WriteLine("Nota invalida!\n Convertida para:" + _nota1 );  }
            } 
        }
        public int Nota2
        {
            get { return _nota2; }
            set
            {
                if (_nota2 >= 0)
                {
                    _nota2 = value;
                }
                else
                {
                    
                    Console.WriteLine("Nota invalida!\n Convertida para:" + _nota2);
                }
            }
        }
        public int Nota3
        {
            get { return _nota3; }
            set
            {
                if (_nota3>= 0)
                {
                    _nota3 = value;
                }
                else
                {
                   
                    Console.WriteLine("Nota invalida!\n Convertida para:" + _nota3);
                }
            }
        }

    }
}
