using System;

namespace Desafio1_JogodaVelha
{
    internal class Program
    {        
        static void LogicaJogo()
        {
            /*Desenvolva um jogo da velha utilizando matrizes em C#. Faça com que cada jogador insira a sua jogada em uma interface amigavel. 
            Teste se a posição é válida e caso não seja solicite ao jogador repetir a jogada. Após cada jogada, apresente o tabuleiro com as 
            jogadas representadas por "X" e "O" e faça a verficação se algum jogador venceu.
            Caso seja empate, apresente o resultado na tela. Possilibilite que o jogo seja reinicializado sem a necessidade de reiniciar o jogo. 

            Desafio extra, pode valer por alguma atividade futura: Faça a implementação de um jogo contra o computador. Faça o possível para evitar que o jogador vença do computador. 
            Para facilitar, faça com que o computador inicie jogando.
            Prazo de entrega: 24/04
            Forma e envio: Enviar pelo chat o link do github
            */

            //elementos para trabalhar o jogo.
            //2 jogadores - X e O
            //turnos
            //computador - (caso eu consiga resolver rapido.)

            /* condições de vitória
               0-1-2   0-1-2   0-1-2 //matriz
           0 - X 0 X | X X X | X X X <-
           1 - 0 X 0 | X X X | X X X <-
           2 - X 0 X | X X X | X X X <-
                      ^ ^ ^
             9 POSSIBILIDADES. (9 TENTATIVAS) - cada jogador pode "ter" 9 possibilidades de jogadas
            o VENCEDOR terá 5 e o PERDEDOR 4
             */
        }

        static void MensagemNaTela()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("  Jogo da Senhora de Terceira Idade  ");
            Console.WriteLine("=====================================");



            
        }

        static void FimDaTela()
        {
            Console.WriteLine("=====================================");
            
            Console.WriteLine("=====================================");
        }              

        static void MatrizPrincipal()
        {
            char[,] matriz = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                Console.Write("   \t ");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    Console.Write($"|{matriz[i, j]}|");
                }

                Console.WriteLine();
            }
        }
        
        static void Main(string[] args)
        {                        
            MensagemNaTela();

            char[,] matriz = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
            char turno1 = 'X';
            char turno2 = 'O';
            int jogadas = 0;

            //matriz principal
            MatrizPrincipal();
            Console.WriteLine("Vez do Jogador 1: X");
            FimDaTela();

            char escolha = Console.ReadKey().KeyChar; //escolhe a letra
            bool escolhaInvalida = true; 

            List<char> listNumeros = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

           
            Console.WriteLine();

            //Loop
            while (jogadas < 8)
            {
                
                
                escolhaInvalida = true;

                for (int i = 0; i < matriz.GetLength(0); i++) //reescreve
                {

                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] == escolha && listNumeros.Contains(escolha))
                        {
                            matriz[i,j] = turno1;
                            escolhaInvalida = false;    
                            break;
                        }                        
                        if (!listNumeros.Contains(escolha))
                        {
                            Console.WriteLine("Jogada inválida, tente novamente!");
                            escolha = Console.ReadKey().KeyChar;
                            Console.WriteLine();
                        }

                    }
                }
                
                Console.Clear();
                MensagemNaTela();

                for (int i = 0; i < matriz.GetLength(0); i++) //reimprime a matriz
                {
                    Console.Write("   \t ");//tabulação

                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {

                        Console.Write($"|{matriz[i, j]}|");
                    }

                    Console.WriteLine();
                    
                }
                if (escolhaInvalida == false)
                {
                    if (turno1 == 'X') //Alterando o jogador
                    {
                        Console.WriteLine($"Vez do Jogador 2: O");
                        turno1 = turno2;
                    }
                    else
                    {
                        Console.WriteLine($"Vez do jogador 1: X");
                        turno1 = 'X';
                    }
                    jogadas++; //DEFINE O EMPATE

                }
                //CONDIÇÕES DE VITORIA

                if (   matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2] //primeira diagonal
                    || matriz[2, 0] == matriz[1, 1] && matriz[1, 1] == matriz[0 , 2] //segunda diagonal
                    || matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2] //primeira coluna
                    || matriz[0, 1] == matriz[1, 1] && matriz[2, 1] == matriz[1, 1] //segunda coluna
                    || matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2] //terceira coluna
                    || matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2 , 0] //primeira linha  
                    || matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2] //segunda linha  
                    || matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2]) //terceira linha
                {
                    Console.WriteLine("VITÓRIA!");
                    Console.WriteLine("FIM DE JOGO!!!");
                    break;

                }
                FimDaTela();

                Console.Write($"Escolha uma posição para jogar:");//repete a frase                
                Console.WriteLine();
                escolha = Console.ReadKey().KeyChar;//jogada
                Console.WriteLine();   
            }

            
            Console.WriteLine("Deu Velha!!");

        }       
    }
}