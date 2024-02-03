using System;

namespace TicTacToe1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            // Paste the Tic-Tac-Toe game code here

            TicTacToeGame game = new TicTacToeGame();
            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            do
            {
                game.PrintBoard();
                int choice;
                bool validMove = false;

                do
                {
                    Console.Write($"\nPlayer {game.currentPlayer}, enter your choice (1-9): ");
                    validMove = int.TryParse(Console.ReadLine(), out choice);
                } while (!validMove || !game.MakeMove(choice));

                if (game.CheckForWinner())
                {
                    game.PrintBoard();
                    if (game.currentPlayer == 1)
                    {
                        Console.WriteLine($"Player 2 wins!");
                    } else
                    {
                        Console.WriteLine($"Player 1 wins!");
                    }
                    game.isGameOver = true;
                }
                else if (game.IsBoardFull())
                {
                    game.PrintBoard();
                    Console.WriteLine("It's a draw!");
                    game.isGameOver = true;
                }

            } while (!game.isGameOver);
        }
    }
}
