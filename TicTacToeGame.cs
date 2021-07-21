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
       
    }
}
