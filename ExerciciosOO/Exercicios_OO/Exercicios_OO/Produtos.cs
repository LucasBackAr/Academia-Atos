using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_OO
{
    internal class Produtos
    {
        private string nome;
        private double preco;
        private Fabricantes fabricantes;
        public Produtos() { }
        
        public string Nome { get { return nome; } set {  nome = value; } }
        public double Preco { get { return preco; } set { preco = value; } }
        public Fabricantes Fabricantes { get {  return fabricantes; } set {  fabricantes = value; } }
    }

}
