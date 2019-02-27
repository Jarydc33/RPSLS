﻿using System;
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
            int Throw = num.Next(5);
            return Throw;
        }
    }
}
