using System;
using System.Collections.Generic;

namespace RockPaperScissors.Library
{
    public class AdaptiveStrategy : IRpsStrategy
    {
        string IRpsStrategy.DecideMove(List<string> roundResults)
        {
            if (!roundResults.Contains("loss"))
            {
                return "P";
            }
            return "S";
        }

 
    }
}
