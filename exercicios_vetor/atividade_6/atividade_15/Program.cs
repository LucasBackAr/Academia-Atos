namespace atividade_15
{
    internal class Program
    {
        static void Main(string[] args)
        { //15.	Faça um programa em C que declare um vetor de 20 elementos inteiros,
          //leia os conteúdos do vetor, e copie estes conteúdos para outro vetor,
          //invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve
          //ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos
          //do primeiro vetor em uma linha e os do segundo uma linha abaixo.

            int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Declare os valores do vetor");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor1.Length; i++) 
            { 
                Console.WriteLine(vetor1);

            }

            //copiando os valores para o v2
            for (int i = 0;i < 20; i++) 
            {
                vetor2[19 - i] = vetor1[i]; 
            
            }

            Console.WriteLine("Vetor 1 :");
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine($"{vetor1[i]}");
            }
            

            //Mostra o v2

            Console.WriteLine("Vetor 2:");
            for (int i = 0; i <  vetor1.Length; i++)
            {
                Console.WriteLine($"{vetor2[i]}");
            }


        }
    }
}