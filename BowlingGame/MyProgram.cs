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

        private static Score ComputeScore(List<Roll> rolls)
        {
            int totalScoreValue = 0;
            for(var i = 0; i < rolls.Count;)
            {
                var firstRoll = rolls[i++];
                int currentScore = firstRoll.Value;

                if (i < rolls.Count)
                {
                    var secondRoll = rolls[i++];
                    currentScore += secondRoll.Value;
                    if (currentScore == 10)
                    {
                        if (i < rolls.Count)
                        {
                            currentScore += rolls[i].Value;
                        }
                    }
                }
                totalScoreValue += currentScore;
            }
            Score totalScore = new Score(totalScoreValue);
            return totalScore;
        }

        private static List<Roll> ParseInput(string[] args)
        {
            List<Roll> rolls = args
                .Select(int.Parse)
                .Select(rollValue => new Roll(rollValue))
                .ToList();
            return rolls;
        }
    }
}
