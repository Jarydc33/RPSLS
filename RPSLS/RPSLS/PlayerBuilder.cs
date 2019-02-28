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
            string test;
            bool check;
            int Choice;
            Console.WriteLine("Would you like to throw (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, or (5) Spock? " +
                    "Press the corresponding number to choose.");
            test = Console.ReadLine();

            check = int.TryParse(test, out Choice);
            if (check) {
                if (Choice < 1 || Choice > 5)
                {
                    Console.WriteLine("Tisk tisk, you are only allowed to choose between 1 and 5. Do pay attention in the future.");
                    Gesture();
                    return 0;
                }
                else
                {
                    return Choice;
                }
            }
            else
            {
                Console.WriteLine("Ok, you have to type a number..not a word. Ugh.");
                Gesture();
                return 0;
            }

            
        }
                 
    }    
}
