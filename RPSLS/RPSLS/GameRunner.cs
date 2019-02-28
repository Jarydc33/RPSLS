using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class GameRunner
    {
        PlayerBuilder Player1;
        PlayerBuilder Player2;
        List<string> Gestures;
        DetermineWinner Winner;

              
        public GameRunner()
        {
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
            UserChoicePlayers();

            Winner = new DetermineWinner();
            
        }

        public void UserChoicePlayers()
        {
            Console.WriteLine("Welcome to RPSLS! Would you like to play against a (1) computer or a (2) person?");
            int Players = int.Parse(Console.ReadLine());

            switch (Players)
            {
                case 1:
                    Player1 = new PlayerBuilder(0);
                    Player2 = new ComputerBuilder(0);
                    break;
                case 2:
                    Player1 = new PlayerBuilder(0);
                    Player2 = new PlayerBuilder(0);
                    break;
                default:
                    Console.WriteLine("I know you`re trying to break my code here (probably Nevin). Look elsewhere.");
                    UserChoicePlayers();
                    break;
            }
        }

        public void ThrowTime()
        {            
            int Player1Throw = Player1.Gesture();
            int Player2Throw = Player2.Gesture();

            if(Player1Throw == Player2Throw)
            {
                Console.WriteLine("Looks like you threw a tie. Please re-roll!");
                ThrowTime();
            }

            Winner.ArraySearch(Player1Throw,Player2Throw); 
        }
                    
    }
}
