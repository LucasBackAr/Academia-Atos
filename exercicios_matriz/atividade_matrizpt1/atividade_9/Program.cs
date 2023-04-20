namespace atividade_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*9) Leia uma matriz 3x3.  Em seguida, 
             * solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
            Caso, seja verdade imprima a mensagem:  
            “O número existe no vetor” , caso contrário “Número inexistente”.
            */
            
            int[,] a = new int[3, 3];
            int numeroDesejo =0;
            bool numTrue = false;
            Random random = new Random();

            //preenche a matriz com num aleatorios, para facilitar

            Console.WriteLine("Digite o numero que deseja encontrar na Matriz:");
            numeroDesejo = int.Parse(Console.ReadLine());



            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    //Console.WriteLine($"Digite o elemento {i} e o {j} da Matriz");
                    //a[i,j] = int.Parse(Console.ReadLine());
                    a[i, j] = random.Next(1, 101);
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i,j] == numeroDesejo)
                    {
                        numTrue = true;
                        break;
                    }
                }
                if (numTrue)
                {
                    break;
                }


            }

            if (numTrue)
            {
                Console.WriteLine($"O número {numeroDesejo} foi encontrado!");
            }
            else { Console.WriteLine($"O número {numeroDesejo} não está presente na matriz"); }













                //print matriz
                for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                Console.WriteLine();

            }

        }
    }
}