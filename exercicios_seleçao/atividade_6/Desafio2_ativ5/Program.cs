using System.Reflection.Emit;

namespace Desafio2_ativ5
{
    internal class Program
    {
        static void Main(string[] args)
        {
//6-Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), a altura (metros) e o peso (kg) de uma pessoa.
//O programa deve calcular o Indice de Massa Corpórea(IMC), exibi - lo ao usuário e informar sua situação conforme a tabela.
//O cálculo do imc = peso / (altura * altura)

//IMC
//menor que 18->baixo peso
//maior que 18 e menor que 25->peso normal
//maior que 25 e menor que 30->sobrepeso
//maior que 30 e menor que 35->obesidade
//maior que 35->obesidade grau sério


            Console.WriteLine("Programa para calcular o IMC");
            double a, peso;
            string nome;
                // Recebe o nome da pessoa
            Console.WriteLine("Informe o seu nome:");
            nome = Console.ReadLine();
            string nomemaisc = nome.ToUpper();
            
            
            // recebe a altura da pessoa
            Console.WriteLine("Digite sua altura (em metro)");
            a = double.Parse(Console.ReadLine());


            //recebe o peso da pessoa
            Console.WriteLine("Digite seu peso (em kg)");
            peso = double.Parse(Console.ReadLine());

            //calculo do imc
            double imc = (peso / (a * a));

            //nome em maiusculo
            Console.WriteLine($"O IMC de {nomemaisc} é: { imc} ");
            
            //tabela
            if (imc < 18) {
                Console.WriteLine("Abaixo do peso");
            }
           else if (imc > 18 && imc < 25) {
            Console.WriteLine("Peso normal");
                    }
            else if (imc >=  25 && imc < 30)
            {
                Console.WriteLine("Situação de Sobrepeso");
            }
            else if ((imc >= 30 && imc > 35))
            {
                Console.WriteLine("Situação de obesidade");

            }
            else if ((imc >= 35 && imc > 40))
            {
                Console.WriteLine("Situação de obesidade grau 2");

            }
            else
            {
                Console.WriteLine("Situação de obsidade grau 3");
            }



        }
    }
}