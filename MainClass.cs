using System;

namespace TicTocToeBoard
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game Board.");
            UC1_TicTacToeGame obj = new UC1_TicTacToeGame();
            obj.play();
        }
    }
}
