using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    public class RandomStrategy : IRpsStrategy
    {
        Random rand = new Random();

        public string DecideMove(List<string> roundResults)
        {
            string[] rps = { "R", "P", "S" };
            rand.Next(0, 3);
            return rps[rand.Next(0, 3)];

        }
    }
}
