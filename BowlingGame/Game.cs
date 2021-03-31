using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public static class Game
    {
        public static TotalScore ComputeScore(BowlingRolls rolls)
        {
            TotalScore totalScore = new TotalScore();
            const int maxNumberOfFrames = 10;
            int currentNumberOfFrames = 0;

            while (rolls.HasRolls() && currentNumberOfFrames < maxNumberOfFrames)
            {
                totalScore = Frame
                    .From(rolls.RollOne())
                    .Score(rolls)
                    .Add(totalScore);

                currentNumberOfFrames++;
            }

            return totalScore;
        }
    }
}
