using System;

namespace TicTocToeBoard
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game Board.");
            TicTacToeGame obj = new TicTacToeGame();
            obj.boardCreate();
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
