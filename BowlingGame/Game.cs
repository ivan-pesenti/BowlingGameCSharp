using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public static class Game
    {
        public static Score ComputeScore(BowlingRolls rolls)
        {
            Score totalScore = new Score();
            const int maxNumberOfFrames = 10;
            int currentOfFrames = 0;

            while (rolls.HasRolls() && currentOfFrames < maxNumberOfFrames)
            {
                var firstRoll = rolls.RollOne();
                var frameScore = FrameScore(rolls, firstRoll);
                totalScore = totalScore.Add(frameScore);
                currentOfFrames++;
            }

            return totalScore;
        }

        private static Score FrameScore(BowlingRolls rolls, Roll firstRoll)
        {
            if (firstRoll.IsStrike())
            {
                return new StrikeFrame().Score(rolls);
            }            
            return new OpenFrame(firstRoll).Score(rolls);
        }
    }
}
