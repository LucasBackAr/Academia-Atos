using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO
{
    internal class Fabricantes
    {
        /*6 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
        Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
        seja vazio e que o preço seja positivo. */

        private string _nome;
        private string _endereco;
        private string _cidade;
        
        public Fabricantes() 
        { 
        } 
        public string Nome { get { return _nome; } set { _nome = value; } }
        public string Endereco { get { return _endereco; } set { _endereco = value; } }
        public string Cidade { get { return _cidade; } set { _cidade = value;} }
    }
}
