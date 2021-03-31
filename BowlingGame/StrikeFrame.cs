using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class StrikeFrame : IFrame
    {
        public IScore Score(BowlingRolls rolls) => new MaxFrameScore(rolls).Score(2);
    }
}
