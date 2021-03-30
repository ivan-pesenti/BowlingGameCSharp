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

        private static Score ComputeScore(Queue<Roll> rolls)
        {
            Score totalScore = new Score();

            for(var i = 0; i < rolls.Count;)
            {
                var firstRoll = rolls.Dequeue();
                Score currentScore = new Score(firstRoll);

                if (i < rolls.Count)
                {
                    var secondRoll = rolls.Dequeue();
                    currentScore = currentScore.Add(secondRoll);

                    if (currentScore.IsSpare())
                    {
                        if (i < rolls.Count)
                        {
                            currentScore = currentScore.Add(rolls.Peek());                            
                        }
                    }
                }
                totalScore = totalScore.Add(currentScore);
            }
            return totalScore;
        }

        private static Queue<Roll> ParseInput(string[] args)
        {
            List<Roll> rolls = args
                .Select(int.Parse)
                .Select(rollValue => new Roll(rollValue))
                .ToList();
            return new Queue<Roll>(rolls);
        }
    }
}
