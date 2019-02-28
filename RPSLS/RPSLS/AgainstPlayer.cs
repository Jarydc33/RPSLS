using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class AgainstPlayer
    {

        PlayerBuilder Player1;
        PlayerBuilder Player2;
        List<string> Gestures;

        public AgainstPlayer()
        {
            Player1 = new PlayerBuilder(0);
            Player2 = new PlayerBuilder(0);
            Console.Write("Ok, you`ll be playing against a friend. Good luck!");

            Gestures = new List<string>();
            Gestures.Add("Rock crushes Scissors"); //0
            Gestures.Add("Scissors cut Paper"); //1
            Gestures.Add("Paper covers Rock"); //2
            Gestures.Add("Rock crushes Lizard"); //3
            Gestures.Add("Lizard poisons Spock"); //4
            Gestures.Add("Spock smashes Scissors"); //5
            Gestures.Add("Scissors decapitate Lizard"); //6
            Gestures.Add("Lizard eats Paper"); //7
            Gestures.Add("Paper disproves Spock");//8
            Gestures.Add("Spock vaporizes Rock");//9

            Throw();
        }

        public void Throw()
        {
            if(Player1.Score == 2 || Player2.Score == 2)
            {
                if (Player1.Score > Player2.Score){
                    
                }
            }

            Console.WriteLine("Player 1, would you like to throw (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, or (5) Spock? " +
                    "Press the corresponding number to choose.");
            int Player1Throw = int.Parse(Console.ReadLine());

            Console.WriteLine("Player 2, would you like to throw (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, or (5) Spock? " +
                    "Press the corresponding number to choose.");
            int Player2Throw = int.Parse(Console.ReadLine());

            if (Player1Throw == Player2Throw)
            {
                Console.WriteLine("Looks like it was a tie, time to roll again!");
                Console.ReadLine();
                Throw();
            }
            else
            {
                Console.WriteLine("Player 1:" + Player1Throw);
                Console.WriteLine("Player 2: " + Player2Throw);
                Console.ReadLine();
                ArraySearch(Player1Throw, Player2Throw);
            }
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
                                Console.WriteLine("Player 1 won because " + Gestures[ArrayField[i, 2]]);
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
}
