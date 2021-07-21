using System;
using System.Collections.Generic;
using System.Text;

namespace TicTocToeBoard
{
    class TicTacToeGame
    {
        public char[] boardCreate()
        {
            char[] CreateBoard = new char[10];
            for (int i = 1; i < CreateBoard.Length; i++)
            {
                CreateBoard[i] = ' ';
            }
            Console.WriteLine("Board Initialized");
            return CreateBoard;
        }

        public char ChoosePlayer()
        {
            char[] choice = new char[] { 'X', 'O' };
            Console.WriteLine("Choose X or O ");
            char playerChoice = char.Parse(Console.ReadLine());
            if (playerChoice == choice[0])
            {
                playerChoice = choice[0];
            }
            else
            {
                playerChoice = choice[1];
            }
            return playerChoice;
        }

    }
}
