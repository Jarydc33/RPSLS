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


        public GameRunner()
        {
            
        }

        public void UserChoicePlayers()
        {
            Console.WriteLine("Would you like to play against a (1) computer or a (2) person?");
            int Players = int.Parse(Console.ReadLine());

            ChoosePlayers(Players);
        }

        public void ChoosePlayers(int numPlayers)
        {
            if(numPlayers == 1)
            {
                Player1 = new PlayerBuilder(0);
                CompPlayer = new ComputerBuilder(0); // I am placing this 0 here in case I want to add a handicap
            }
            else
            {
                Player1 = new PlayerBuilder(0);
                Player2 = new PlayerBuilder(0);
            }
        }
    }
}
