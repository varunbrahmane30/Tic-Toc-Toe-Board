using System;
using System.Collections.Generic;
using System.Text;

namespace TicTocToeBoard
{
    class TicTacToeGame
    {

        public const char X = 'X';
        public const char O = 'O';
       
        public char[] boardCreate()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            Console.WriteLine("Board Initialized");
            return board;
        }

        public void choosePlayer()
        {
            Console.WriteLine("Enter you Choice from O/X :");
            char playerChoice = Convert.ToChar(Console.ReadLine());
            if (playerChoice == 'X')
            {
                Console.WriteLine("Player Chose " + playerChoice);
                Console.WriteLine("Computer Chose " + O);
            }
            else if (playerChoice == 'O')
            {
                Console.WriteLine("Player Chose " + playerChoice);
                Console.WriteLine(" Computer Chose " + X);
            }
            else
            {
                Console.WriteLine("Entered invalid input  ");
            }
        }
        public void showGameBoard(char[] board)
        {
            Console.WriteLine(board[1] + " | " + board[2] + " |" + board[3]);
            Console.WriteLine("-------------");
            Console.WriteLine(board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("-------------");
            Console.WriteLine(board[7] + " | " + board[8] + " | " + board[9]);
        }
    }
}
