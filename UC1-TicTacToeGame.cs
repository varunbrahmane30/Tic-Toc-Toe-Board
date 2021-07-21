using System;
using System.Collections.Generic;
using System.Text;

namespace TicTocToeBoard
{
    class UC1_TicTacToeGame
    {
        static char[] board = { '0','1','2','3','4','5','6','7','8','9'};

        public void play()
        {
            Random random = new Random();
            int value = random.Next(0, 2);

            if ( value == 1)
            {
                Console.WriteLine("X generated");
            }
            else
            {
                Console.WriteLine("O generated");
            }
        }



    }
}
