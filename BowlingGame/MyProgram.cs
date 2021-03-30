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
            Score totalScore = new Score(rolls.Select(roll => roll.Value).Sum());
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
