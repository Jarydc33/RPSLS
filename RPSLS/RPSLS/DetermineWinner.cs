using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class DetermineWinner
    {
        List<string> Gestures;

        public DetermineWinner()
        {
            Gestures = new List<string>();
            Gestures.Add("Rock"); 
            Gestures.Add("Paper"); 
            Gestures.Add("Scissors"); 
            Gestures.Add("Lizard"); 
            Gestures.Add("Spock");            
        }

        public int ArraySearch(int Player1Choice, int Player2Choice)
        {
            int counter = 0;
            Player1Choice--;
            Player2Choice--;
            int[,] ArrayField = new int[,] { { 0, 2 }, { 0, 3 }, { 1, 0 }, { 1, 4 },
                                             { 2, 1 }, { 2, 3 }, { 3, 4 }, { 3, 1 },
                                             { 4, 0 }, { 4, 2 }, { 0, 1 }, { 0, 4 },
                                             { 1, 2 }, { 1, 3 }, { 2, 0 }, { 2, 4 },
                                             { 3, 1 }, { 3, 2 }, { 4, 1 }, { 4, 3 } };
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
                                Console.WriteLine("Player 1 won because " + Gestures[ArrayField[i, 0]] + " beats " + Gestures[ArrayField[i,1]]);
                                return 1;
                            }
                            else
                            {
                                Console.WriteLine("Player 2 won because " + Gestures[ArrayField[i, 1]] + " beats " + Gestures[ArrayField[i, 0]]);
                                return 2;
                            }
                        }
                    }
                }
                counter++;               
            }
            return 0;
        }
    }
}
