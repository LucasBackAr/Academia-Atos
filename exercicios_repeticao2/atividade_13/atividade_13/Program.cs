using System.Net;
using System.Xml.Serialization;

namespace atividade_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //13.Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.


            int soma = 0, i;
            for(i = 0; i < 500; i++) 
            {
                if (i % 2 == 0)

                    soma += i;
            }
            Console.WriteLine("A soma dos valores pares entre 1 e 500 é:" + soma);
        }
    }
}