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
            Gestures.Add("Rock crushes Scissors"); 
            Gestures.Add("Scissors cut Paper"); 
            Gestures.Add("Paper covers Rock"); 
            Gestures.Add("Rock crushes Lizard"); 
            Gestures.Add("Lizard poisons Spock"); 
            Gestures.Add("Spock smashes Scissors"); 
            Gestures.Add("Scissors decapitate Lizard"); 
            Gestures.Add("Lizard eats Paper"); 
            Gestures.Add("Paper disproves Spock");
            Gestures.Add("Spock vaporizes Rock");
        }

        public int ArraySearch(int Player1Choice, int Player2Choice)
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
                                Console.WriteLine("Player 1 won because " + Gestures[ArrayField[i, 2]]);
                                return 1;
                            }
                            else
                            {
                                Console.WriteLine("Player 2 won because " + Gestures[ArrayField[i, 2]]);
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
