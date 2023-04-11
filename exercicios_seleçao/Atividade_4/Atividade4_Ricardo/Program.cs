namespace Atividade4_Ricardo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
            //link de Internet(em Mbps).Em seguida, calcule e informe o tempo aproximado de download
            //do arquivo usando este link(em minutos).

            double tamProgram, velNet, tempDownls, VelMB, tempoM;
            Console.WriteLine("Qual o tamanho do programa que deseja realizar o download (em MB)?");
            tamProgram = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a velocidade da sua internet (em Mbps)");
            velNet = double.Parse(Console.ReadLine());

            VelMB = velNet * 0.125;

            tempDownls = tamProgram/VelMB;
            tempoM = tempDownls / 60;

            Console.WriteLine($"A Velocidade aproximada para download é de: {tempoM} minutos");



        }
    }
}