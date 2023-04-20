namespace atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2) Solicite ao usuário, preencher uma Matriz 3x3

            //Informe ao usuário:
            //*A soma dos elementos de cada linha

            //-Ex: Linha 1: 30

            //Linha 2: 17
            //* A soma dos elementos de cada coluna

            //-Ex: Coluna 1: 23

            //Coluna 2: 36

            int[,] a = new int[3,3];
          
            for (int i = 0; i < a.GetLength(0); i++)
            {
                

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine($"Posição [ {i}, {j}];");
                    a[i,j] = int.Parse(Console.ReadLine());
                }

                
            }
            //print matriz
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0;j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine(); 

            }

            int soma;
            //soma das linhas
            for (int i = 0; i < a.GetLength(0);i++)
            {
                soma = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    soma += a[i,j];
                }
                Console.WriteLine($"A soma dos elementos das linha {i}: {soma}");

            }

            //soma das colunas
            for (int j = 0; j < a.GetLength(0); j++)
            {
                soma = 0;
                for (int i =  0; i < a.GetLength(1); i++)
                {
                    soma += a[i,j];
                }

                Console.WriteLine($"A soma dos elementos das coluna {j}: {soma}");
            }

        }
    }
}
       