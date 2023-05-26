using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO.Atividade04
{
    //4 - Crie uma classe chamada Pessoa que tenha as propriedades Nome e Idade.
    //Utilize o encapsulamento para garantir que o nome não seja vazio e que a
    //idade seja maior que zero.

    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome
        {
            get { return _nome; }
            set { 
                _nome = "Lucas"; }
        }
        public int Idade
        {
            get { return _idade; }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("A idade deve ser maior que 0");
                                
                }
                else
                {
                    _idade = value;
                }
                
            }

        }
    }
}
