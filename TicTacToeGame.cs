using System;

public class TicTacToeGame
{
    private char[] board;
    public int currentPlayer;
    public int previouisPlayer;
    public bool isGameOver;

    public TicTacToeGame()
    {
        board = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        currentPlayer = 1;
        
        isGameOver = false;
    }

    public void PrintBoard()
    {
        Console.WriteLine($"Player 1 (X) - Player 2 (O)\n");

        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---|---|---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    public bool MakeMove(int choice)
    {
        char playerSymbol = (currentPlayer == 1) ? 'X' : 'O';

        if (choice < 1 || choice > 9 || board[choice - 1] == 'X' || board[choice - 1] == 'O')
        {
            Console.WriteLine("Invalid choice. Try again.");
            return false;
        }

        board[choice - 1] = playerSymbol;
        currentPlayer = (currentPlayer == 1) ? 2 : 1;
        previouisPlayer = currentPlayer - 1;


        return true;
    }


    public bool CheckForWinner()
    {
        for (int i = 0; i < 3; i++)
        {
            // Check rows
            if (board[i * 3] == board[i * 3 + 1] && board[i * 3] == board[i * 3 + 2])
            {
                return true;
            }

            // Check columns
            if (board[i] == board[i + 3] && board[i] == board[i + 6])
            {
                return true;
            }
        }

        // Check diagonals
        if (board[0] == board[4] && board[0] == board[8])
        {
            return true;
        }

        if (board[2] == board[4] && board[2] == board[6])
        {
            return true;
        }

        return false;
    }






    public bool IsBoardFull()
    {
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O')
            {
                return false;
            }
        }
        return true;
    }
}

