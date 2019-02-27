using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class ComputerBuilder
    {
        int CompScore;
        
        public ComputerBuilder(int InitialScore)
        {
            CompScore = InitialScore;
        }

        public int ThrowRandomizer()
        {
            Random num = new Random();
            int Throw = num.Next(5);
            return Throw;
        }
    }
}
