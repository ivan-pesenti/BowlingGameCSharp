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
            var totalScore = Game.ComputeScore(rolls);
            PrintTotalScore(totalScore);
        }

        private static void PrintTotalScore(TotalScore totalScore)
        {
            Console.WriteLine(totalScore);
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
