using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class PlayerBuilder
    {
        public int Score;

        public PlayerBuilder(int InitialScore)
        {
            Score = InitialScore;
        }

        public virtual int Gesture()
        {
            Console.WriteLine("Would you like to throw (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, or (5) Spock? " +
                    "Press the corresponding number to choose.");
            int Choice = int.Parse(Console.ReadLine());
            return Choice;
        }
                 
    }    
}
