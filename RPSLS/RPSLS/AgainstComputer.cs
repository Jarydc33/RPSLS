using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class AgainstComputer
    {
        PlayerBuilder Player1;
        ComputerBuilder Player2;
        List<string> Gestures;

        public AgainstComputer()
        {
            Player1 = new PlayerBuilder(0);
            Player2 = new ComputerBuilder(0); // I am placing this 0 here in case I want to add a handicap
            Console.WriteLine("Ok cool, you`ll be playing against the computer. We`ll call him..Dave. He is very good I must warn you.");

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
                //call end game function
                Console.WriteLine("Call end game");
            }

            Console.WriteLine("Would you like to throw (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, or (5) Spock? " +
                    "Press the corresponding number to choose.");
            int UserThrow = int.Parse(Console.ReadLine());
            int CompThrow = Player2.ThrowRandomizer();
            
            if(UserThrow == CompThrow)
            {
                Console.WriteLine("Looks like it was a tie, time to roll again!");
                Console.ReadLine();
                Throw();
            }
            else
            {
                Console.WriteLine("User:" + UserThrow);
                Console.WriteLine("Computer: " + CompThrow);
                Console.ReadLine();
                ArraySearch(UserThrow, CompThrow);
            }
        }

        public void ArraySearch(int UserChoice, int CompChoice)
        {
            int counter = 0;
            int[,] ArrayField = new int[,] { { 1, 3, 0 }, { 1, 4, 3 }, { 2, 1, 2 }, { 2, 5, 8 },
                                             { 3, 2, 1 }, { 3, 4, 6 }, { 4, 5, 4 }, { 4, 2, 7 },
                                             { 5, 1, 5 }, { 5, 3, 9 }, { 1, 2, 2 }, { 1, 5, 5 },
                                             { 2, 3, 1 }, { 2, 4, 7 }, { 3, 1, 0 }, { 3, 5, 9 },
                                             { 4, 1, 3 }, { 4, 3, 6 }, { 5, 2, 8 }, { 5, 4, 4 }};
            for(int i = 0; i < 20; i++)
            {
                for(int j = 0; j<1; j++)
                {
                   if(ArrayField[i,j] == UserChoice)
                   {
                        if(ArrayField[i,1] == CompChoice)
                        {
                            if (counter < 9)
                            {
                                Console.WriteLine("You won because " + Gestures[ArrayField[i, 2]]);
                                Player1.Score++;
                                Console.WriteLine("Your score is now: " + Player1.Score);
                                Console.ReadLine();
                                Throw();
                            }
                            else
                            {
                                Console.WriteLine("You lost because " + Gestures[ArrayField[i, 2]]);
                                Player2.Score++;
                                Console.WriteLine("The computer`s score is now: " + Player2.Score);
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
