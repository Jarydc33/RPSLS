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

        public override int Gesture()
        {
            Random num = new Random();
            int Throw = num.Next(1,5);
            return Throw;
        }        
    }
}
