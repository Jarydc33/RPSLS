using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class DetermineWinner
    {
        public DetermineWinner()
        {

        }

        public void ArraySearch(int Player1Choice, int Player2Choice)
        {
            int counter = 0;
            int[,] ArrayField = new int[,] { { 1, 3, 0 }, { 1, 4, 3 }, { 2, 1, 2 }, { 2, 5, 8 },
                                             { 3, 2, 1 }, { 3, 4, 6 }, { 4, 5, 4 }, { 4, 2, 7 },
                                             { 5, 1, 5 }, { 5, 3, 9 }, { 1, 2, 2 }, { 1, 5, 5 },
                                             { 2, 3, 1 }, { 2, 4, 7 }, { 3, 1, 0 }, { 3, 5, 9 },
                                             { 4, 1, 3 }, { 4, 3, 6 }, { 5, 2, 8 }, { 5, 4, 4 }};
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (ArrayField[i, j] == Player1Choice)
                    {
                        if (ArrayField[i, 1] == Player2Choice)
                        {
                            if (counter < 9)
                            {
                                Console.WriteLine("Player 1 won because " + RPSLS.Gestures[ArrayField[i, 2]]);
                                Player1.Score++;
                                Console.WriteLine("Player 1`s score is now: " + Player1.Score);
                                Console.ReadLine();
                                Throw();
                            }
                            else
                            {
                                Console.WriteLine("Player 2 won because " + Gestures[ArrayField[i, 2]]);
                                Player2.Score++;
                                Console.WriteLine("Player 2`s score is now: " + Player2.Score);
                                Console.ReadLine();
                                Throw();
                            }
                        }
                    }
                }
                counter++;
            }
        }
}
