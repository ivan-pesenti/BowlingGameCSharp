using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class TotalScore
    {
        private readonly IScore _score;

        public TotalScore(IScore score = null)
        {
            _score = score;
        }

        public TotalScore Add(IScore score)
        {
            return new TotalScore(_score?.Add(score) ?? score);
        }

        public override string ToString()
        {
            return $"{_score?.ToString() ?? "0"}{Environment.NewLine}{_score?.Value ?? 0}";
        }
    }
}
