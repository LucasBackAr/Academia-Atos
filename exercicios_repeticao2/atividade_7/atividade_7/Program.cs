using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System;

namespace atividade_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa.
            // A cada solicitação, teste se o usuário informou um valor válido. 
            // Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
            // informe que ele está incorreto e saia do programa em VS.
            // Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero),
            // informe que está errada e saia.Se estiver correta, solicite o salário.
            // Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.
            // Se estiver correto, mostre todos os valores lidos.

            int idade = 0;
            double salario = 0;
            string nome = "";

            while (nome == "")
            {
                Console.WriteLine("Digite seu nome:");
                nome = Console.ReadLine();

                if (nome == "")
                {
                    Console.WriteLine("Nome inválido! Digite novamente.");
                    break;
                }
            }

            while (idade <= 0)
            {
                Console.WriteLine("Digite a idade");
                idade = int.Parse(Console.ReadLine());

                if (idade <= 0)
                {
                    Console.WriteLine("Idade inválida!");
                    
                }

            }
            while (salario <= 0)
            {
                Console.WriteLine("Digite o salário");
                if (!double.TryParse(Console.ReadLine(), out salario) || salario <= 0)
                {
                    Console.WriteLine("Salario inválido! Digite novamente");
                }
            }
            Console.WriteLine($"Nome:{nome}");
            Console.WriteLine($"Idade:{idade}");
            Console.WriteLine($"Salário:{salario}");


        }
    }
}