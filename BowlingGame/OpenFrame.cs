using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class OpenFrame : IFrame
    {
        private readonly Roll _firstRoll;

        public OpenFrame(Roll firstRoll)
        {
            _firstRoll = firstRoll;
        }

        public IScore Score(BowlingRolls rolls)
        {
            if (rolls.CanRoll())
            {
                return EvaluateAsSpare(rolls, _firstRoll, rolls.RollOne());
            }
            return new Score(_firstRoll);
        }

        private IScore EvaluateAsSpare(BowlingRolls rolls, Roll firstRoll, Roll secondRoll)
        {
            var currentScore = new Score(firstRoll).Add(secondRoll);
            if (currentScore.IsSpare())
            {
                return SpareFrame.Score(rolls);
            }

            return currentScore;
        }
    }
}
