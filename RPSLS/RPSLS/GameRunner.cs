using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class GameRunner
    {
        PlayerBuilder Player1;
        PlayerBuilder Player2;
        DetermineWinner Winner;

              
        public GameRunner()
        {            
            Winner = new DetermineWinner();
            UserChoicePlayers();
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
                    ThrowTime();
                    break;
                case 2:
                    Player1 = new PlayerBuilder(0);
                    Player2 = new PlayerBuilder(0);
                    ThrowTime();
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

            int ScoreUpdate = Winner.ArraySearch(Player1Throw,Player2Throw); 

            if(ScoreUpdate == 1)
            {
                Player1.Score++;                
            }
            else
            {
                Player2.Score++;                
            }
            Console.WriteLine("Player 1`s score is: " + Player1.Score);
            Console.WriteLine("Player 2`s score is: " + Player2.Score + "\n");

            if(Player1.Score == 2 || Player2.Score == 2)
            {
                string NewGame;
                if (Player1.Score > Player2.Score)
                {
                    Console.WriteLine("Looks like Player 1 has won the game! Congrats! Would you like to play again? Yes or no.");
                    NewGame = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Looks like Player 2 has won the game! Congrats! Would you like to play again? Yes or no.");
                    NewGame = Console.ReadLine();
                }

                if(NewGame.ToLower() == "yes")
                {
                    UserChoicePlayers();
                }
                else if(NewGame.ToLower() == "no")
                {
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                }
            }

            ThrowTime();
        }
                    
    }
}
