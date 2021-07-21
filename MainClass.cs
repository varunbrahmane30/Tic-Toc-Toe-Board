using System;

namespace TicTocToeBoard
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game Board.");
            TicTacToeGame obj = new TicTacToeGame();

            Char[] board = obj.boardCreate();
            obj.choosePlayer();
            obj.showGameBoard(board);
        }
       
    }
}
