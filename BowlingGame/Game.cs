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
                return StrikeFrameScore(rolls);
            }
            return OpenFrameScore(rolls, firstRoll);
        }

        private static Score OpenFrameScore(BowlingRolls rolls, Roll roll)
        {
            var currentScore = new Score(roll);
            if (rolls.CanRoll())
            {
                var secondRoll = rolls.RollOne();
                return ComputeScore(rolls, currentScore, secondRoll);
            }

            return currentScore;
        }

        private static Score ComputeScore(BowlingRolls rolls, Score currentScore, Roll secondRoll)
        {
            currentScore = currentScore.Add(secondRoll);
            if (currentScore.IsSpare())
            {
                currentScore = SpareFrameScore(rolls, currentScore);
            }

            return currentScore;
        }

        private static Score SpareFrameScore(BowlingRolls rolls, Score currentScore)
        {
            currentScore = currentScore.Add(rolls.Bonus(1));
            return currentScore;
        }

        private static Score StrikeFrameScore(BowlingRolls rolls)
        {
            return new Score(10).Add(rolls.Bonus(2));
        }
    }
}
