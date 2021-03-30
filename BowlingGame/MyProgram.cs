using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingGame
{
    public class MyProgram
    {
        public static void Main(string[] args)
        {
            var rolls = ParseInput(args);
            var totalScore = ComputeScore(rolls);
            PrintTotalScore(totalScore);
        }

        private static void PrintTotalScore(Score totalScore)
        {
            Console.WriteLine(totalScore);
        }

        private static Score ComputeScore(BowlingRolls rolls)
        {
            Score totalScore = new Score();

            const int maxNumberOfFrames = 10;
            int currentOfFrames = 0;

            while (rolls.HasRolls() && currentOfFrames < maxNumberOfFrames)
            {
                var firstRoll = rolls.RollOne();
                Score currentScore = new Score(firstRoll);

                if (firstRoll.Value == 10)
                {
                    currentScore = currentScore.Add(rolls.Bonus(2));
                }
                else
                {
                    if (rolls.CanRoll())
                    {
                        var secondRoll = rolls.RollOne();
                        currentScore = currentScore.Add(secondRoll);

                        if (currentScore.IsSpare())
                        {
                            if (rolls.CanRoll())
                            {
                                currentScore = currentScore.Add(rolls.Bonus(1));
                            }
                        }
                    }
                }

                totalScore = totalScore.Add(currentScore);
                currentOfFrames++;
            }
            return totalScore;
        }

        private static BowlingRolls ParseInput(string[] args)
        {
            List<Roll> rolls = args
                .Select(int.Parse)
                .Select(rollValue => new Roll(rollValue))
                .ToList();
            return new BowlingRolls(new Queue<Roll>(rolls));
        }
    }
}
