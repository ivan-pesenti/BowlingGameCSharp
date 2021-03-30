using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class OpenFrame
    {
        private readonly Roll _firstRoll;

        public OpenFrame(Roll firstRoll)
        {
            _firstRoll = firstRoll;
        }

        public Score Score(BowlingRolls rolls)
        {
            if (rolls.CanRoll())
            {
                var secondRoll = rolls.RollOne();
                return ComputeScore(rolls, _firstRoll, secondRoll);
            }
            return new Score(_firstRoll);
        }

        private Score ComputeScore(BowlingRolls rolls, Roll firstRoll, Roll secondRoll)
        {
            var currentScore = new Score(firstRoll).Add(secondRoll);
            if (currentScore.IsSpare())
            {
                return new SpareFrame().Score(rolls);
            }

            return currentScore;
        }
    }
}
