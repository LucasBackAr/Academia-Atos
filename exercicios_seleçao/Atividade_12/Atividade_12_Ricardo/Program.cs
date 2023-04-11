namespace Atividade_12_Ricardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
            //número de horas trabalhadas de um operário.Na sequência, calcule o salário sabendo - se que ele ganha
            //R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento
            //armazenando - o na variável "extra", caso contrário zerar tal variável.
            //A hora excedente de trabalho vale R$ 20,00.
            //No final do processamento, exibir o salário total e o salário excedente do operário.

            int codigo, horasTrabalhadas, horasExtras;
            double salario, salarioExtra;

            //Recebe o codigo do funcionario
            Console.WriteLine("Digite o código do funcionário:");
            codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de horas trabalhadas:");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            // se as horas trabalhadas forem maiores que 50
            if (horasTrabalhadas > 50)
            {
                horasExtras = horasTrabalhadas - 50;
                salarioExtra = horasExtras * 20.0;
                salario = 50 * 10.0 + salarioExtra;
            }
            else
            {
                horasExtras = 0;
                salarioExtra = 0.0;
                salario = horasTrabalhadas * 10.0;
            }

            Console.WriteLine("Salário total: R$ " + salario);
            Console.WriteLine("Salário excedente: R$ " + salarioExtra);


        }
    }
}