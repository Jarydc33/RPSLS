using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class ComputerBuilder : PlayerBuilder
    {
        
        
        public ComputerBuilder(int InitialScore)
            :base(InitialScore)
        {
            this.Score = InitialScore;
        }

        public int ThrowRandomizer()
        {
            Random num = new Random();
            int Throw = num.Next(1,5);
            return Throw;
        }

        public override void Throw()
        {
            Console.WriteLine("Would you like to throw (1) Rock, (2) Paper, (3) Scissors, (4) Lizard, or (5) Spock? " +
                    "Press the corresponding number to choose.");
            int UserThrow = int.Parse(Console.ReadLine());
            int CompThrow = ThrowRandomizer();

            if (UserThrow == CompThrow)
            {
                Console.WriteLine("Looks like it was a tie, time to roll again!");
                Console.ReadLine();
                Throw();
            }
            else
            {
                Console.WriteLine("Player 1:" + UserThrow);
                Console.WriteLine("Player 2: " + CompThrow);
                Console.ReadLine();
                ArraySearch(UserThrow, CompThrow);
            }
        }
    }
}
