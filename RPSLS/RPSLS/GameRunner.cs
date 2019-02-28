using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class GameRunner
    {
        PlayerBuilder Player1;
        PlayerBuilder Player2;
        ComputerBuilder CompPlayer;

        public GameRunner()
        {
            List<string> Gestures = new List<string>();
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
        }

        public void UserChoicePlayers()
        {
            Console.WriteLine("Would you like to play against a (1) computer or a (2) person?");
            int Players = int.Parse(Console.ReadLine());

            switch (Players)
            {
                case 1:
                    AgainstComputer vsComputer = new AgainstComputer();
                    break;
                case 2:
                    AgainstPlayer vsPlayer = new AgainstPlayer();
                    break;
                default:
                    Console.WriteLine("I know you`re trying to break my code here (probably Nevin). Look elsewhere.");
                    UserChoicePlayers();
                    break;
            }
        }
      
    }
}
