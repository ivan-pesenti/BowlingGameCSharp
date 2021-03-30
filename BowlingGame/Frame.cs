using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public static class Frame
    {
        public static IFrame From(Roll firstRoll)
        {
            if (firstRoll.IsStrike())
            {
                return new StrikeFrame();
            }
            return new OpenFrame(firstRoll);
        }
    }
}
