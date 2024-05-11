using System;
using TicTacToe;
using BoardLogic;

namespace TicTacToe
{
class Program 
{
        static Board game = new Board();
        static void Main(string[] args)
        {
            int userTurn = -1;
            int computerTurn = -1;
            Random random = new Random();

            while (game.checkForWinner() == 0)
            {
                while (userTurn == -1 || game.Grid[userTurn] != 0) 
                {
                    userTurn = Convert.ToInt32(Console.ReadLine());
                }
                game.Grid[userTurn] = 1;
                if (game.isBoardFull())
                    break;
                while (computerTurn == -1 || game.Grid[computerTurn] != 0)
                {
                    computerTurn = random.Next(8);
                }
                game.Grid[computerTurn] = 2;
                if (game.isBoardFull())
                    break;
                printBoard();
            }
            Console.WriteLine("Playe " + game.checkForWinner() + " Won The Game");
        }
        public static void printBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                if (game.Grid[i] == 0)
                {
                    Console.Write(".");
                }
                if (game.Grid[i] == 1)
                {
                    Console.Write("X");
                }
                if (game.Grid[i] == 2)
                {
                    Console.Write("O");
                }
                if (i == 2 || i == 5 || i == 8)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}