using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class GameRunner
    {
        int NumPlayers;
        PlayerBuilder Player1;
        PlayerBuilder Player2;
        ComputerBuilder CompPlayer;
        List<string> Gestures;
        int TotalScore = 0;
        int UserThrow;
        int CompThrow;

        public GameRunner()
        {
            Gestures = new List<string>();
            Gestures.Add("Rock"); //case 1
            Gestures.Add("Paper"); //case 2
            Gestures.Add("Scissors"); //case 3
            Gestures.Add("Lizard"); //case 4
            Gestures.Add("Spock"); //case 5
        }

        public void UserChoicePlayers()
        {
            Console.WriteLine("Would you like to play against a (1) computer or a (2) person?");
            int Players = int.Parse(Console.ReadLine());

            switch (Players)
            {
                case 1:
                    ChoosePlayers(Players);
                    break;
                case 2:
                    ChoosePlayers(Players);
                    break;
                default:
                    Console.WriteLine("I know you`re trying to break my code here (probably Nevin). Look elsewhere.");
                    UserChoicePlayers();
                    break;
            }
        }

        public void ChoosePlayers(int numPlayers)
        {
            if(numPlayers == 1)
            {
                Player1 = new PlayerBuilder(0);
                CompPlayer = new ComputerBuilder(0); // I am placing this 0 here in case I want to add a handicap
                Console.WriteLine("Ok cool, you`ll be playing against the computer. We`ll call him..Dave. He is very good I must warn you.");
            }
            else
            {
                Player1 = new PlayerBuilder(0);
                Player2 = new PlayerBuilder(0);
            }

            PlayGame();
        }

        public void PlayGame()
        {
            do
            {
                Console.WriteLine("Would you like to throw (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, or (5) Spock? " +
                    "Press the corresponding number to choose.");
                if (NumPlayers == 1)
                {
                    UserThrow = int.Parse(Console.ReadLine());
                    CompThrow = CompPlayer.ThrowRandomizer();
                }
                else
                {
                    
                }

                if(UserThrow == CompThrow)
                {
                    Console.WriteLine("Looks like it was a tie! Time to start the round again!");
                    PlayGame();
                }

                switch (UserThrow)
                {
                    case 1:
                        
                        break;

                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;
                }        
            } while (TotalScore != 3);
        }

        public void RockResults(int UserChoice, int CompChoice)
        {

        }

    }
}
