using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingGame
{
    public class InvalidScore : IScore
    {
        private readonly IScore _score;

        public InvalidScore(IScore score)
        {
            _score = score;
        }

        public InvalidScore(Roll firstRoll) : this(new Score(firstRoll)) { }

        public IScore Add(Roll secondRoll) => new InvalidScore(new Score(secondRoll));

        public IScore Add(IScore otherScore) => new ScoreChain(this, new InvalidScore(otherScore));

        public IScore Add(IBonus bonus) => new InvalidScore(new Score().Add(bonus));

        public bool IsSpare() => false;
        public TotalScore Add(TotalScore totalScore) => totalScore.Add(this);

        public int Value => _score.Value;

        public override string ToString()
        {
            return "-";
        }
    }
}
