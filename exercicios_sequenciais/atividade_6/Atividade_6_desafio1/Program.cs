using System.Drawing;

namespace Atividade_6_desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
            //de IPI(única) a ser acrescentada.


            int nCodigo1, nCodigo2, nQuant1, nQuant2;
            double vUnidade1, vUnidade2, Ipi1, Ipi2;


            // RECEBE O ITEM A
            Console.WriteLine("Insira os dados do Parafuso A");
            Console.WriteLine("Insira os codigo do parafuso");
            nCodigo1 = int.Parse(Console.ReadLine());
            
            //RECEBE QUANTIDADE DE PEÇAS
            Console.WriteLine($"Insira a quantidade de parafusos, correspondentes ao codigo: {nCodigo1}");
            nQuant1 = int.Parse(Console.ReadLine());

            //RECEBE VALOR
            Console.WriteLine($"Inidique o valor da unidade do Parafuso: {nCodigo1}:");
            vUnidade1 = double.Parse(Console.ReadLine());


            //RECEBE O IPI INDICADA PELO USUARIO.
            Console.WriteLine("Indique a porcentagem de IPI aplicada a peça");
            Ipi1 = double.Parse(Console.ReadLine());


            ////DADOS DO ITEM B
            Console.WriteLine("Insira os dados do Parafuso B");        
            
            //RECEBE O PARAFUSO B
            Console.WriteLine("Insira os codigo do parafuso");
            nCodigo2 = int.Parse(Console.ReadLine());
            
            //RECEBE QUANTIDADE
            Console.WriteLine($"Insira a quantidade de parafusos, correspondentes ao codigo: {nCodigo2}");
            nQuant2 = int.Parse(Console.ReadLine());

            //RECEBE VALOR
            Console.WriteLine($"Inidique o valor da unidade do Parafuso: {nCodigo2}:");
            vUnidade2 = double.Parse(Console.ReadLine());

            //RECEBE O IPI INDICADA PELO USUARIO.
            Console.WriteLine("Indique a porcentagem de IPI aplicada a peça");
            Ipi2 = double.Parse(Console.ReadLine());

            //variaveis calculadas
            double vTotal1, vTotal2,tIpi1, tIpi2;
            vTotal1 = vUnidade1 * nQuant1;
            vTotal2 = vUnidade2 * nQuant2;
            tIpi1 = (Ipi1/100) * vTotal1;
            tIpi2 = (Ipi2/100) * vTotal2;

            // APRESENTANDO RESULTADOS SO PARAFUSO A
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"O Parafuso A de codigo: {nCodigo1} tem:");
            Console.WriteLine("Codigo:" + nCodigo1);
            Console.WriteLine("Unidades:" + nQuant1);
            Console.WriteLine("Valor unitario de:" + vUnidade1);
            Console.WriteLine("Total do Valor das peças:" + vTotal1);

            // APRESENTANDO RESULTADOS SO PARAFUSO B
            
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"O Parafuso B de codigo: {nCodigo2} tem:");
            Console.WriteLine("Codigo:" + nCodigo2);
            Console.WriteLine("Unidades:" + nQuant2);
            Console.WriteLine("Valor unitario de:" + vUnidade2);
            Console.WriteLine("Total do Valor das peças:" + vTotal2);


        }

    }
}